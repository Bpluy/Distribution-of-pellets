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
            this.buttonShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbXY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbXZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbYZ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDrob)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numExperiments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numCurrentExperiment)).BeginInit();
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
            this.buttonGenerate.Location = new System.Drawing.Point(332, 405);
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
            this.numDrob.Size = new System.Drawing.Size(197, 20);
            this.numDrob.TabIndex = 15;
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
            this.numExperiments.Location = new System.Drawing.Point(435, 375);
            this.numExperiments.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numExperiments.Name = "numExperiments";
            this.numExperiments.Size = new System.Drawing.Size(197, 20);
            this.numExperiments.TabIndex = 26;
            this.numExperiments.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(329, 364);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 38);
            this.label1.TabIndex = 25;
            this.label1.Text = "Количество испытаний";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelInfo
            // 
            this.labelInfo.Location = new System.Drawing.Point(329, 471);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(302, 126);
            this.labelInfo.TabIndex = 30;
            this.labelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // numCurrentExperiment
            // 
            this.numCurrentExperiment.Enabled = false;
            this.numCurrentExperiment.Location = new System.Drawing.Point(332, 442);
            this.numCurrentExperiment.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numCurrentExperiment.Name = "numCurrentExperiment";
            this.numCurrentExperiment.Size = new System.Drawing.Size(53, 20);
            this.numCurrentExperiment.TabIndex = 31;
            this.numCurrentExperiment.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numCurrentExperiment.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // buttonShow
            // 
            this.buttonShow.Enabled = false;
            this.buttonShow.Location = new System.Drawing.Point(392, 442);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(239, 23);
            this.buttonShow.TabIndex = 32;
            this.buttonShow.Text = "Показать";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.Click += new System.EventHandler(this.buttonShow_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 661);
            this.Controls.Add(this.buttonShow);
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
        private System.Windows.Forms.Button buttonShow;
    }
}

