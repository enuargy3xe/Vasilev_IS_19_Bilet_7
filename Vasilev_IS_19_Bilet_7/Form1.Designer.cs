﻿namespace Vasilev_IS_19_Bilet_7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.perfomanceSelector = new System.Windows.Forms.ComboBox();
            this.VipRB = new System.Windows.Forms.RadioButton();
            this.ParterRB = new System.Windows.Forms.RadioButton();
            this.BalconRB = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.outPutLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.confirmReceipButton = new System.Windows.Forms.Button();
            this.amountInput = new System.Windows.Forms.NumericUpDown();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Представления";
            // 
            // perfomanceSelector
            // 
            this.perfomanceSelector.FormattingEnabled = true;
            this.perfomanceSelector.Location = new System.Drawing.Point(11, 101);
            this.perfomanceSelector.Name = "perfomanceSelector";
            this.perfomanceSelector.Size = new System.Drawing.Size(121, 21);
            this.perfomanceSelector.TabIndex = 1;
            this.perfomanceSelector.SelectedIndexChanged += new System.EventHandler(this.perfomanceSelector_SelectedIndexChanged);
            // 
            // VipRB
            // 
            this.VipRB.AutoSize = true;
            this.VipRB.Location = new System.Drawing.Point(11, 141);
            this.VipRB.Name = "VipRB";
            this.VipRB.Size = new System.Drawing.Size(42, 17);
            this.VipRB.TabIndex = 2;
            this.VipRB.TabStop = true;
            this.VipRB.Text = "VIP";
            this.VipRB.UseVisualStyleBackColor = true;
            this.VipRB.CheckedChanged += new System.EventHandler(this.VipRB_CheckedChanged);
            // 
            // ParterRB
            // 
            this.ParterRB.AutoSize = true;
            this.ParterRB.Location = new System.Drawing.Point(10, 174);
            this.ParterRB.Name = "ParterRB";
            this.ParterRB.Size = new System.Drawing.Size(62, 17);
            this.ParterRB.TabIndex = 3;
            this.ParterRB.TabStop = true;
            this.ParterRB.Text = "Партер";
            this.ParterRB.UseVisualStyleBackColor = true;
            this.ParterRB.CheckedChanged += new System.EventHandler(this.ParterRB_CheckedChanged);
            // 
            // BalconRB
            // 
            this.BalconRB.AutoSize = true;
            this.BalconRB.Location = new System.Drawing.Point(11, 206);
            this.BalconRB.Name = "BalconRB";
            this.BalconRB.Size = new System.Drawing.Size(62, 17);
            this.BalconRB.TabIndex = 4;
            this.BalconRB.TabStop = true;
            this.BalconRB.Text = "Балкон";
            this.BalconRB.UseVisualStyleBackColor = true;
            this.BalconRB.CheckedChanged += new System.EventHandler(this.BalconRB_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 254);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Количество";
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(11, 297);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(121, 23);
            this.calculateButton.TabIndex = 7;
            this.calculateButton.Text = "Расчет";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // outPutLabel
            // 
            this.outPutLabel.AutoSize = true;
            this.outPutLabel.Location = new System.Drawing.Point(11, 327);
            this.outPutLabel.Name = "outPutLabel";
            this.outPutLabel.Size = new System.Drawing.Size(155, 13);
            this.outPutLabel.TabIndex = 8;
            this.outPutLabel.Text = "Вывод информации о сеансе";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(161, 84);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 183);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(199, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(189, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Добавить афишу";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // confirmReceipButton
            // 
            this.confirmReceipButton.Location = new System.Drawing.Point(14, 375);
            this.confirmReceipButton.Name = "confirmReceipButton";
            this.confirmReceipButton.Size = new System.Drawing.Size(173, 32);
            this.confirmReceipButton.TabIndex = 11;
            this.confirmReceipButton.Text = "Оформить квитанцию";
            this.confirmReceipButton.UseVisualStyleBackColor = true;
            this.confirmReceipButton.Click += new System.EventHandler(this.confirmReceipButton_Click);
            // 
            // amountInput
            // 
            this.amountInput.Location = new System.Drawing.Point(10, 271);
            this.amountInput.Name = "amountInput";
            this.amountInput.Size = new System.Drawing.Size(120, 20);
            this.amountInput.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(4, -1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 82);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.Location = new System.Drawing.Point(1, -1);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(443, 82);
            this.label3.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(108, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 34);
            this.label4.TabIndex = 15;
            this.label4.Text = "Т Е А Т Р";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 415);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.amountInput);
            this.Controls.Add(this.confirmReceipButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.outPutLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BalconRB);
            this.Controls.Add(this.ParterRB);
            this.Controls.Add(this.VipRB);
            this.Controls.Add(this.perfomanceSelector);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Театр";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amountInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox perfomanceSelector;
        private System.Windows.Forms.RadioButton VipRB;
        private System.Windows.Forms.RadioButton ParterRB;
        private System.Windows.Forms.RadioButton BalconRB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label outPutLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button confirmReceipButton;
        private System.Windows.Forms.NumericUpDown amountInput;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

