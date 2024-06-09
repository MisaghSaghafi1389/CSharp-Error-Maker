namespace Error_Make
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            ERRORTEXT = new TextBox();
            label2 = new Label();
            RB1 = new RadioButton();
            RB2 = new RadioButton();
            RB3 = new RadioButton();
            RB4 = new RadioButton();
            RB5 = new RadioButton();
            Start = new Button();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            RB11 = new RadioButton();
            RB10 = new RadioButton();
            RB9 = new RadioButton();
            RB8 = new RadioButton();
            RB7 = new RadioButton();
            RB6 = new RadioButton();
            ERRORTITLE = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 15);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Error Maker";
            // 
            // ERRORTEXT
            // 
            ERRORTEXT.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ERRORTEXT.Location = new Point(12, 96);
            ERRORTEXT.Name = "ERRORTEXT";
            ERRORTEXT.Size = new Size(592, 23);
            ERRORTEXT.TabIndex = 1;
            ERRORTEXT.Text = "This is your error";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 78);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "Error Text :";
            // 
            // RB1
            // 
            RB1.AutoSize = true;
            RB1.Location = new Point(6, 13);
            RB1.Name = "RB1";
            RB1.Size = new Size(67, 19);
            RB1.TabIndex = 4;
            RB1.TabStop = true;
            RB1.Text = "No Icon";
            RB1.UseVisualStyleBackColor = true;
            // 
            // RB2
            // 
            RB2.AutoSize = true;
            RB2.Location = new Point(79, 13);
            RB2.Name = "RB2";
            RB2.Size = new Size(88, 19);
            RB2.TabIndex = 5;
            RB2.TabStop = true;
            RB2.Text = "Critical Icon";
            RB2.UseVisualStyleBackColor = true;
            // 
            // RB3
            // 
            RB3.AutoSize = true;
            RB3.Location = new Point(173, 13);
            RB3.Name = "RB3";
            RB3.Size = new Size(99, 19);
            RB3.TabIndex = 6;
            RB3.TabStop = true;
            RB3.Text = "Question Icon";
            RB3.UseVisualStyleBackColor = true;
            // 
            // RB4
            // 
            RB4.AutoSize = true;
            RB4.Location = new Point(272, 13);
            RB4.Name = "RB4";
            RB4.Size = new Size(96, 19);
            RB4.TabIndex = 7;
            RB4.TabStop = true;
            RB4.Text = "Warning Icon";
            RB4.UseVisualStyleBackColor = true;
            // 
            // RB5
            // 
            RB5.AutoSize = true;
            RB5.Location = new Point(369, 13);
            RB5.Name = "RB5";
            RB5.Size = new Size(72, 19);
            RB5.TabIndex = 8;
            RB5.TabStop = true;
            RB5.Text = "Info Icon";
            RB5.UseVisualStyleBackColor = true;
            // 
            // Start
            // 
            Start.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Start.Location = new Point(401, 252);
            Start.Name = "Start";
            Start.Size = new Size(203, 44);
            Start.TabIndex = 9;
            Start.Text = "Make Error";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(RB1);
            groupBox1.Controls.Add(RB2);
            groupBox1.Controls.Add(RB5);
            groupBox1.Controls.Add(RB3);
            groupBox1.Controls.Add(RB4);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(12, 125);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(592, 37);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select your icon type :";
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(RB11);
            groupBox2.Controls.Add(RB10);
            groupBox2.Controls.Add(RB9);
            groupBox2.Controls.Add(RB8);
            groupBox2.Controls.Add(RB7);
            groupBox2.Controls.Add(RB6);
            groupBox2.Location = new Point(12, 165);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(592, 40);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Select your Button type :";
            // 
            // RB11
            // 
            RB11.AutoSize = true;
            RB11.Location = new Point(489, 15);
            RB11.Name = "RB11";
            RB11.Size = new Size(99, 19);
            RB11.TabIndex = 14;
            RB11.TabStop = true;
            RB11.Text = "Retry - Cancel";
            RB11.UseVisualStyleBackColor = true;
            // 
            // RB10
            // 
            RB10.AutoSize = true;
            RB10.Location = new Point(414, 13);
            RB10.Name = "RB10";
            RB10.Size = new Size(69, 19);
            RB10.TabIndex = 12;
            RB10.TabStop = true;
            RB10.Text = "Yes - No";
            RB10.UseVisualStyleBackColor = true;
            // 
            // RB9
            // 
            RB9.AutoSize = true;
            RB9.Location = new Point(292, 13);
            RB9.Name = "RB9";
            RB9.Size = new Size(116, 19);
            RB9.TabIndex = 13;
            RB9.TabStop = true;
            RB9.Text = "Yes - No - Cancel";
            RB9.UseVisualStyleBackColor = true;
            // 
            // RB8
            // 
            RB8.AutoSize = true;
            RB8.Location = new Point(145, 13);
            RB8.Name = "RB8";
            RB8.Size = new Size(141, 19);
            RB8.TabIndex = 12;
            RB8.TabStop = true;
            RB8.Text = "Abort - Retry  - Ignore";
            RB8.UseVisualStyleBackColor = true;
            // 
            // RB7
            // 
            RB7.AutoSize = true;
            RB7.Location = new Point(52, 13);
            RB7.Name = "RB7";
            RB7.Size = new Size(87, 19);
            RB7.TabIndex = 12;
            RB7.TabStop = true;
            RB7.Text = "Ok - Cancel";
            RB7.UseVisualStyleBackColor = true;
            // 
            // RB6
            // 
            RB6.AutoSize = true;
            RB6.Location = new Point(6, 13);
            RB6.Name = "RB6";
            RB6.Size = new Size(40, 19);
            RB6.TabIndex = 0;
            RB6.TabStop = true;
            RB6.Text = "Ok";
            RB6.UseVisualStyleBackColor = true;
            // 
            // ERRORTITLE
            // 
            ERRORTITLE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            ERRORTITLE.Location = new Point(12, 52);
            ERRORTITLE.Name = "ERRORTITLE";
            ERRORTITLE.Size = new Size(592, 23);
            ERRORTITLE.TabIndex = 12;
            ERRORTITLE.Text = "Error";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 34);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 13;
            label3.Text = "Error Title :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 308);
            Controls.Add(label3);
            Controls.Add(ERRORTITLE);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(Start);
            Controls.Add(label2);
            Controls.Add(ERRORTEXT);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Error Maker";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox ERRORTEXT;
        private Label label2;
        private RadioButton RB1;
        private RadioButton RB2;
        private RadioButton RB3;
        private RadioButton RB4;
        private RadioButton RB5;
        private Button Start;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private RadioButton RB6;
        private RadioButton RB7;
        private RadioButton RB9;
        private RadioButton RB8;
        private RadioButton RB10;
        private RadioButton RB11;
        private TextBox ERRORTITLE;
        private Label label3;
    }
}
