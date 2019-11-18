namespace WindowsFormsApp1
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
            this.athleteName = new System.Windows.Forms.TextBox();
            this.athleteGym = new System.Windows.Forms.TextBox();
            this.addGymnast = new System.Windows.Forms.Button();
            this.displayGymnast = new System.Windows.Forms.Button();
            this.floorScore = new System.Windows.Forms.TextBox();
            this.pommelScore = new System.Windows.Forms.TextBox();
            this.vaultScore = new System.Windows.Forms.TextBox();
            this.ringsScore = new System.Windows.Forms.TextBox();
            this.pbarScore = new System.Windows.Forms.TextBox();
            this.hbarScore = new System.Windows.Forms.TextBox();
            this.aaScore = new System.Windows.Forms.TextBox();
            this.chooseGymnast = new System.Windows.Forms.ComboBox();
            this.chooseMeet = new System.Windows.Forms.ComboBox();
            this.meetName = new System.Windows.Forms.TextBox();
            this.addMeet = new System.Windows.Forms.Button();
            this.topMeet = new System.Windows.Forms.Button();
            this.topFloor = new System.Windows.Forms.TextBox();
            this.topPommel = new System.Windows.Forms.TextBox();
            this.topRings = new System.Windows.Forms.TextBox();
            this.topVault = new System.Windows.Forms.TextBox();
            this.topPbars = new System.Windows.Forms.TextBox();
            this.topHbar = new System.Windows.Forms.TextBox();
            this.topAA = new System.Windows.Forms.TextBox();
            this.toMeet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // athleteName
            // 
            this.athleteName.Location = new System.Drawing.Point(514, 178);
            this.athleteName.Name = "athleteName";
            this.athleteName.Size = new System.Drawing.Size(100, 20);
            this.athleteName.TabIndex = 0;
            this.athleteName.TextChanged += new System.EventHandler(this.AthleteName_TextChanged);
            // 
            // athleteGym
            // 
            this.athleteGym.Location = new System.Drawing.Point(514, 213);
            this.athleteGym.Name = "athleteGym";
            this.athleteGym.Size = new System.Drawing.Size(100, 20);
            this.athleteGym.TabIndex = 1;
            this.athleteGym.TextChanged += new System.EventHandler(this.AthleteGym_TextChanged);
            // 
            // addGymnast
            // 
            this.addGymnast.Location = new System.Drawing.Point(636, 192);
            this.addGymnast.Name = "addGymnast";
            this.addGymnast.Size = new System.Drawing.Size(120, 23);
            this.addGymnast.TabIndex = 2;
            this.addGymnast.Text = "Add Gymnast";
            this.addGymnast.UseVisualStyleBackColor = true;
            this.addGymnast.Click += new System.EventHandler(this.AddGymnast_Click);
            // 
            // displayGymnast
            // 
            this.displayGymnast.Location = new System.Drawing.Point(636, 237);
            this.displayGymnast.Name = "displayGymnast";
            this.displayGymnast.Size = new System.Drawing.Size(120, 23);
            this.displayGymnast.TabIndex = 3;
            this.displayGymnast.Text = "Display Gymnast";
            this.displayGymnast.UseVisualStyleBackColor = true;
            this.displayGymnast.Click += new System.EventHandler(this.DisplayGymnast_Click);
            // 
            // floorScore
            // 
            this.floorScore.Location = new System.Drawing.Point(778, 240);
            this.floorScore.Name = "floorScore";
            this.floorScore.Size = new System.Drawing.Size(100, 20);
            this.floorScore.TabIndex = 4;
            this.floorScore.TextChanged += new System.EventHandler(this.FloorScore_TextChanged);
            // 
            // pommelScore
            // 
            this.pommelScore.Location = new System.Drawing.Point(778, 266);
            this.pommelScore.Name = "pommelScore";
            this.pommelScore.Size = new System.Drawing.Size(100, 20);
            this.pommelScore.TabIndex = 5;
            this.pommelScore.TextChanged += new System.EventHandler(this.PommelScore_TextChanged);
            // 
            // vaultScore
            // 
            this.vaultScore.Location = new System.Drawing.Point(778, 318);
            this.vaultScore.Name = "vaultScore";
            this.vaultScore.Size = new System.Drawing.Size(100, 20);
            this.vaultScore.TabIndex = 6;
            this.vaultScore.TextChanged += new System.EventHandler(this.VaultScore_TextChanged);
            // 
            // ringsScore
            // 
            this.ringsScore.Location = new System.Drawing.Point(778, 292);
            this.ringsScore.Name = "ringsScore";
            this.ringsScore.Size = new System.Drawing.Size(100, 20);
            this.ringsScore.TabIndex = 7;
            this.ringsScore.TextChanged += new System.EventHandler(this.RingsScore_TextChanged);
            // 
            // pbarScore
            // 
            this.pbarScore.Location = new System.Drawing.Point(778, 344);
            this.pbarScore.Name = "pbarScore";
            this.pbarScore.Size = new System.Drawing.Size(100, 20);
            this.pbarScore.TabIndex = 8;
            this.pbarScore.TextChanged += new System.EventHandler(this.PbarScore_TextChanged);
            // 
            // hbarScore
            // 
            this.hbarScore.Location = new System.Drawing.Point(778, 370);
            this.hbarScore.Name = "hbarScore";
            this.hbarScore.Size = new System.Drawing.Size(100, 20);
            this.hbarScore.TabIndex = 9;
            this.hbarScore.TextChanged += new System.EventHandler(this.HbarScore_TextChanged);
            // 
            // aaScore
            // 
            this.aaScore.Location = new System.Drawing.Point(778, 396);
            this.aaScore.Name = "aaScore";
            this.aaScore.Size = new System.Drawing.Size(100, 20);
            this.aaScore.TabIndex = 10;
            this.aaScore.TextChanged += new System.EventHandler(this.AaScore_TextChanged);
            // 
            // chooseGymnast
            // 
            this.chooseGymnast.FormattingEnabled = true;
            this.chooseGymnast.Location = new System.Drawing.Point(350, 194);
            this.chooseGymnast.Name = "chooseGymnast";
            this.chooseGymnast.Size = new System.Drawing.Size(121, 21);
            this.chooseGymnast.TabIndex = 11;
            this.chooseGymnast.SelectedIndexChanged += new System.EventHandler(this.ChooseGymnast_SelectedIndexChanged);
            // 
            // chooseMeet
            // 
            this.chooseMeet.FormattingEnabled = true;
            this.chooseMeet.Location = new System.Drawing.Point(44, 177);
            this.chooseMeet.Name = "chooseMeet";
            this.chooseMeet.Size = new System.Drawing.Size(121, 21);
            this.chooseMeet.TabIndex = 12;
            this.chooseMeet.SelectedIndexChanged += new System.EventHandler(this.ChooseMeet_SelectedIndexChanged);
            // 
            // meetName
            // 
            this.meetName.Location = new System.Drawing.Point(44, 240);
            this.meetName.Name = "meetName";
            this.meetName.Size = new System.Drawing.Size(100, 20);
            this.meetName.TabIndex = 13;
            this.meetName.TextChanged += new System.EventHandler(this.MeetName_TextChanged);
            // 
            // addMeet
            // 
            this.addMeet.Location = new System.Drawing.Point(152, 213);
            this.addMeet.Name = "addMeet";
            this.addMeet.Size = new System.Drawing.Size(75, 23);
            this.addMeet.TabIndex = 14;
            this.addMeet.Text = "Add Meet";
            this.addMeet.UseVisualStyleBackColor = true;
            this.addMeet.Click += new System.EventHandler(this.AddMeet_Click);
            // 
            // topMeet
            // 
            this.topMeet.Location = new System.Drawing.Point(44, 289);
            this.topMeet.Name = "topMeet";
            this.topMeet.Size = new System.Drawing.Size(75, 23);
            this.topMeet.TabIndex = 15;
            this.topMeet.Text = "Top in Meet";
            this.topMeet.UseVisualStyleBackColor = true;
            this.topMeet.Click += new System.EventHandler(this.TopMeet_Click);
            // 
            // topFloor
            // 
            this.topFloor.Location = new System.Drawing.Point(44, 328);
            this.topFloor.Name = "topFloor";
            this.topFloor.Size = new System.Drawing.Size(100, 20);
            this.topFloor.TabIndex = 16;
            this.topFloor.TextChanged += new System.EventHandler(this.TopFloor_TextChanged);
            // 
            // topPommel
            // 
            this.topPommel.Location = new System.Drawing.Point(44, 354);
            this.topPommel.Name = "topPommel";
            this.topPommel.Size = new System.Drawing.Size(100, 20);
            this.topPommel.TabIndex = 17;
            this.topPommel.TextChanged += new System.EventHandler(this.TopPommel_TextChanged);
            // 
            // topRings
            // 
            this.topRings.Location = new System.Drawing.Point(44, 380);
            this.topRings.Name = "topRings";
            this.topRings.Size = new System.Drawing.Size(100, 20);
            this.topRings.TabIndex = 18;
            this.topRings.TextChanged += new System.EventHandler(this.TopRings_TextChanged);
            // 
            // topVault
            // 
            this.topVault.Location = new System.Drawing.Point(44, 406);
            this.topVault.Name = "topVault";
            this.topVault.Size = new System.Drawing.Size(100, 20);
            this.topVault.TabIndex = 19;
            this.topVault.TextChanged += new System.EventHandler(this.TopVault_TextChanged);
            // 
            // topPbars
            // 
            this.topPbars.Location = new System.Drawing.Point(44, 432);
            this.topPbars.Name = "topPbars";
            this.topPbars.Size = new System.Drawing.Size(100, 20);
            this.topPbars.TabIndex = 20;
            this.topPbars.TextChanged += new System.EventHandler(this.TopPbars_TextChanged);
            // 
            // topHbar
            // 
            this.topHbar.Location = new System.Drawing.Point(44, 458);
            this.topHbar.Name = "topHbar";
            this.topHbar.Size = new System.Drawing.Size(100, 20);
            this.topHbar.TabIndex = 21;
            this.topHbar.TextChanged += new System.EventHandler(this.TopHbar_TextChanged);
            // 
            // topAA
            // 
            this.topAA.Location = new System.Drawing.Point(44, 484);
            this.topAA.Name = "topAA";
            this.topAA.Size = new System.Drawing.Size(100, 20);
            this.topAA.TabIndex = 22;
            this.topAA.TextChanged += new System.EventHandler(this.TopAA_TextChanged);
            // 
            // toMeet
            // 
            this.toMeet.Location = new System.Drawing.Point(457, 263);
            this.toMeet.Name = "toMeet";
            this.toMeet.Size = new System.Drawing.Size(101, 23);
            this.toMeet.TabIndex = 23;
            this.toMeet.Text = "Gymnast to Met";
            this.toMeet.UseVisualStyleBackColor = true;
            this.toMeet.Click += new System.EventHandler(this.ToMeet_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1011, 582);
            this.Controls.Add(this.toMeet);
            this.Controls.Add(this.topAA);
            this.Controls.Add(this.topHbar);
            this.Controls.Add(this.topPbars);
            this.Controls.Add(this.topVault);
            this.Controls.Add(this.topRings);
            this.Controls.Add(this.topPommel);
            this.Controls.Add(this.topFloor);
            this.Controls.Add(this.topMeet);
            this.Controls.Add(this.addMeet);
            this.Controls.Add(this.meetName);
            this.Controls.Add(this.chooseMeet);
            this.Controls.Add(this.chooseGymnast);
            this.Controls.Add(this.aaScore);
            this.Controls.Add(this.hbarScore);
            this.Controls.Add(this.pbarScore);
            this.Controls.Add(this.ringsScore);
            this.Controls.Add(this.vaultScore);
            this.Controls.Add(this.pommelScore);
            this.Controls.Add(this.floorScore);
            this.Controls.Add(this.displayGymnast);
            this.Controls.Add(this.addGymnast);
            this.Controls.Add(this.athleteGym);
            this.Controls.Add(this.athleteName);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox gymnastName;
        private System.Windows.Forms.TextBox athleteName;
        private System.Windows.Forms.TextBox athleteGym;
        private System.Windows.Forms.Button addGymnast;
        private System.Windows.Forms.Button displayGymnast;
        private System.Windows.Forms.TextBox floorScore;
        private System.Windows.Forms.TextBox pommelScore;
        private System.Windows.Forms.TextBox vaultScore;
        private System.Windows.Forms.TextBox ringsScore;
        private System.Windows.Forms.TextBox pbarScore;
        private System.Windows.Forms.TextBox hbarScore;
        private System.Windows.Forms.TextBox aaScore;
        private System.Windows.Forms.ComboBox chooseGymnast;
        private System.Windows.Forms.ComboBox chooseMeet;
        private System.Windows.Forms.TextBox meetName;
        private System.Windows.Forms.Button addMeet;
        private System.Windows.Forms.Button topMeet;
        private System.Windows.Forms.TextBox topFloor;
        private System.Windows.Forms.TextBox topPommel;
        private System.Windows.Forms.TextBox topRings;
        private System.Windows.Forms.TextBox topVault;
        private System.Windows.Forms.TextBox topPbars;
        private System.Windows.Forms.TextBox topHbar;
        private System.Windows.Forms.TextBox topAA;
        private System.Windows.Forms.Button toMeet;
    }
}

