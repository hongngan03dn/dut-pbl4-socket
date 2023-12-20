namespace ClientWinform.View.User
{
    partial class ChatReviewForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMain = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.pictureBoxOnline = new System.Windows.Forms.PictureBox();
            this.picAva = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.labelTime);
            this.panelMain.Controls.Add(this.labelMessage);
            this.panelMain.Controls.Add(this.labelUsername);
            this.panelMain.Controls.Add(this.pictureBoxOnline);
            this.panelMain.Controls.Add(this.picAva);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(432, 64);
            this.panelMain.TabIndex = 7;
            this.panelMain.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMain_MouseClick);
            this.panelMain.MouseEnter += new System.EventHandler(this.panelMain_MouseEnter);
            this.panelMain.MouseLeave += new System.EventHandler(this.panelMain_MouseLeave);
            this.panelMain.MouseHover += new System.EventHandler(this.panelMain_MouseHover);
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.labelTime.Location = new System.Drawing.Point(332, 11);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 19);
            this.labelTime.TabIndex = 7;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.labelMessage.Location = new System.Drawing.Point(92, 39);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(63, 19);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Message";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.labelUsername.Location = new System.Drawing.Point(91, 8);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 23);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // pictureBoxOnline
            // 
            this.pictureBoxOnline.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxOnline.Image = global::ClientWinform.Properties.Resources.OnlineIcon;
            this.pictureBoxOnline.Location = new System.Drawing.Point(67, 43);
            this.pictureBoxOnline.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxOnline.Name = "pictureBoxOnline";
            this.pictureBoxOnline.Size = new System.Drawing.Size(14, 13);
            this.pictureBoxOnline.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOnline.TabIndex = 6;
            this.pictureBoxOnline.TabStop = false;
            this.pictureBoxOnline.Visible = false;
            // 
            // picAva
            // 
            this.picAva.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAva.ImageRotate = 0F;
            this.picAva.Location = new System.Drawing.Point(24, 8);
            this.picAva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAva.Name = "picAva";
            this.picAva.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAva.Size = new System.Drawing.Size(53, 48);
            this.picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAva.TabIndex = 3;
            this.picAva.TabStop = false;
            // 
            // ChatReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ChatReviewForm";
            this.Size = new System.Drawing.Size(432, 64);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOnline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAva;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.PictureBox pictureBoxOnline;
        private System.Windows.Forms.Label labelTime;
    }
}
