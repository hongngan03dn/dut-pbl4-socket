
namespace ClientWinform.View.User
{
    partial class ChatListForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanelListChat = new System.Windows.Forms.FlowLayoutPanel();
            this.panelChatContentAndLeftLine = new System.Windows.Forms.Panel();
            this.panelChatContent = new System.Windows.Forms.Panel();
            this.pictureBoxNoChatSelected = new System.Windows.Forms.PictureBox();
            this.panelLineLeft = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelChatContentAndLeftLine.SuspendLayout();
            this.panelChatContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoChatSelected)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.tableLayoutPanelMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1566, 1024);
            this.panelMain.TabIndex = 0;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelChatContentAndLeftLine, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1566, 1024);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.searchTxt, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanelListChat, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.714844F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.28516F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(375, 1024);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTxt.AutoRoundedCorners = true;
            this.searchTxt.BorderColor = System.Drawing.Color.Black;
            this.searchTxt.BorderRadius = 25;
            this.searchTxt.BorderThickness = 0;
            this.searchTxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTxt.DefaultText = "";
            this.searchTxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTxt.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.searchTxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxt.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.searchTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.searchTxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTxt.IconLeft = global::ClientWinform.Properties.Resources.Untitled__1_;
            this.searchTxt.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.searchTxt.IconLeftSize = new System.Drawing.Size(22, 22);
            this.searchTxt.Location = new System.Drawing.Point(8, 13);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(0);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.SelectedText = "";
            this.searchTxt.Size = new System.Drawing.Size(358, 52);
            this.searchTxt.TabIndex = 12;
            // 
            // flowLayoutPanelListChat
            // 
            this.flowLayoutPanelListChat.AutoScroll = true;
            this.flowLayoutPanelListChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelListChat.Location = new System.Drawing.Point(0, 79);
            this.flowLayoutPanelListChat.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelListChat.Name = "flowLayoutPanelListChat";
            this.flowLayoutPanelListChat.Size = new System.Drawing.Size(375, 945);
            this.flowLayoutPanelListChat.TabIndex = 3;
            // 
            // panelChatContentAndLeftLine
            // 
            this.panelChatContentAndLeftLine.Controls.Add(this.panelChatContent);
            this.panelChatContentAndLeftLine.Controls.Add(this.panelLineLeft);
            this.panelChatContentAndLeftLine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatContentAndLeftLine.Location = new System.Drawing.Point(375, 0);
            this.panelChatContentAndLeftLine.Margin = new System.Windows.Forms.Padding(0);
            this.panelChatContentAndLeftLine.Name = "panelChatContentAndLeftLine";
            this.panelChatContentAndLeftLine.Size = new System.Drawing.Size(1191, 1024);
            this.panelChatContentAndLeftLine.TabIndex = 1;
            // 
            // panelChatContent
            // 
            this.panelChatContent.Controls.Add(this.pictureBoxNoChatSelected);
            this.panelChatContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChatContent.Location = new System.Drawing.Point(1, 0);
            this.panelChatContent.Name = "panelChatContent";
            this.panelChatContent.Size = new System.Drawing.Size(1190, 1024);
            this.panelChatContent.TabIndex = 2;
            // 
            // pictureBoxNoChatSelected
            // 
            this.pictureBoxNoChatSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxNoChatSelected.Image = global::ClientWinform.Properties.Resources.Chat_content__1_;
            this.pictureBoxNoChatSelected.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxNoChatSelected.Name = "pictureBoxNoChatSelected";
            this.pictureBoxNoChatSelected.Size = new System.Drawing.Size(1190, 1024);
            this.pictureBoxNoChatSelected.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxNoChatSelected.TabIndex = 2;
            this.pictureBoxNoChatSelected.TabStop = false;
            // 
            // panelLineLeft
            // 
            this.panelLineLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.panelLineLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLineLeft.Location = new System.Drawing.Point(0, 0);
            this.panelLineLeft.Margin = new System.Windows.Forms.Padding(0);
            this.panelLineLeft.Name = "panelLineLeft";
            this.panelLineLeft.Size = new System.Drawing.Size(1, 1024);
            this.panelLineLeft.TabIndex = 1;
            // 
            // ChatListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1566, 1024);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatListForm";
            this.Text = "ChatListForm";
            this.panelMain.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panelChatContentAndLeftLine.ResumeLayout(false);
            this.panelChatContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxNoChatSelected)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private System.Windows.Forms.Panel panelLineLeft;
        private System.Windows.Forms.Panel panelChatContentAndLeftLine;
        private System.Windows.Forms.Panel panelChatContent;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListChat;
        private System.Windows.Forms.PictureBox pictureBoxNoChatSelected;
    }
}