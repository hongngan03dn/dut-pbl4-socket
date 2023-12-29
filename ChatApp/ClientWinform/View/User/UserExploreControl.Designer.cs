namespace ClientWinform.View.User
{
    partial class UserExploreControl
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
            this.lableName = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.picAva = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.White;
            this.panelMain.Controls.Add(this.lableName);
            this.panelMain.Controls.Add(this.labelUsername);
            this.panelMain.Controls.Add(this.picAva);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(456, 64);
            this.panelMain.TabIndex = 8;
            // 
            // lableName
            // 
            this.lableName.AutoSize = true;
            this.lableName.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lableName.Location = new System.Drawing.Point(90, 39);
            this.lableName.Name = "lableName";
            this.lableName.Size = new System.Drawing.Size(45, 19);
            this.lableName.TabIndex = 5;
            this.lableName.Text = "Name";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.labelUsername.Location = new System.Drawing.Point(89, 8);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(87, 23);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            // 
            // picAva
            // 
            this.picAva.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picAva.ImageRotate = 0F;
            this.picAva.Location = new System.Drawing.Point(20, 10);
            this.picAva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picAva.Name = "picAva";
            this.picAva.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.picAva.Size = new System.Drawing.Size(53, 48);
            this.picAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAva.TabIndex = 3;
            this.picAva.TabStop = false;
            // 
            // UserExploreControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UserExploreControl";
            this.Size = new System.Drawing.Size(456, 64);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label lableName;
        private System.Windows.Forms.Label labelUsername;
        private Guna.UI2.WinForms.Guna2CirclePictureBox picAva;
    }
}
