namespace MainForm
{
    partial class MainForm
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
            this.buttonGenerate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numDrob = new System.Windows.Forms.NumericUpDown();
            this.buttonShoot = new System.Windows.Forms.Button();
            this.numExperiments = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.numCurrentExperiment = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.numKX = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numKY = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numKZ = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentExperiment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKZ)).BeginInit();
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
            // buttonGenerate
            // 
            this.buttonGenerate.Location = new System.Drawing.Point(332, 438);
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
            this.label5.Location = new System.Drawing.Point(329, 334);
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
            this.numDrob.Location = new System.Drawing.Point(435, 345);
            this.numDrob.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDrob.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numDrob.Name = "numDrob";
            this.numDrob.Size = new System.Drawing.Size(41, 20);
            this.numDrob.TabIndex = 15;
            this.numDrob.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numDrob.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // buttonShoot
            // 
            this.buttonShoot.Enabled = false;
            this.buttonShoot.Location = new System.Drawing.Point(332, 609);
            this.buttonShoot.Name = "buttonShoot";
            this.buttonShoot.Size = new System.Drawing.Size(300, 23);
            this.buttonShoot.TabIndex = 24;
            this.buttonShoot.Text = "Выстрел";
            this.buttonShoot.UseVisualStyleBackColor = true;
            this.buttonShoot.Click += new System.EventHandler(this.buttonShoot_Click);
            // 
            // numExperiments
            // 
            this.numExperiments.Location = new System.Drawing.Point(588, 345);
            this.numExperiments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExperiments.Name = "numExperiments";
            this.numExperiments.Size = new System.Drawing.Size(41, 20);
            this.numExperiments.TabIndex = 26;
            this.numExperiments.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numExperiments.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(482, 334);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Количество испытаний";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(329, 498);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(302, 108);
            this.labelInfo.TabIndex = 30;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numCurrentExperiment
            // 
            this.numCurrentExperiment.Enabled = false;
            this.numCurrentExperiment.Location = new System.Drawing.Point(539, 467);
            this.numCurrentExperiment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurrentExperiment.Name = "numCurrentExperiment";
            this.numCurrentExperiment.Size = new System.Drawing.Size(93, 20);
            this.numCurrentExperiment.TabIndex = 31;
            this.numCurrentExperiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCurrentExperiment.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurrentExperiment.ValueChanged += new System.EventHandler(this.numCurrentExperiment_ValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(332, 467);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Номер текущего эксперимента";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numKX
            // 
            this.numKX.DecimalPlaces = 2;
            this.numKX.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numKX.Location = new System.Drawing.Point(332, 412);
            this.numKX.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numKX.Minimum = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.numKX.Name = "numKX";
            this.numKX.Size = new System.Drawing.Size(69, 20);
            this.numKX.TabIndex = 34;
            this.numKX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numKX.Value = new decimal(new int[] {
            19,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(329, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 38);
            this.label3.TabIndex = 33;
            this.label3.Text = "СКО по X";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numKY
            // 
            this.numKY.DecimalPlaces = 2;
            this.numKY.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.numKY.Location = new System.Drawing.Point(453, 412);
            this.numKY.Maximum = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numKY.Minimum = new decimal(new int[] {
            19,
            0,
            0,
            0});
            this.numKY.Name = "numKY";
            this.numKY.Size = new System.Drawing.Size(69, 20);
            this.numKY.TabIndex = 36;
            this.numKY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numKY.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(450, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 38);
            this.label4.TabIndex = 35;
            this.label4.Text = "СКО по Y";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numKZ
            // 
            this.numKZ.DecimalPlaces = 3;
            this.numKZ.Increment = new decimal(new int[] {
            125,
            0,
            0,
            196608});
            this.numKZ.Location = new System.Drawing.Point(563, 412);
            this.numKZ.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            65536});
            this.numKZ.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numKZ.Name = "numKZ";
            this.numKZ.Size = new System.Drawing.Size(69, 20);
            this.numKZ.TabIndex = 38;
            this.numKZ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numKZ.Value = new decimal(new int[] {
            225,
            0,
            0,
            131072});
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(560, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 38);
            this.label6.TabIndex = 37;
            this.label6.Text = "СКО по Z";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 661);
            this.Controls.Add(this.numKZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numKY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numKX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numCurrentExperiment);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.numExperiments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonShoot);
            this.Controls.Add(this.numDrob);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonGenerate);
            this.Controls.Add(this.pbYZ);
            this.Controls.Add(this.pbXZ);
            this.Controls.Add(this.pbXY);
            this.MaximumSize = new System.Drawing.Size(670, 700);
            this.MinimumSize = new System.Drawing.Size(670, 700);
            this.Name = "MainForm";
            this.Text = "Shotgun Modeler";
            ((System.ComponentModel.ISupportInitialize)(this.pbXY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYZ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrob)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentExperiment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numKZ)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbXY;
        private System.Windows.Forms.PictureBox pbXZ;
        private System.Windows.Forms.PictureBox pbYZ;
        private System.Windows.Forms.Button buttonGenerate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numDrob;
        private System.Windows.Forms.Button buttonShoot;
        private System.Windows.Forms.NumericUpDown numExperiments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.NumericUpDown numCurrentExperiment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numKX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numKY;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numKZ;
        private System.Windows.Forms.Label label6;
    }
}

