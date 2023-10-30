using P13_amatbruno_proyectoBarberTopACTUAL;
using System.Diagnostics;
using System.DirectoryServices;
using System.Text.Json;

namespace P13_amatbruno_proyectoBarberTop_p1
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        //Declaraciones globales
        int count = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonsubmit_Click(object sender, EventArgs e)
        {
            //VARIABLES DECLARATION
            string goodusername;
            goodusername = textboxusername.Text;

            string goodpassword;
            goodpassword = textboxpassword.Text;

            string passwdMD5 = classSecurity.md5Digest(goodpassword);
            //MessageBox.Show(passwdMD5);


            //CHECK IF LOGIN AND PASSWD ARE CORRECT
            if (goodusername == "Monlau" && goodpassword == "2022")
            {
                timer1.Enabled = true;
                textBoxError.Enabled = false;
                textBoxError.Visible = false;
            }
            else { 
                textBoxError.Enabled = true;
                textBoxError.Visible = true;
            }

            String passwdJson;
            passwdJson = classSecurity.convertToJSON(goodusername, passwdMD5);
            //MessageBox.Show(passwdJson);
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            count++;

            if (count <= 100)
            {
                progressBar1.Value = count;
            }
            else {
                timer1.Enabled = false;

                //GO TO NEXT FORM
                FormMainl FormMainl = new FormMainl();
                this.Hide();

                FormMainl.ShowDialog();
                this.Close();
        }
    }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Movemos la imagen de ocultar contraseña al frente
            pictureboxclosedeye.BringToFront();

            //Mostramos la contraseña
            textboxpassword.PasswordChar = '\0';
        }


        private void pictureboxclosedeye_Click(object sender, EventArgs e)
        {
            //Movemos la imagen de mostrar contraseña al frente
            pictureboxeye.BringToFront();

            //Ocualtamos la contraseña
            textboxpassword.PasswordChar = '*';
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //NO FUNCIONA
        private void libLaunchLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("explorer", "https://www.google.com");
        }
    }
}