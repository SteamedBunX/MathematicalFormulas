namespace MathematicalFormulas
{
    partial class MainForm
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
            this.tab_Formulas = new System.Windows.Forms.TabControl();
            this.tabPageCircle = new System.Windows.Forms.TabPage();
            this.textCirAResult = new System.Windows.Forms.TextBox();
            this.textCirCResult = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textTitleCir = new System.Windows.Forms.TextBox();
            this.textWarningCir = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButtonRad = new System.Windows.Forms.RadioButton();
            this.radioButtonDia = new System.Windows.Forms.RadioButton();
            this.textDiameter = new System.Windows.Forms.TextBox();
            this.textRadius = new System.Windows.Forms.TextBox();
            this.tabPageHemis = new System.Windows.Forms.TabPage();
            this.tabPageTri = new System.Windows.Forms.TabPage();
            this.tabPageQuad = new System.Windows.Forms.TabPage();
            this.tab_Formulas.SuspendLayout();
            this.tabPageCircle.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_Formulas
            // 
            this.tab_Formulas.Controls.Add(this.tabPageCircle);
            this.tab_Formulas.Controls.Add(this.tabPageHemis);
            this.tab_Formulas.Controls.Add(this.tabPageTri);
            this.tab_Formulas.Controls.Add(this.tabPageQuad);
            this.tab_Formulas.Location = new System.Drawing.Point(0, 0);
            this.tab_Formulas.Name = "tab_Formulas";
            this.tab_Formulas.SelectedIndex = 0;
            this.tab_Formulas.Size = new System.Drawing.Size(602, 453);
            this.tab_Formulas.TabIndex = 0;
            // 
            // tabPageCircle
            // 
            this.tabPageCircle.Controls.Add(this.textCirAResult);
            this.tabPageCircle.Controls.Add(this.textCirCResult);
            this.tabPageCircle.Controls.Add(this.textBox1);
            this.tabPageCircle.Controls.Add(this.textTitleCir);
            this.tabPageCircle.Controls.Add(this.textWarningCir);
            this.tabPageCircle.Controls.Add(this.panel1);
            this.tabPageCircle.Location = new System.Drawing.Point(4, 25);
            this.tabPageCircle.Name = "tabPageCircle";
            this.tabPageCircle.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCircle.Size = new System.Drawing.Size(594, 424);
            this.tabPageCircle.TabIndex = 0;
            this.tabPageCircle.Text = "Area and circumference of circle";
            // 
            // textCirAResult
            // 
            this.textCirAResult.BackColor = System.Drawing.SystemColors.Control;
            this.textCirAResult.Location = new System.Drawing.Point(404, 144);
            this.textCirAResult.Name = "textCirAResult";
            this.textCirAResult.ReadOnly = true;
            this.textCirAResult.Size = new System.Drawing.Size(170, 22);
            this.textCirAResult.TabIndex = 7;
            // 
            // textCirCResult
            // 
            this.textCirCResult.BackColor = System.Drawing.SystemColors.Control;
            this.textCirCResult.Location = new System.Drawing.Point(404, 44);
            this.textCirCResult.Name = "textCirCResult";
            this.textCirCResult.ReadOnly = true;
            this.textCirCResult.Size = new System.Drawing.Size(170, 22);
            this.textCirCResult.TabIndex = 6;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Control;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(404, 123);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(96, 15);
            this.textBox1.TabIndex = 5;
            this.textBox1.Text = "Area:";
            // 
            // textTitleCir
            // 
            this.textTitleCir.BackColor = System.Drawing.SystemColors.Control;
            this.textTitleCir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitleCir.Location = new System.Drawing.Point(405, 23);
            this.textTitleCir.Name = "textTitleCir";
            this.textTitleCir.Size = new System.Drawing.Size(96, 15);
            this.textTitleCir.TabIndex = 4;
            this.textTitleCir.Text = "Circumferece:";
            // 
            // textWarningCir
            // 
            this.textWarningCir.BackColor = System.Drawing.SystemColors.Control;
            this.textWarningCir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textWarningCir.ForeColor = System.Drawing.Color.Red;
            this.textWarningCir.Location = new System.Drawing.Point(403, 197);
            this.textWarningCir.Multiline = true;
            this.textWarningCir.Name = "textWarningCir";
            this.textWarningCir.ReadOnly = true;
            this.textWarningCir.ShortcutsEnabled = false;
            this.textWarningCir.Size = new System.Drawing.Size(188, 102);
            this.textWarningCir.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::MathematicalFormulas.Properties.Resources.Circle;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.radioButtonRad);
            this.panel1.Controls.Add(this.radioButtonDia);
            this.panel1.Controls.Add(this.textDiameter);
            this.panel1.Controls.Add(this.textRadius);
            this.panel1.Location = new System.Drawing.Point(8, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(390, 390);
            this.panel1.TabIndex = 1;
            // 
            // radioButtonRad
            // 
            this.radioButtonRad.AutoSize = true;
            this.radioButtonRad.Checked = true;
            this.radioButtonRad.Location = new System.Drawing.Point(269, 203);
            this.radioButtonRad.Name = "radioButtonRad";
            this.radioButtonRad.Size = new System.Drawing.Size(17, 16);
            this.radioButtonRad.TabIndex = 9;
            this.radioButtonRad.TabStop = true;
            this.radioButtonRad.UseVisualStyleBackColor = true;
            this.radioButtonRad.CheckedChanged += new System.EventHandler(this.radioButtonRad_CheckedChanged);
            // 
            // radioButtonDia
            // 
            this.radioButtonDia.AutoSize = true;
            this.radioButtonDia.Location = new System.Drawing.Point(97, 214);
            this.radioButtonDia.Name = "radioButtonDia";
            this.radioButtonDia.Size = new System.Drawing.Size(17, 16);
            this.radioButtonDia.TabIndex = 8;
            this.radioButtonDia.TabStop = true;
            this.radioButtonDia.UseVisualStyleBackColor = true;
            this.radioButtonDia.CheckedChanged += new System.EventHandler(this.radioButtonDia_CheckedChanged);            // 
            // textDiameter
            // 
            this.textDiameter.Location = new System.Drawing.Point(28, 160);
            this.textDiameter.Name = "textDiameter";
            this.textDiameter.Size = new System.Drawing.Size(146, 22);
            this.textDiameter.TabIndex = 1;
            this.textDiameter.TextChanged += new System.EventHandler(this.textDiameter_TextChanged);
            this.textDiameter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textDiameter_KeyPress);
            // 
            // textRadius
            // 
            this.textRadius.Location = new System.Drawing.Point(191, 254);
            this.textRadius.Name = "textRadius";
            this.textRadius.Size = new System.Drawing.Size(146, 22);
            this.textRadius.TabIndex = 0;
            this.textRadius.TextChanged += new System.EventHandler(this.textRadius_TextChanged);
            this.textRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textRadius_KeyPress);
            // 
            // tabPageHemis
            // 
            this.tabPageHemis.Location = new System.Drawing.Point(4, 25);
            this.tabPageHemis.Name = "tabPageHemis";
            this.tabPageHemis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHemis.Size = new System.Drawing.Size(594, 424);
            this.tabPageHemis.TabIndex = 1;
            this.tabPageHemis.Text = "Volume of a hemisphere";
            // 
            // tabPageTri
            // 
            this.tabPageTri.Location = new System.Drawing.Point(4, 25);
            this.tabPageTri.Name = "tabPageTri";
            this.tabPageTri.Size = new System.Drawing.Size(594, 424);
            this.tabPageTri.TabIndex = 2;
            this.tabPageTri.Text = "Area of triangle";
            this.tabPageTri.UseVisualStyleBackColor = true;
            // 
            // tabPageQuad
            // 
            this.tabPageQuad.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuad.Name = "tabPageQuad";
            this.tabPageQuad.Size = new System.Drawing.Size(594, 424);
            this.tabPageQuad.TabIndex = 3;
            this.tabPageQuad.Text = "Quadratic equation";
            this.tabPageQuad.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(602, 450);
            this.Controls.Add(this.tab_Formulas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Mathematical Formulas";
            this.tab_Formulas.ResumeLayout(false);
            this.tabPageCircle.ResumeLayout(false);
            this.tabPageCircle.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Formulas;
        private System.Windows.Forms.TabPage tabPageCircle;
        private System.Windows.Forms.TabPage tabPageHemis;
        private System.Windows.Forms.TabPage tabPageTri;
        private System.Windows.Forms.TabPage tabPageQuad;
        private System.Windows.Forms.TextBox textWarningCir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textDiameter;
        private System.Windows.Forms.TextBox textRadius;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textTitleCir;
        private System.Windows.Forms.TextBox textCirAResult;
        private System.Windows.Forms.TextBox textCirCResult;
        private System.Windows.Forms.RadioButton radioButtonRad;
        private System.Windows.Forms.RadioButton radioButtonDia;
    }
}

