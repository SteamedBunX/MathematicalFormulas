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
            this.textTitleCirA = new System.Windows.Forms.TextBox();
            this.textTitleCirC = new System.Windows.Forms.TextBox();
            this.textWarningCir = new System.Windows.Forms.TextBox();
            this.imgCircle = new System.Windows.Forms.Panel();
            this.radioButtonRad = new System.Windows.Forms.RadioButton();
            this.radioButtonDia = new System.Windows.Forms.RadioButton();
            this.textDiameter = new System.Windows.Forms.TextBox();
            this.textRadius = new System.Windows.Forms.TextBox();
            this.tabPageHemis = new System.Windows.Forms.TabPage();
            this.textHemiVResult = new System.Windows.Forms.TextBox();
            this.textTitleHemiV = new System.Windows.Forms.TextBox();
            this.textWarningHemi = new System.Windows.Forms.TextBox();
            this.imgHemisphere = new System.Windows.Forms.Panel();
            this.textHemiRadius = new System.Windows.Forms.TextBox();
            this.tabPageTri = new System.Windows.Forms.TabPage();
            this.tabPageQuad = new System.Windows.Forms.TabPage();
            this.tab_Formulas.SuspendLayout();
            this.tabPageCircle.SuspendLayout();
            this.imgCircle.SuspendLayout();
            this.tabPageHemis.SuspendLayout();
            this.imgHemisphere.SuspendLayout();
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
            this.tabPageCircle.Controls.Add(this.textTitleCirA);
            this.tabPageCircle.Controls.Add(this.textTitleCirC);
            this.tabPageCircle.Controls.Add(this.textWarningCir);
            this.tabPageCircle.Controls.Add(this.imgCircle);
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
            this.textCirAResult.Text = "0";
            // 
            // textCirCResult
            // 
            this.textCirCResult.BackColor = System.Drawing.SystemColors.Control;
            this.textCirCResult.Location = new System.Drawing.Point(404, 44);
            this.textCirCResult.Name = "textCirCResult";
            this.textCirCResult.ReadOnly = true;
            this.textCirCResult.Size = new System.Drawing.Size(170, 22);
            this.textCirCResult.TabIndex = 6;
            this.textCirCResult.Text = "0";
            // 
            // textTitleCirA
            // 
            this.textTitleCirA.BackColor = System.Drawing.SystemColors.Control;
            this.textTitleCirA.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitleCirA.Location = new System.Drawing.Point(404, 123);
            this.textTitleCirA.Name = "textTitleCirA";
            this.textTitleCirA.Size = new System.Drawing.Size(96, 15);
            this.textTitleCirA.TabIndex = 5;
            this.textTitleCirA.Text = "Area:";
            // 
            // textTitleCirC
            // 
            this.textTitleCirC.BackColor = System.Drawing.SystemColors.Control;
            this.textTitleCirC.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitleCirC.Location = new System.Drawing.Point(405, 23);
            this.textTitleCirC.Name = "textTitleCirC";
            this.textTitleCirC.Size = new System.Drawing.Size(96, 15);
            this.textTitleCirC.TabIndex = 4;
            this.textTitleCirC.Text = "Circumferece:";
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
            // imgCircle
            // 
            this.imgCircle.BackgroundImage = global::MathematicalFormulas.Properties.Resources.Circle;
            this.imgCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgCircle.Controls.Add(this.radioButtonRad);
            this.imgCircle.Controls.Add(this.radioButtonDia);
            this.imgCircle.Controls.Add(this.textDiameter);
            this.imgCircle.Controls.Add(this.textRadius);
            this.imgCircle.Location = new System.Drawing.Point(8, 23);
            this.imgCircle.Name = "imgCircle";
            this.imgCircle.Size = new System.Drawing.Size(390, 390);
            this.imgCircle.TabIndex = 1;
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
            this.radioButtonDia.CheckedChanged += new System.EventHandler(this.radioButtonDia_CheckedChanged);
            // 
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
            this.tabPageHemis.Controls.Add(this.textHemiVResult);
            this.tabPageHemis.Controls.Add(this.textTitleHemiV);
            this.tabPageHemis.Controls.Add(this.textWarningHemi);
            this.tabPageHemis.Controls.Add(this.imgHemisphere);
            this.tabPageHemis.Location = new System.Drawing.Point(4, 25);
            this.tabPageHemis.Name = "tabPageHemis";
            this.tabPageHemis.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageHemis.Size = new System.Drawing.Size(594, 424);
            this.tabPageHemis.TabIndex = 1;
            this.tabPageHemis.Text = "Volume of a hemisphere";
            // 
            // textHemiVResult
            // 
            this.textHemiVResult.BackColor = System.Drawing.SystemColors.Control;
            this.textHemiVResult.Location = new System.Drawing.Point(404, 44);
            this.textHemiVResult.Name = "textHemiVResult";
            this.textHemiVResult.ReadOnly = true;
            this.textHemiVResult.Size = new System.Drawing.Size(170, 22);
            this.textHemiVResult.TabIndex = 9;
            // 
            // textTitleHemiV
            // 
            this.textTitleHemiV.BackColor = System.Drawing.SystemColors.Control;
            this.textTitleHemiV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textTitleHemiV.Location = new System.Drawing.Point(405, 23);
            this.textTitleHemiV.Name = "textTitleHemiV";
            this.textTitleHemiV.Size = new System.Drawing.Size(96, 15);
            this.textTitleHemiV.TabIndex = 8;
            this.textTitleHemiV.Text = "Volume:";
            // 
            // textWarningHemi
            // 
            this.textWarningHemi.BackColor = System.Drawing.SystemColors.Control;
            this.textWarningHemi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textWarningHemi.ForeColor = System.Drawing.Color.Red;
            this.textWarningHemi.Location = new System.Drawing.Point(403, 197);
            this.textWarningHemi.Multiline = true;
            this.textWarningHemi.Name = "textWarningHemi";
            this.textWarningHemi.ReadOnly = true;
            this.textWarningHemi.ShortcutsEnabled = false;
            this.textWarningHemi.Size = new System.Drawing.Size(188, 102);
            this.textWarningHemi.TabIndex = 7;
            // 
            // imgHemisphere
            // 
            this.imgHemisphere.BackgroundImage = global::MathematicalFormulas.Properties.Resources.hemisphere001;
            this.imgHemisphere.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgHemisphere.Controls.Add(this.textHemiRadius);
            this.imgHemisphere.Location = new System.Drawing.Point(8, 23);
            this.imgHemisphere.Name = "imgHemisphere";
            this.imgHemisphere.Size = new System.Drawing.Size(390, 390);
            this.imgHemisphere.TabIndex = 2;
            // 
            // textHemiRadius
            // 
            this.textHemiRadius.Location = new System.Drawing.Point(188, 245);
            this.textHemiRadius.Name = "textHemiRadius";
            this.textHemiRadius.Size = new System.Drawing.Size(146, 22);
            this.textHemiRadius.TabIndex = 0;
            this.textHemiRadius.TextChanged += new System.EventHandler(this.textHemiRadius_TextChanged);
            this.textHemiRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textHemiRadius_KeyPress);
            // 
            // tabPageTri
            // 
            this.tabPageTri.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageTri.Location = new System.Drawing.Point(4, 25);
            this.tabPageTri.Name = "tabPageTri";
            this.tabPageTri.Size = new System.Drawing.Size(594, 424);
            this.tabPageTri.TabIndex = 2;
            this.tabPageTri.Text = "Area of triangle";
            // 
            // tabPageQuad
            // 
            this.tabPageQuad.BackColor = System.Drawing.SystemColors.Control;
            this.tabPageQuad.Location = new System.Drawing.Point(4, 25);
            this.tabPageQuad.Name = "tabPageQuad";
            this.tabPageQuad.Size = new System.Drawing.Size(594, 424);
            this.tabPageQuad.TabIndex = 3;
            this.tabPageQuad.Text = "Quadratic equation";
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
            this.imgCircle.ResumeLayout(false);
            this.imgCircle.PerformLayout();
            this.tabPageHemis.ResumeLayout(false);
            this.tabPageHemis.PerformLayout();
            this.imgHemisphere.ResumeLayout(false);
            this.imgHemisphere.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_Formulas;
        private System.Windows.Forms.TabPage tabPageCircle;
        private System.Windows.Forms.TabPage tabPageHemis;
        private System.Windows.Forms.TabPage tabPageTri;
        private System.Windows.Forms.TabPage tabPageQuad;
        private System.Windows.Forms.TextBox textWarningCir;
        private System.Windows.Forms.Panel imgCircle;
        private System.Windows.Forms.TextBox textDiameter;
        private System.Windows.Forms.TextBox textRadius;
        private System.Windows.Forms.TextBox textTitleCirA;
        private System.Windows.Forms.TextBox textTitleCirC;
        private System.Windows.Forms.TextBox textCirAResult;
        private System.Windows.Forms.TextBox textCirCResult;
        private System.Windows.Forms.RadioButton radioButtonRad;
        private System.Windows.Forms.RadioButton radioButtonDia;
        private System.Windows.Forms.Panel imgHemisphere;
        private System.Windows.Forms.TextBox textHemiRadius;
        private System.Windows.Forms.TextBox textHemiVResult;
        private System.Windows.Forms.TextBox textTitleHemiV;
        private System.Windows.Forms.TextBox textWarningHemi;
    }
}

