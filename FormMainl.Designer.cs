namespace P13_amatbruno_proyectoBarberTop_p1
{
    partial class FormMainl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainl));
            this.radioButtonWomen = new System.Windows.Forms.RadioButton();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonKid = new System.Windows.Forms.RadioButton();
            this.checkBoxWash = new System.Windows.Forms.CheckBox();
            this.checkBoxCut = new System.Windows.Forms.CheckBox();
            this.checkBoxComb = new System.Windows.Forms.CheckBox();
            this.checkBoxDye = new System.Windows.Forms.CheckBox();
            this.checkBoxPerm = new System.Windows.Forms.CheckBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.comboBoxIVA = new System.Windows.Forms.ComboBox();
            this.labelIVA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxService = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxChange = new System.Windows.Forms.TextBox();
            this.timerHour = new System.Windows.Forms.Timer(this.components);
            this.textBoxCash = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonWomen
            // 
            this.radioButtonWomen.AutoSize = true;
            this.radioButtonWomen.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonWomen.Checked = true;
            this.radioButtonWomen.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonWomen.ForeColor = System.Drawing.Color.White;
            this.radioButtonWomen.Location = new System.Drawing.Point(39, 57);
            this.radioButtonWomen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonWomen.Name = "radioButtonWomen";
            this.radioButtonWomen.Size = new System.Drawing.Size(172, 40);
            this.radioButtonWomen.TabIndex = 2;
            this.radioButtonWomen.TabStop = true;
            this.radioButtonWomen.Text = "WOMEN";
            this.radioButtonWomen.UseVisualStyleBackColor = false;
            this.radioButtonWomen.CheckedChanged += new System.EventHandler(this.calculateService);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMan.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonMan.ForeColor = System.Drawing.Color.White;
            this.radioButtonMan.Location = new System.Drawing.Point(39, 101);
            this.radioButtonMan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(118, 40);
            this.radioButtonMan.TabIndex = 3;
            this.radioButtonMan.Text = "MEN";
            this.radioButtonMan.UseVisualStyleBackColor = false;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.calculateService);
            // 
            // radioButtonKid
            // 
            this.radioButtonKid.AutoSize = true;
            this.radioButtonKid.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonKid.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.radioButtonKid.ForeColor = System.Drawing.Color.White;
            this.radioButtonKid.Location = new System.Drawing.Point(39, 151);
            this.radioButtonKid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButtonKid.Name = "radioButtonKid";
            this.radioButtonKid.Size = new System.Drawing.Size(143, 40);
            this.radioButtonKid.TabIndex = 4;
            this.radioButtonKid.Text = "CHILD";
            this.radioButtonKid.UseVisualStyleBackColor = false;
            this.radioButtonKid.CheckedChanged += new System.EventHandler(this.calculateService);
            // 
            // checkBoxWash
            // 
            this.checkBoxWash.AutoSize = true;
            this.checkBoxWash.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxWash.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxWash.ForeColor = System.Drawing.Color.White;
            this.checkBoxWash.Location = new System.Drawing.Point(40, 77);
            this.checkBoxWash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxWash.Name = "checkBoxWash";
            this.checkBoxWash.Size = new System.Drawing.Size(142, 40);
            this.checkBoxWash.TabIndex = 5;
            this.checkBoxWash.Text = "WASH";
            this.checkBoxWash.UseVisualStyleBackColor = false;
            this.checkBoxWash.CheckedChanged += new System.EventHandler(this.calculateService);
            // 
            // checkBoxCut
            // 
            this.checkBoxCut.AutoSize = true;
            this.checkBoxCut.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxCut.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxCut.ForeColor = System.Drawing.Color.White;
            this.checkBoxCut.Location = new System.Drawing.Point(186, 77);
            this.checkBoxCut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxCut.Name = "checkBoxCut";
            this.checkBoxCut.Size = new System.Drawing.Size(236, 40);
            this.checkBoxCut.TabIndex = 6;
            this.checkBoxCut.Text = "CUT + COMB";
            this.checkBoxCut.UseVisualStyleBackColor = false;
            this.checkBoxCut.CheckedChanged += new System.EventHandler(this.calculateService);
            // 
            // checkBoxComb
            // 
            this.checkBoxComb.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.checkBoxComb.AutoSize = true;
            this.checkBoxComb.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxComb.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxComb.ForeColor = System.Drawing.Color.White;
            this.checkBoxComb.Location = new System.Drawing.Point(40, 135);
            this.checkBoxComb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxComb.Name = "checkBoxComb";
            this.checkBoxComb.Size = new System.Drawing.Size(132, 40);
            this.checkBoxComb.TabIndex = 7;
            this.checkBoxComb.Text = "COMB";
            this.checkBoxComb.UseVisualStyleBackColor = false;
            this.checkBoxComb.CheckedChanged += new System.EventHandler(this.calculateService);
            // 
            // checkBoxDye
            // 
            this.checkBoxDye.AutoSize = true;
            this.checkBoxDye.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDye.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxDye.ForeColor = System.Drawing.Color.White;
            this.checkBoxDye.Location = new System.Drawing.Point(186, 135);
            this.checkBoxDye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxDye.Name = "checkBoxDye";
            this.checkBoxDye.Size = new System.Drawing.Size(108, 40);
            this.checkBoxDye.TabIndex = 8;
            this.checkBoxDye.Text = "DYE";
            this.checkBoxDye.UseVisualStyleBackColor = false;
            this.checkBoxDye.CheckedChanged += new System.EventHandler(this.calculateService);
            // 
            // checkBoxPerm
            // 
            this.checkBoxPerm.AutoSize = true;
            this.checkBoxPerm.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxPerm.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.checkBoxPerm.ForeColor = System.Drawing.Color.White;
            this.checkBoxPerm.Location = new System.Drawing.Point(315, 137);
            this.checkBoxPerm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxPerm.Name = "checkBoxPerm";
            this.checkBoxPerm.Size = new System.Drawing.Size(137, 40);
            this.checkBoxPerm.TabIndex = 9;
            this.checkBoxPerm.Text = "PERM";
            this.checkBoxPerm.UseVisualStyleBackColor = false;
            this.checkBoxPerm.CheckedChanged += new System.EventHandler(this.calculateService);
            // 
            // labelTime
            // 
            this.labelTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTime.AutoSize = true;
            this.labelTime.BackColor = System.Drawing.Color.Transparent;
            this.labelTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelTime.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTime.ForeColor = System.Drawing.Color.White;
            this.labelTime.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelTime.Location = new System.Drawing.Point(1205, 116);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(108, 48);
            this.labelTime.TabIndex = 11;
            this.labelTime.Text = "label2";
            // 
            // labelDate
            // 
            this.labelDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDate.AutoSize = true;
            this.labelDate.BackColor = System.Drawing.Color.Transparent;
            this.labelDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDate.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDate.ForeColor = System.Drawing.Color.White;
            this.labelDate.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.labelDate.Location = new System.Drawing.Point(1205, 55);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(108, 48);
            this.labelDate.TabIndex = 10;
            this.labelDate.Text = "label1";
            // 
            // comboBoxIVA
            // 
            this.comboBoxIVA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.comboBoxIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIVA.DropDownWidth = 10;
            this.comboBoxIVA.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBoxIVA.ForeColor = System.Drawing.Color.Black;
            this.comboBoxIVA.FormattingEnabled = true;
            this.comboBoxIVA.Items.AddRange(new object[] {
            "0",
            "4",
            "10",
            "21"});
            this.comboBoxIVA.Location = new System.Drawing.Point(163, 155);
            this.comboBoxIVA.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxIVA.Name = "comboBoxIVA";
            this.comboBoxIVA.Size = new System.Drawing.Size(102, 40);
            this.comboBoxIVA.TabIndex = 12;
            // 
            // labelIVA
            // 
            this.labelIVA.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelIVA.AutoSize = true;
            this.labelIVA.BackColor = System.Drawing.Color.Transparent;
            this.labelIVA.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelIVA.ForeColor = System.Drawing.Color.White;
            this.labelIVA.Location = new System.Drawing.Point(80, 161);
            this.labelIVA.Name = "labelIVA";
            this.labelIVA.Size = new System.Drawing.Size(72, 31);
            this.labelIVA.TabIndex = 17;
            this.labelIVA.Text = "IVA";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(18, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 31);
            this.label5.TabIndex = 19;
            this.label5.Text = "SERVICE";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(51, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 31);
            this.label6.TabIndex = 20;
            this.label6.Text = "PRICE";
            // 
            // textBoxService
            // 
            this.textBoxService.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxService.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxService.ForeColor = System.Drawing.Color.Black;
            this.textBoxService.Location = new System.Drawing.Point(163, 64);
            this.textBoxService.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxService.Name = "textBoxService";
            this.textBoxService.ReadOnly = true;
            this.textBoxService.Size = new System.Drawing.Size(102, 39);
            this.textBoxService.TabIndex = 22;
            this.textBoxService.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxService.TextChanged += new System.EventHandler(this.calculateService);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.textBoxPrice.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxPrice.ForeColor = System.Drawing.Color.Black;
            this.textBoxPrice.Location = new System.Drawing.Point(163, 109);
            this.textBoxPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.ReadOnly = true;
            this.textBoxPrice.Size = new System.Drawing.Size(102, 39);
            this.textBoxPrice.TabIndex = 23;
            this.textBoxPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(7, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 31);
            this.label7.TabIndex = 24;
            this.label7.Text = "CHANGE";
            // 
            // textBoxChange
            // 
            this.textBoxChange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxChange.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxChange.ForeColor = System.Drawing.Color.Black;
            this.textBoxChange.Location = new System.Drawing.Point(163, 382);
            this.textBoxChange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxChange.Name = "textBoxChange";
            this.textBoxChange.ReadOnly = true;
            this.textBoxChange.Size = new System.Drawing.Size(102, 39);
            this.textBoxChange.TabIndex = 25;
            this.textBoxChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // timerHour
            // 
            this.timerHour.Enabled = true;
            this.timerHour.Tick += new System.EventHandler(this.timerHour_Tick);
            // 
            // textBoxCash
            // 
            this.textBoxCash.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCash.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCash.ForeColor = System.Drawing.Color.Black;
            this.textBoxCash.Location = new System.Drawing.Point(163, 272);
            this.textBoxCash.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxCash.Name = "textBoxCash";
            this.textBoxCash.Size = new System.Drawing.Size(102, 39);
            this.textBoxCash.TabIndex = 27;
            this.textBoxCash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(57, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 31);
            this.label8.TabIndex = 26;
            this.label8.Text = "CASH";
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxTotal.ForeColor = System.Drawing.Color.Black;
            this.textBoxTotal.Location = new System.Drawing.Point(163, 225);
            this.textBoxTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(102, 39);
            this.textBoxTotal.TabIndex = 29;
            this.textBoxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(42, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 31);
            this.label9.TabIndex = 28;
            this.label9.Text = "TOTAL";
            // 
            // buttonPrint
            // 
            this.buttonPrint.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrint.Font = new System.Drawing.Font("Lucida Calligraphy", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPrint.ForeColor = System.Drawing.Color.Black;
            this.buttonPrint.Location = new System.Drawing.Point(80, 443);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(158, 43);
            this.buttonPrint.TabIndex = 31;
            this.buttonPrint.Text = "PRINT BILL";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(58, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1066, 66);
            this.label1.TabIndex = 13;
            this.label1.Text = "WELCOME!  What we gonna do today?";
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.Font = new System.Drawing.Font("Lucida Calligraphy", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(738, 676);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 64);
            this.button1.TabIndex = 33;
            this.button1.Text = "I WANT TO CALCULATE \r\nIT BY MY OWN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calculatorClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(647, 253);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 345);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radioButtonWomen);
            this.groupBox1.Controls.Add(this.radioButtonMan);
            this.groupBox1.Controls.Add(this.radioButtonKid);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(58, 228);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(534, 216);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT YOUR GENDER";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.checkBoxWash);
            this.groupBox2.Controls.Add(this.checkBoxCut);
            this.groupBox2.Controls.Add(this.checkBoxComb);
            this.groupBox2.Controls.Add(this.checkBoxDye);
            this.groupBox2.Controls.Add(this.checkBoxPerm);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(58, 519);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(534, 216);
            this.groupBox2.TabIndex = 37;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SELECT YOUR SERVICES";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.buttonCalc);
            this.groupBox3.Controls.Add(this.textBoxService);
            this.groupBox3.Controls.Add(this.comboBoxIVA);
            this.groupBox3.Controls.Add(this.labelIVA);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.textBoxPrice);
            this.groupBox3.Controls.Add(this.buttonPrint);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.textBoxChange);
            this.groupBox3.Controls.Add(this.textBoxTotal);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.textBoxCash);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Calligraphy", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(1021, 233);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox3.Size = new System.Drawing.Size(313, 507);
            this.groupBox3.TabIndex = 38;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "BILL";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonCalc.ForeColor = System.Drawing.Color.Black;
            this.buttonCalc.Location = new System.Drawing.Point(91, 322);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(165, 35);
            this.buttonCalc.TabIndex = 39;
            this.buttonCalc.Text = "CALCULATE";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.buttonCalc_Click);
            // 
            // FormMainl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1445, 824);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelDate);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMainl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainl";
            this.Load += new System.EventHandler(this.FormMainl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private RadioButton radioButtonWomen;
        private RadioButton radioButtonMan;
        private RadioButton radioButtonKid;
        private CheckBox checkBoxWash;
        private CheckBox checkBoxCut;
        private CheckBox checkBoxComb;
        private CheckBox checkBoxDye;
        private CheckBox checkBoxPerm;
        private Label labelTime;
        private Label labelDate;
        private ComboBox comboBoxIVA;
        private Label labelIVA;
        private Label label5;
        private Label label6;
        private TextBox textBoxService;
        private TextBox textBoxPrice;
        private Label label7;
        private TextBox textBoxChange;
        private System.Windows.Forms.Timer timerHour;
        private TextBox textBoxCash;
        private Label label8;
        private TextBox textBoxTotal;
        private Label label9;
        private Button buttonPrint;
        private Label label1;
        private Button button1;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Button buttonCalc;
    }
}