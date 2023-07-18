using System;
using System.Drawing;
using System.Windows.Forms;

namespace ScoreBoard
{
    public partial class Form1 : Form
    {
        public static WebSocket webSocket;
        private ScoreBoardInfo scoreBoard;
        public static int _overlayCount = 0;
/// Timer Section
        private bool isOverlayVisible; 
        private bool isTimerChanged;
        private int timerSeconds ; // all timers are expressed in total seconds (for easy conversion)
        private int periodState; // 1 = 1st half | 2 = 2nd half
        private DateTime _mainTimer; // the main Timer in scoreboard
        private DateTime _extraTimer;//the extra Timer that appears after the end of Main Timer
        private bool isExtraTimeVisible;//Shows/Hide the Extra Time that needs to end the match
        private int timerState;// -1 = Stop ; 0 = Pause ; 1 = Play
        private int timerMode ;// 0 = Focus on Main Timer ; 1= Focus on Extra Timer
///
        public Form1()
        {
            InitializeComponent();

            this.ActiveControl = scoreboardName;

            isOverlayVisible = true;

            isTimerChanged = false;
            timerSeconds = 0;

            periodState = 1;
            timerState = -2;//Unknown TimerState
            timerMode = 0;
            isExtraTimeVisible=false;

            webSocket = new WebSocket();
            this.scoreBoard = new ScoreBoardInfo();
///-------------->Getting Information from an already save File
            dynamic data = scoreBoard.fromContentJson(); 
                this.scoreBoard.team1Name = this.team1Name.Text = data.player1NameText;
                this.scoreBoard.team2Name = this.team2Name.Text = data.player2NameText;

                score1.Text = String.Format("{0}", data.player1ScoreText);
                score2.Text= String.Format("{0}", data.player2ScoreText);
                scoreBoard.team1Score = Int32.Parse(score1.Text);
                scoreBoard.team2Score = Int32.Parse(score2.Text);

                team1Color.BackColor = ColorTranslator.FromHtml(String.Format("{0}", data.player1ColorBox));
                team2Color.BackColor = ColorTranslator.FromHtml(String.Format("{0}", data.player2ColorBox));
                scoreBoard.team1Color = ScoreBoardInfo.HexConverter(team1Color.BackColor);
                scoreBoard.team2Color = ScoreBoardInfo.HexConverter(team2Color.BackColor);
///------------------------------------------------------------------------------------------
            webSocket.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
///---------------> this for resetting timer parameters in the save File before closing
            isTimerChanged = false;
            timerSeconds = 0;
            isOverlayVisible = true;
            periodTime.Value = 1;
            periodState = 1;
            timerState = -2;
            extraTime.Value = 0;
            isExtraTimeVisible = false;
            UpdateAndSend(1);
///---------------------------------------------
            webSocket.Stop();
        }

        private void UpdateAndSend(int mode = 0) 
        {
            if (webSocket.isOpen)
            {
                if (mode==0)
                {
                    this.scoreBoard.team1Name = this.team1Name.Text;
                    this.scoreBoard.team2Name = this.team2Name.Text;
                    scoreBoard.team1Score = Int32.Parse(score1.Text);
                    scoreBoard.team2Score = Int32.Parse(score2.Text);
                    scoreBoard.team1Color = ScoreBoardInfo.HexConverter(team1Color.BackColor);
                    scoreBoard.team2Color = ScoreBoardInfo.HexConverter(team2Color.BackColor);
                    scoreBoard.SendCss();
                }
                if (mode == 1)
                {
                    scoreBoard.isTimerChanged = this.isTimerChanged;
                    scoreBoard.timerSeconds = this.timerSeconds;
                    scoreBoard.isOverlayVisible = this.isOverlayVisible;
                    scoreBoard.periodTime = (int)periodTime.Value;
                    scoreBoard.periodState = this.periodState;
                    scoreBoard.timerState = this.timerState;
                    scoreBoard.extraTime = (int)extraTime.Value;
                    scoreBoard.isExtraTimeVisible = this.isExtraTimeVisible;
                    scoreBoard.SendJson();
                }



                webSocket.Update();
            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                team1Color.BackColor = colorDialog1.Color;
                UpdateAndSend();
            }
            
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                team2Color.BackColor = colorDialog1.Color;
                UpdateAndSend();
            }
        }

        private void team2Name_Leave(object sender, EventArgs e)
        {
            this.UpdateAndSend();
            this.disablerName2.Checked = true;
            this.team2Name.Enabled = false;
        }

        private void team1Name_Leave(object sender, EventArgs e)
        {

            this.UpdateAndSend();
            this.disablerName1.Checked = true;
            this.team1Name.Enabled = false;
        }

        private void increment2_Click(object sender, EventArgs e)
        {
            score2.Text = (Int32.Parse(score2.Text) + 1).ToString();

            this.UpdateAndSend();

            this.disablerScore2.Checked = true;
            this.increment2.Enabled = this.decrement2.Enabled = false;
        }

        private void decrement2_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(score2.Text) > 0)
            {
                score2.Text = (Int32.Parse(score2.Text) - 1).ToString();
                this.UpdateAndSend();

                this.disablerScore2.Checked = true;
                this.increment2.Enabled = this.decrement2.Enabled = false;
            }

        }

        private void increment1_Click(object sender, EventArgs e)
        {
            score1.Text = (Int32.Parse(score1.Text) + 1).ToString();
            this.UpdateAndSend();
            this.disablerScore1.Checked = true;
            this.increment1.Enabled = this.decrement1.Enabled = false;
        }

        private void decrement1_Click(object sender, EventArgs e)
        {
            if (Int32.Parse(score1.Text) > 0)
            {
                score1.Text = (Int32.Parse(score1.Text) - 1).ToString();
                this.UpdateAndSend();
                this.disablerScore1.Checked = true;
                this.increment1.Enabled = this.decrement1.Enabled = false;
            }

        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            //_overlayCount = WebSocket._OverlayCount();
            this.overlayCount.Text = "Overlay Connected: " + WebSocket._OverlayCount();
        }

        private void disabler_CheckedChanged(object sender, EventArgs e)
        {
            this.team1Name.Enabled = !this.disablerName1.Checked;
            this.team2Name.Enabled = !this.disablerName2.Checked;
            this.increment1.Enabled = this.decrement1.Enabled = !this.disablerScore1.Checked;
            this.increment2.Enabled = this.decrement2.Enabled = !this.disablerScore2.Checked;
        }

        private void allTimer_Tick(object sender, EventArgs e)
        {

            // Update the count down every 1 second
            if (timerMode == 0)
            {
                _mainTimer = _mainTimer.AddSeconds(1);
                var minutes = Math.Floor( TimeSpan.FromTicks(_mainTimer.Ticks).TotalSeconds / 60);
                mainTimer.Text =String.Format("{0:00}:{1:00}", minutes, _mainTimer.Second);
                //Console.WriteLine(_mainTimer.TotalMinutes);

                // If the count down is over, write some text 
                if (_mainTimer.Minute.Equals((int)periodTime.Value*periodState))
                {
                    timerMode = 1;
                }
            }
            if (timerMode == 1)
            {
                _extraTimer = _extraTimer.AddSeconds(1);

                extraTimer.Text = _extraTimer.ToString("mm':'ss");
                Console.WriteLine(_extraTimer.Second);

                // If the count down is over, write some text 

            }

        }

        private void play_Click(object sender, EventArgs e)
        {
            if (timerState==-1)
            {
                _mainTimer = (periodState==1)?new DateTime(): new DateTime(1,1,1,0, (int)periodTime.Value,0);
                _extraTimer= new DateTime();
                
            }

                timerSeconds = (int)TimeSpan.FromTicks(_mainTimer.Ticks).TotalSeconds;
            allTimer.Enabled = true;
            allTimer.Start();
            timerState = 1;
            periodTime.Enabled = false;
            periodeStatePanel.Enabled = false;

            stop.Enabled = true;
            pause.Enabled = true;
            play.Enabled = false;
            UpdateAndSend(1);
            isTimerChanged = false;
            this.mainTimer.ForeColor = (isTimerChanged) ? System.Drawing.Color.Red : System.Drawing.Color.Black;
            changeTimer.Enabled = false;
        }

        private void pause_Click(object sender, EventArgs e)
        {
            allTimer.Stop();
            pause.Enabled = false;
            play.Enabled = true;
            timerState = 0;
            changeTimer.Enabled = true;
            UpdateAndSend(1);
        }

        private void stop_Click(object sender, EventArgs e)
        {
            _mainTimer = new DateTime();
            mainTimer.Text = "00:00";
            extraTimer.Text = "00:00";
            allTimer.Stop();
            timerMode = 0;
            timerState = -1;

            periodTime.Enabled = true;
            periodeStatePanel.Enabled = true;
            firstPeriod.Checked = true;

            isExtraTimeVisible = false;
            extraTimeLabel.Visible = false;
            extraTime.Enabled = true;
            showExtraTime.Enabled = true;
            hideExtraTime.Enabled = false;

            pause.Enabled = false;
            play.Enabled = true;

            isTimerChanged = false;
            this.mainTimer.ForeColor = (isTimerChanged) ? System.Drawing.Color.Red : System.Drawing.Color.Black;
            changeTimer.Enabled = true;
            UpdateAndSend(1);
        }

        private void Period_CheckedChanged(object sender, EventArgs e)
        {
            periodState = (firstPeriod.Checked)?1:2;

            this.emergencyMinutes.Maximum = periodTime.Value * ((firstPeriod.Checked) ? 1 : 2) - 1;
            this.emergencyMinutes.Minimum = ((firstPeriod.Checked) ? 0 : periodTime.Value);

            isTimerChanged = true;

            _mainTimer = (periodState == 1) ? new DateTime() : new DateTime(1, 1, 1, 0, (int)periodTime.Value, 0);
            mainTimer.Text = (periodState == 1) ? new DateTime().ToString("mm':'ss")
                : String.Format("{0:00}:{1:00}",
                TimeSpan.FromTicks(new DateTime(1, 1, 1, 0, (int)periodTime.Value, 0).Ticks).TotalMinutes
                , _mainTimer.Second);
        }

        private void showExtraTime_Click(object sender, EventArgs e)
        {
            isExtraTimeVisible = true;
            extraTimeLabel.Text = @"'" + extraTime.Value;
            extraTimeLabel.Visible = true;
            extraTime.Enabled = false;

            hideExtraTime.Enabled = true;
            showExtraTime.Enabled = false;
            UpdateAndSend(1);
        }

        private void hideExtraTime_Click(object sender, EventArgs e)
        {
            isExtraTimeVisible = false;
            extraTimeLabel.Visible = false;
            extraTime.Enabled = true;

            showExtraTime.Enabled = true;
            hideExtraTime.Enabled = false;
            UpdateAndSend(1);

        }

        private void periodTime_ValueChanged(object sender, EventArgs e)
        {
            mainTimer.Text = (periodState == 1) ? new DateTime().ToString("mm':'ss")
                                : new DateTime(1, 1, 1, 0, (int)periodTime.Value, 0).ToString("mm':'ss");
            this.emergencyMinutes.Maximum = (periodTime.Value * ((firstPeriod.Checked) ? 1 : 2)) - 1;
            this.emergencyMinutes.Minimum = ((firstPeriod.Checked) ? 0 : periodTime.Value);
        }

        private void hideOverlay_Click(object sender, EventArgs e)
        {
            isOverlayVisible = false;
            hideOverlay.Enabled = false;
            showOverlay.Enabled = true;
            showHideOverlayPanel.Enabled = false;
            disablerShowHidePanel.Checked = true;
            UpdateAndSend(1);

        }

        private void showOverlay_Click(object sender, EventArgs e)
        {
            isOverlayVisible = true;
            hideOverlay.Enabled = true;
            showOverlay.Enabled = false;
            showHideOverlayPanel.Enabled = false;
            disablerShowHidePanel.Checked = true;
            UpdateAndSend(1);
        }

        private void disablerShowHidePanel_CheckedChanged(object sender, EventArgs e)
        {
            showHideOverlayPanel.Enabled = !disablerShowHidePanel.Checked;
        }
///---------------------------------------- this serves to change the timer values manually (minutes and seconds) in any case happens--------  
        private void emergencyConfirm_Click(object sender, EventArgs e)
        {
            timerState = -2;
            var time = TimeSpan.FromSeconds((((double)emergencyMinutes.Value) * 60) + ((double)emergencySeconds.Value));
            var minutes = Math.Floor(time.TotalSeconds / 60);

            _mainTimer =  new DateTime(1, 1, 1, time.Hours, time.Minutes, time.Seconds);

            mainTimer.Text = String.Format("{0:00}:{1:00}", minutes, time.Seconds);
            isTimerChanged= true;

            this.mainTimer.ForeColor = (isTimerChanged) ? System.Drawing.Color.Red : System.Drawing.Color.Black;
            emergencyPanel.Enabled= false;
            disablerEmergency.Checked = true;
        }

        private void disablerEmergency_CheckedChanged(object sender, EventArgs e)
        {
            emergencyPanel.Enabled = !disablerEmergency.Checked;
        }

        private void changeTimer_Click(object sender, EventArgs e)
        {
            isTimerChanged = true;
            this.mainTimer.ForeColor =(isTimerChanged)? System.Drawing.Color.Red : System.Drawing.Color.Black;
        }
///------------------------------------------------------------------------------------------

    }
}