namespace Zoo.TigerEnclosure.App
{
    partial class EnclosureForm
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
            this.TigerPictureBox = new System.Windows.Forms.PictureBox();
            this.FeedButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TigerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TigerPictureBox
            // 
            this.TigerPictureBox.Image = global::Zoo.TigerEnclosure.App.Properties.Resources.tiger;
            this.TigerPictureBox.Location = new System.Drawing.Point(624, 195);
            this.TigerPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.TigerPictureBox.Name = "TigerPictureBox";
            this.TigerPictureBox.Size = new System.Drawing.Size(131, 211);
            this.TigerPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TigerPictureBox.TabIndex = 0;
            this.TigerPictureBox.TabStop = false;
            // 
            // FeedButton
            // 
            this.FeedButton.Location = new System.Drawing.Point(230, 260);
            this.FeedButton.Margin = new System.Windows.Forms.Padding(0);
            this.FeedButton.Name = "FeedButton";
            this.FeedButton.Size = new System.Drawing.Size(126, 59);
            this.FeedButton.TabIndex = 1;
            this.FeedButton.Text = "Feed";
            this.FeedButton.UseVisualStyleBackColor = true;
            this.FeedButton.Click += new System.EventHandler(this.FeedButton_Click);
            // 
            // EnclosureForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 550);
            this.Controls.Add(this.FeedButton);
            this.Controls.Add(this.TigerPictureBox);
            this.Name = "EnclosureForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tiger Enclosure";
            this.Resize += new System.EventHandler(this.EnclosureForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.TigerPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TigerPictureBox;
        private System.Windows.Forms.Button FeedButton;
    }
}

