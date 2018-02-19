namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.sideLalelA = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.sideLabelB = new System.Windows.Forms.Label();
            this.sideLabelC = new System.Windows.Forms.Label();
            this.dotButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.areaLabel = new System.Windows.Forms.Label();
            this.perimeterLabel = new System.Windows.Forms.Label();
            this.areaValue = new System.Windows.Forms.Label();
            this.perimeterValue = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Heron\'s formula";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(295, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 38);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(364, 120);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(47, 38);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(435, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(47, 38);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(295, 175);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 38);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(364, 175);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(47, 38);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(435, 175);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(47, 38);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button7
            // 
            this.button7.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button7.Location = new System.Drawing.Point(295, 230);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 38);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button8
            // 
            this.button8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button8.Location = new System.Drawing.Point(364, 230);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(47, 38);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button9
            // 
            this.button9.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button9.Location = new System.Drawing.Point(435, 230);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(47, 38);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button0
            // 
            this.button0.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button0.Location = new System.Drawing.Point(364, 283);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(47, 38);
            this.button0.TabIndex = 11;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.fillTextBox);
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearButton.Location = new System.Drawing.Point(295, 283);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(63, 38);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButtonClick);
            // 
            // textBoxA
            // 
            this.textBoxA.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxA.Location = new System.Drawing.Point(150, 120);
            this.textBoxA.MaxLength = 9;
            this.textBoxA.Multiline = true;
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(126, 36);
            this.textBoxA.TabIndex = 13;
            this.textBoxA.Click += new System.EventHandler(this.setTextBoxActive);
            this.textBoxA.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            this.textBoxA.TabIndexChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxA.TabStopChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxA.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.textBoxA.DoubleClick += new System.EventHandler(this.setTextBoxActive);
            this.textBoxA.Enter += new System.EventHandler(this.setTextBoxActive);
            this.textBoxA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.textBoxA.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            this.textBoxA.MouseCaptureChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxA.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            // 
            // sideLalelA
            // 
            this.sideLalelA.AutoSize = true;
            this.sideLalelA.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sideLalelA.Location = new System.Drawing.Point(43, 125);
            this.sideLalelA.Name = "sideLalelA";
            this.sideLalelA.Size = new System.Drawing.Size(85, 33);
            this.sideLalelA.TabIndex = 14;
            this.sideLalelA.Text = "Side A";
            // 
            // textBoxB
            // 
            this.textBoxB.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxB.Location = new System.Drawing.Point(150, 175);
            this.textBoxB.MaxLength = 9;
            this.textBoxB.Multiline = true;
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(126, 36);
            this.textBoxB.TabIndex = 16;
            this.textBoxB.Click += new System.EventHandler(this.setTextBoxActive);
            this.textBoxB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            this.textBoxB.TabIndexChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxB.TabStopChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxB.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.textBoxB.DoubleClick += new System.EventHandler(this.setTextBoxActive);
            this.textBoxB.Enter += new System.EventHandler(this.setTextBoxActive);
            this.textBoxB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.textBoxB.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            this.textBoxB.MouseCaptureChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            // 
            // textBoxC
            // 
            this.textBoxC.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxC.Location = new System.Drawing.Point(150, 230);
            this.textBoxC.MaxLength = 9;
            this.textBoxC.Multiline = true;
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(126, 36);
            this.textBoxC.TabIndex = 17;
            this.textBoxC.Click += new System.EventHandler(this.setTextBoxActive);
            this.textBoxC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            this.textBoxC.TabIndexChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxC.TabStopChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxC.TextChanged += new System.EventHandler(this.textChangedEvent);
            this.textBoxC.DoubleClick += new System.EventHandler(this.setTextBoxActive);
            this.textBoxC.Enter += new System.EventHandler(this.setTextBoxActive);
            this.textBoxC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.textBoxC.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            this.textBoxC.MouseCaptureChanged += new System.EventHandler(this.setTextBoxActive);
            this.textBoxC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.setTextBoxActive);
            // 
            // sideLabelB
            // 
            this.sideLabelB.AutoSize = true;
            this.sideLabelB.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sideLabelB.Location = new System.Drawing.Point(43, 180);
            this.sideLabelB.Name = "sideLabelB";
            this.sideLabelB.Size = new System.Drawing.Size(84, 33);
            this.sideLabelB.TabIndex = 18;
            this.sideLabelB.Text = "Side B";
            // 
            // sideLabelC
            // 
            this.sideLabelC.AutoSize = true;
            this.sideLabelC.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sideLabelC.Location = new System.Drawing.Point(43, 235);
            this.sideLabelC.Name = "sideLabelC";
            this.sideLabelC.Size = new System.Drawing.Size(83, 33);
            this.sideLabelC.TabIndex = 19;
            this.sideLabelC.Text = "Side C";
            // 
            // dotButton
            // 
            this.dotButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dotButton.Location = new System.Drawing.Point(435, 283);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(47, 38);
            this.dotButton.TabIndex = 20;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.fillTextBox);
            // 
            // calculateButton
            // 
            this.calculateButton.Enabled = false;
            this.calculateButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculateButton.Location = new System.Drawing.Point(58, 272);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(208, 45);
            this.calculateButton.TabIndex = 21;
            this.calculateButton.Text = "Calculate area";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButtonClick);
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaLabel.Location = new System.Drawing.Point(52, 43);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(57, 36);
            this.areaLabel.TabIndex = 22;
            this.areaLabel.Text = "S = ";
            this.areaLabel.Visible = false;
            // 
            // perimeterLabel
            // 
            this.perimeterLabel.AutoSize = true;
            this.perimeterLabel.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perimeterLabel.Location = new System.Drawing.Point(52, 79);
            this.perimeterLabel.Name = "perimeterLabel";
            this.perimeterLabel.Size = new System.Drawing.Size(58, 36);
            this.perimeterLabel.TabIndex = 23;
            this.perimeterLabel.Text = "P = ";
            this.perimeterLabel.Visible = false;
            // 
            // areaValue
            // 
            this.areaValue.AutoSize = true;
            this.areaValue.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.areaValue.Location = new System.Drawing.Point(106, 48);
            this.areaValue.Name = "areaValue";
            this.areaValue.Size = new System.Drawing.Size(0, 29);
            this.areaValue.TabIndex = 24;
            // 
            // perimeterValue
            // 
            this.perimeterValue.AutoSize = true;
            this.perimeterValue.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.perimeterValue.Location = new System.Drawing.Point(106, 84);
            this.perimeterValue.Name = "perimeterValue";
            this.perimeterValue.Size = new System.Drawing.Size(0, 29);
            this.perimeterValue.TabIndex = 25;
            // 
            // resetButton
            // 
            this.resetButton.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.Location = new System.Drawing.Point(391, 53);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(91, 55);
            this.resetButton.TabIndex = 26;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButtonClick);
            // 
            // button10
            // 
            this.button10.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button10.Location = new System.Drawing.Point(295, 120);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(47, 38);
            this.button10.TabIndex = 2;
            this.button10.Text = "1";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button11
            // 
            this.button11.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button11.Location = new System.Drawing.Point(364, 120);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(47, 38);
            this.button11.TabIndex = 3;
            this.button11.Text = "2";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button12
            // 
            this.button12.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button12.Location = new System.Drawing.Point(435, 120);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(47, 38);
            this.button12.TabIndex = 4;
            this.button12.Text = "3";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button13
            // 
            this.button13.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button13.Location = new System.Drawing.Point(295, 175);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(47, 38);
            this.button13.TabIndex = 5;
            this.button13.Text = "4";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button14
            // 
            this.button14.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button14.Location = new System.Drawing.Point(364, 175);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(47, 38);
            this.button14.TabIndex = 6;
            this.button14.Text = "5";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.fillTextBox);
            // 
            // button15
            // 
            this.button15.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button15.Location = new System.Drawing.Point(435, 175);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(47, 38);
            this.button15.TabIndex = 7;
            this.button15.Text = "6";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.fillTextBox);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(543, 333);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.perimeterValue);
            this.Controls.Add(this.areaValue);
            this.Controls.Add(this.perimeterLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.sideLabelC);
            this.Controls.Add(this.sideLabelB);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.sideLalelA);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Heron\'s formula";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyPressEvent);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label sideLalelA;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Label sideLabelB;
        private System.Windows.Forms.Label sideLabelC;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label perimeterLabel;
        private System.Windows.Forms.Label areaValue;
        private System.Windows.Forms.Label perimeterValue;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
    }
}

