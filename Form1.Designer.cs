namespace Calculator
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
        /// 
        //Cleans up resources when the form is closed or no longer needed.
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button10 = new Button();
            button11 = new Button();
            button12 = new Button();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            button16 = new Button();
            button18 = new Button();
            button20 = new Button();
            button6 = new Button();
            NameBox_result = new TextBox();
            labelCurrentOperation = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(106, 110);
            button1.Name = "button1";
            button1.Size = new Size(45, 45);
            button1.TabIndex = 0;
            button1.Text = "7";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_Click;
            // 
            // button2
            // 
            button2.Location = new Point(259, 161);
            button2.Name = "button2";
            button2.Size = new Size(45, 45);
            button2.TabIndex = 1;
            button2.Text = "*";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Operator_Click;
            // 
            // button3
            // 
            button3.Location = new Point(208, 110);
            button3.Name = "button3";
            button3.Size = new Size(45, 45);
            button3.TabIndex = 2;
            button3.Text = "9";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button_Click;
            // 
            // button4
            // 
            button4.Location = new Point(157, 110);
            button4.Name = "button4";
            button4.Size = new Size(45, 45);
            button4.TabIndex = 3;
            button4.Text = "8";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button_Click;
            // 
            // button5
            // 
            button5.Location = new Point(310, 110);
            button5.Name = "button5";
            button5.Size = new Size(54, 45);
            button5.TabIndex = 4;
            button5.Text = "CE";
            button5.UseVisualStyleBackColor = true;
            button5.Click += CE_Click;
            // 
            // button7
            // 
            button7.Location = new Point(157, 212);
            button7.Name = "button7";
            button7.Size = new Size(45, 45);
            button7.TabIndex = 8;
            button7.Text = "2";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button_Click;
            // 
            // button8
            // 
            button8.Location = new Point(208, 212);
            button8.Name = "button8";
            button8.Size = new Size(45, 45);
            button8.TabIndex = 7;
            button8.Text = "3";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button_Click;
            // 
            // button9
            // 
            button9.Location = new Point(259, 263);
            button9.Name = "button9";
            button9.Size = new Size(45, 45);
            button9.TabIndex = 6;
            button9.Text = "+";
            button9.UseVisualStyleBackColor = true;
            button9.Click += Operator_Click;
            // 
            // button10
            // 
            button10.Location = new Point(106, 212);
            button10.Name = "button10";
            button10.Size = new Size(45, 45);
            button10.TabIndex = 5;
            button10.Text = "1";
            button10.UseVisualStyleBackColor = true;
            button10.Click += button_Click;
            // 
            // button11
            // 
            button11.Location = new Point(311, 162);
            button11.Name = "button11";
            button11.Size = new Size(54, 45);
            button11.TabIndex = 14;
            button11.Text = "C";
            button11.UseVisualStyleBackColor = true;
            button11.Click += ClearEntry_Click;
            // 
            // button12
            // 
            button12.Location = new Point(157, 161);
            button12.Name = "button12";
            button12.Size = new Size(45, 45);
            button12.TabIndex = 13;
            button12.Text = "5";
            button12.UseVisualStyleBackColor = true;
            button12.Click += button_Click;
            // 
            // button13
            // 
            button13.Location = new Point(208, 161);
            button13.Name = "button13";
            button13.Size = new Size(45, 45);
            button13.TabIndex = 12;
            button13.Text = "6";
            button13.UseVisualStyleBackColor = true;
            button13.Click += button_Click;
            // 
            // button14
            // 
            button14.Location = new Point(259, 212);
            button14.Name = "button14";
            button14.Size = new Size(45, 45);
            button14.TabIndex = 11;
            button14.Text = "-";
            button14.UseVisualStyleBackColor = true;
            button14.Click += Operator_Click;
            // 
            // button15
            // 
            button15.Location = new Point(106, 161);
            button15.Name = "button15";
            button15.Size = new Size(45, 45);
            button15.TabIndex = 10;
            button15.Text = "4";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button_Click;
            // 
            // button16
            // 
            button16.Location = new Point(311, 213);
            button16.Name = "button16";
            button16.Size = new Size(54, 96);
            button16.TabIndex = 19;
            button16.Text = "=";
            button16.UseVisualStyleBackColor = true;
            button16.Click += Equal_operator;
            // 
            // button18
            // 
            button18.Location = new Point(208, 263);
            button18.Name = "button18";
            button18.Size = new Size(45, 45);
            button18.TabIndex = 17;
            button18.Text = ".";
            button18.UseVisualStyleBackColor = true;
            button18.Click += button_Click;
            // 
            // button20
            // 
            button20.Location = new Point(106, 263);
            button20.Name = "button20";
            button20.Size = new Size(96, 45);
            button20.TabIndex = 15;
            button20.Text = "0";
            button20.UseVisualStyleBackColor = true;
            button20.Click += button_Click;
            // 
            // button6
            // 
            button6.Location = new Point(259, 110);
            button6.Name = "button6";
            button6.Size = new Size(45, 45);
            button6.TabIndex = 20;
            button6.Text = "/";
            button6.UseVisualStyleBackColor = true;
            button6.Click += Operator_Click;
            // 
            // NameBox_result
            // 
            NameBox_result.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            NameBox_result.Location = new Point(106, 71);
            NameBox_result.Name = "NameBox_result";
            NameBox_result.Size = new Size(258, 33);
            NameBox_result.TabIndex = 21;
            NameBox_result.Text = "0";
            NameBox_result.TextAlign = HorizontalAlignment.Right;
            // 
            // labelCurrentOperation
            // 
            labelCurrentOperation.AutoSize = true;
            labelCurrentOperation.Font = new Font("Segoe UI", 16F, FontStyle.Bold | FontStyle.Italic);
            labelCurrentOperation.ForeColor = Color.DarkSlateGray;
            labelCurrentOperation.Location = new Point(150, 30);
            labelCurrentOperation.Name = "labelCurrentOperation";
            labelCurrentOperation.Size = new Size(0, 30);
            labelCurrentOperation.TabIndex = 22;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 450);
            Controls.Add(labelCurrentOperation);
            Controls.Add(NameBox_result);
            Controls.Add(button6);
            Controls.Add(button16);
            Controls.Add(button18);
            Controls.Add(button20);
            Controls.Add(button11);
            Controls.Add(button12);
            Controls.Add(button13);
            Controls.Add(button14);
            Controls.Add(button15);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button10);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Calculator";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Claculator";
            TransparencyKey = Color.FromArgb(255, 128, 0);
            Load += Calculator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button12;
        private Button button13;
        private Button button14;
        private Button button15;
        private Button button16;
        private Button button18;
        private Button button20;
        private Button button6;
        private TextBox NameBox_result;
        private Label labelCurrentOperation;
    }
}
