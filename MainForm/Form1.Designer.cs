namespace MainForm
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
            this.pbXY = new System.Windows.Forms.PictureBox();
            this.pbXZ = new System.Windows.Forms.PictureBox();
            this.pbYZ = new System.Windows.Forms.PictureBox();
            this.labelExpectedValue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numDrob = new System.Windows.Forms.NumericUpDown();
            this.numDX = new System.Windows.Forms.NumericUpDown();
            this.numMX = new System.Windows.Forms.NumericUpDown();
            this.numMY = new System.Windows.Forms.NumericUpDown();
            this.numDY = new System.Windows.Forms.NumericUpDown();
            this.numSZ = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pbXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSZ)).BeginInit();
            this.SuspendLayout();
            // 
            // pbXY
            // 
            this.pbXY.Location = new System.Drawing.Point(12, 12);
            this.pbXY.Name = "pbXY";
            this.pbXY.Size = new System.Drawing.Size(300, 300);
            this.pbXY.TabIndex = 0;
            this.pbXY.TabStop = false;
            // 
            // pbXZ
            // 
            this.pbXZ.Location = new System.Drawing.Point(12, 332);
            this.pbXZ.Name = "pbXZ";
            this.pbXZ.Size = new System.Drawing.Size(300, 300);
            this.pbXZ.TabIndex = 1;
            this.pbXZ.TabStop = false;
            // 
            // pbYZ
            // 
            this.pbYZ.Location = new System.Drawing.Point(332, 12);
            this.pbYZ.Name = "pbYZ";
            this.pbYZ.Size = new System.Drawing.Size(300, 300);
            this.pbYZ.TabIndex = 2;
            this.pbYZ.TabStop = false;
            // 
            // labelExpectedValue
            // 
            this.labelExpectedValue.Location = new System.Drawing.Point(329, 352);
            this.labelExpectedValue.Name = "labelExpectedValue";
            this.labelExpectedValue.Size = new System.Drawing.Size(100, 30);
            this.labelExpectedValue.TabIndex = 3;
            this.labelExpectedValue.Text = "Математическое ожидание по X";
            this.labelExpectedValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(329, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 30);
            this.label1.TabIndex = 5;
            this.label1.Text = "Математическое ожидание по Y";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(329, 493);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дисперсия по Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(329, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 30);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дисперсия по X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(329, 538);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 30);
            this.label4.TabIndex = 11;
            this.label4.Text = "σ по Z";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(332, 609);
            this.buttonGenerate.Name = "buttonGenerate";
            this.buttonGenerate.Size = new System.Drawing.Size(300, 23);
            this.buttonGenerate.TabIndex = 13;
            this.buttonGenerate.Text = "Сгенерировать";
            this.buttonGenerate.UseVisualStyleBackColor = true;
            this.buttonGenerate.Click += new System.EventHandler(this.buttonGenerate_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Location = new System.Drawing.Point(329, 568);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 38);
            this.label5.TabIndex = 14;
            this.label5.Text = "Количество дробин";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numDrob
            // 
            this.numDrob.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numDrob.Location = new System.Drawing.Point(435, 579);
            this.numDrob.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numDrob.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numDrob.Name = "numDrob";
            this.numDrob.Size = new System.Drawing.Size(197, 20);
            this.numDrob.TabIndex = 15;
            this.numDrob.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // numDX
            // 
            this.numDX.DecimalPlaces = 2;
            this.numDX.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numDX.Location = new System.Drawing.Point(435, 452);
            this.numDX.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDX.Name = "numDX";
            this.numDX.Size = new System.Drawing.Size(197, 20);
            this.numDX.TabIndex = 18;
            this.numDX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numMX
            // 
            this.numMX.DecimalPlaces = 2;
            this.numMX.Location = new System.Drawing.Point(435, 359);
            this.numMX.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numMX.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numMX.Name = "numMX";
            this.numMX.Size = new System.Drawing.Size(197, 20);
            this.numMX.TabIndex = 20;
            // 
            // numMY
            // 
            this.numMY.DecimalPlaces = 2;
            this.numMY.Location = new System.Drawing.Point(435, 407);
            this.numMY.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numMY.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numMY.Name = "numMY";
            this.numMY.Size = new System.Drawing.Size(197, 20);
            this.numMY.TabIndex = 21;
            // 
            // numDY
            // 
            this.numDY.DecimalPlaces = 2;
            this.numDY.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numDY.Location = new System.Drawing.Point(435, 500);
            this.numDY.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDY.Name = "numDY";
            this.numDY.Size = new System.Drawing.Size(197, 20);
            this.numDY.TabIndex = 22;
            this.numDY.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numSZ
            // 
            this.numSZ.DecimalPlaces = 2;
            this.numSZ.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numSZ.Location = new System.Drawing.Point(435, 545);
            this.numSZ.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numSZ.Name = "numSZ";
            this.numSZ.Size = new System.Drawing.Size(197, 20);
            this.numSZ.TabIndex = 23;
            this.numSZ.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 661);
            this.Controls.Add(this.numSZ);
            this.Controls.Add(this.numDY);
            this.Controls.Add(this.numMY);
            this.Controls.Add(this.numMX);
            this.Controls.Add(this.numDX);
            this.Controls.Add(this.numDrob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelExpectedValue);
            this.Controls.Add(this.pbYZ);
            this.Controls.Add(this.pbXZ);
            this.Controls.Add(this.pbXY);
            this.MaximumSize = new System.Drawing.Size(670, 700);
            this.MinimumSize = new System.Drawing.Size(670, 700);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numSZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbXY;
        private System.Windows.Forms.PictureBox pbXZ;
        private System.Windows.Forms.PictureBox pbYZ;
        private System.Windows.Forms.Label labelExpectedValue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDrob;
        private System.Windows.Forms.NumericUpDown numDX;
        private System.Windows.Forms.NumericUpDown numMX;
        private System.Windows.Forms.NumericUpDown numMY;
        private System.Windows.Forms.NumericUpDown numDY;
        private System.Windows.Forms.NumericUpDown numSZ;
    }
}

