namespace P13_amatbruno_proyectoBarberTop_p1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxpassword = new System.Windows.Forms.TextBox();
            this.buttonsubmit = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureboxeye = new System.Windows.Forms.PictureBox();
            this.pictureboxclosedeye = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxError = new System.Windows.Forms.Label();
            this.libLaunchLink = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxeye)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxclosedeye)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(605, 67);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 123);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(111, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "USERNAME";
            // 
            // textboxusername
            // 
            this.textboxusername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxusername.Location = new System.Drawing.Point(322, 211);
            this.textboxusername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxusername.Name = "textboxusername";
            this.textboxusername.Size = new System.Drawing.Size(277, 34);
            this.textboxusername.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Lucida Calligraphy", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(121, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 38);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD";
            // 
            // textboxpassword
            // 
            this.textboxpassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textboxpassword.Location = new System.Drawing.Point(322, 264);
            this.textboxpassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textboxpassword.Name = "textboxpassword";
            this.textboxpassword.PasswordChar = '*';
            this.textboxpassword.Size = new System.Drawing.Size(247, 34);
            this.textboxpassword.TabIndex = 4;
            // 
            // buttonsubmit
            // 
            this.buttonsubmit.Font = new System.Drawing.Font("Lucida Calligraphy", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonsubmit.Location = new System.Drawing.Point(354, 320);
            this.buttonsubmit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonsubmit.Name = "buttonsubmit";
            this.buttonsubmit.Size = new System.Drawing.Size(157, 47);
            this.buttonsubmit.TabIndex = 5;
            this.buttonsubmit.Text = "SUBMIT";
            this.buttonsubmit.UseVisualStyleBackColor = true;
            this.buttonsubmit.Click += new System.EventHandler(this.buttonsubmit_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.Location = new System.Drawing.Point(14, 412);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(784, 21);
            this.progressBar1.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureboxeye
            // 
            this.pictureboxeye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureboxeye.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxeye.Image")));
            this.pictureboxeye.Location = new System.Drawing.Point(568, 264);
            this.pictureboxeye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureboxeye.Name = "pictureboxeye";
            this.pictureboxeye.Size = new System.Drawing.Size(31, 33);
            this.pictureboxeye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxeye.TabIndex = 7;
            this.pictureboxeye.TabStop = false;
            this.pictureboxeye.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureboxclosedeye
            // 
            this.pictureboxclosedeye.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureboxclosedeye.Image = ((System.Drawing.Image)(resources.GetObject("pictureboxclosedeye.Image")));
            this.pictureboxclosedeye.Location = new System.Drawing.Point(567, 264);
            this.pictureboxclosedeye.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureboxclosedeye.Name = "pictureboxclosedeye";
            this.pictureboxclosedeye.Size = new System.Drawing.Size(33, 33);
            this.pictureboxclosedeye.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureboxclosedeye.TabIndex = 8;
            this.pictureboxclosedeye.TabStop = false;
            this.pictureboxclosedeye.Click += new System.EventHandler(this.pictureboxclosedeye_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(65, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(342, 89);
            this.label3.TabIndex = 9;
            this.label3.Text = "BARBER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Font = new System.Drawing.Font("Lucida Handwriting", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(402, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 89);
            this.label4.TabIndex = 10;
            this.label4.Text = "TOP";
            // 
            // textBoxError
            // 
            this.textBoxError.AutoSize = true;
            this.textBoxError.Enabled = false;
            this.textBoxError.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBoxError.ForeColor = System.Drawing.Color.Red;
            this.textBoxError.Location = new System.Drawing.Point(307, 385);
            this.textBoxError.Name = "textBoxError";
            this.textBoxError.Size = new System.Drawing.Size(290, 23);
            this.textBoxError.TabIndex = 11;
            this.textBoxError.Text = "LOGIN OR PASSWORD INCORRECT";
            this.textBoxError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.textBoxError.Visible = false;
            // 
            // libLaunchLink
            // 
            this.libLaunchLink.AutoSize = true;
            this.libLaunchLink.BackColor = System.Drawing.SystemColors.ControlText;
            this.libLaunchLink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.libLaunchLink.ForeColor = System.Drawing.Color.White;
            this.libLaunchLink.LinkColor = System.Drawing.Color.White;
            this.libLaunchLink.Location = new System.Drawing.Point(640, 12);
            this.libLaunchLink.Name = "libLaunchLink";
            this.libLaunchLink.Size = new System.Drawing.Size(169, 28);
            this.libLaunchLink.TabIndex = 14;
            this.libLaunchLink.TabStop = true;
            this.libLaunchLink.Text = "Visit my webpage";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(810, 447);
            this.Controls.Add(this.libLaunchLink);
            this.Controls.Add(this.textBoxError);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureboxeye);
            this.Controls.Add(this.pictureboxclosedeye);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.buttonsubmit);
            this.Controls.Add(this.textboxpassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxusername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxeye)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureboxclosedeye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textboxusername;
        private Label label2;
        private TextBox textboxpassword;
        private Button buttonsubmit;
        private ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureboxeye;
        private PictureBox pictureboxclosedeye;
        private Label label3;
        private Label label4;
        private Label textBoxError;
        private LinkLabel libLaunchLink;
    }
}