namespace Calculator
{
    partial class Calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            buttonDot = new Button();
            buttonMult = new Button();
            buttonDiv = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonEqualTo = new Button();
            buttonC = new Button();
            textBoxExpression = new TextBox();
            textBoxResult = new TextBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(43, 261);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(169, 261);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(291, 261);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(412, 261);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(43, 301);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 3;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(169, 301);
            button6.Name = "button6";
            button6.Size = new Size(94, 29);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(291, 301);
            button7.Name = "button7";
            button7.Size = new Size(94, 29);
            button7.TabIndex = 5;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(412, 301);
            button8.Name = "button8";
            button8.Size = new Size(94, 29);
            button8.TabIndex = 6;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(43, 354);
            button9.Name = "button9";
            button9.Size = new Size(94, 29);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // button10
            // 
            button10.Location = new Point(169, 354);
            button10.Name = "button10";
            button10.Size = new Size(94, 29);
            button10.TabIndex = 8;
            button10.Text = "10";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // buttonDot
            // 
            buttonDot.Location = new Point(291, 354);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(94, 29);
            buttonDot.TabIndex = 9;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += buttonDot_Click;
            // 
            // buttonMult
            // 
            buttonMult.Location = new Point(560, 317);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(94, 29);
            buttonMult.TabIndex = 10;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(671, 317);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(94, 29);
            buttonDiv.TabIndex = 11;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // buttonPlus
            // 
            buttonPlus.Location = new Point(560, 264);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(94, 29);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += buttonPlus_Click;
            // 
            // buttonMinus
            // 
            buttonMinus.Location = new Point(671, 264);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(94, 29);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += buttonMinus_Click;
            // 
            // buttonEqualTo
            // 
            buttonEqualTo.Location = new Point(560, 210);
            buttonEqualTo.Name = "buttonEqualTo";
            buttonEqualTo.Size = new Size(205, 29);
            buttonEqualTo.TabIndex = 14;
            buttonEqualTo.Text = "=";
            buttonEqualTo.UseVisualStyleBackColor = true;
            buttonEqualTo.Click += buttonEqualTo_Click;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(43, 210);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(463, 29);
            buttonC.TabIndex = 15;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // textBoxExpression
            // 
            textBoxExpression.Location = new Point(43, 24);
            textBoxExpression.Multiline = true;
            textBoxExpression.Name = "textBoxExpression";
            textBoxExpression.Size = new Size(722, 77);
            textBoxExpression.TabIndex = 16;
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(595, 120);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(161, 50);
            textBoxResult.TabIndex = 17;
            //textBoxResult.TextChanged += textBoxResult_TextChanged;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxResult);
            Controls.Add(textBoxExpression);
            Controls.Add(buttonC);
            Controls.Add(buttonEqualTo);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMult);
            Controls.Add(buttonDot);
            Controls.Add(button10);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Calculator";
            Text = "MOST SCIENTIFIC COMPLEX CALCULATOR EVER CONCEIVED BY MANKIND";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button buttonDot;
        private Button buttonMult;
        private Button buttonDiv;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonEqualTo;
        private Button buttonC;
        private TextBox textBoxExpression;
        private TextBox textBoxResult;
    }
}