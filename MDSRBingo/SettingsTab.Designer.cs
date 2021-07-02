namespace MDSRBingo
{
    partial class SettingsTab
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
            this.fontColorPicker = new System.Windows.Forms.Button();
            this.fontDisplayColor = new System.Windows.Forms.TextBox();
            this.boardColorPicker = new System.Windows.Forms.Button();
            this.boardDisplayColor = new System.Windows.Forms.TextBox();
            this.tileColorPicker = new System.Windows.Forms.Button();
            this.tileDisplayColor = new System.Windows.Forms.TextBox();
            this.applySettings = new System.Windows.Forms.Button();
            this.resetSettings = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // fontColorPicker
            // 
            this.fontColorPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontColorPicker.Location = new System.Drawing.Point(12, 108);
            this.fontColorPicker.Name = "fontColorPicker";
            this.fontColorPicker.Size = new System.Drawing.Size(122, 42);
            this.fontColorPicker.TabIndex = 7;
            this.fontColorPicker.Text = "Font Color";
            this.fontColorPicker.UseVisualStyleBackColor = true;
            this.fontColorPicker.Click += new System.EventHandler(this.fontColorPicker_Click);
            // 
            // fontDisplayColor
            // 
            this.fontDisplayColor.BackColor = System.Drawing.SystemColors.Control;
            this.fontDisplayColor.Enabled = false;
            this.fontDisplayColor.Location = new System.Drawing.Point(140, 108);
            this.fontDisplayColor.Multiline = true;
            this.fontDisplayColor.Name = "fontDisplayColor";
            this.fontDisplayColor.Size = new System.Drawing.Size(171, 42);
            this.fontDisplayColor.TabIndex = 8;
            // 
            // boardColorPicker
            // 
            this.boardColorPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boardColorPicker.Location = new System.Drawing.Point(12, 60);
            this.boardColorPicker.Name = "boardColorPicker";
            this.boardColorPicker.Size = new System.Drawing.Size(122, 42);
            this.boardColorPicker.TabIndex = 9;
            this.boardColorPicker.Text = "Board Color";
            this.boardColorPicker.UseVisualStyleBackColor = true;
            this.boardColorPicker.Click += new System.EventHandler(this.boardColorPicker_Click);
            // 
            // boardDisplayColor
            // 
            this.boardDisplayColor.BackColor = System.Drawing.SystemColors.Control;
            this.boardDisplayColor.Enabled = false;
            this.boardDisplayColor.Location = new System.Drawing.Point(140, 60);
            this.boardDisplayColor.Multiline = true;
            this.boardDisplayColor.Name = "boardDisplayColor";
            this.boardDisplayColor.Size = new System.Drawing.Size(171, 42);
            this.boardDisplayColor.TabIndex = 10;
            // 
            // tileColorPicker
            // 
            this.tileColorPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tileColorPicker.Location = new System.Drawing.Point(12, 12);
            this.tileColorPicker.Name = "tileColorPicker";
            this.tileColorPicker.Size = new System.Drawing.Size(122, 42);
            this.tileColorPicker.TabIndex = 11;
            this.tileColorPicker.Text = "Tile Color";
            this.tileColorPicker.UseVisualStyleBackColor = true;
            this.tileColorPicker.Click += new System.EventHandler(this.tileColorPicker_Click);
            // 
            // tileDisplayColor
            // 
            this.tileDisplayColor.BackColor = System.Drawing.SystemColors.Control;
            this.tileDisplayColor.Enabled = false;
            this.tileDisplayColor.Location = new System.Drawing.Point(140, 12);
            this.tileDisplayColor.Multiline = true;
            this.tileDisplayColor.Name = "tileDisplayColor";
            this.tileDisplayColor.Size = new System.Drawing.Size(171, 42);
            this.tileDisplayColor.TabIndex = 12;
            // 
            // applySettings
            // 
            this.applySettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applySettings.Location = new System.Drawing.Point(12, 199);
            this.applySettings.Name = "applySettings";
            this.applySettings.Size = new System.Drawing.Size(299, 42);
            this.applySettings.TabIndex = 13;
            this.applySettings.Text = "Apply";
            this.applySettings.UseVisualStyleBackColor = true;
            this.applySettings.Click += new System.EventHandler(this.applySettings_Click);
            // 
            // resetSettings
            // 
            this.resetSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetSettings.Location = new System.Drawing.Point(12, 247);
            this.resetSettings.Name = "resetSettings";
            this.resetSettings.Size = new System.Drawing.Size(299, 42);
            this.resetSettings.TabIndex = 14;
            this.resetSettings.Text = "Reset";
            this.resetSettings.UseVisualStyleBackColor = true;
            this.resetSettings.Click += new System.EventHandler(this.resetSettings_Click);
            // 
            // SettingsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 301);
            this.Controls.Add(this.resetSettings);
            this.Controls.Add(this.applySettings);
            this.Controls.Add(this.tileDisplayColor);
            this.Controls.Add(this.tileColorPicker);
            this.Controls.Add(this.boardDisplayColor);
            this.Controls.Add(this.boardColorPicker);
            this.Controls.Add(this.fontDisplayColor);
            this.Controls.Add(this.fontColorPicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsTab";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.SettingsTab_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fontColorPicker;
        private System.Windows.Forms.TextBox fontDisplayColor;
        private System.Windows.Forms.Button boardColorPicker;
        private System.Windows.Forms.TextBox boardDisplayColor;
        private System.Windows.Forms.Button tileColorPicker;
        private System.Windows.Forms.TextBox tileDisplayColor;
        private System.Windows.Forms.Button applySettings;
        private System.Windows.Forms.Button resetSettings;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}