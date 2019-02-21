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
        double hemiRadius = 0.0;
        double hemiVolume = 0.0;
        double a = 0.0, b = 0.0, c = 0.0;
        decimal quadA = 0.0m, quadB = 0.0m, quadC = 0.0m;
        decimal quadX1 = 0.0m, quadX2 = 0.0m;

        public MainForm()
        {
            InitializeComponent();
        }

        // Circle
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
                    textCirCResult.Text = $"{cirCirc:F3}";
                    textCirAResult.Text = $"{cirArea:F3}";
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
                    textCirCResult.Text = $"{cirCirc:F3}";
                    textCirAResult.Text = $"{cirArea:F3}";
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
                    textCirCResult.Text = $"{cirCirc:F3}";
                    textCirAResult.Text = $"{cirArea:F3}";
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
                    textCirCResult.Text = $"{cirCirc:F3}";
                    textCirAResult.Text = $"{cirArea:F3}";
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

        // Hemisphere 
        // Radius Text changed
        private void textHemiRadius_TextChanged(object sender, EventArgs e)
        {
            if (textHemiRadius.Text.Length == 0)
            {
                textHemiVResult.Text = "0";
            }
            if (Double.TryParse(textHemiRadius.Text, out hemiRadius))
            {
                hemiVolume = GetHemiVol(hemiRadius);
                textHemiVResult.Text = $"{hemiVolume:F3}";
            }
            // Print warning massage if failed to work
            else
            {
                textHemiVResult.Text = "0";
                textWarningHemi.Text = "Failed to parse the length.";
            }
        }

        // Triangle
        // Any of the 3 text changed
        private void textTriangleInput_TextChanged(object sender, EventArgs e)
        {
            if (double.TryParse(textTriA.Text, out a) && double.TryParse(textTriB.Text, out b) && double.TryParse(textTriC.Text, out c))
            {
                if (a == 0 || b == 0 || c == 0)
                {
                    textWarningTri.Text = "Length cannot be 0.";
                }
                else if (a >= b + c || b >= a + c || c >= a + b)
                {
                    textWarningTri.Text = "One side cannot be longer than or equal to the other two sides combined.";
                }
                else
                {
                    textTriAResult.Text = $"{GetTriArea(a, b, c):f3}";
                }

            }
            else
            {
                textWarningTri.Text = "Failed to parse the Lengths.";
            }
        }

        // Quadratic equation
        private void textQuadInput_TextChanged(object sender, EventArgs e)
        {
            textWarningQuad.ResetText();

            if (textQuadA.Text.Length == 0 ||
                textQuadB.Text.Length == 0 ||
                textQuadC.Text.Length == 0)
            {
                textWarningQuad.Text = "Please fill out all the numbers.";
            }
            else if (!decimal.TryParse(textQuadA.Text, out quadA) ||
                !decimal.TryParse(textQuadB.Text, out quadB) ||
                !decimal.TryParse(textQuadC.Text, out quadC))
            {
                textWarningQuad.Text = "Failed to parse the numbers.";
            }
            else if (quadA.Equals(0.0))
            {
                textWarningQuad.Text = "a cannot be 0.";
            }
            else if ((quadB * quadB) - (4 * quadA * quadC) < 0)
            {
                textWarningQuad.Text = "b^2 - 4ac cannot be less than 0.";
            }
            else
            {
                Tuple<decimal, decimal> xs= GetQuadX(quadA, quadB, quadC);
                quadX1 = xs.Item1;
                quadX2 = xs.Item2;
                textBoxX1.Text = quadX1.ToString();
                textBoxX2.Text = quadX2.ToString();
            }
        }

        // Quadratic Equation specific keypress, limiting imput to 4 digits.
        public void textQuad_KeyPress(object sender, KeyPressEventArgs e)
        {
            textWarningQuad.ResetText();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                textWarningQuad.Text = "You can only enter numbers here.";
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                textWarningQuad.Text = "You can only enter one decimal point.";
                e.Handled = true;
            }

            if ((e.KeyChar == '-') && (sender as TextBox).Text.Length > 0)
            {
                textWarningQuad.Text = "- can only be put in the front";
                e.Handled = true;
            }

            // above code are copied and modified from stackoverflow post
            // https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.Length > 3)
            {
                if ((sender as TextBox).Text.IndexOf('.') > -1)
                {
                    if ((sender as TextBox).Text.Length > 4)
                    {
                        textWarningQuad.Text = "You can only enter up to 4 digit number.";
                        e.Handled = true;
                    }
                }
                // Only allowing negative to be put in the front.


                else
                {
                    textWarningQuad.Text = "You can only enter up to 4 digit number.";
                    e.Handled = true;
                }
            }
        }

        //Key Press Events
        private void textDiameter_KeyPress(object sender, KeyPressEventArgs e)
        {
            text_KeyPress(sender, e, textWarningCir);
        }
        private void textRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            text_KeyPress(sender, e, textWarningCir);
        }
        private void textHemiRadius_KeyPress(object sender, KeyPressEventArgs e)
        {
            text_KeyPress(sender, e, textWarningHemi);
        }
        private void textTriLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            text_KeyPress(sender, e, textWarningTri);
        }

        public void text_KeyPress(object sender, KeyPressEventArgs e, TextBox textWarning)
        {
            textWarning.ResetText();
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.') && (e.KeyChar != '-'))
            {
                textWarning.Text = "You can only enter numbers here.";
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                textWarning.Text = "You can only enter one decimal point.";
                e.Handled = true;
            }

            // above code are copied and modified from stackoverflow post
            // https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

            // Not allowing negative
            if ((e.KeyChar == '-'))
            {
                textWarning.Text = "Length can only be positive numbers.";
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar) && (sender as TextBox).Text.Length > 5)
            {
                if ((sender as TextBox).Text.IndexOf('.') > -1)
                {
                    if ((sender as TextBox).Text.Length > 6)
                    {
                        textWarning.Text = "You can only enter up to 6 digit number.";
                        e.Handled = true;
                    }
                }
                else
                {
                    textWarning.Text = "You can only enter up to 6 digit number.";
                    e.Handled = true;
                }
            }
        }

    }
}
