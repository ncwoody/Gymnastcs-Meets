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
            this.components = new System.ComponentModel.Container();
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
            this.addGym = new System.Windows.Forms.Button();
            this.chooseGym = new System.Windows.Forms.ComboBox();
            this.gymnastToGym = new System.Windows.Forms.Button();
            this.listGym = new System.Windows.Forms.Button();
            this.displayGymList = new System.Windows.Forms.TextBox();
            this.CLEAR = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.floorSheet = new System.Windows.Forms.Button();
            this.pommelSheet = new System.Windows.Forms.Button();
            this.ringsSheet = new System.Windows.Forms.Button();
            this.vaultSheet = new System.Windows.Forms.Button();
            this.pbarsheet = new System.Windows.Forms.Button();
            this.hbarSheet = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog3 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog4 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog5 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog6 = new System.Windows.Forms.OpenFileDialog();
            this.exportGym = new System.Windows.Forms.Button();
            this.exportMeet = new System.Windows.Forms.Button();
            this.gymPath = new System.Windows.Forms.TextBox();
            this.meetPath = new System.Windows.Forms.TextBox();
            this.exportGmnst = new System.Windows.Forms.Button();
            this.nastPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
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
            this.athleteGym.Location = new System.Drawing.Point(514, 318);
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
            this.floorScore.Location = new System.Drawing.Point(778, 237);
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
            this.toMeet.Location = new System.Drawing.Point(261, 266);
            this.toMeet.Name = "toMeet";
            this.toMeet.Size = new System.Drawing.Size(101, 23);
            this.toMeet.TabIndex = 23;
            this.toMeet.Text = "Gymnast to Meet";
            this.toMeet.UseVisualStyleBackColor = true;
            this.toMeet.Click += new System.EventHandler(this.ToMeet_Click);
            // 
            // addGym
            // 
            this.addGym.Location = new System.Drawing.Point(636, 341);
            this.addGym.Name = "addGym";
            this.addGym.Size = new System.Drawing.Size(75, 23);
            this.addGym.TabIndex = 24;
            this.addGym.Text = "Add Gym";
            this.addGym.UseVisualStyleBackColor = true;
            this.addGym.Click += new System.EventHandler(this.AddGym_Click);
            // 
            // chooseGym
            // 
            this.chooseGym.FormattingEnabled = true;
            this.chooseGym.Location = new System.Drawing.Point(383, 353);
            this.chooseGym.Name = "chooseGym";
            this.chooseGym.Size = new System.Drawing.Size(121, 21);
            this.chooseGym.TabIndex = 25;
            this.chooseGym.SelectedIndexChanged += new System.EventHandler(this.ChooseGym_SelectedIndexChanged);
            // 
            // gymnastToGym
            // 
            this.gymnastToGym.Location = new System.Drawing.Point(514, 263);
            this.gymnastToGym.Name = "gymnastToGym";
            this.gymnastToGym.Size = new System.Drawing.Size(100, 23);
            this.gymnastToGym.TabIndex = 26;
            this.gymnastToGym.Text = "Gymnast to Gym";
            this.gymnastToGym.UseVisualStyleBackColor = true;
            this.gymnastToGym.Click += new System.EventHandler(this.GymnastToGym_Click);
            // 
            // listGym
            // 
            this.listGym.Location = new System.Drawing.Point(529, 367);
            this.listGym.Name = "listGym";
            this.listGym.Size = new System.Drawing.Size(75, 23);
            this.listGym.TabIndex = 27;
            this.listGym.Text = "List in Gym";
            this.listGym.UseVisualStyleBackColor = true;
            this.listGym.Click += new System.EventHandler(this.ListGym_Click);
            // 
            // displayGymList
            // 
            this.displayGymList.Location = new System.Drawing.Point(514, 406);
            this.displayGymList.Multiline = true;
            this.displayGymList.Name = "displayGymList";
            this.displayGymList.Size = new System.Drawing.Size(209, 89);
            this.displayGymList.TabIndex = 28;
            this.displayGymList.TextChanged += new System.EventHandler(this.DisplayGymList_TextChanged);
            // 
            // CLEAR
            // 
            this.CLEAR.Location = new System.Drawing.Point(905, 535);
            this.CLEAR.Name = "CLEAR";
            this.CLEAR.Size = new System.Drawing.Size(75, 23);
            this.CLEAR.TabIndex = 29;
            this.CLEAR.Text = "ClearAll";
            this.CLEAR.UseVisualStyleBackColor = true;
            this.CLEAR.Click += new System.EventHandler(this.CLEAR_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.RestoreDirectory = true;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.DefaultExt = "txt";
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // floorSheet
            // 
            this.floorSheet.Location = new System.Drawing.Point(884, 237);
            this.floorSheet.Name = "floorSheet";
            this.floorSheet.Size = new System.Drawing.Size(115, 23);
            this.floorSheet.TabIndex = 30;
            this.floorSheet.Text = "Add Score Sheet";
            this.floorSheet.UseVisualStyleBackColor = true;
            this.floorSheet.Click += new System.EventHandler(this.FloorSheet_Click);
            // 
            // pommelSheet
            // 
            this.pommelSheet.Location = new System.Drawing.Point(884, 264);
            this.pommelSheet.Name = "pommelSheet";
            this.pommelSheet.Size = new System.Drawing.Size(115, 23);
            this.pommelSheet.TabIndex = 31;
            this.pommelSheet.Text = "Add Score Sheet";
            this.pommelSheet.UseVisualStyleBackColor = true;
            this.pommelSheet.Click += new System.EventHandler(this.PommelSheet_Click);
            // 
            // ringsSheet
            // 
            this.ringsSheet.Location = new System.Drawing.Point(884, 290);
            this.ringsSheet.Name = "ringsSheet";
            this.ringsSheet.Size = new System.Drawing.Size(115, 23);
            this.ringsSheet.TabIndex = 32;
            this.ringsSheet.Text = "Add Score Sheet";
            this.ringsSheet.UseVisualStyleBackColor = true;
            this.ringsSheet.Click += new System.EventHandler(this.RingsSheet_Click);
            // 
            // vaultSheet
            // 
            this.vaultSheet.Location = new System.Drawing.Point(884, 316);
            this.vaultSheet.Name = "vaultSheet";
            this.vaultSheet.Size = new System.Drawing.Size(115, 23);
            this.vaultSheet.TabIndex = 33;
            this.vaultSheet.Text = "Add Score Sheet";
            this.vaultSheet.UseVisualStyleBackColor = true;
            this.vaultSheet.Click += new System.EventHandler(this.VaultSheet_Click);
            // 
            // pbarsheet
            // 
            this.pbarsheet.Location = new System.Drawing.Point(884, 341);
            this.pbarsheet.Name = "pbarsheet";
            this.pbarsheet.Size = new System.Drawing.Size(115, 23);
            this.pbarsheet.TabIndex = 34;
            this.pbarsheet.Text = "Add Score Sheet";
            this.pbarsheet.UseVisualStyleBackColor = true;
            this.pbarsheet.Click += new System.EventHandler(this.Pbarsheet_Click);
            // 
            // hbarSheet
            // 
            this.hbarSheet.Location = new System.Drawing.Point(884, 370);
            this.hbarSheet.Name = "hbarSheet";
            this.hbarSheet.Size = new System.Drawing.Size(115, 23);
            this.hbarSheet.TabIndex = 35;
            this.hbarSheet.Text = "Add Score Sheet";
            this.hbarSheet.UseVisualStyleBackColor = true;
            this.hbarSheet.Click += new System.EventHandler(this.HbarSheet_Click);
            // 
            // openFileDialog3
            // 
            this.openFileDialog3.DefaultExt = "txt";
            this.openFileDialog3.FileName = "openFileDialog3";
            // 
            // openFileDialog4
            // 
            this.openFileDialog4.DefaultExt = "txt";
            this.openFileDialog4.FileName = "openFileDialog4";
            // 
            // openFileDialog5
            // 
            this.openFileDialog5.DefaultExt = "txt";
            this.openFileDialog5.FileName = "openFileDialog5";
            // 
            // openFileDialog6
            // 
            this.openFileDialog6.DefaultExt = "txt";
            this.openFileDialog6.FileName = "openFileDialog6";
            // 
            // exportGym
            // 
            this.exportGym.Location = new System.Drawing.Point(636, 143);
            this.exportGym.Name = "exportGym";
            this.exportGym.Size = new System.Drawing.Size(75, 23);
            this.exportGym.TabIndex = 36;
            this.exportGym.Text = "Export Gym";
            this.exportGym.UseVisualStyleBackColor = true;
            this.exportGym.Click += new System.EventHandler(this.ExportGym_Click);
            // 
            // exportMeet
            // 
            this.exportMeet.Location = new System.Drawing.Point(152, 519);
            this.exportMeet.Name = "exportMeet";
            this.exportMeet.Size = new System.Drawing.Size(75, 23);
            this.exportMeet.TabIndex = 37;
            this.exportMeet.Text = "Export Meet";
            this.exportMeet.UseVisualStyleBackColor = true;
            this.exportMeet.Click += new System.EventHandler(this.ExportMeet_Click);
            // 
            // gymPath
            // 
            this.gymPath.Location = new System.Drawing.Point(623, 117);
            this.gymPath.Name = "gymPath";
            this.gymPath.Size = new System.Drawing.Size(133, 20);
            this.gymPath.TabIndex = 38;
            this.gymPath.TextChanged += new System.EventHandler(this.GymPath_TextChanged);
            // 
            // meetPath
            // 
            this.meetPath.Location = new System.Drawing.Point(152, 550);
            this.meetPath.Name = "meetPath";
            this.meetPath.Size = new System.Drawing.Size(100, 20);
            this.meetPath.TabIndex = 39;
            this.meetPath.TextChanged += new System.EventHandler(this.MeetPath_TextChanged);
            // 
            // exportGmnst
            // 
            this.exportGmnst.Location = new System.Drawing.Point(459, 143);
            this.exportGmnst.Name = "exportGmnst";
            this.exportGmnst.Size = new System.Drawing.Size(100, 23);
            this.exportGmnst.TabIndex = 40;
            this.exportGmnst.Text = "Export Gymnast";
            this.exportGmnst.UseVisualStyleBackColor = true;
            this.exportGmnst.Click += new System.EventHandler(this.ExportGmnst_Click);
            // 
            // nastPath
            // 
            this.nastPath.Location = new System.Drawing.Point(459, 117);
            this.nastPath.Name = "nastPath";
            this.nastPath.Size = new System.Drawing.Size(100, 20);
            this.nastPath.TabIndex = 41;
            this.nastPath.TextChanged += new System.EventHandler(this.NastPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Competition Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(524, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Gymnast Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 341);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Gym Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(347, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "List of Gymnasts";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "List of Competitions";
            this.label5.Click += new System.EventHandler(this.Label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(380, 380);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "List of Gyms";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 498);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Gymnasts in Gym";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(39, 507);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Top Scores in Meet";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(775, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 13);
            this.label9.TabIndex = 50;
            this.label9.Text = "Scores for Gymnast";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(269, 557);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Path to export Competition";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(456, 101);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 13);
            this.label11.TabIndex = 52;
            this.label11.Text = "Path to export Gymnast";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(620, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 53;
            this.label12.Text = "Path to export gym";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(108, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(181, 13);
            this.label13.TabIndex = 54;
            this.label13.Text = "Gymnastics Competition Scorer V 1.0";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1011, 582);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nastPath);
            this.Controls.Add(this.exportGmnst);
            this.Controls.Add(this.meetPath);
            this.Controls.Add(this.gymPath);
            this.Controls.Add(this.exportMeet);
            this.Controls.Add(this.exportGym);
            this.Controls.Add(this.hbarSheet);
            this.Controls.Add(this.pbarsheet);
            this.Controls.Add(this.vaultSheet);
            this.Controls.Add(this.ringsSheet);
            this.Controls.Add(this.pommelSheet);
            this.Controls.Add(this.floorSheet);
            this.Controls.Add(this.CLEAR);
            this.Controls.Add(this.displayGymList);
            this.Controls.Add(this.listGym);
            this.Controls.Add(this.gymnastToGym);
            this.Controls.Add(this.chooseGym);
            this.Controls.Add(this.addGym);
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
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
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
        private System.Windows.Forms.Button addGym;
        private System.Windows.Forms.ComboBox chooseGym;
        private System.Windows.Forms.Button gymnastToGym;
        private System.Windows.Forms.Button listGym;
        private System.Windows.Forms.TextBox displayGymList;
        private System.Windows.Forms.Button CLEAR;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button floorSheet;
        private System.Windows.Forms.Button pommelSheet;
        private System.Windows.Forms.Button ringsSheet;
        private System.Windows.Forms.Button vaultSheet;
        private System.Windows.Forms.Button pbarsheet;
        private System.Windows.Forms.Button hbarSheet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.OpenFileDialog openFileDialog3;
        private System.Windows.Forms.OpenFileDialog openFileDialog4;
        private System.Windows.Forms.OpenFileDialog openFileDialog5;
        private System.Windows.Forms.OpenFileDialog openFileDialog6;
        private System.Windows.Forms.Button exportGym;
        private System.Windows.Forms.Button exportMeet;
        private System.Windows.Forms.TextBox gymPath;
        private System.Windows.Forms.TextBox meetPath;
        private System.Windows.Forms.Button exportGmnst;
        private System.Windows.Forms.TextBox nastPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

