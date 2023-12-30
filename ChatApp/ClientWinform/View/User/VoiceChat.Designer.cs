namespace ClientWinform.View.User
{
    partial class VoiceChat
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
            this.btnStartRecord = new System.Windows.Forms.Button();
            this.btnEndRecord = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStartRecord
            // 
            this.btnStartRecord.Location = new System.Drawing.Point(28, 24);
            this.btnStartRecord.Name = "btnStartRecord";
            this.btnStartRecord.Size = new System.Drawing.Size(75, 23);
            this.btnStartRecord.TabIndex = 0;
            this.btnStartRecord.Text = "Start Record";
            this.btnStartRecord.UseVisualStyleBackColor = true;
            this.btnStartRecord.Click += new System.EventHandler(this.btnStartRecord_Click);
            // 
            // btnEndRecord
            // 
            this.btnEndRecord.Location = new System.Drawing.Point(28, 96);
            this.btnEndRecord.Name = "btnEndRecord";
            this.btnEndRecord.Size = new System.Drawing.Size(75, 23);
            this.btnEndRecord.TabIndex = 1;
            this.btnEndRecord.Text = "End";
            this.btnEndRecord.UseVisualStyleBackColor = true;
            this.btnEndRecord.Click += new System.EventHandler(this.btnEndRecord_Click);
            // 
            // VoiceChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 185);
            this.Controls.Add(this.btnEndRecord);
            this.Controls.Add(this.btnStartRecord);
            this.Name = "VoiceChat";
            this.Text = "VoiceChat";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartRecord;
        private System.Windows.Forms.Button btnEndRecord;
    }
}