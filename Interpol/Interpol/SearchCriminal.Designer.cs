namespace Interpol
{
    partial class SearchCriminal
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
            this.CriminalsData = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriminalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nickname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriminalHeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HairColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EyeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motherland = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Citizenship = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastHome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Languages = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CriminalWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.CheckCrimeMotherland = new System.Windows.Forms.CheckBox();
            this.CrimeDescription = new System.Windows.Forms.TextBox();
            this.CheckCrimeDescription = new System.Windows.Forms.CheckBox();
            this.CheckCrimeEyeColor = new System.Windows.Forms.CheckBox();
            this.CheckCrimeHairColor = new System.Windows.Forms.CheckBox();
            this.CrimeMotherland = new System.Windows.Forms.TextBox();
            this.CrimeEyeColor = new System.Windows.Forms.Button();
            this.CrimeHairColor = new System.Windows.Forms.Button();
            this.CheckCrimeLanguage = new System.Windows.Forms.CheckBox();
            this.CrimeLastHome = new System.Windows.Forms.TextBox();
            this.CrimeCitizenship = new System.Windows.Forms.TextBox();
            this.CheckCrimeLastHome = new System.Windows.Forms.CheckBox();
            this.CheckCrimeCitizenship = new System.Windows.Forms.CheckBox();
            this.CheckCrimeBirth = new System.Windows.Forms.CheckBox();
            this.CrimeBirthDate = new System.Windows.Forms.DateTimePicker();
            this.CrimeLastDeal = new System.Windows.Forms.TextBox();
            this.CheckCrimeLastDeal = new System.Windows.Forms.CheckBox();
            this.CrimeWork = new System.Windows.Forms.TextBox();
            this.CheckCrimeWork = new System.Windows.Forms.CheckBox();
            this.CrimeLanguages = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.ColorChooser = new System.Windows.Forms.ColorDialog();
            this.CheckCrimeName = new System.Windows.Forms.CheckBox();
            this.CheckCrimeSurname = new System.Windows.Forms.CheckBox();
            this.CheckCrimeNickname = new System.Windows.Forms.CheckBox();
            this.CrimeName = new System.Windows.Forms.TextBox();
            this.CrimeSurname = new System.Windows.Forms.TextBox();
            this.CrimeNickname = new System.Windows.Forms.TextBox();
            this.CheckCrimeHeight = new System.Windows.Forms.CheckBox();
            this.CrimeTopHeight = new System.Windows.Forms.NumericUpDown();
            this.CheckAll = new System.Windows.Forms.CheckBox();
            this.CrimeBotHeight = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CriminalsData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrimeTopHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrimeBotHeight)).BeginInit();
            this.SuspendLayout();
            // 
            // CriminalsData
            // 
            this.CriminalsData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CriminalsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CriminalsData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.CriminalName,
            this.Surname,
            this.Nickname,
            this.CriminalHeight,
            this.HairColor,
            this.EyeColor,
            this.Description,
            this.Motherland,
            this.Birth,
            this.Citizenship,
            this.LastHome,
            this.Languages,
            this.CriminalWork,
            this.LastWork});
            this.CriminalsData.Location = new System.Drawing.Point(12, 12);
            this.CriminalsData.Name = "CriminalsData";
            this.CriminalsData.ReadOnly = true;
            this.CriminalsData.RowHeadersVisible = false;
            this.CriminalsData.Size = new System.Drawing.Size(1354, 323);
            this.CriminalsData.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // CriminalName
            // 
            this.CriminalName.HeaderText = "Имя";
            this.CriminalName.Name = "CriminalName";
            this.CriminalName.ReadOnly = true;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.Name = "Surname";
            this.Surname.ReadOnly = true;
            // 
            // Nickname
            // 
            this.Nickname.HeaderText = "Кличка";
            this.Nickname.Name = "Nickname";
            this.Nickname.ReadOnly = true;
            // 
            // CriminalHeight
            // 
            this.CriminalHeight.HeaderText = "Рост";
            this.CriminalHeight.Name = "CriminalHeight";
            this.CriminalHeight.ReadOnly = true;
            // 
            // HairColor
            // 
            this.HairColor.HeaderText = "Цвет волос";
            this.HairColor.Name = "HairColor";
            this.HairColor.ReadOnly = true;
            // 
            // EyeColor
            // 
            this.EyeColor.HeaderText = "Цвет глаз";
            this.EyeColor.Name = "EyeColor";
            this.EyeColor.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Отличительные приметы";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Motherland
            // 
            this.Motherland.HeaderText = "Родина";
            this.Motherland.Name = "Motherland";
            this.Motherland.ReadOnly = true;
            // 
            // Birth
            // 
            this.Birth.HeaderText = "Дата рождения";
            this.Birth.Name = "Birth";
            this.Birth.ReadOnly = true;
            // 
            // Citizenship
            // 
            this.Citizenship.HeaderText = "Гражданство";
            this.Citizenship.Name = "Citizenship";
            this.Citizenship.ReadOnly = true;
            // 
            // LastHome
            // 
            this.LastHome.HeaderText = "Последнее место жительства";
            this.LastHome.Name = "LastHome";
            this.LastHome.ReadOnly = true;
            // 
            // Languages
            // 
            this.Languages.HeaderText = "Языки";
            this.Languages.Name = "Languages";
            this.Languages.ReadOnly = true;
            // 
            // CriminalWork
            // 
            this.CriminalWork.HeaderText = "Тюремная работа";
            this.CriminalWork.Name = "CriminalWork";
            this.CriminalWork.ReadOnly = true;
            // 
            // LastWork
            // 
            this.LastWork.HeaderText = "Последнее преступление";
            this.LastWork.Name = "LastWork";
            this.LastWork.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Фильтр:";
            // 
            // CheckCrimeMotherland
            // 
            this.CheckCrimeMotherland.AutoSize = true;
            this.CheckCrimeMotherland.Location = new System.Drawing.Point(314, 431);
            this.CheckCrimeMotherland.Name = "CheckCrimeMotherland";
            this.CheckCrimeMotherland.Size = new System.Drawing.Size(63, 17);
            this.CheckCrimeMotherland.TabIndex = 38;
            this.CheckCrimeMotherland.Text = "Родина";
            this.CheckCrimeMotherland.UseVisualStyleBackColor = true;
            this.CheckCrimeMotherland.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CrimeDescription
            // 
            this.CrimeDescription.Location = new System.Drawing.Point(473, 407);
            this.CrimeDescription.Name = "CrimeDescription";
            this.CrimeDescription.Size = new System.Drawing.Size(141, 20);
            this.CrimeDescription.TabIndex = 37;
            // 
            // CheckCrimeDescription
            // 
            this.CheckCrimeDescription.AutoSize = true;
            this.CheckCrimeDescription.Location = new System.Drawing.Point(314, 408);
            this.CheckCrimeDescription.Name = "CheckCrimeDescription";
            this.CheckCrimeDescription.Size = new System.Drawing.Size(153, 17);
            this.CheckCrimeDescription.TabIndex = 34;
            this.CheckCrimeDescription.Text = "Отличительные приметы";
            this.CheckCrimeDescription.UseVisualStyleBackColor = true;
            this.CheckCrimeDescription.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CheckCrimeEyeColor
            // 
            this.CheckCrimeEyeColor.AutoSize = true;
            this.CheckCrimeEyeColor.Location = new System.Drawing.Point(314, 385);
            this.CheckCrimeEyeColor.Name = "CheckCrimeEyeColor";
            this.CheckCrimeEyeColor.Size = new System.Drawing.Size(77, 17);
            this.CheckCrimeEyeColor.TabIndex = 33;
            this.CheckCrimeEyeColor.Text = "Цвет глаз";
            this.CheckCrimeEyeColor.UseVisualStyleBackColor = true;
            this.CheckCrimeEyeColor.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CheckCrimeHairColor
            // 
            this.CheckCrimeHairColor.AutoSize = true;
            this.CheckCrimeHairColor.Location = new System.Drawing.Point(314, 362);
            this.CheckCrimeHairColor.Name = "CheckCrimeHairColor";
            this.CheckCrimeHairColor.Size = new System.Drawing.Size(84, 17);
            this.CheckCrimeHairColor.TabIndex = 32;
            this.CheckCrimeHairColor.Text = "Цвет волос";
            this.CheckCrimeHairColor.UseVisualStyleBackColor = true;
            this.CheckCrimeHairColor.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CrimeMotherland
            // 
            this.CrimeMotherland.Location = new System.Drawing.Point(473, 430);
            this.CrimeMotherland.Name = "CrimeMotherland";
            this.CrimeMotherland.Size = new System.Drawing.Size(141, 20);
            this.CrimeMotherland.TabIndex = 39;
            // 
            // CrimeEyeColor
            // 
            this.CrimeEyeColor.Location = new System.Drawing.Point(473, 382);
            this.CrimeEyeColor.Name = "CrimeEyeColor";
            this.CrimeEyeColor.Size = new System.Drawing.Size(141, 23);
            this.CrimeEyeColor.TabIndex = 41;
            this.CrimeEyeColor.Text = "Выбрать цвет";
            this.CrimeEyeColor.UseVisualStyleBackColor = true;
            this.CrimeEyeColor.Click += new System.EventHandler(this.CrimeEyeColor_Click);
            // 
            // CrimeHairColor
            // 
            this.CrimeHairColor.Location = new System.Drawing.Point(473, 359);
            this.CrimeHairColor.Name = "CrimeHairColor";
            this.CrimeHairColor.Size = new System.Drawing.Size(141, 23);
            this.CrimeHairColor.TabIndex = 40;
            this.CrimeHairColor.Text = "Выбрать цвет";
            this.CrimeHairColor.UseVisualStyleBackColor = true;
            this.CrimeHairColor.Click += new System.EventHandler(this.CrimeHairColor_Click);
            // 
            // CheckCrimeLanguage
            // 
            this.CheckCrimeLanguage.AutoSize = true;
            this.CheckCrimeLanguage.Location = new System.Drawing.Point(696, 431);
            this.CheckCrimeLanguage.Name = "CheckCrimeLanguage";
            this.CheckCrimeLanguage.Size = new System.Drawing.Size(60, 17);
            this.CheckCrimeLanguage.TabIndex = 48;
            this.CheckCrimeLanguage.Text = "Языки";
            this.CheckCrimeLanguage.UseVisualStyleBackColor = true;
            this.CheckCrimeLanguage.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CrimeLastHome
            // 
            this.CrimeLastHome.Location = new System.Drawing.Point(881, 407);
            this.CrimeLastHome.Name = "CrimeLastHome";
            this.CrimeLastHome.Size = new System.Drawing.Size(141, 20);
            this.CrimeLastHome.TabIndex = 47;
            // 
            // CrimeCitizenship
            // 
            this.CrimeCitizenship.Location = new System.Drawing.Point(881, 384);
            this.CrimeCitizenship.Name = "CrimeCitizenship";
            this.CrimeCitizenship.Size = new System.Drawing.Size(141, 20);
            this.CrimeCitizenship.TabIndex = 46;
            // 
            // CheckCrimeLastHome
            // 
            this.CheckCrimeLastHome.AutoSize = true;
            this.CheckCrimeLastHome.Location = new System.Drawing.Point(696, 408);
            this.CheckCrimeLastHome.Name = "CheckCrimeLastHome";
            this.CheckCrimeLastHome.Size = new System.Drawing.Size(179, 17);
            this.CheckCrimeLastHome.TabIndex = 44;
            this.CheckCrimeLastHome.Text = "Последнее место жительства";
            this.CheckCrimeLastHome.UseVisualStyleBackColor = true;
            this.CheckCrimeLastHome.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CheckCrimeCitizenship
            // 
            this.CheckCrimeCitizenship.AutoSize = true;
            this.CheckCrimeCitizenship.Location = new System.Drawing.Point(696, 385);
            this.CheckCrimeCitizenship.Name = "CheckCrimeCitizenship";
            this.CheckCrimeCitizenship.Size = new System.Drawing.Size(93, 17);
            this.CheckCrimeCitizenship.TabIndex = 43;
            this.CheckCrimeCitizenship.Text = "Гражданство";
            this.CheckCrimeCitizenship.UseVisualStyleBackColor = true;
            this.CheckCrimeCitizenship.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CheckCrimeBirth
            // 
            this.CheckCrimeBirth.AutoSize = true;
            this.CheckCrimeBirth.Location = new System.Drawing.Point(696, 362);
            this.CheckCrimeBirth.Name = "CheckCrimeBirth";
            this.CheckCrimeBirth.Size = new System.Drawing.Size(105, 17);
            this.CheckCrimeBirth.TabIndex = 42;
            this.CheckCrimeBirth.Text = "Дата рождения";
            this.CheckCrimeBirth.UseVisualStyleBackColor = true;
            this.CheckCrimeBirth.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CrimeBirthDate
            // 
            this.CrimeBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CrimeBirthDate.Location = new System.Drawing.Point(881, 358);
            this.CrimeBirthDate.MaxDate = new System.DateTime(2018, 6, 10, 0, 0, 0, 0);
            this.CrimeBirthDate.Name = "CrimeBirthDate";
            this.CrimeBirthDate.Size = new System.Drawing.Size(141, 20);
            this.CrimeBirthDate.TabIndex = 50;
            this.CrimeBirthDate.Value = new System.DateTime(2018, 6, 10, 0, 0, 0, 0);
            // 
            // CrimeLastDeal
            // 
            this.CrimeLastDeal.Location = new System.Drawing.Point(1225, 384);
            this.CrimeLastDeal.Name = "CrimeLastDeal";
            this.CrimeLastDeal.Size = new System.Drawing.Size(141, 20);
            this.CrimeLastDeal.TabIndex = 54;
            // 
            // CheckCrimeLastDeal
            // 
            this.CheckCrimeLastDeal.AutoSize = true;
            this.CheckCrimeLastDeal.Location = new System.Drawing.Point(1064, 385);
            this.CheckCrimeLastDeal.Name = "CheckCrimeLastDeal";
            this.CheckCrimeLastDeal.Size = new System.Drawing.Size(155, 17);
            this.CheckCrimeLastDeal.TabIndex = 53;
            this.CheckCrimeLastDeal.Text = "Последнее преступление";
            this.CheckCrimeLastDeal.UseVisualStyleBackColor = true;
            this.CheckCrimeLastDeal.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CrimeWork
            // 
            this.CrimeWork.Location = new System.Drawing.Point(1225, 361);
            this.CrimeWork.Name = "CrimeWork";
            this.CrimeWork.Size = new System.Drawing.Size(141, 20);
            this.CrimeWork.TabIndex = 52;
            // 
            // CheckCrimeWork
            // 
            this.CheckCrimeWork.AutoSize = true;
            this.CheckCrimeWork.Location = new System.Drawing.Point(1064, 362);
            this.CheckCrimeWork.Name = "CheckCrimeWork";
            this.CheckCrimeWork.Size = new System.Drawing.Size(138, 17);
            this.CheckCrimeWork.TabIndex = 51;
            this.CheckCrimeWork.Text = "Тюремная профессия";
            this.CheckCrimeWork.UseVisualStyleBackColor = true;
            this.CheckCrimeWork.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CrimeLanguages
            // 
            this.CrimeLanguages.Location = new System.Drawing.Point(881, 430);
            this.CrimeLanguages.Name = "CrimeLanguages";
            this.CrimeLanguages.Size = new System.Drawing.Size(141, 20);
            this.CrimeLanguages.TabIndex = 55;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(1064, 428);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(155, 23);
            this.Search.TabIndex = 56;
            this.Search.Text = "Применить фильтр";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CheckCrimeName
            // 
            this.CheckCrimeName.AutoSize = true;
            this.CheckCrimeName.Location = new System.Drawing.Point(12, 362);
            this.CheckCrimeName.Name = "CheckCrimeName";
            this.CheckCrimeName.Size = new System.Drawing.Size(48, 17);
            this.CheckCrimeName.TabIndex = 2;
            this.CheckCrimeName.Text = "Имя";
            this.CheckCrimeName.UseVisualStyleBackColor = true;
            this.CheckCrimeName.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CheckCrimeSurname
            // 
            this.CheckCrimeSurname.AutoSize = true;
            this.CheckCrimeSurname.Location = new System.Drawing.Point(12, 385);
            this.CheckCrimeSurname.Name = "CheckCrimeSurname";
            this.CheckCrimeSurname.Size = new System.Drawing.Size(75, 17);
            this.CheckCrimeSurname.TabIndex = 3;
            this.CheckCrimeSurname.Text = "Фамилия";
            this.CheckCrimeSurname.UseVisualStyleBackColor = true;
            this.CheckCrimeSurname.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CheckCrimeNickname
            // 
            this.CheckCrimeNickname.AutoSize = true;
            this.CheckCrimeNickname.Location = new System.Drawing.Point(12, 408);
            this.CheckCrimeNickname.Name = "CheckCrimeNickname";
            this.CheckCrimeNickname.Size = new System.Drawing.Size(62, 17);
            this.CheckCrimeNickname.TabIndex = 4;
            this.CheckCrimeNickname.Text = "Кличка";
            this.CheckCrimeNickname.UseVisualStyleBackColor = true;
            this.CheckCrimeNickname.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CrimeName
            // 
            this.CrimeName.Location = new System.Drawing.Point(99, 361);
            this.CrimeName.Name = "CrimeName";
            this.CrimeName.Size = new System.Drawing.Size(141, 20);
            this.CrimeName.TabIndex = 6;
            // 
            // CrimeSurname
            // 
            this.CrimeSurname.Location = new System.Drawing.Point(99, 384);
            this.CrimeSurname.Name = "CrimeSurname";
            this.CrimeSurname.Size = new System.Drawing.Size(141, 20);
            this.CrimeSurname.TabIndex = 7;
            // 
            // CrimeNickname
            // 
            this.CrimeNickname.Location = new System.Drawing.Point(99, 407);
            this.CrimeNickname.Name = "CrimeNickname";
            this.CrimeNickname.Size = new System.Drawing.Size(141, 20);
            this.CrimeNickname.TabIndex = 8;
            // 
            // CheckCrimeHeight
            // 
            this.CheckCrimeHeight.AutoSize = true;
            this.CheckCrimeHeight.Location = new System.Drawing.Point(12, 446);
            this.CheckCrimeHeight.Name = "CheckCrimeHeight";
            this.CheckCrimeHeight.Size = new System.Drawing.Size(50, 17);
            this.CheckCrimeHeight.TabIndex = 9;
            this.CheckCrimeHeight.Text = "Рост";
            this.CheckCrimeHeight.UseVisualStyleBackColor = true;
            this.CheckCrimeHeight.CheckedChanged += new System.EventHandler(this.CheckCrime_CheckedChanged);
            // 
            // CrimeTopHeight
            // 
            this.CrimeTopHeight.Location = new System.Drawing.Point(99, 431);
            this.CrimeTopHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CrimeTopHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CrimeTopHeight.Name = "CrimeTopHeight";
            this.CrimeTopHeight.Size = new System.Drawing.Size(141, 20);
            this.CrimeTopHeight.TabIndex = 31;
            this.CrimeTopHeight.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // CheckAll
            // 
            this.CheckAll.AutoSize = true;
            this.CheckAll.Location = new System.Drawing.Point(1064, 408);
            this.CheckAll.Name = "CheckAll";
            this.CheckAll.Size = new System.Drawing.Size(45, 17);
            this.CheckAll.TabIndex = 57;
            this.CheckAll.Text = "Все";
            this.CheckAll.UseVisualStyleBackColor = true;
            // 
            // CrimeBotHeight
            // 
            this.CrimeBotHeight.Location = new System.Drawing.Point(99, 457);
            this.CrimeBotHeight.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.CrimeBotHeight.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.CrimeBotHeight.Name = "CrimeBotHeight";
            this.CrimeBotHeight.Size = new System.Drawing.Size(141, 20);
            this.CrimeBotHeight.TabIndex = 58;
            this.CrimeBotHeight.Value = new decimal(new int[] {
            170,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "от:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 433);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 60;
            this.label3.Text = "до:";
            // 
            // SearchCriminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 489);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CrimeBotHeight);
            this.Controls.Add(this.CheckAll);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CrimeLanguages);
            this.Controls.Add(this.CrimeLastDeal);
            this.Controls.Add(this.CheckCrimeLastDeal);
            this.Controls.Add(this.CrimeWork);
            this.Controls.Add(this.CheckCrimeWork);
            this.Controls.Add(this.CrimeBirthDate);
            this.Controls.Add(this.CheckCrimeLanguage);
            this.Controls.Add(this.CrimeLastHome);
            this.Controls.Add(this.CrimeCitizenship);
            this.Controls.Add(this.CheckCrimeLastHome);
            this.Controls.Add(this.CheckCrimeCitizenship);
            this.Controls.Add(this.CheckCrimeBirth);
            this.Controls.Add(this.CrimeEyeColor);
            this.Controls.Add(this.CrimeHairColor);
            this.Controls.Add(this.CrimeMotherland);
            this.Controls.Add(this.CheckCrimeMotherland);
            this.Controls.Add(this.CrimeDescription);
            this.Controls.Add(this.CheckCrimeDescription);
            this.Controls.Add(this.CheckCrimeEyeColor);
            this.Controls.Add(this.CheckCrimeHairColor);
            this.Controls.Add(this.CrimeTopHeight);
            this.Controls.Add(this.CheckCrimeHeight);
            this.Controls.Add(this.CrimeNickname);
            this.Controls.Add(this.CrimeSurname);
            this.Controls.Add(this.CrimeName);
            this.Controls.Add(this.CheckCrimeNickname);
            this.Controls.Add(this.CheckCrimeSurname);
            this.Controls.Add(this.CheckCrimeName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CriminalsData);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchCriminal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Поиск заключенного";
            ((System.ComponentModel.ISupportInitialize)(this.CriminalsData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrimeTopHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrimeBotHeight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CriminalsData;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriminalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nickname;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriminalHeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn HairColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn EyeColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motherland;
        private System.Windows.Forms.DataGridViewTextBoxColumn Birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn Citizenship;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastHome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Languages;
        private System.Windows.Forms.DataGridViewTextBoxColumn CriminalWork;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastWork;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox CheckCrimeMotherland;
        private System.Windows.Forms.TextBox CrimeDescription;
        private System.Windows.Forms.CheckBox CheckCrimeDescription;
        private System.Windows.Forms.CheckBox CheckCrimeEyeColor;
        private System.Windows.Forms.CheckBox CheckCrimeHairColor;
        private System.Windows.Forms.TextBox CrimeMotherland;
        private System.Windows.Forms.Button CrimeEyeColor;
        private System.Windows.Forms.Button CrimeHairColor;
        private System.Windows.Forms.CheckBox CheckCrimeLanguage;
        private System.Windows.Forms.TextBox CrimeLastHome;
        private System.Windows.Forms.TextBox CrimeCitizenship;
        private System.Windows.Forms.CheckBox CheckCrimeLastHome;
        private System.Windows.Forms.CheckBox CheckCrimeCitizenship;
        private System.Windows.Forms.CheckBox CheckCrimeBirth;
        private System.Windows.Forms.DateTimePicker CrimeBirthDate;
        private System.Windows.Forms.TextBox CrimeLastDeal;
        private System.Windows.Forms.CheckBox CheckCrimeLastDeal;
        private System.Windows.Forms.TextBox CrimeWork;
        private System.Windows.Forms.CheckBox CheckCrimeWork;
        private System.Windows.Forms.TextBox CrimeLanguages;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ColorDialog ColorChooser;
        private System.Windows.Forms.CheckBox CheckCrimeName;
        private System.Windows.Forms.CheckBox CheckCrimeSurname;
        private System.Windows.Forms.CheckBox CheckCrimeNickname;
        private System.Windows.Forms.TextBox CrimeName;
        private System.Windows.Forms.TextBox CrimeSurname;
        private System.Windows.Forms.TextBox CrimeNickname;
        private System.Windows.Forms.CheckBox CheckCrimeHeight;
        private System.Windows.Forms.NumericUpDown CrimeTopHeight;
        private System.Windows.Forms.CheckBox CheckAll;
        private System.Windows.Forms.NumericUpDown CrimeBotHeight;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;


    }
}