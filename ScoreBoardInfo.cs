using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace ScoreBoard
{
    internal class ScoreBoardInfo
    {
        private readonly string filePath = @"C:\xampp\htdocs\getContentCss\";
        private readonly string cssPath = "content.css";//the save File for teams contents
        private readonly string jsonPath = "content.json";//the save file that contains parameters for timers and The overlay
        private readonly string cssToJsonPath = "contentCSS.json";//the css file that transforms into Json file

        public string team1Name { get; set; }
        public string team2Name { get; set; }
        public int team1Score { get; set; }
        public int team2Score { get; set; }
        public string team1Color { get; set; }
        public string team2Color { get; set; }

        public bool isTimerChanged { get; set; }
        public int timerSeconds { get; set; }
        public int timerState { get; set; }
        public int periodTime { get; set; }
        public int periodState { get; set; }
        public int extraTime { get; set; }
        public bool isExtraTimeVisible { get; set; }
        public bool isOverlayVisible { get; set; }



        public ScoreBoardInfo()
        {
            this.team1Name = "Team1";
            this.team2Name = "Team2";
            this.team1Score = 0;
            this.team2Score = 0;
            this.team1Color = "";
            this.team2Color = "";

            this.isTimerChanged = false;
            this.timerSeconds = 0;
            this.timerState = -2;
            this.periodTime = 45;
            this.periodState = 1;
            this.extraTime = 0;
            this.isExtraTimeVisible = false;
            this.isOverlayVisible = true;
        }
        public JObject fromContentJson() 
        {
            return JObject.Parse(File.ReadAllText(String.Concat(filePath, cssToJsonPath)));
        }
        public void contentCssToJson()
        {
            var content = String.Format(@"{{""player1NameText"":""{0}""
,""player1ScoreText"":{1}
,""player2NameText"": ""{2}""
,""player2ScoreText"":{3}
,""player1ColorBox"":""{4}""
,""player2ColorBox"":""{5}""
}}", team1Name, team1Score, team2Name, team2Score, team1Color, team2Color);

            File.WriteAllText(String.Concat(filePath, cssToJsonPath), content);
        }

        public string toContentJson()
        {
            return String.Format(@"{{""TimerState"":{0}
,""PeriodTime"":{1}
,""PeriodState"":{2}
,""ExtraTime"":{3}
,""ExtraTimeVisible"":""{4}""
,""TimerTotalSeconds"":""{5}""
,""OverlayVisible"":""{6}""
,""TimerChanged"":""{7}""}}",
timerState, periodTime, periodState, extraTime, isExtraTimeVisible,timerSeconds, isOverlayVisible, isTimerChanged);
        }
        public void SendJson()
        {
            File.WriteAllText(String.Concat(filePath, jsonPath), toContentJson());
        }
        public string toContentCss()
        {
            return String.Format(@"#player1NameText:before {{ content: ""{0}""; }}
#player1ScoreText:before {{ content: ""{1}"" }}
#player2NameText:before {{ content: ""{2}""; }}
#player2ScoreText:before {{ content: ""{3}"" }}
#player1ColorBox {{ background: {4} }}
#player2ColorBox {{ background: {5} }}
", team1Name, team1Score, team2Name, team2Score,team1Color,team2Color);
        }

        public void SendCss()
        {
            contentCssToJson();
            File.WriteAllText(String.Concat(filePath,cssPath), toContentCss());
        }
        //public int team1Score { get; set; }

        public static String HexConverter(System.Drawing.Color c)//converting color into a hex value
        {
            return "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
        }
    }
}
