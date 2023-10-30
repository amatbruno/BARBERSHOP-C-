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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainl));
            radioButtonWomen = new RadioButton();
            radioButtonMan = new RadioButton();
            radioButtonKid = new RadioButton();
            checkBoxWash = new CheckBox();
            checkBoxCut = new CheckBox();
            checkBoxComb = new CheckBox();
            checkBoxDye = new CheckBox();
            checkBoxPerm = new CheckBox();
            labelTime = new Label();
            labelDate = new Label();
            comboBoxIVA = new ComboBox();
            labelIVA = new Label();
            label5 = new Label();
            label6 = new Label();
            textBoxService = new TextBox();
            textBoxPrice = new TextBox();
            label7 = new Label();
            textBoxChange = new TextBox();
            timerHour = new System.Windows.Forms.Timer(components);
            textBoxCash = new TextBox();
            label8 = new Label();
            textBoxTotal = new TextBox();
            label9 = new Label();
            buttonPrint = new Button();
            label1 = new Label();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            buttonCalc = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // radioButtonWomen
            // 
            radioButtonWomen.AutoSize = true;
            radioButtonWomen.BackColor = Color.Transparent;
            radioButtonWomen.Checked = true;
            radioButtonWomen.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonWomen.ForeColor = Color.White;
            radioButtonWomen.Location = new Point(34, 43);
            radioButtonWomen.Name = "radioButtonWomen";
            radioButtonWomen.Size = new Size(136, 31);
            radioButtonWomen.TabIndex = 2;
            radioButtonWomen.TabStop = true;
            radioButtonWomen.Text = "WOMEN";
            radioButtonWomen.UseVisualStyleBackColor = false;
            radioButtonWomen.CheckedChanged += calculateService;
            // 
            // radioButtonMan
            // 
            radioButtonMan.AutoSize = true;
            radioButtonMan.BackColor = Color.Transparent;
            radioButtonMan.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonMan.ForeColor = Color.White;
            radioButtonMan.Location = new Point(34, 76);
            radioButtonMan.Name = "radioButtonMan";
            radioButtonMan.Size = new Size(94, 31);
            radioButtonMan.TabIndex = 3;
            radioButtonMan.Text = "MEN";
            radioButtonMan.UseVisualStyleBackColor = false;
            radioButtonMan.CheckedChanged += calculateService;
            // 
            // radioButtonKid
            // 
            radioButtonKid.AutoSize = true;
            radioButtonKid.BackColor = Color.Transparent;
            radioButtonKid.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            radioButtonKid.ForeColor = Color.White;
            radioButtonKid.Location = new Point(34, 113);
            radioButtonKid.Name = "radioButtonKid";
            radioButtonKid.Size = new Size(114, 31);
            radioButtonKid.TabIndex = 4;
            radioButtonKid.Text = "CHILD";
            radioButtonKid.UseVisualStyleBackColor = false;
            radioButtonKid.CheckedChanged += calculateService;
            // 
            // checkBoxWash
            // 
            checkBoxWash.AutoSize = true;
            checkBoxWash.BackColor = Color.Transparent;
            checkBoxWash.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxWash.ForeColor = Color.White;
            checkBoxWash.Location = new Point(35, 58);
            checkBoxWash.Name = "checkBoxWash";
            checkBoxWash.Size = new Size(113, 31);
            checkBoxWash.TabIndex = 5;
            checkBoxWash.Text = "WASH";
            checkBoxWash.UseVisualStyleBackColor = false;
            checkBoxWash.CheckedChanged += calculateService;
            // 
            // checkBoxCut
            // 
            checkBoxCut.AutoSize = true;
            checkBoxCut.BackColor = Color.Transparent;
            checkBoxCut.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxCut.ForeColor = Color.White;
            checkBoxCut.Location = new Point(163, 58);
            checkBoxCut.Name = "checkBoxCut";
            checkBoxCut.Size = new Size(189, 31);
            checkBoxCut.TabIndex = 6;
            checkBoxCut.Text = "CUT + COMB";
            checkBoxCut.UseVisualStyleBackColor = false;
            checkBoxCut.CheckedChanged += calculateService;
            // 
            // checkBoxComb
            // 
            checkBoxComb.AccessibleRole = AccessibleRole.ButtonDropDownGrid;
            checkBoxComb.AutoSize = true;
            checkBoxComb.BackColor = Color.Transparent;
            checkBoxComb.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxComb.ForeColor = Color.White;
            checkBoxComb.Location = new Point(35, 101);
            checkBoxComb.Name = "checkBoxComb";
            checkBoxComb.Size = new Size(106, 31);
            checkBoxComb.TabIndex = 7;
            checkBoxComb.Text = "COMB";
            checkBoxComb.UseVisualStyleBackColor = false;
            checkBoxComb.CheckedChanged += calculateService;
            // 
            // checkBoxDye
            // 
            checkBoxDye.AutoSize = true;
            checkBoxDye.BackColor = Color.Transparent;
            checkBoxDye.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxDye.ForeColor = Color.White;
            checkBoxDye.Location = new Point(163, 101);
            checkBoxDye.Name = "checkBoxDye";
            checkBoxDye.Size = new Size(86, 31);
            checkBoxDye.TabIndex = 8;
            checkBoxDye.Text = "DYE";
            checkBoxDye.UseVisualStyleBackColor = false;
            checkBoxDye.CheckedChanged += calculateService;
            // 
            // checkBoxPerm
            // 
            checkBoxPerm.AutoSize = true;
            checkBoxPerm.BackColor = Color.Transparent;
            checkBoxPerm.Font = new Font("Lucida Calligraphy", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            checkBoxPerm.ForeColor = Color.White;
            checkBoxPerm.Location = new Point(276, 103);
            checkBoxPerm.Name = "checkBoxPerm";
            checkBoxPerm.Size = new Size(108, 31);
            checkBoxPerm.TabIndex = 9;
            checkBoxPerm.Text = "PERM";
            checkBoxPerm.UseVisualStyleBackColor = false;
            checkBoxPerm.CheckedChanged += calculateService;
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.BackColor = Color.Transparent;
            labelTime.BorderStyle = BorderStyle.Fixed3D;
            labelTime.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelTime.ForeColor = Color.White;
            labelTime.ImageAlign = ContentAlignment.TopRight;
            labelTime.Location = new Point(1054, 87);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(86, 38);
            labelTime.TabIndex = 11;
            labelTime.Text = "label2";
            // 
            // labelDate
            // 
            labelDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelDate.AutoSize = true;
            labelDate.BackColor = Color.Transparent;
            labelDate.BorderStyle = BorderStyle.Fixed3D;
            labelDate.Font = new Font("Palatino Linotype", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            labelDate.ForeColor = Color.White;
            labelDate.ImageAlign = ContentAlignment.TopRight;
            labelDate.Location = new Point(1054, 41);
            labelDate.Name = "labelDate";
            labelDate.Size = new Size(86, 38);
            labelDate.TabIndex = 10;
            labelDate.Text = "label1";
            // 
            // comboBoxIVA
            // 
            comboBoxIVA.Anchor = AnchorStyles.Right;
            comboBoxIVA.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxIVA.DropDownWidth = 10;
            comboBoxIVA.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxIVA.ForeColor = Color.Black;
            comboBoxIVA.FormattingEnabled = true;
            comboBoxIVA.Items.AddRange(new object[] { "0", "4", "10", "21" });
            comboBoxIVA.Location = new Point(143, 116);
            comboBoxIVA.Name = "comboBoxIVA";
            comboBoxIVA.Size = new Size(90, 33);
            comboBoxIVA.TabIndex = 12;
            // 
            // labelIVA
            // 
            labelIVA.Anchor = AnchorStyles.Right;
            labelIVA.AutoSize = true;
            labelIVA.BackColor = Color.Transparent;
            labelIVA.Font = new Font("Lucida Calligraphy", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelIVA.ForeColor = Color.White;
            labelIVA.Location = new Point(70, 121);
            labelIVA.Name = "labelIVA";
            labelIVA.Size = new Size(58, 24);
            labelIVA.TabIndex = 17;
            labelIVA.Text = "IVA";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Lucida Calligraphy", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(16, 53);
            label5.Name = "label5";
            label5.Size = new Size(112, 24);
            label5.TabIndex = 19;
            label5.Text = "SERVICE";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Right;
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Lucida Calligraphy", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(45, 85);
            label6.Name = "label6";
            label6.Size = new Size(83, 24);
            label6.TabIndex = 20;
            label6.Text = "PRICE";
            // 
            // textBoxService
            // 
            textBoxService.Anchor = AnchorStyles.Right;
            textBoxService.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxService.ForeColor = Color.Black;
            textBoxService.Location = new Point(143, 48);
            textBoxService.Name = "textBoxService";
            textBoxService.ReadOnly = true;
            textBoxService.Size = new Size(90, 33);
            textBoxService.TabIndex = 22;
            textBoxService.TextAlign = HorizontalAlignment.Center;
            textBoxService.TextChanged += calculateService;
            // 
            // textBoxPrice
            // 
            textBoxPrice.Anchor = AnchorStyles.Right;
            textBoxPrice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPrice.ForeColor = Color.Black;
            textBoxPrice.Location = new Point(143, 82);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.ReadOnly = true;
            textBoxPrice.Size = new Size(90, 33);
            textBoxPrice.TabIndex = 23;
            textBoxPrice.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Lucida Calligraphy", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(6, 289);
            label7.Name = "label7";
            label7.Size = new Size(116, 24);
            label7.TabIndex = 24;
            label7.Text = "CHANGE";
            // 
            // textBoxChange
            // 
            textBoxChange.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxChange.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxChange.ForeColor = Color.Black;
            textBoxChange.Location = new Point(143, 286);
            textBoxChange.Name = "textBoxChange";
            textBoxChange.ReadOnly = true;
            textBoxChange.Size = new Size(90, 33);
            textBoxChange.TabIndex = 25;
            textBoxChange.TextAlign = HorizontalAlignment.Center;
            // 
            // timerHour
            // 
            timerHour.Enabled = true;
            timerHour.Tick += timerHour_Tick;
            // 
            // textBoxCash
            // 
            textBoxCash.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxCash.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxCash.ForeColor = Color.Black;
            textBoxCash.Location = new Point(143, 204);
            textBoxCash.Name = "textBoxCash";
            textBoxCash.Size = new Size(90, 33);
            textBoxCash.TabIndex = 27;
            textBoxCash.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Lucida Calligraphy", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.White;
            label8.Location = new Point(50, 208);
            label8.Name = "label8";
            label8.Size = new Size(77, 24);
            label8.TabIndex = 26;
            label8.Text = "CASH";
            // 
            // textBoxTotal
            // 
            textBoxTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            textBoxTotal.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxTotal.ForeColor = Color.Black;
            textBoxTotal.Location = new Point(143, 169);
            textBoxTotal.Name = "textBoxTotal";
            textBoxTotal.ReadOnly = true;
            textBoxTotal.Size = new Size(90, 33);
            textBoxTotal.TabIndex = 29;
            textBoxTotal.TextAlign = HorizontalAlignment.Center;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Lucida Calligraphy", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.White;
            label9.Location = new Point(37, 177);
            label9.Name = "label9";
            label9.Size = new Size(90, 24);
            label9.TabIndex = 28;
            label9.Text = "TOTAL";
            // 
            // buttonPrint
            // 
            buttonPrint.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonPrint.Font = new Font("Lucida Calligraphy", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPrint.ForeColor = Color.Black;
            buttonPrint.Location = new Point(70, 332);
            buttonPrint.Name = "buttonPrint";
            buttonPrint.Size = new Size(138, 32);
            buttonPrint.TabIndex = 31;
            buttonPrint.Text = "PRINT BILL";
            buttonPrint.UseVisualStyleBackColor = true;
            buttonPrint.Click += buttonPrint_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.BorderStyle = BorderStyle.Fixed3D;
            label1.Font = new Font("Lucida Calligraphy", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(51, 41);
            label1.Name = "label1";
            label1.Size = new Size(849, 54);
            label1.TabIndex = 13;
            label1.Text = "WELCOME!  What we gonna do today?";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom;
            button1.Font = new Font("Lucida Calligraphy", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(646, 507);
            button1.Name = "button1";
            button1.Size = new Size(131, 48);
            button1.TabIndex = 33;
            button1.Text = "I WANT TO CALCULATE \r\nIT BY MY OWN";
            button1.UseVisualStyleBackColor = true;
            button1.Click += calculatorClick;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(566, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(310, 259);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 35;
            pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Left;
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(radioButtonWomen);
            groupBox1.Controls.Add(radioButtonMan);
            groupBox1.Controls.Add(radioButtonKid);
            groupBox1.Font = new Font("Lucida Calligraphy", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(51, 171);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(467, 162);
            groupBox1.TabIndex = 36;
            groupBox1.TabStop = false;
            groupBox1.Text = "SELECT YOUR GENDER";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(checkBoxWash);
            groupBox2.Controls.Add(checkBoxCut);
            groupBox2.Controls.Add(checkBoxComb);
            groupBox2.Controls.Add(checkBoxDye);
            groupBox2.Controls.Add(checkBoxPerm);
            groupBox2.Font = new Font("Lucida Calligraphy", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(51, 389);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(467, 162);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "SELECT YOUR SERVICES";
            // 
            // groupBox3
            // 
            groupBox3.Anchor = AnchorStyles.Right;
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(buttonCalc);
            groupBox3.Controls.Add(textBoxService);
            groupBox3.Controls.Add(comboBoxIVA);
            groupBox3.Controls.Add(labelIVA);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(textBoxPrice);
            groupBox3.Controls.Add(buttonPrint);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(textBoxChange);
            groupBox3.Controls.Add(textBoxTotal);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label9);
            groupBox3.Controls.Add(textBoxCash);
            groupBox3.Font = new Font("Lucida Calligraphy", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox3.ForeColor = Color.White;
            groupBox3.Location = new Point(893, 175);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(274, 380);
            groupBox3.TabIndex = 38;
            groupBox3.TabStop = false;
            groupBox3.Text = "BILL";
            // 
            // buttonCalc
            // 
            buttonCalc.Font = new Font("Lucida Calligraphy", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonCalc.ForeColor = Color.Black;
            buttonCalc.Location = new Point(80, 242);
            buttonCalc.Margin = new Padding(3, 2, 3, 2);
            buttonCalc.Name = "buttonCalc";
            buttonCalc.Size = new Size(144, 26);
            buttonCalc.TabIndex = 39;
            buttonCalc.Text = "CALCULATE";
            buttonCalc.UseVisualStyleBackColor = true;
            buttonCalc.Click += buttonCalc_Click;
            // 
            // FormMainl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.Black;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1264, 618);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(labelTime);
            Controls.Add(labelDate);
            Name = "FormMainl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormMainl";
            Load += FormMainl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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