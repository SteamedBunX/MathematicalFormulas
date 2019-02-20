using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MathFunctions.MathFunctionsClass;

namespace MathematicalFormulas
{
    public partial class MainForm : Form
    {
        double cirDiameter = 0.0;
        double cirRadius = 0.0;
        double cirArea = 0.0;
        double cirCirc = 0.0;

        public MainForm()
        {
            InitializeComponent();
        }

        // Radius check box changed
        private void radioButtonRad_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonRad.Checked)
            {
                // If nothing is in there the result will be 0
                if (textRadius.Text.Length == 0)
                {
                    cirDiameter = 0;
                    cirRadius = 0;
                    textCirCResult.Text = "0";
                    textCirAResult.Text = "0";
                }
                // Make sure the text is parsable
                else if (Double.TryParse(textRadius.Text, out cirRadius))
                {
                    cirCirc = GetCirCirc(cirRadius);
                    cirArea = GetCirArea(cirRadius);
                    textCirCResult.Text = cirCirc.ToString();
                    textCirAResult.Text = cirArea.ToString();
                }
                // Print warning massage if failed to work
                else
                {
                    textCirCResult.Text = "0";
                    textCirAResult.Text = "0";
                    textWarningCir.Text = "Failed to parse the diameter.";
                }
            }
        }

        // Radius Text changed
        private void textRadius_TextChanged(object sender, EventArgs e)
        {
            if (radioButtonRad.Checked)
            {
                // If nothing is in there the result will be 0
                if (textRadius.Text.Length == 0)
                {
                    cirDiameter = 0;
                    cirRadius = 0;
                    textCirCResult.Text = "0";
                    textCirAResult.Text = "0";
                }
                // Make sure the text is parsable
                else if (Double.TryParse(textRadius.Text, out cirRadius))
                {
                    cirCirc = GetCirCirc(cirRadius);
                    cirArea = GetCirArea(cirRadius);
                    textCirCResult.Text = cirCirc.ToString();
                    textCirAResult.Text = cirArea.ToString();
                }
                // Print warning massage if failed to work
                else
                {
                    textCirCResult.Text = "0";
                    textCirAResult.Text = "0";
                    textWarningCir.Text = "Failed to parse the diameter.";
                }
            }
        }

        // Diameter check box changed
        private void radioButtonDia_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonDia.Checked)
            {
                // If nothing is in there the result will be 0
                if (textDiameter.Text.Length == 0)
                {
                    cirDiameter = 0;
                    cirRadius = 0;
                    textCirCResult.Text = "0";
                    textCirAResult.Text = "0";
                }
                // Make sure the text is parsable
                else if (Double.TryParse(textDiameter.Text, out cirDiameter))
                {
                    cirRadius = cirDiameter / 2;
                    cirCirc = GetCirCirc(cirRadius);
                    cirArea = GetCirArea(cirRadius);
                    textCirCResult.Text = cirCirc.ToString();
                    textCirAResult.Text = cirArea.ToString();
                }
                // Print warning massage if failed to work
                else
                {
                    textCirCResult.Text = "0";
                    textCirAResult.Text = "0";
                    textWarningCir.Text = "Failed to parse the diameter.";
                }
            }
        }

        // Diameter Text changed
        private void textDiameter_TextChanged(object sender, EventArgs e)
        {

            if (radioButtonDia.Checked)
            {
                // If nothing is in there the result will be 0
                if (textDiameter.Text.Length == 0)
                {
                    cirDiameter = 0;
                    cirRadius = 0;
                    textCirCResult.Text = "0";
                    textCirAResult.Text = "0";
                }
                // Make sure the text is parsable
                else if (Double.TryParse(textDiameter.Text, out cirDiameter))
                {
                    cirRadius = cirDiameter / 2;
                    cirCirc = GetCirCirc(cirRadius);
                    cirArea = GetCirArea(cirRadius);
                    textCirCResult.Text = cirCirc.ToString();
                    textCirAResult.Text = cirArea.ToString();
                }
                // Print warning massage if failed to work
                else
                {
                    textCirCResult.Text = "0";
                    textCirAResult.Text = "0";
                    textWarningCir.Text = "Failed to parse the diameter.";
                }
            }
        }

        private void textDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            textWarningCir.ResetText();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                textWarningCir.Text = "You can only enter numbers here.";
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                textWarningCir.Text = "You can only enter one decimal point.";
                e.Handled = true;
            }

            // above code are copied and modified from stackoverflow post
            // https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

            // only allow - at the beginning
            if ((e.KeyChar == '-'))
            {
                textWarningCir.Text = "Length can only be positive numbers.";
                e.Handled = true;
            }
        }

        private void textRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            textWarningCir.ResetText();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                textWarningCir.Text = "You can only enter numbers here.";
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                textWarningCir.Text = "You can only enter one decimal point.";
                e.Handled = true;
            }

            // above code are copied and modified from stackoverflow post
            // https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

            // only allow - at the beginning
            if ((e.KeyChar == '-'))
            {
                textWarningCir.Text = "Length can only be positive numbers.";
                e.Handled = true;
            }
        }
    }
}
