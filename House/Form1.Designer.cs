namespace House
{
    partial class Form1
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
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oneRadioButton = new System.Windows.Forms.RadioButton();
            this.twoRadioButton = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.garageCheckBox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.roomNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.basementCheckBox = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.regularRadioButton = new System.Windows.Forms.RadioButton();
            this.gourmetRadioButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.buildButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bathFlooringComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bedFlooringComboBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.commonFlooringComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.roomNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // resultTextBox
            // 
            this.resultTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.Location = new System.Drawing.Point(198, -1);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(261, 536);
            this.resultTextBox.TabIndex = 0;
            this.resultTextBox.Text = "Build your dream houseBuilderVM!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "House Options";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(16, 62);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 2;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of Stories";
            // 
            // oneRadioButton
            // 
            this.oneRadioButton.AutoSize = true;
            this.oneRadioButton.Location = new System.Drawing.Point(0, 21);
            this.oneRadioButton.Name = "oneRadioButton";
            this.oneRadioButton.Size = new System.Drawing.Size(45, 17);
            this.oneRadioButton.TabIndex = 4;
            this.oneRadioButton.TabStop = true;
            this.oneRadioButton.Text = "One";
            this.oneRadioButton.UseVisualStyleBackColor = true;
            // 
            // twoRadioButton
            // 
            this.twoRadioButton.AutoSize = true;
            this.twoRadioButton.Location = new System.Drawing.Point(0, 45);
            this.twoRadioButton.Name = "twoRadioButton";
            this.twoRadioButton.Size = new System.Drawing.Size(46, 17);
            this.twoRadioButton.TabIndex = 5;
            this.twoRadioButton.TabStop = true;
            this.twoRadioButton.Text = "Two";
            this.twoRadioButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Garage Configuration";
            // 
            // garageCheckBox
            // 
            this.garageCheckBox.AutoSize = true;
            this.garageCheckBox.Location = new System.Drawing.Point(16, 175);
            this.garageCheckBox.Name = "garageCheckBox";
            this.garageCheckBox.Size = new System.Drawing.Size(149, 17);
            this.garageCheckBox.TabIndex = 7;
            this.garageCheckBox.Text = "Include a third garage bay";
            this.garageCheckBox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Rooms";
            // 
            // roomNumericUpDown
            // 
            this.roomNumericUpDown.Location = new System.Drawing.Point(16, 211);
            this.roomNumericUpDown.Name = "roomNumericUpDown";
            this.roomNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.roomNumericUpDown.TabIndex = 9;
            this.roomNumericUpDown.ValueChanged += new System.EventHandler(this.roomNumericUpDown_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Basement";
            // 
            // basementCheckBox
            // 
            this.basementCheckBox.AutoSize = true;
            this.basementCheckBox.Location = new System.Drawing.Point(17, 268);
            this.basementCheckBox.Name = "basementCheckBox";
            this.basementCheckBox.Size = new System.Drawing.Size(119, 17);
            this.basementCheckBox.TabIndex = 11;
            this.basementCheckBox.Text = "Include a basement";
            this.basementCheckBox.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Kitchen Type";
            // 
            // regularRadioButton
            // 
            this.regularRadioButton.AutoSize = true;
            this.regularRadioButton.Location = new System.Drawing.Point(0, 21);
            this.regularRadioButton.Name = "regularRadioButton";
            this.regularRadioButton.Size = new System.Drawing.Size(62, 17);
            this.regularRadioButton.TabIndex = 13;
            this.regularRadioButton.TabStop = true;
            this.regularRadioButton.Text = "Regular";
            this.regularRadioButton.UseVisualStyleBackColor = true;
            // 
            // gourmetRadioButton
            // 
            this.gourmetRadioButton.AutoSize = true;
            this.gourmetRadioButton.Location = new System.Drawing.Point(0, 44);
            this.gourmetRadioButton.Name = "gourmetRadioButton";
            this.gourmetRadioButton.Size = new System.Drawing.Size(65, 17);
            this.gourmetRadioButton.TabIndex = 14;
            this.gourmetRadioButton.TabStop = true;
            this.gourmetRadioButton.Text = "Gourmet";
            this.gourmetRadioButton.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Name Your House";
            // 
            // buildButton
            // 
            this.buildButton.Location = new System.Drawing.Point(17, 512);
            this.buildButton.Name = "buildButton";
            this.buildButton.Size = new System.Drawing.Size(75, 23);
            this.buildButton.TabIndex = 16;
            this.buildButton.Text = "Build";
            this.buildButton.UseVisualStyleBackColor = true;
            this.buildButton.Click += new System.EventHandler(this.buildButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.twoRadioButton);
            this.groupBox1.Controls.Add(this.oneRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(16, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(86, 68);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.gourmetRadioButton);
            this.groupBox2.Controls.Add(this.regularRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(17, 291);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(75, 65);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // bathFlooringComboBox
            // 
            this.bathFlooringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bathFlooringComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bathFlooringComboBox.FormattingEnabled = true;
            this.bathFlooringComboBox.Location = new System.Drawing.Point(16, 375);
            this.bathFlooringComboBox.Name = "bathFlooringComboBox";
            this.bathFlooringComboBox.Size = new System.Drawing.Size(121, 21);
            this.bathFlooringComboBox.TabIndex = 19;
            this.bathFlooringComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 359);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Bathroom Flooring";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 403);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Bedroom Flooring";
            // 
            // bedFlooringComboBox
            // 
            this.bedFlooringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bedFlooringComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bedFlooringComboBox.FormattingEnabled = true;
            this.bedFlooringComboBox.Location = new System.Drawing.Point(16, 419);
            this.bedFlooringComboBox.Name = "bedFlooringComboBox";
            this.bedFlooringComboBox.Size = new System.Drawing.Size(121, 21);
            this.bedFlooringComboBox.TabIndex = 22;
            this.bedFlooringComboBox.SelectedIndexChanged += new System.EventHandler(this.bedFlooringComboBox_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 448);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(113, 13);
            this.label10.TabIndex = 23;
            this.label10.Text = "Common Area Flooring";
            // 
            // commonFlooringComboBox
            // 
            this.commonFlooringComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.commonFlooringComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.commonFlooringComboBox.FormattingEnabled = true;
            this.commonFlooringComboBox.Location = new System.Drawing.Point(17, 464);
            this.commonFlooringComboBox.Name = "commonFlooringComboBox";
            this.commonFlooringComboBox.Size = new System.Drawing.Size(121, 21);
            this.commonFlooringComboBox.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 612);
            this.Controls.Add(this.commonFlooringComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.bedFlooringComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bathFlooringComboBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buildButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.basementCheckBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomNumericUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.garageCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultTextBox);
            this.Name = "Form1";
            this.Text = "ss";
            ((System.ComponentModel.ISupportInitialize)(this.roomNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton oneRadioButton;
        private System.Windows.Forms.RadioButton twoRadioButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox garageCheckBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown roomNumericUpDown;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox basementCheckBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton regularRadioButton;
        private System.Windows.Forms.RadioButton gourmetRadioButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buildButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox bathFlooringComboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox bedFlooringComboBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox commonFlooringComboBox;
    }
}

