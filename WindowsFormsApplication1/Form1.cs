using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public object caller;

        public Form1()
        {
            InitializeComponent();
            
        }


        private bool alreadyExist(string _text, ref char KeyChar)
        {
            if (_text.IndexOf('.') > -1)
            {
                KeyChar = '.';
                return true;
            }
            if (_text.IndexOf(',') > -1)
            {
                KeyChar = ',';
                return true;
            }
            return false;
        }

        private void setTextBoxActive(object sender, EventArgs e)
        {
            caller = sender;
        }

      

        private void fillTextBox(object sender, EventArgs e)
        {
            TextBox currentTB = (TextBox)caller;
            Button myBytton = (Button)sender;

            if (currentTB == null) return;

            char sepratorChar = 's';
            if (myBytton.Text == ".")
            {   
                if (currentTB.Text.Length == 0) return;
                if (alreadyExist(currentTB.Text, ref sepratorChar)) return;
                
            }

            currentTB.Text = currentTB.Text + myBytton.Text;
            
        }

      

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void KeyPressEvent(object sender, KeyPressEventArgs e)
        {
            TextBox currentTB = (TextBox)sender;

            if (!char.IsControl(e.KeyChar)
                    && !char.IsDigit(e.KeyChar)
                    && e.KeyChar != '.' )
            {
                e.Handled = true;
            }

            //check if '.' , ',' pressed
            char sepratorChar = 's';
            if (e.KeyChar == '.' )
            {
                // check if it's in the beginning of text not accept
                if (currentTB.Text.Length == 0) e.Handled = true;
                // check if it's in the beginning of text not accept
                if (currentTB.SelectionStart == 0) e.Handled = true;
                // check if there is already exist a '.' , ','
                if (alreadyExist(currentTB.Text, ref sepratorChar)) e.Handled = true;
                //check if '.' or ',' is in middle of a number and after it is not a number greater than 99
                if (currentTB.SelectionStart != currentTB.Text.Length && e.Handled == false)
                {
                    // '.' or ',' is in the middle
                    string AfterDotString = currentTB.Text.Substring(currentTB.SelectionStart);

                    if (AfterDotString.Length > 5)
                    {
                        e.Handled = true;
                    }
                }
            }
            
       

            }

        private void clearButtonClick(object sender, EventArgs e)
        {
            TextBox currentTB = (TextBox)caller;
            if (currentTB == null) return;
            currentTB.Text = "";
        }

        private void calculateButtonClick(object sender, EventArgs e)
        {
            double a, b, c, p, s = 0.0F;

            a = double.Parse(textBoxA.Text, CultureInfo.InvariantCulture.NumberFormat);
            b = double.Parse(textBoxB.Text, CultureInfo.InvariantCulture.NumberFormat);
            c = double.Parse(textBoxC.Text, CultureInfo.InvariantCulture.NumberFormat);

            if (!(a + b > c) || !(a + c > b) || !(b + c > a))
            {
                MessageBox.Show("Such triangle doesn't exist");
                textBoxA.Text = "";
                textBoxB.Text = "";
                textBoxC.Text = "";
                return;
            }
                
            p = a + b + c;
            s = Math.Sqrt((p / 2) * (p / 2 - a) * (p / 2 - b) * (p / 2 - c));

            areaLabel.Visible = true;
            perimeterLabel.Visible = true;
            areaValue.Text = s.ToString();
            perimeterValue.Text = p.ToString();

        }

        private void textChangedEvent(object sender, EventArgs e)
        {
            TextBox currentTB = (TextBox)sender;
            if(!System.Text.RegularExpressions.Regex.IsMatch(currentTB.Text, @"^(?:\d{0,9})?(?:\.\d{0,9})?$"))
            {
                MessageBox.Show("Only numbers are allowed");
                currentTB.Text = "";
            }
            if(textBoxA.Text.Length>=1 && textBoxB.Text.Length>=1 && textBoxC.Text.Length>=1)
            {
                calculateButton.Enabled = true;
            }
            else
            {
                calculateButton.Enabled = false;
            }
        }


        private void resetButtonClick(object sender, EventArgs e)
        {
            areaLabel.Visible = false;
            perimeterLabel.Visible = false;
            areaValue.Text = "";
            perimeterValue.Text = "";
            calculateButton.Enabled = false;
            textBoxA.Text = "";
            textBoxB.Text = "";
            textBoxC.Text = "";
        }

        
    }
    }

