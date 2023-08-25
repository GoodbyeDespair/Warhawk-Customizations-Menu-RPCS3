namespace WindowsFormsApp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.connectionLabel = new System.Windows.Forms.Label();
            this.pidLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chernovanSet = new System.Windows.Forms.Button();
            this.planeC = new System.Windows.Forms.NumericUpDown();
            this.upperC = new System.Windows.Forms.NumericUpDown();
            this.lowerC = new System.Windows.Forms.NumericUpDown();
            this.headC = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.eucadianSet = new System.Windows.Forms.Button();
            this.planeE = new System.Windows.Forms.NumericUpDown();
            this.upperE = new System.Windows.Forms.NumericUpDown();
            this.lowerE = new System.Windows.Forms.NumericUpDown();
            this.headE = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planeC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headC)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planeE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.headE)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(184, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Process:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "PID:";
            // 
            // connectionLabel
            // 
            this.connectionLabel.AutoSize = true;
            this.connectionLabel.Location = new System.Drawing.Point(238, 9);
            this.connectionLabel.Name = "connectionLabel";
            this.connectionLabel.Size = new System.Drawing.Size(14, 13);
            this.connectionLabel.TabIndex = 2;
            this.connectionLabel.Text = "#";
            // 
            // pidLabel
            // 
            this.pidLabel.AutoSize = true;
            this.pidLabel.Location = new System.Drawing.Point(218, 31);
            this.pidLabel.Name = "pidLabel";
            this.pidLabel.Size = new System.Drawing.Size(14, 13);
            this.pidLabel.TabIndex = 3;
            this.pidLabel.Text = "#";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chernovanSet);
            this.groupBox1.Controls.Add(this.planeC);
            this.groupBox1.Controls.Add(this.upperC);
            this.groupBox1.Controls.Add(this.lowerC);
            this.groupBox1.Controls.Add(this.headC);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 143);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chernovan";
            // 
            // chernovanSet
            // 
            this.chernovanSet.Location = new System.Drawing.Point(154, 65);
            this.chernovanSet.Name = "chernovanSet";
            this.chernovanSet.Size = new System.Drawing.Size(75, 23);
            this.chernovanSet.TabIndex = 10;
            this.chernovanSet.Text = "SET";
            this.chernovanSet.UseVisualStyleBackColor = true;
            this.chernovanSet.Click += new System.EventHandler(this.ChernovanSet_Click);
            // 
            // planeC
            // 
            this.planeC.Location = new System.Drawing.Point(184, 23);
            this.planeC.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.planeC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.planeC.Name = "planeC";
            this.planeC.Size = new System.Drawing.Size(49, 20);
            this.planeC.TabIndex = 9;
            this.planeC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upperC
            // 
            this.upperC.Location = new System.Drawing.Point(64, 63);
            this.upperC.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.upperC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upperC.Name = "upperC";
            this.upperC.Size = new System.Drawing.Size(49, 20);
            this.upperC.TabIndex = 8;
            this.upperC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lowerC
            // 
            this.lowerC.Location = new System.Drawing.Point(64, 103);
            this.lowerC.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lowerC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lowerC.Name = "lowerC";
            this.lowerC.Size = new System.Drawing.Size(49, 20);
            this.lowerC.TabIndex = 7;
            this.lowerC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // headC
            // 
            this.headC.Location = new System.Drawing.Point(64, 23);
            this.headC.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.headC.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.headC.Name = "headC";
            this.headC.Size = new System.Drawing.Size(49, 20);
            this.headC.TabIndex = 5;
            this.headC.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(133, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "PLANE:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 65);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "UPPER:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "LOWER:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "HEAD:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "By Despair";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.eucadianSet);
            this.groupBox2.Controls.Add(this.planeE);
            this.groupBox2.Controls.Add(this.upperE);
            this.groupBox2.Controls.Add(this.lowerE);
            this.groupBox2.Controls.Add(this.headE);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(3, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(300, 143);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Eucadian";
            // 
            // eucadianSet
            // 
            this.eucadianSet.Location = new System.Drawing.Point(154, 65);
            this.eucadianSet.Name = "eucadianSet";
            this.eucadianSet.Size = new System.Drawing.Size(75, 23);
            this.eucadianSet.TabIndex = 10;
            this.eucadianSet.Text = "SET";
            this.eucadianSet.UseVisualStyleBackColor = true;
            this.eucadianSet.Click += new System.EventHandler(this.EucadianSet_Click);
            // 
            // planeE
            // 
            this.planeE.Location = new System.Drawing.Point(184, 23);
            this.planeE.Maximum = new decimal(new int[] {
            29,
            0,
            0,
            0});
            this.planeE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.planeE.Name = "planeE";
            this.planeE.Size = new System.Drawing.Size(49, 20);
            this.planeE.TabIndex = 9;
            this.planeE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // upperE
            // 
            this.upperE.Location = new System.Drawing.Point(64, 63);
            this.upperE.Maximum = new decimal(new int[] {
            14,
            0,
            0,
            0});
            this.upperE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.upperE.Name = "upperE";
            this.upperE.Size = new System.Drawing.Size(49, 20);
            this.upperE.TabIndex = 8;
            this.upperE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lowerE
            // 
            this.lowerE.Location = new System.Drawing.Point(64, 103);
            this.lowerE.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.lowerE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.lowerE.Name = "lowerE";
            this.lowerE.Size = new System.Drawing.Size(49, 20);
            this.lowerE.TabIndex = 7;
            this.lowerE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // headE
            // 
            this.headE.Location = new System.Drawing.Point(64, 23);
            this.headE.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.headE.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.headE.Name = "headE";
            this.headE.Size = new System.Drawing.Size(49, 20);
            this.headE.TabIndex = 5;
            this.headE.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(133, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "PLANE:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "UPPER:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 105);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(50, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "LOWER:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(40, 13);
            this.label13.TabIndex = 0;
            this.label13.Text = "HEAD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Welcome";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(75, 31);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(14, 13);
            this.username.TabIndex = 13;
            this.username.Text = "#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(306, 360);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pidLabel);
            this.Controls.Add(this.connectionLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Warhawk Customizations";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planeC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headC)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.planeE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upperE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lowerE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.headE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label connectionLabel;
        private System.Windows.Forms.Label pidLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button chernovanSet;
        private System.Windows.Forms.NumericUpDown planeC;
        private System.Windows.Forms.NumericUpDown upperC;
        private System.Windows.Forms.NumericUpDown lowerC;
        private System.Windows.Forms.NumericUpDown headC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button eucadianSet;
        private System.Windows.Forms.NumericUpDown planeE;
        private System.Windows.Forms.NumericUpDown upperE;
        private System.Windows.Forms.NumericUpDown lowerE;
        private System.Windows.Forms.NumericUpDown headE;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label username;
    }
}

