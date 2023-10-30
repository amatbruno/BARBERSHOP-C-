using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P13_amatbruno_proyectoBarberTop_p1
{
    public partial class FormMainl : Form
    {

        //Constructor
        public FormMainl()
        {
            InitializeComponent();
            initConfig();
        }


        private void initConfig()
        {
            comboBoxIVA.SelectedIndex = 3;
            radioButtonWomen.Checked = true;
            dataClass.initMatrix();

        }


        private void FormMainl_Load(object sender, EventArgs e)
        {
            dateTime();
        }


        private void dateTime()
        {
            string date = DateTime.Now.ToString("dd/MM/yyyy");
            string hour = DateTime.Now.ToString("HH:mm:ss");

            labelDate.Text = date;
            labelTime.Text = hour;
        }


        private void calculateService(object sender, EventArgs e)
        {
            int row = 0, col = 0, price = 0, service = 0;
            calculateRowCol(ref row, ref col, ref price, ref service);

            Double IVA = Convert.ToDouble(comboBoxIVA.SelectedItem.ToString()) / 100 + 1;
            Double totalPrice = price * IVA;

            /*INSTEAD OF A MESSAGE BOX, WE CAN CALL ToString AND OPTIMIZE THE PRINTING METHOD
            MessageBox.Show(" " + row + " " + col + " " + dataClass.matrixPrice[col, row] + ":" + price);*/
            textBoxPrice.Text = price.ToString();
            textBoxTotal.Text = totalPrice.ToString();
            textBoxService.Text = service.ToString();
        }


        private void calculatePrice(int row, int col, ref int price)
        {
            price += dataClass.matrixPrice[row, col];

        }


        private void calculateRowCol(ref int row, ref int col, ref int price, ref int service)
        {
            row = 0; col = 0; price = 0; service = 0;

            if (radioButtonKid.Checked) col = 2;
            else if (radioButtonWomen.Checked) col = 0;
            else if (radioButtonMan.Checked) col = 1;
            //-------------------------------------------------
            if (checkBoxWash.Checked)
            {
                service++;
                row = 0;
                calculatePrice(row, col, ref price);
            }

            if (checkBoxCut.Checked)
            {
                service++;
                row = 1;
                calculatePrice(row, col, ref price);

            }

            if (checkBoxComb.Checked)
            {
                service++;
                row = 2;
                calculatePrice(row, col, ref price);
            }

            if (checkBoxDye.Checked)
            {
                service++;
                row = 3;
                calculatePrice(row, col, ref price);
            }

            if (checkBoxPerm.Checked)
            {
                service++;
                row = 4;
                calculatePrice(row, col, ref price);
            }


            //IF WE SELECT KID AS A GENDER, THE SERVICE PERMAMENT IS NOT AVAILABLE
            if (radioButtonKid.Checked)
            {
                checkBoxPerm.Visible = false;
                checkBoxPerm.Enabled = false;
                //service--;
            }
            else
            {
                checkBoxPerm.Visible = true;
                checkBoxPerm.Enabled = true;
            }
        }


        private void timerHour_Tick(object sender, EventArgs e)
        {
            dateTime();
        }


        private void calculatorClick(object sender, EventArgs e)
        {
            Process.Start("calc.exe");
        }


        private void buttonPrint_Click(object sender, EventArgs e)
        {
            //CALL THE .EXE OF INVOID
            Process.Start("C:/Users/brunoamagar/source/repos/P3_M7_Factura/bin/Debug/net6.0-windows/P3_M7_Factura.exe");
        }


        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double priceT = Convert.ToDouble(textBoxTotal.Text);
            double priceC = Convert.ToDouble(textBoxCash.Text);

            if (priceC >= priceT)
            {
                double priceF = priceC - priceT;
                textBoxChange.Text = priceF.ToString();
            }

            else if (priceC < priceT)
            {
                MessageBox.Show("Invalid cash");
            }

        }
    }
}
