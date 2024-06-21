namespace calculatorAppAct
{
    partial class Form1
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
            display = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            equal = new Button();
            button11 = new Button();
            clear = new Button();
            add = new Button();
            subtract = new Button();
            mutiply = new Button();
            divide = new Button();
            backspace = new Button();
            SuspendLayout();
            // 
            // display
            // 
            display.BackColor = SystemColors.ButtonHighlight;
            display.Location = new Point(10, 7);
            display.Multiline = true;
            display.Name = "display";
            display.ReadOnly = true;
            display.Size = new Size(600, 89);
            display.TabIndex = 0;
            display.TextAlign = HorizontalAlignment.Right;
            // 
            // button1
            // 
            button1.BackColor = Color.Aquamarine;
            button1.Location = new Point(49, 124);
            button1.Name = "button1";
            button1.Size = new Size(90, 48);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Aquamarine;
            button2.Location = new Point(176, 124);
            button2.Name = "button2";
            button2.Size = new Size(90, 48);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Aquamarine;
            button3.Location = new Point(295, 124);
            button3.Name = "button3";
            button3.Size = new Size(90, 48);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Aquamarine;
            button4.Location = new Point(49, 187);
            button4.Name = "button4";
            button4.Size = new Size(90, 48);
            button4.TabIndex = 6;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            button5.BackColor = Color.Aquamarine;
            button5.Location = new Point(176, 187);
            button5.Name = "button5";
            button5.Size = new Size(90, 48);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.Aquamarine;
            button6.Location = new Point(295, 187);
            button6.Name = "button6";
            button6.Size = new Size(90, 48);
            button6.TabIndex = 4;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            button7.BackColor = Color.Aquamarine;
            button7.Location = new Point(49, 253);
            button7.Name = "button7";
            button7.Size = new Size(90, 48);
            button7.TabIndex = 9;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            button8.BackColor = Color.Aquamarine;
            button8.Location = new Point(176, 253);
            button8.Name = "button8";
            button8.Size = new Size(90, 48);
            button8.TabIndex = 8;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            button9.BackColor = Color.Aquamarine;
            button9.Location = new Point(295, 253);
            button9.Name = "button9";
            button9.Size = new Size(90, 48);
            button9.TabIndex = 7;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            // 
            // equal
            // 
            equal.BackColor = Color.Aquamarine;
            equal.Location = new Point(295, 329);
            equal.Name = "equal";
            equal.Size = new Size(90, 48);
            equal.TabIndex = 12;
            equal.Text = "=";
            equal.UseVisualStyleBackColor = false;
            equal.Click += ButtonEquals_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.Aquamarine;
            button11.Location = new Point(176, 329);
            button11.Name = "button11";
            button11.Size = new Size(90, 48);
            button11.TabIndex = 11;
            button11.Text = "0";
            button11.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            clear.BackColor = Color.Aquamarine;
            clear.Location = new Point(49, 329);
            clear.Name = "clear";
            clear.Size = new Size(90, 48);
            clear.TabIndex = 10;
            clear.Text = "C";
            clear.UseVisualStyleBackColor = false;
            // 
            // add
            // 
            add.BackColor = Color.LightGreen;
            add.Location = new Point(419, 329);
            add.Name = "add";
            add.Size = new Size(90, 48);
            add.TabIndex = 16;
            add.Text = "+";
            add.UseVisualStyleBackColor = false;
            // 
            // subtract
            // 
            subtract.BackColor = Color.LightGreen;
            subtract.Location = new Point(419, 187);
            subtract.Name = "subtract";
            subtract.Size = new Size(90, 48);
            subtract.TabIndex = 15;
            subtract.Text = "-";
            subtract.UseVisualStyleBackColor = false;
            // 
            // mutiply
            // 
            mutiply.BackColor = Color.LightGreen;
            mutiply.Location = new Point(419, 124);
            mutiply.Name = "mutiply";
            mutiply.Size = new Size(90, 48);
            mutiply.TabIndex = 14;
            mutiply.Text = "x";
            mutiply.UseVisualStyleBackColor = false;
            // 
            // divide
            // 
            divide.BackColor = Color.LightGreen;
            divide.Location = new Point(419, 253);
            divide.Name = "divide";
            divide.Size = new Size(90, 48);
            divide.TabIndex = 13;
            divide.Text = "/";
            divide.UseVisualStyleBackColor = false;
            // 
            // backspace
            // 
            backspace.BackColor = Color.LightGreen;
            backspace.BackgroundImageLayout = ImageLayout.None;
            backspace.Location = new Point(520, 124);
            backspace.Name = "backspace";
            backspace.Size = new Size(90, 48);
            backspace.TabIndex = 17;
            backspace.Text = "<";
            backspace.UseVisualStyleBackColor = false;
            backspace.Click += backspace_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(622, 446);
            Controls.Add(backspace);
            Controls.Add(add);
            Controls.Add(subtract);
            Controls.Add(mutiply);
            Controls.Add(divide);
            Controls.Add(equal);
            Controls.Add(button11);
            Controls.Add(clear);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(display);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            TransparencyKey = Color.Lime;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox display;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button equal;
        private Button button11;
        private Button clear;
        private Button add;
        private Button subtract;
        private Button mutiply;
        private Button divide;
        private Button backspace;
    }
}
