
namespace ClientWinform.View.User
{
    partial class ChatContentForm
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
            this.panelMain = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.messageTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.backBtn = new Guna.UI2.WinForms.Guna2CircleButton();
            this.panelChatMessage = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1190, 1024);
            this.panelMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.messageTxt, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelChatMessage, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.35955F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.64045F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1190, 1024);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // messageTxt
            // 
            this.messageTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.messageTxt.AutoRoundedCorners = true;
            this.messageTxt.BorderColor = System.Drawing.Color.Black;
            this.messageTxt.BorderRadius = 29;
            this.messageTxt.BorderThickness = 0;
            this.messageTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.messageTxt.DefaultText = "";
            this.messageTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.messageTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.messageTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.messageTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.messageTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.messageTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.messageTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.messageTxt.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.messageTxt.IconLeftSize = new System.Drawing.Size(22, 22);
            this.messageTxt.IconRight = global::ClientWinform.Properties.Resources.paperclip;
            this.messageTxt.IconRightOffset = new System.Drawing.Point(15, 0);
            this.messageTxt.IconRightSize = new System.Drawing.Size(25, 25);
            this.messageTxt.Location = new System.Drawing.Point(0, 926);
            this.messageTxt.Margin = new System.Windows.Forms.Padding(0);
            this.messageTxt.Name = "messageTxt";
            this.messageTxt.PasswordChar = '\0';
            this.messageTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.messageTxt.PlaceholderText = "Type a message...";
            this.messageTxt.SelectedText = "";
            this.messageTxt.Size = new System.Drawing.Size(1190, 61);
            this.messageTxt.TabIndex = 13;
            this.messageTxt.IconRightClick += new System.EventHandler(this.messageTxt_IconRightClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panel1.Controls.Add(this.labelUsername);
            this.panel1.Controls.Add(this.backBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 110);
            this.panel1.TabIndex = 0;
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.labelUsername.Location = new System.Drawing.Point(103, 34);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(83, 38);
            this.labelUsername.TabIndex = 6;
            this.labelUsername.Text = "hona";
            this.labelUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backBtn
            // 
            this.backBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.backBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.backBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.backBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.backBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.backBtn.ForeColor = System.Drawing.Color.White;
            this.backBtn.Image = global::ClientWinform.Properties.Resources.Untitled__2_;
            this.backBtn.Location = new System.Drawing.Point(29, 30);
            this.backBtn.Name = "backBtn";
            this.backBtn.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.backBtn.Size = new System.Drawing.Size(50, 50);
            this.backBtn.TabIndex = 0;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // panelChatMessage
            // 
            this.panelChatMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatMessage.Location = new System.Drawing.Point(0, 110);
            this.panelChatMessage.Margin = new System.Windows.Forms.Padding(0);
            this.panelChatMessage.Name = "panelChatMessage";
            this.panelChatMessage.Size = new System.Drawing.Size(1190, 780);
            this.panelChatMessage.TabIndex = 1;
            // 
            // ChatContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1190, 1024);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatContentForm";
            this.Text = "ChatContentForm";
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CircleButton backBtn;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelChatMessage;
        private Guna.UI2.WinForms.Guna2TextBox messageTxt;
    }
}