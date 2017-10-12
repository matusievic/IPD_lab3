namespace BatteryInfo
{
    partial class BatteryInfoForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.chargeLevelLabel = new System.Windows.Forms.Label();
            this.connectionTypeTextLabel = new System.Windows.Forms.Label();
            this.connectionTypeLabel = new System.Windows.Forms.Label();
            this.chargeLevelTextLabel = new System.Windows.Forms.Label();
            this.remainingTimeTextLabel = new System.Windows.Forms.Label();
            this.remainingTimeLabel = new System.Windows.Forms.Label();
            this.turnOffTextLabel = new System.Windows.Forms.Label();
            this.turnOffTimeComboBox = new System.Windows.Forms.ComboBox();
            this.secLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chargeLevelLabel
            // 
            this.chargeLevelLabel.AutoSize = true;
            this.chargeLevelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chargeLevelLabel.Location = new System.Drawing.Point(199, 47);
            this.chargeLevelLabel.Name = "chargeLevelLabel";
            this.chargeLevelLabel.Size = new System.Drawing.Size(30, 25);
            this.chargeLevelLabel.TabIndex = 0;
            this.chargeLevelLabel.Text = "...";
            // 
            // connectionTypeTextLabel
            // 
            this.connectionTypeTextLabel.AutoSize = true;
            this.connectionTypeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionTypeTextLabel.Location = new System.Drawing.Point(12, 22);
            this.connectionTypeTextLabel.Name = "connectionTypeTextLabel";
            this.connectionTypeTextLabel.Size = new System.Drawing.Size(181, 25);
            this.connectionTypeTextLabel.TabIndex = 1;
            this.connectionTypeTextLabel.Text = "Connection Type:";
            // 
            // connectionTypeLabel
            // 
            this.connectionTypeLabel.AutoSize = true;
            this.connectionTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.connectionTypeLabel.Location = new System.Drawing.Point(199, 22);
            this.connectionTypeLabel.Name = "connectionTypeLabel";
            this.connectionTypeLabel.Size = new System.Drawing.Size(30, 25);
            this.connectionTypeLabel.TabIndex = 2;
            this.connectionTypeLabel.Text = "...";
            // 
            // chargeLevelTextLabel
            // 
            this.chargeLevelTextLabel.AutoSize = true;
            this.chargeLevelTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chargeLevelTextLabel.Location = new System.Drawing.Point(12, 47);
            this.chargeLevelTextLabel.Name = "chargeLevelTextLabel";
            this.chargeLevelTextLabel.Size = new System.Drawing.Size(146, 25);
            this.chargeLevelTextLabel.TabIndex = 3;
            this.chargeLevelTextLabel.Text = "Charge Level:";
            // 
            // remainingTimeTextLabel
            // 
            this.remainingTimeTextLabel.AutoSize = true;
            this.remainingTimeTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainingTimeTextLabel.Location = new System.Drawing.Point(12, 72);
            this.remainingTimeTextLabel.Name = "remainingTimeTextLabel";
            this.remainingTimeTextLabel.Size = new System.Drawing.Size(173, 25);
            this.remainingTimeTextLabel.TabIndex = 4;
            this.remainingTimeTextLabel.Text = "Remaining Time:";
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.remainingTimeLabel.Location = new System.Drawing.Point(199, 72);
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(30, 25);
            this.remainingTimeLabel.TabIndex = 5;
            this.remainingTimeLabel.Text = "...";
            // 
            // turnOffTextLabel
            // 
            this.turnOffTextLabel.AutoSize = true;
            this.turnOffTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.turnOffTextLabel.Location = new System.Drawing.Point(14, 122);
            this.turnOffTextLabel.Name = "turnOffTextLabel";
            this.turnOffTextLabel.Size = new System.Drawing.Size(159, 40);
            this.turnOffTextLabel.TabIndex = 6;
            this.turnOffTextLabel.Text = "Turn off the screen in\r\nbattery mode after";
            // 
            // turnOffTimeComboBox
            // 
            this.turnOffTimeComboBox.FormattingEnabled = true;
            this.turnOffTimeComboBox.Items.AddRange(new object[] {
            "10",
            "20",
            "30",
            "45",
            "60",
            "120",
            "180",
            "300",
            "600",
            "900"});
            this.turnOffTimeComboBox.Location = new System.Drawing.Point(179, 141);
            this.turnOffTimeComboBox.Name = "turnOffTimeComboBox";
            this.turnOffTimeComboBox.Size = new System.Drawing.Size(121, 21);
            this.turnOffTimeComboBox.TabIndex = 7;
            this.turnOffTimeComboBox.SelectedIndexChanged += new System.EventHandler(this.turnOffTimeComboBox_SelectedIndexChanged);
            // 
            // secLabel
            // 
            this.secLabel.AutoSize = true;
            this.secLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secLabel.Location = new System.Drawing.Point(306, 142);
            this.secLabel.Name = "secLabel";
            this.secLabel.Size = new System.Drawing.Size(34, 20);
            this.secLabel.TabIndex = 8;
            this.secLabel.Text = "sec";
            // 
            // BatteryInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 181);
            this.Controls.Add(this.secLabel);
            this.Controls.Add(this.turnOffTimeComboBox);
            this.Controls.Add(this.turnOffTextLabel);
            this.Controls.Add(this.remainingTimeLabel);
            this.Controls.Add(this.remainingTimeTextLabel);
            this.Controls.Add(this.chargeLevelTextLabel);
            this.Controls.Add(this.connectionTypeLabel);
            this.Controls.Add(this.connectionTypeTextLabel);
            this.Controls.Add(this.chargeLevelLabel);
            this.Name = "BatteryInfoForm";
            this.Text = "BatteryInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.BatteryInfoForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chargeLevelLabel;
        private System.Windows.Forms.Label connectionTypeTextLabel;
        private System.Windows.Forms.Label connectionTypeLabel;
        private System.Windows.Forms.Label chargeLevelTextLabel;
        private System.Windows.Forms.Label remainingTimeTextLabel;
        private System.Windows.Forms.Label remainingTimeLabel;
        private System.Windows.Forms.Label turnOffTextLabel;
        private System.Windows.Forms.ComboBox turnOffTimeComboBox;
        private System.Windows.Forms.Label secLabel;
    }
}

