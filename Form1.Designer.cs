namespace ScoreBoard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.operationPanel = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.changeTimer = new System.Windows.Forms.Button();
            this.disablerEmergency = new System.Windows.Forms.CheckBox();
            this.emergencyPanel = new System.Windows.Forms.Panel();
            this.emergencyConfirm = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.emergencySeconds = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.emergencyMinutes = new System.Windows.Forms.NumericUpDown();
            this.disablerShowHidePanel = new System.Windows.Forms.CheckBox();
            this.showHideOverlayPanel = new System.Windows.Forms.Panel();
            this.showOverlay = new System.Windows.Forms.Button();
            this.hideOverlay = new System.Windows.Forms.Button();
            this.extraTimeLabel = new System.Windows.Forms.Label();
            this.hideExtraTime = new System.Windows.Forms.Button();
            this.showExtraTime = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.extraTimer = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Button();
            this.pause = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Button();
            this.mainTimer = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.periodeStatePanel = new System.Windows.Forms.Panel();
            this.secondPeriod = new System.Windows.Forms.RadioButton();
            this.firstPeriod = new System.Windows.Forms.RadioButton();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.extraTime = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.periodTime = new System.Windows.Forms.NumericUpDown();
            this.splitterPanel = new System.Windows.Forms.Panel();
            this.splitter = new System.Windows.Forms.SplitContainer();
            this.score1Panel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.disablerScore1 = new System.Windows.Forms.CheckBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.score1 = new System.Windows.Forms.Label();
            this.decrement1 = new System.Windows.Forms.Button();
            this.increment1 = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.name1Panel = new System.Windows.Forms.Panel();
            this.team1Name = new System.Windows.Forms.TextBox();
            this.disablerName1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.team1Color = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.score2Panel = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.disablerScore2 = new System.Windows.Forms.CheckBox();
            this.panel9 = new System.Windows.Forms.Panel();
            this.score2 = new System.Windows.Forms.Label();
            this.decrement2 = new System.Windows.Forms.Button();
            this.increment2 = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.name2Panel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.disablerName2 = new System.Windows.Forms.CheckBox();
            this.team2Name = new System.Windows.Forms.TextBox();
            this.team2Color = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nameScoreboard = new System.Windows.Forms.Panel();
            this.scoreboardName = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.overlayCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.allTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.operationPanel.SuspendLayout();
            this.panel11.SuspendLayout();
            this.emergencyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergencySeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyMinutes)).BeginInit();
            this.showHideOverlayPanel.SuspendLayout();
            this.periodeStatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodTime)).BeginInit();
            this.splitterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).BeginInit();
            this.splitter.Panel1.SuspendLayout();
            this.splitter.Panel2.SuspendLayout();
            this.splitter.SuspendLayout();
            this.score1Panel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.name1Panel.SuspendLayout();
            this.team1Color.SuspendLayout();
            this.score2Panel.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.name2Panel.SuspendLayout();
            this.team2Color.SuspendLayout();
            this.nameScoreboard.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.operationPanel);
            this.mainPanel.Controls.Add(this.nameScoreboard);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(683, 783);
            this.mainPanel.TabIndex = 0;
            // 
            // operationPanel
            // 
            this.operationPanel.Controls.Add(this.panel11);
            this.operationPanel.Controls.Add(this.splitterPanel);
            this.operationPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.operationPanel.Location = new System.Drawing.Point(0, 55);
            this.operationPanel.Name = "operationPanel";
            this.operationPanel.Size = new System.Drawing.Size(683, 728);
            this.operationPanel.TabIndex = 1;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.changeTimer);
            this.panel11.Controls.Add(this.disablerEmergency);
            this.panel11.Controls.Add(this.emergencyPanel);
            this.panel11.Controls.Add(this.disablerShowHidePanel);
            this.panel11.Controls.Add(this.showHideOverlayPanel);
            this.panel11.Controls.Add(this.extraTimeLabel);
            this.panel11.Controls.Add(this.hideExtraTime);
            this.panel11.Controls.Add(this.showExtraTime);
            this.panel11.Controls.Add(this.label9);
            this.panel11.Controls.Add(this.extraTimer);
            this.panel11.Controls.Add(this.stop);
            this.panel11.Controls.Add(this.pause);
            this.panel11.Controls.Add(this.play);
            this.panel11.Controls.Add(this.mainTimer);
            this.panel11.Controls.Add(this.button5);
            this.panel11.Controls.Add(this.periodeStatePanel);
            this.panel11.Controls.Add(this.label8);
            this.panel11.Controls.Add(this.extraTime);
            this.panel11.Controls.Add(this.label6);
            this.panel11.Controls.Add(this.periodTime);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 308);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(683, 420);
            this.panel11.TabIndex = 4;
            // 
            // changeTimer
            // 
            this.changeTimer.AutoSize = true;
            this.changeTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeTimer.Location = new System.Drawing.Point(52, 16);
            this.changeTimer.Name = "changeTimer";
            this.changeTimer.Size = new System.Drawing.Size(153, 33);
            this.changeTimer.TabIndex = 34;
            this.changeTimer.Text = "Change Timer";
            this.changeTimer.UseVisualStyleBackColor = true;
            this.changeTimer.Click += new System.EventHandler(this.changeTimer_Click);
            // 
            // disablerEmergency
            // 
            this.disablerEmergency.AutoSize = true;
            this.disablerEmergency.Checked = true;
            this.disablerEmergency.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disablerEmergency.Location = new System.Drawing.Point(541, 311);
            this.disablerEmergency.Name = "disablerEmergency";
            this.disablerEmergency.Size = new System.Drawing.Size(15, 14);
            this.disablerEmergency.TabIndex = 33;
            this.disablerEmergency.UseVisualStyleBackColor = true;
            this.disablerEmergency.CheckedChanged += new System.EventHandler(this.disablerEmergency_CheckedChanged);
            // 
            // emergencyPanel
            // 
            this.emergencyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emergencyPanel.Controls.Add(this.emergencyConfirm);
            this.emergencyPanel.Controls.Add(this.label12);
            this.emergencyPanel.Controls.Add(this.emergencySeconds);
            this.emergencyPanel.Controls.Add(this.label11);
            this.emergencyPanel.Controls.Add(this.emergencyMinutes);
            this.emergencyPanel.Enabled = false;
            this.emergencyPanel.Location = new System.Drawing.Point(12, 280);
            this.emergencyPanel.Name = "emergencyPanel";
            this.emergencyPanel.Size = new System.Drawing.Size(523, 79);
            this.emergencyPanel.TabIndex = 32;
            // 
            // emergencyConfirm
            // 
            this.emergencyConfirm.AutoSize = true;
            this.emergencyConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyConfirm.Location = new System.Drawing.Point(178, 43);
            this.emergencyConfirm.Name = "emergencyConfirm";
            this.emergencyConfirm.Size = new System.Drawing.Size(163, 33);
            this.emergencyConfirm.TabIndex = 32;
            this.emergencyConfirm.Text = "Confirm";
            this.emergencyConfirm.UseVisualStyleBackColor = true;
            this.emergencyConfirm.Click += new System.EventHandler(this.emergencyConfirm_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label12.Location = new System.Drawing.Point(287, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label12.Size = new System.Drawing.Size(116, 31);
            this.label12.TabIndex = 8;
            this.label12.Text = "Seconds  :";
            // 
            // emergencySeconds
            // 
            this.emergencySeconds.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emergencySeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencySeconds.Location = new System.Drawing.Point(443, 2);
            this.emergencySeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.emergencySeconds.Name = "emergencySeconds";
            this.emergencySeconds.Size = new System.Drawing.Size(56, 29);
            this.emergencySeconds.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label11.Location = new System.Drawing.Point(3, 0);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label11.Size = new System.Drawing.Size(114, 31);
            this.label11.TabIndex = 6;
            this.label11.Text = "Minutes   :";
            // 
            // emergencyMinutes
            // 
            this.emergencyMinutes.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.emergencyMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emergencyMinutes.Location = new System.Drawing.Point(159, 2);
            this.emergencyMinutes.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.emergencyMinutes.Name = "emergencyMinutes";
            this.emergencyMinutes.Size = new System.Drawing.Size(56, 29);
            this.emergencyMinutes.TabIndex = 5;
            // 
            // disablerShowHidePanel
            // 
            this.disablerShowHidePanel.AutoSize = true;
            this.disablerShowHidePanel.Location = new System.Drawing.Point(541, 231);
            this.disablerShowHidePanel.Name = "disablerShowHidePanel";
            this.disablerShowHidePanel.Size = new System.Drawing.Size(15, 14);
            this.disablerShowHidePanel.TabIndex = 31;
            this.disablerShowHidePanel.UseVisualStyleBackColor = true;
            this.disablerShowHidePanel.CheckedChanged += new System.EventHandler(this.disablerShowHidePanel_CheckedChanged);
            // 
            // showHideOverlayPanel
            // 
            this.showHideOverlayPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.showHideOverlayPanel.Controls.Add(this.showOverlay);
            this.showHideOverlayPanel.Controls.Add(this.hideOverlay);
            this.showHideOverlayPanel.Location = new System.Drawing.Point(148, 198);
            this.showHideOverlayPanel.Name = "showHideOverlayPanel";
            this.showHideOverlayPanel.Size = new System.Drawing.Size(387, 76);
            this.showHideOverlayPanel.TabIndex = 30;
            // 
            // showOverlay
            // 
            this.showOverlay.AutoSize = true;
            this.showOverlay.Enabled = false;
            this.showOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showOverlay.Location = new System.Drawing.Point(23, 22);
            this.showOverlay.Name = "showOverlay";
            this.showOverlay.Size = new System.Drawing.Size(163, 33);
            this.showOverlay.TabIndex = 31;
            this.showOverlay.Text = "Show ScoreBoard";
            this.showOverlay.UseVisualStyleBackColor = true;
            this.showOverlay.Click += new System.EventHandler(this.showOverlay_Click);
            // 
            // hideOverlay
            // 
            this.hideOverlay.AutoSize = true;
            this.hideOverlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideOverlay.Location = new System.Drawing.Point(208, 22);
            this.hideOverlay.Name = "hideOverlay";
            this.hideOverlay.Size = new System.Drawing.Size(156, 33);
            this.hideOverlay.TabIndex = 30;
            this.hideOverlay.Text = "Hide ScoreBoard";
            this.hideOverlay.UseVisualStyleBackColor = true;
            this.hideOverlay.Click += new System.EventHandler(this.hideOverlay_Click);
            // 
            // extraTimeLabel
            // 
            this.extraTimeLabel.AutoSize = true;
            this.extraTimeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.extraTimeLabel.Location = new System.Drawing.Point(387, 71);
            this.extraTimeLabel.Name = "extraTimeLabel";
            this.extraTimeLabel.Size = new System.Drawing.Size(32, 28);
            this.extraTimeLabel.TabIndex = 27;
            this.extraTimeLabel.Text = "\'0";
            this.extraTimeLabel.Visible = false;
            // 
            // hideExtraTime
            // 
            this.hideExtraTime.AutoSize = true;
            this.hideExtraTime.Enabled = false;
            this.hideExtraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hideExtraTime.Location = new System.Drawing.Point(114, 69);
            this.hideExtraTime.Name = "hideExtraTime";
            this.hideExtraTime.Size = new System.Drawing.Size(153, 33);
            this.hideExtraTime.TabIndex = 26;
            this.hideExtraTime.Text = "Hide Extra Time";
            this.hideExtraTime.UseVisualStyleBackColor = true;
            this.hideExtraTime.Click += new System.EventHandler(this.hideExtraTime_Click);
            // 
            // showExtraTime
            // 
            this.showExtraTime.AutoSize = true;
            this.showExtraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showExtraTime.Location = new System.Drawing.Point(434, 69);
            this.showExtraTime.Name = "showExtraTime";
            this.showExtraTime.Size = new System.Drawing.Size(153, 33);
            this.showExtraTime.TabIndex = 25;
            this.showExtraTime.Text = "Show Extra Time";
            this.showExtraTime.UseVisualStyleBackColor = true;
            this.showExtraTime.Click += new System.EventHandler(this.showExtraTime_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(281, 76);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(19, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = "+";
            // 
            // extraTimer
            // 
            this.extraTimer.AutoSize = true;
            this.extraTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.extraTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.extraTimer.Location = new System.Drawing.Point(299, 69);
            this.extraTimer.Name = "extraTimer";
            this.extraTimer.Size = new System.Drawing.Size(89, 33);
            this.extraTimer.TabIndex = 23;
            this.extraTimer.Text = "00:00";
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.stop.Location = new System.Drawing.Point(218, 12);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(43, 41);
            this.stop.TabIndex = 22;
            this.stop.Text = "◼";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // pause
            // 
            this.pause.Enabled = false;
            this.pause.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.Location = new System.Drawing.Point(425, 12);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(43, 41);
            this.pause.TabIndex = 21;
            this.pause.Text = "| |";
            this.pause.UseVisualStyleBackColor = true;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // play
            // 
            this.play.FlatAppearance.BorderSize = 2;
            this.play.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.play.Location = new System.Drawing.Point(474, 12);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(43, 41);
            this.play.TabIndex = 20;
            this.play.Text = "▶";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // mainTimer
            // 
            this.mainTimer.AutoSize = true;
            this.mainTimer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTimer.ForeColor = System.Drawing.Color.Black;
            this.mainTimer.Location = new System.Drawing.Point(267, 3);
            this.mainTimer.Name = "mainTimer";
            this.mainTimer.Size = new System.Drawing.Size(152, 57);
            this.mainTimer.TabIndex = 19;
            this.mainTimer.Text = "00:00";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.Location = new System.Drawing.Point(656, 372);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 23);
            this.button5.TabIndex = 18;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // periodeStatePanel
            // 
            this.periodeStatePanel.AutoSize = true;
            this.periodeStatePanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.periodeStatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.periodeStatePanel.Controls.Add(this.secondPeriod);
            this.periodeStatePanel.Controls.Add(this.firstPeriod);
            this.periodeStatePanel.Controls.Add(this.label10);
            this.periodeStatePanel.Location = new System.Drawing.Point(12, 161);
            this.periodeStatePanel.Name = "periodeStatePanel";
            this.periodeStatePanel.Size = new System.Drawing.Size(343, 36);
            this.periodeStatePanel.TabIndex = 14;
            // 
            // secondPeriod
            // 
            this.secondPeriod.AutoSize = true;
            this.secondPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.secondPeriod.Location = new System.Drawing.Point(272, 2);
            this.secondPeriod.Name = "secondPeriod";
            this.secondPeriod.Size = new System.Drawing.Size(66, 29);
            this.secondPeriod.TabIndex = 16;
            this.secondPeriod.Text = "2nd";
            this.secondPeriod.UseVisualStyleBackColor = true;
            this.secondPeriod.CheckedChanged += new System.EventHandler(this.Period_CheckedChanged);
            // 
            // firstPeriod
            // 
            this.firstPeriod.AutoSize = true;
            this.firstPeriod.Checked = true;
            this.firstPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.firstPeriod.Location = new System.Drawing.Point(183, 2);
            this.firstPeriod.Name = "firstPeriod";
            this.firstPeriod.Size = new System.Drawing.Size(59, 29);
            this.firstPeriod.TabIndex = 15;
            this.firstPeriod.TabStop = true;
            this.firstPeriod.Text = "1st";
            this.firstPeriod.UseVisualStyleBackColor = true;
            this.firstPeriod.CheckedChanged += new System.EventHandler(this.Period_CheckedChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label10.Size = new System.Drawing.Size(154, 31);
            this.label10.TabIndex = 14;
            this.label10.Text = "Which Period :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label8.Location = new System.Drawing.Point(408, 126);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label8.Size = new System.Drawing.Size(135, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "Extra Time : ";
            // 
            // extraTime
            // 
            this.extraTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.extraTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraTime.Location = new System.Drawing.Point(551, 127);
            this.extraTime.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.extraTime.Name = "extraTime";
            this.extraTime.Size = new System.Drawing.Size(56, 29);
            this.extraTime.TabIndex = 5;
            this.extraTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.Location = new System.Drawing.Point(12, 125);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label6.Size = new System.Drawing.Size(219, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "Period Time Ends in :";
            // 
            // periodTime
            // 
            this.periodTime.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.periodTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodTime.Location = new System.Drawing.Point(238, 127);
            this.periodTime.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.periodTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.periodTime.Name = "periodTime";
            this.periodTime.Size = new System.Drawing.Size(56, 29);
            this.periodTime.TabIndex = 0;
            this.periodTime.Value = new decimal(new int[] {
            45,
            0,
            0,
            0});
            this.periodTime.ValueChanged += new System.EventHandler(this.periodTime_ValueChanged);
            // 
            // splitterPanel
            // 
            this.splitterPanel.Controls.Add(this.splitter);
            this.splitterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitterPanel.Location = new System.Drawing.Point(0, 0);
            this.splitterPanel.Name = "splitterPanel";
            this.splitterPanel.Size = new System.Drawing.Size(683, 308);
            this.splitterPanel.TabIndex = 2;
            // 
            // splitter
            // 
            this.splitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitter.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter.Location = new System.Drawing.Point(0, 0);
            this.splitter.Name = "splitter";
            // 
            // splitter.Panel1
            // 
            this.splitter.Panel1.Controls.Add(this.score1Panel);
            this.splitter.Panel1.Controls.Add(this.name1Panel);
            this.splitter.Panel1.Controls.Add(this.team1Color);
            // 
            // splitter.Panel2
            // 
            this.splitter.Panel2.Controls.Add(this.score2Panel);
            this.splitter.Panel2.Controls.Add(this.name2Panel);
            this.splitter.Panel2.Controls.Add(this.team2Color);
            this.splitter.Size = new System.Drawing.Size(683, 553);
            this.splitter.SplitterDistance = 336;
            this.splitter.SplitterWidth = 2;
            this.splitter.TabIndex = 1;
            // 
            // score1Panel
            // 
            this.score1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.score1Panel.Controls.Add(this.panel4);
            this.score1Panel.Controls.Add(this.panel5);
            this.score1Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.score1Panel.Location = new System.Drawing.Point(0, 160);
            this.score1Panel.Name = "score1Panel";
            this.score1Panel.Size = new System.Drawing.Size(334, 146);
            this.score1Panel.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.disablerScore1);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.decrement1);
            this.panel4.Controls.Add(this.increment1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 36);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 108);
            this.panel4.TabIndex = 8;
            // 
            // disablerScore1
            // 
            this.disablerScore1.AutoSize = true;
            this.disablerScore1.Location = new System.Drawing.Point(130, 48);
            this.disablerScore1.Name = "disablerScore1";
            this.disablerScore1.Size = new System.Drawing.Size(15, 14);
            this.disablerScore1.TabIndex = 10;
            this.disablerScore1.UseVisualStyleBackColor = true;
            this.disablerScore1.CheckedChanged += new System.EventHandler(this.disabler_CheckedChanged);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.score1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(231, 0);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(101, 108);
            this.panel6.TabIndex = 9;
            // 
            // score1
            // 
            this.score1.AutoSize = true;
            this.score1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score1.Location = new System.Drawing.Point(26, 26);
            this.score1.Name = "score1";
            this.score1.Size = new System.Drawing.Size(52, 55);
            this.score1.TabIndex = 3;
            this.score1.Text = "0";
            // 
            // decrement1
            // 
            this.decrement1.BackColor = System.Drawing.Color.DodgerBlue;
            this.decrement1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.decrement1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.decrement1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.decrement1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrement1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.decrement1.ForeColor = System.Drawing.Color.White;
            this.decrement1.Location = new System.Drawing.Point(161, 60);
            this.decrement1.Margin = new System.Windows.Forms.Padding(0);
            this.decrement1.Name = "decrement1";
            this.decrement1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decrement1.Size = new System.Drawing.Size(43, 40);
            this.decrement1.TabIndex = 8;
            this.decrement1.Text = "-";
            this.decrement1.UseVisualStyleBackColor = false;
            this.decrement1.Click += new System.EventHandler(this.decrement1_Click);
            // 
            // increment1
            // 
            this.increment1.BackColor = System.Drawing.Color.Red;
            this.increment1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.increment1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.increment1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.increment1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increment1.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.increment1.ForeColor = System.Drawing.Color.White;
            this.increment1.Location = new System.Drawing.Point(161, 9);
            this.increment1.Margin = new System.Windows.Forms.Padding(0);
            this.increment1.Name = "increment1";
            this.increment1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.increment1.Size = new System.Drawing.Size(43, 40);
            this.increment1.TabIndex = 7;
            this.increment1.Text = "+";
            this.increment1.UseVisualStyleBackColor = false;
            this.increment1.Click += new System.EventHandler(this.increment1_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(332, 36);
            this.panel5.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(129, 3);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label5.Size = new System.Drawing.Size(68, 29);
            this.label5.TabIndex = 3;
            this.label5.Text = "Score";
            // 
            // name1Panel
            // 
            this.name1Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name1Panel.Controls.Add(this.team1Name);
            this.name1Panel.Controls.Add(this.disablerName1);
            this.name1Panel.Controls.Add(this.label3);
            this.name1Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.name1Panel.Location = new System.Drawing.Point(0, 55);
            this.name1Panel.Name = "name1Panel";
            this.name1Panel.Size = new System.Drawing.Size(334, 105);
            this.name1Panel.TabIndex = 6;
            // 
            // team1Name
            // 
            this.team1Name.CausesValidation = false;
            this.team1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Bold);
            this.team1Name.Location = new System.Drawing.Point(23, 38);
            this.team1Name.Multiline = true;
            this.team1Name.Name = "team1Name";
            this.team1Name.Size = new System.Drawing.Size(268, 44);
            this.team1Name.TabIndex = 0;
            this.team1Name.TabStop = false;
            this.team1Name.Text = "Team1";
            this.team1Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.team1Name.Leave += new System.EventHandler(this.team1Name_Leave);
            // 
            // disablerName1
            // 
            this.disablerName1.AutoSize = true;
            this.disablerName1.Location = new System.Drawing.Point(297, 53);
            this.disablerName1.Name = "disablerName1";
            this.disablerName1.Size = new System.Drawing.Size(15, 14);
            this.disablerName1.TabIndex = 5;
            this.disablerName1.UseVisualStyleBackColor = true;
            this.disablerName1.CheckedChanged += new System.EventHandler(this.disabler_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(128, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // team1Color
            // 
            this.team1Color.BackColor = System.Drawing.Color.Red;
            this.team1Color.Controls.Add(this.label1);
            this.team1Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.team1Color.Dock = System.Windows.Forms.DockStyle.Top;
            this.team1Color.Location = new System.Drawing.Point(0, 0);
            this.team1Color.Name = "team1Color";
            this.team1Color.Size = new System.Drawing.Size(334, 55);
            this.team1Color.TabIndex = 1;
            this.team1Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(130, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Team1";
            // 
            // score2Panel
            // 
            this.score2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.score2Panel.Controls.Add(this.panel8);
            this.score2Panel.Controls.Add(this.panel10);
            this.score2Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.score2Panel.Location = new System.Drawing.Point(0, 160);
            this.score2Panel.Name = "score2Panel";
            this.score2Panel.Size = new System.Drawing.Size(343, 146);
            this.score2Panel.TabIndex = 8;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.disablerScore2);
            this.panel8.Controls.Add(this.panel9);
            this.panel8.Controls.Add(this.decrement2);
            this.panel8.Controls.Add(this.increment2);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(0, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(341, 108);
            this.panel8.TabIndex = 8;
            // 
            // disablerScore2
            // 
            this.disablerScore2.AutoSize = true;
            this.disablerScore2.Location = new System.Drawing.Point(196, 48);
            this.disablerScore2.Name = "disablerScore2";
            this.disablerScore2.Size = new System.Drawing.Size(15, 14);
            this.disablerScore2.TabIndex = 10;
            this.disablerScore2.UseVisualStyleBackColor = true;
            this.disablerScore2.CheckedChanged += new System.EventHandler(this.disabler_CheckedChanged);
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.score2);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(5);
            this.panel9.Size = new System.Drawing.Size(101, 108);
            this.panel9.TabIndex = 9;
            // 
            // score2
            // 
            this.score2.AutoSize = true;
            this.score2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score2.Location = new System.Drawing.Point(26, 26);
            this.score2.Name = "score2";
            this.score2.Size = new System.Drawing.Size(52, 55);
            this.score2.TabIndex = 3;
            this.score2.Text = "0";
            // 
            // decrement2
            // 
            this.decrement2.BackColor = System.Drawing.Color.DodgerBlue;
            this.decrement2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.decrement2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.decrement2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.decrement2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decrement2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.decrement2.ForeColor = System.Drawing.Color.White;
            this.decrement2.Location = new System.Drawing.Point(134, 60);
            this.decrement2.Margin = new System.Windows.Forms.Padding(0);
            this.decrement2.Name = "decrement2";
            this.decrement2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.decrement2.Size = new System.Drawing.Size(43, 40);
            this.decrement2.TabIndex = 8;
            this.decrement2.Text = "-";
            this.decrement2.UseVisualStyleBackColor = false;
            this.decrement2.Click += new System.EventHandler(this.decrement2_Click);
            // 
            // increment2
            // 
            this.increment2.BackColor = System.Drawing.Color.Red;
            this.increment2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.increment2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.increment2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.increment2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.increment2.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold);
            this.increment2.ForeColor = System.Drawing.Color.White;
            this.increment2.Location = new System.Drawing.Point(134, 9);
            this.increment2.Margin = new System.Windows.Forms.Padding(0);
            this.increment2.Name = "increment2";
            this.increment2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.increment2.Size = new System.Drawing.Size(43, 40);
            this.increment2.TabIndex = 7;
            this.increment2.Text = "+";
            this.increment2.UseVisualStyleBackColor = false;
            this.increment2.Click += new System.EventHandler(this.increment2_Click);
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.label7);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(341, 36);
            this.panel10.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(138, 3);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.label7.Size = new System.Drawing.Size(68, 29);
            this.label7.TabIndex = 3;
            this.label7.Text = "Score";
            // 
            // name2Panel
            // 
            this.name2Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name2Panel.Controls.Add(this.label4);
            this.name2Panel.Controls.Add(this.disablerName2);
            this.name2Panel.Controls.Add(this.team2Name);
            this.name2Panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.name2Panel.Location = new System.Drawing.Point(0, 55);
            this.name2Panel.Name = "name2Panel";
            this.name2Panel.Size = new System.Drawing.Size(343, 105);
            this.name2Panel.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label4.Location = new System.Drawing.Point(137, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Name";
            // 
            // disablerName2
            // 
            this.disablerName2.AutoSize = true;
            this.disablerName2.Location = new System.Drawing.Point(26, 53);
            this.disablerName2.Name = "disablerName2";
            this.disablerName2.Size = new System.Drawing.Size(15, 14);
            this.disablerName2.TabIndex = 4;
            this.disablerName2.UseVisualStyleBackColor = true;
            this.disablerName2.CheckedChanged += new System.EventHandler(this.disabler_CheckedChanged);
            // 
            // team2Name
            // 
            this.team2Name.CausesValidation = false;
            this.team2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.75F, System.Drawing.FontStyle.Bold);
            this.team2Name.Location = new System.Drawing.Point(47, 38);
            this.team2Name.Multiline = true;
            this.team2Name.Name = "team2Name";
            this.team2Name.Size = new System.Drawing.Size(268, 44);
            this.team2Name.TabIndex = 1;
            this.team2Name.TabStop = false;
            this.team2Name.Text = "Team2";
            this.team2Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.team2Name.Leave += new System.EventHandler(this.team2Name_Leave);
            // 
            // team2Color
            // 
            this.team2Color.BackColor = System.Drawing.Color.DodgerBlue;
            this.team2Color.Controls.Add(this.label2);
            this.team2Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.team2Color.Dock = System.Windows.Forms.DockStyle.Top;
            this.team2Color.Location = new System.Drawing.Point(0, 0);
            this.team2Color.Name = "team2Color";
            this.team2Color.Size = new System.Drawing.Size(343, 55);
            this.team2Color.TabIndex = 2;
            this.team2Color.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(139, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Team2";
            // 
            // nameScoreboard
            // 
            this.nameScoreboard.BackColor = System.Drawing.Color.Orange;
            this.nameScoreboard.Controls.Add(this.scoreboardName);
            this.nameScoreboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameScoreboard.Location = new System.Drawing.Point(0, 0);
            this.nameScoreboard.Name = "nameScoreboard";
            this.nameScoreboard.Size = new System.Drawing.Size(683, 55);
            this.nameScoreboard.TabIndex = 0;
            // 
            // scoreboardName
            // 
            this.scoreboardName.AutoSize = true;
            this.scoreboardName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30.25F, System.Drawing.FontStyle.Bold);
            this.scoreboardName.ForeColor = System.Drawing.Color.White;
            this.scoreboardName.Location = new System.Drawing.Point(259, 4);
            this.scoreboardName.Name = "scoreboardName";
            this.scoreboardName.Size = new System.Drawing.Size(180, 47);
            this.scoreboardName.TabIndex = 0;
            this.scoreboardName.Text = "FootBall";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.overlayCount});
            this.statusStrip.Location = new System.Drawing.Point(0, 761);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(683, 22);
            this.statusStrip.TabIndex = 12;
            this.statusStrip.Text = "statusStrip1";
            // 
            // overlayCount
            // 
            this.overlayCount.Name = "overlayCount";
            this.overlayCount.Size = new System.Drawing.Size(117, 17);
            this.overlayCount.Text = "Overlay Connected : ";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // allTimer
            // 
            this.allTimer.Interval = 1000;
            this.allTimer.Tick += new System.EventHandler(this.allTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(683, 783);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.mainPanel.ResumeLayout(false);
            this.operationPanel.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.emergencyPanel.ResumeLayout(false);
            this.emergencyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emergencySeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emergencyMinutes)).EndInit();
            this.showHideOverlayPanel.ResumeLayout(false);
            this.showHideOverlayPanel.PerformLayout();
            this.periodeStatePanel.ResumeLayout(false);
            this.periodeStatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.extraTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.periodTime)).EndInit();
            this.splitterPanel.ResumeLayout(false);
            this.splitter.Panel1.ResumeLayout(false);
            this.splitter.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter)).EndInit();
            this.splitter.ResumeLayout(false);
            this.score1Panel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.name1Panel.ResumeLayout(false);
            this.name1Panel.PerformLayout();
            this.team1Color.ResumeLayout(false);
            this.team1Color.PerformLayout();
            this.score2Panel.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.name2Panel.ResumeLayout(false);
            this.name2Panel.PerformLayout();
            this.team2Color.ResumeLayout(false);
            this.team2Color.PerformLayout();
            this.nameScoreboard.ResumeLayout(false);
            this.nameScoreboard.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel nameScoreboard;
        private System.Windows.Forms.Label scoreboardName;
        private System.Windows.Forms.Panel operationPanel;
        private System.Windows.Forms.Panel splitterPanel;
        private System.Windows.Forms.SplitContainer splitter;
        private System.Windows.Forms.Panel score1Panel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox disablerScore1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label score1;
        private System.Windows.Forms.Button decrement1;
        private System.Windows.Forms.Button increment1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel name1Panel;
        private System.Windows.Forms.TextBox team1Name;
        private System.Windows.Forms.CheckBox disablerName1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel team1Color;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel score2Panel;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.CheckBox disablerScore2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label score2;
        private System.Windows.Forms.Button decrement2;
        private System.Windows.Forms.Button increment2;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel name2Panel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox disablerName2;
        private System.Windows.Forms.TextBox team2Name;
        private System.Windows.Forms.Panel team2Color;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown extraTime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown periodTime;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel overlayCount;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel periodeStatePanel;
        private System.Windows.Forms.RadioButton secondPeriod;
        private System.Windows.Forms.RadioButton firstPeriod;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button hideExtraTime;
        private System.Windows.Forms.Button showExtraTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label extraTimer;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Label mainTimer;
        private System.Windows.Forms.Timer allTimer;
        private System.Windows.Forms.Label extraTimeLabel;
        private System.Windows.Forms.Panel showHideOverlayPanel;
        private System.Windows.Forms.Button showOverlay;
        private System.Windows.Forms.Button hideOverlay;
        private System.Windows.Forms.CheckBox disablerShowHidePanel;
        private System.Windows.Forms.Panel emergencyPanel;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown emergencySeconds;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown emergencyMinutes;
        private System.Windows.Forms.CheckBox disablerEmergency;
        private System.Windows.Forms.Button emergencyConfirm;
        private System.Windows.Forms.Button changeTimer;
    }
}

