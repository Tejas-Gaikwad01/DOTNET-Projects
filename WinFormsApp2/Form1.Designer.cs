namespace WinFormsApp2
{
    partial class Calculator
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
            components = new System.ComponentModel.Container();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btn0 = new Button();
            btnPlus = new Button();
            btnMin = new Button();
            btnMult = new Button();
            btnDiv = new Button();
            btnEql = new Button();
            btnClear = new Button();
            txtTotal = new TextBox();
            notifyIcon1 = new NotifyIcon(components);
            SuspendLayout();
            // 
            // btn1
            // 
            btn1.AccessibleName = "";
            btn1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn1.Location = new Point(72, 153);
            btn1.Name = "btn1";
            btn1.Size = new Size(94, 66);
            btn1.TabIndex = 1;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button1_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn2.Location = new Point(229, 153);
            btn2.Name = "btn2";
            btn2.Size = new Size(94, 66);
            btn2.TabIndex = 2;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn3.Location = new Point(372, 153);
            btn3.Name = "btn3";
            btn3.Size = new Size(94, 66);
            btn3.TabIndex = 3;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button3_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn4.Location = new Point(531, 153);
            btn4.Name = "btn4";
            btn4.Size = new Size(94, 66);
            btn4.TabIndex = 4;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn5.Location = new Point(693, 153);
            btn5.Name = "btn5";
            btn5.Size = new Size(94, 66);
            btn5.TabIndex = 5;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn6.Location = new Point(72, 282);
            btn6.Name = "btn6";
            btn6.Size = new Size(94, 66);
            btn6.TabIndex = 6;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn7.Location = new Point(229, 282);
            btn7.Name = "btn7";
            btn7.Size = new Size(94, 66);
            btn7.TabIndex = 7;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn8.Location = new Point(372, 282);
            btn8.Name = "btn8";
            btn8.Size = new Size(94, 66);
            btn8.TabIndex = 8;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn9.Location = new Point(531, 282);
            btn9.Name = "btn9";
            btn9.Size = new Size(94, 66);
            btn9.TabIndex = 9;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn0.Location = new Point(693, 292);
            btn0.Name = "btn0";
            btn0.Size = new Size(94, 66);
            btn0.TabIndex = 10;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button10_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPlus.Location = new Point(72, 407);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(94, 66);
            btnPlus.TabIndex = 11;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnMin
            // 
            btnMin.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMin.Location = new Point(229, 407);
            btnMin.Name = "btnMin";
            btnMin.Size = new Size(94, 66);
            btnMin.TabIndex = 12;
            btnMin.Text = "-";
            btnMin.UseVisualStyleBackColor = true;
            btnMin.Click += btnMin_Click;
            // 
            // btnMult
            // 
            btnMult.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnMult.Location = new Point(372, 407);
            btnMult.Name = "btnMult";
            btnMult.Size = new Size(94, 66);
            btnMult.TabIndex = 13;
            btnMult.Text = "*";
            btnMult.UseVisualStyleBackColor = true;
            btnMult.Click += btnMult_Click;
            // 
            // btnDiv
            // 
            btnDiv.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnDiv.Location = new Point(531, 407);
            btnDiv.Name = "btnDiv";
            btnDiv.Size = new Size(94, 66);
            btnDiv.TabIndex = 14;
            btnDiv.Text = "/";
            btnDiv.UseVisualStyleBackColor = true;
            btnDiv.Click += btnDiv_Click;
            // 
            // btnEql
            // 
            btnEql.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            btnEql.Location = new Point(666, 407);
            btnEql.Name = "btnEql";
            btnEql.Size = new Size(149, 66);
            btnEql.TabIndex = 15;
            btnEql.Text = "=";
            btnEql.UseVisualStyleBackColor = true;
            btnEql.Click += btnEql_Click;
            // 
            // btnClear
            // 
            btnClear.BackgroundImageLayout = ImageLayout.Center;
            btnClear.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnClear.ForeColor = Color.FromArgb(255, 128, 0);
            btnClear.Location = new Point(61, 500);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(754, 66);
            btnClear.TabIndex = 16;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(192, 29);
            txtTotal.Multiline = true;
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(519, 68);
            txtTotal.TabIndex = 0;
            txtTotal.TextChanged += txtDisplay_TextChanged;
            // 
            // notifyIcon1
            // 
            notifyIcon1.Text = "notifyIcon1";
            notifyIcon1.Visible = true;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(953, 578);
            Controls.Add(btnClear);
            Controls.Add(btnEql);
            Controls.Add(btnDiv);
            Controls.Add(btnMult);
            Controls.Add(btnMin);
            Controls.Add(btnPlus);
            Controls.Add(btn0);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(txtTotal);
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btn0;
        private Button btnPlus;
        private Button btnMin;
        private Button btnMult;
        private Button btnDiv;
        private Button btnEql;
        private Button btnClear;
        private TextBox txtTotal;
        private NotifyIcon notifyIcon1;
    }
}
