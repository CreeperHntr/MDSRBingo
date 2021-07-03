
namespace MDSRBingo
{
    partial class CreditsTab
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
            this.mdsr = new System.Windows.Forms.Label();
            this.mdsrDiscord = new System.Windows.Forms.Button();
            this.mdsrTwitch = new System.Windows.Forms.Button();
            this.mdsrYT = new System.Windows.Forms.Button();
            this.mdsrPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.creeperTwitch = new System.Windows.Forms.Button();
            this.creeperYT = new System.Windows.Forms.Button();
            this.creeper = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.metaTwitch = new System.Windows.Forms.Button();
            this.metaYT = new System.Windows.Forms.Button();
            this.meta = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.quarthTwitch = new System.Windows.Forms.Button();
            this.quarth = new System.Windows.Forms.Label();
            this.creeperTwitter = new System.Windows.Forms.Button();
            this.mdsrPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // mdsr
            // 
            this.mdsr.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdsr.AutoSize = true;
            this.mdsr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdsr.Location = new System.Drawing.Point(3, 0);
            this.mdsr.Name = "mdsr";
            this.mdsr.Size = new System.Drawing.Size(186, 32);
            this.mdsr.TabIndex = 0;
            this.mdsr.Text = "MDSR";
            this.mdsr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mdsrDiscord
            // 
            this.mdsrDiscord.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdsrDiscord.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdsrDiscord.Location = new System.Drawing.Point(3, 35);
            this.mdsrDiscord.Name = "mdsrDiscord";
            this.mdsrDiscord.Size = new System.Drawing.Size(186, 26);
            this.mdsrDiscord.TabIndex = 1;
            this.mdsrDiscord.Text = "Discord";
            this.mdsrDiscord.UseVisualStyleBackColor = true;
            this.mdsrDiscord.Click += new System.EventHandler(this.mdsrDiscord_Click);
            // 
            // mdsrTwitch
            // 
            this.mdsrTwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdsrTwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdsrTwitch.Location = new System.Drawing.Point(3, 67);
            this.mdsrTwitch.Name = "mdsrTwitch";
            this.mdsrTwitch.Size = new System.Drawing.Size(186, 26);
            this.mdsrTwitch.TabIndex = 2;
            this.mdsrTwitch.Text = "Twitch";
            this.mdsrTwitch.UseVisualStyleBackColor = true;
            this.mdsrTwitch.Click += new System.EventHandler(this.mdsrTwitch_Click);
            // 
            // mdsrYT
            // 
            this.mdsrYT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mdsrYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdsrYT.Location = new System.Drawing.Point(3, 99);
            this.mdsrYT.Name = "mdsrYT";
            this.mdsrYT.Size = new System.Drawing.Size(186, 26);
            this.mdsrYT.TabIndex = 3;
            this.mdsrYT.Text = "YouTube";
            this.mdsrYT.UseVisualStyleBackColor = true;
            this.mdsrYT.Click += new System.EventHandler(this.mdsrYT_Click);
            // 
            // mdsrPanel
            // 
            this.mdsrPanel.ColumnCount = 1;
            this.mdsrPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mdsrPanel.Controls.Add(this.mdsrTwitch, 0, 2);
            this.mdsrPanel.Controls.Add(this.mdsrYT, 0, 3);
            this.mdsrPanel.Controls.Add(this.mdsr, 0, 0);
            this.mdsrPanel.Controls.Add(this.mdsrDiscord, 0, 1);
            this.mdsrPanel.Location = new System.Drawing.Point(12, 12);
            this.mdsrPanel.Name = "mdsrPanel";
            this.mdsrPanel.RowCount = 4;
            this.mdsrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mdsrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mdsrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mdsrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.mdsrPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mdsrPanel.Size = new System.Drawing.Size(192, 128);
            this.mdsrPanel.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.creeperTwitter, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.creeper, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.creeperTwitch, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.creeperYT, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(245, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(192, 128);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // creeperTwitch
            // 
            this.creeperTwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creeperTwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creeperTwitch.Location = new System.Drawing.Point(3, 35);
            this.creeperTwitch.Name = "creeperTwitch";
            this.creeperTwitch.Size = new System.Drawing.Size(186, 26);
            this.creeperTwitch.TabIndex = 2;
            this.creeperTwitch.Text = "Twitch";
            this.creeperTwitch.UseVisualStyleBackColor = true;
            this.creeperTwitch.Click += new System.EventHandler(this.creeperTwitch_Click);
            // 
            // creeperYT
            // 
            this.creeperYT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creeperYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creeperYT.Location = new System.Drawing.Point(3, 67);
            this.creeperYT.Name = "creeperYT";
            this.creeperYT.Size = new System.Drawing.Size(186, 26);
            this.creeperYT.TabIndex = 3;
            this.creeperYT.Text = "YouTube";
            this.creeperYT.UseVisualStyleBackColor = true;
            this.creeperYT.Click += new System.EventHandler(this.creeperYT_Click);
            // 
            // creeper
            // 
            this.creeper.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creeper.AutoSize = true;
            this.creeper.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creeper.Location = new System.Drawing.Point(3, 0);
            this.creeper.Name = "creeper";
            this.creeper.Size = new System.Drawing.Size(186, 32);
            this.creeper.TabIndex = 0;
            this.creeper.Text = "CreeperHntr (Dev)";
            this.creeper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.meta, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metaTwitch, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.metaYT, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 172);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(192, 128);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // metaTwitch
            // 
            this.metaTwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metaTwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metaTwitch.Location = new System.Drawing.Point(3, 35);
            this.metaTwitch.Name = "metaTwitch";
            this.metaTwitch.Size = new System.Drawing.Size(186, 26);
            this.metaTwitch.TabIndex = 2;
            this.metaTwitch.Text = "Twitch";
            this.metaTwitch.UseVisualStyleBackColor = true;
            this.metaTwitch.Click += new System.EventHandler(this.metaTwitch_Click);
            // 
            // metaYT
            // 
            this.metaYT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metaYT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metaYT.Location = new System.Drawing.Point(3, 67);
            this.metaYT.Name = "metaYT";
            this.metaYT.Size = new System.Drawing.Size(186, 26);
            this.metaYT.TabIndex = 3;
            this.metaYT.Text = "YouTube";
            this.metaYT.UseVisualStyleBackColor = true;
            this.metaYT.Click += new System.EventHandler(this.metaYT_Click);
            // 
            // meta
            // 
            this.meta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.meta.AutoSize = true;
            this.meta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meta.Location = new System.Drawing.Point(3, 0);
            this.meta.Name = "meta";
            this.meta.Size = new System.Drawing.Size(186, 32);
            this.meta.TabIndex = 0;
            this.meta.Text = "Meta_LIVE (Assets)";
            this.meta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.quarth, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.quarthTwitch, 0, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(245, 172);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(192, 128);
            this.tableLayoutPanel3.TabIndex = 9;
            // 
            // quarthTwitch
            // 
            this.quarthTwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quarthTwitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarthTwitch.Location = new System.Drawing.Point(3, 35);
            this.quarthTwitch.Name = "quarthTwitch";
            this.quarthTwitch.Size = new System.Drawing.Size(186, 26);
            this.quarthTwitch.TabIndex = 2;
            this.quarthTwitch.Text = "Twitch";
            this.quarthTwitch.UseVisualStyleBackColor = true;
            this.quarthTwitch.Click += new System.EventHandler(this.quarthTwitch_Click);
            // 
            // quarth
            // 
            this.quarth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.quarth.AutoSize = true;
            this.quarth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarth.Location = new System.Drawing.Point(3, 0);
            this.quarth.Name = "quarth";
            this.quarth.Size = new System.Drawing.Size(186, 32);
            this.quarth.TabIndex = 0;
            this.quarth.Text = "Quarth234 (QA)";
            this.quarth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // creeperTwitter
            // 
            this.creeperTwitter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.creeperTwitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creeperTwitter.Location = new System.Drawing.Point(3, 99);
            this.creeperTwitter.Name = "creeperTwitter";
            this.creeperTwitter.Size = new System.Drawing.Size(186, 26);
            this.creeperTwitter.TabIndex = 10;
            this.creeperTwitter.Text = "Twitter";
            this.creeperTwitter.UseVisualStyleBackColor = true;
            this.creeperTwitter.Click += new System.EventHandler(this.creeperTwitter_Click);
            // 
            // CreditsTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 312);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.mdsrPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditsTab";
            this.Text = "Credits";
            this.mdsrPanel.ResumeLayout(false);
            this.mdsrPanel.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mdsr;
        private System.Windows.Forms.Button mdsrDiscord;
        private System.Windows.Forms.Button mdsrTwitch;
        private System.Windows.Forms.Button mdsrYT;
        private System.Windows.Forms.TableLayoutPanel mdsrPanel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label creeper;
        private System.Windows.Forms.Button creeperTwitch;
        private System.Windows.Forms.Button creeperYT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label meta;
        private System.Windows.Forms.Button metaTwitch;
        private System.Windows.Forms.Button metaYT;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label quarth;
        private System.Windows.Forms.Button quarthTwitch;
        private System.Windows.Forms.Button creeperTwitter;
    }
}