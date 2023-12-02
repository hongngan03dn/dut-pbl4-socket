
namespace ClientWinform
{
    partial class NavigationForm
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
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelNavigation = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMenu = new System.Windows.Forms.TableLayoutPanel();
            this.panelBtn = new System.Windows.Forms.Panel();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.chatBtn = new Guna.UI2.WinForms.Guna2Button();
            this.exploreBtn = new Guna.UI2.WinForms.Guna2Button();
            this.profileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureAva = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lableUsername = new System.Windows.Forms.Label();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelExplore = new System.Windows.Forms.Panel();
            this.tableLayoutPanelExplore = new System.Windows.Forms.TableLayoutPanel();
            this.searchTxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.flowLayoutPanelListExplore = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureAva)).BeginInit();
            this.panelControlBox.SuspendLayout();
            this.panelChild.SuspendLayout();
            this.panelExplore.SuspendLayout();
            this.tableLayoutPanelExplore.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanelMain.Controls.Add(this.panelNavigation, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelChild, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1047, 629);
            this.tableLayoutPanelMain.TabIndex = 0;
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.panelNavigation.BackgroundImage = global::ClientWinform.Properties.Resources.Control_bar;
            this.panelNavigation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelNavigation.Controls.Add(this.tableLayoutPanelMenu);
            this.panelNavigation.Controls.Add(this.panelControlBox);
            this.panelNavigation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNavigation.Location = new System.Drawing.Point(0, 0);
            this.panelNavigation.Margin = new System.Windows.Forms.Padding(0);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.Size = new System.Drawing.Size(125, 629);
            this.panelNavigation.TabIndex = 0;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.panelBtn, 0, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.pictureAva, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.lableUsername, 0, 1);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 26);
            this.tableLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 3;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.902357F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15825F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(125, 475);
            this.tableLayoutPanelMenu.TabIndex = 1;
            this.tableLayoutPanelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.tableLayoutPanelMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.tableLayoutPanelMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.panelLeftMenu);
            this.panelBtn.Controls.Add(this.chatBtn);
            this.panelBtn.Controls.Add(this.exploreBtn);
            this.panelBtn.Controls.Add(this.profileBtn);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtn.Location = new System.Drawing.Point(0, 240);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(125, 235);
            this.panelBtn.TabIndex = 3;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.White;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 62);
            this.panelLeftMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(9, 57);
            this.panelLeftMenu.TabIndex = 0;
            this.panelLeftMenu.Visible = false;
            // 
            // chatBtn
            // 
            this.chatBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.chatBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.chatBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.chatBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.chatBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.chatBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.chatBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.chatBtn.ForeColor = System.Drawing.Color.White;
            this.chatBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.chatBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.chatBtn.Image = global::ClientWinform.Properties.Resources.message_square1;
            this.chatBtn.ImageOffset = new System.Drawing.Point(-8, 0);
            this.chatBtn.Location = new System.Drawing.Point(0, 63);
            this.chatBtn.Margin = new System.Windows.Forms.Padding(0);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.chatBtn.Size = new System.Drawing.Size(125, 57);
            this.chatBtn.TabIndex = 0;
            this.chatBtn.Text = "Chat";
            this.chatBtn.TextOffset = new System.Drawing.Point(-4, 0);
            this.chatBtn.Click += new System.EventHandler(this.chatBtn_Click);
            // 
            // exploreBtn
            // 
            this.exploreBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.exploreBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.exploreBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.exploreBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.exploreBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.exploreBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.exploreBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.exploreBtn.ForeColor = System.Drawing.Color.White;
            this.exploreBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.exploreBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.exploreBtn.Image = global::ClientWinform.Properties.Resources.user_plus;
            this.exploreBtn.ImageOffset = new System.Drawing.Point(-3, 0);
            this.exploreBtn.Location = new System.Drawing.Point(0, 120);
            this.exploreBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exploreBtn.Name = "exploreBtn";
            this.exploreBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.exploreBtn.Size = new System.Drawing.Size(125, 57);
            this.exploreBtn.TabIndex = 1;
            this.exploreBtn.Text = "Explore";
            this.exploreBtn.Click += new System.EventHandler(this.exploreBtn_Click);
            // 
            // profileBtn
            // 
            this.profileBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.profileBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.profileBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.profileBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.profileBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.profileBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.profileBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.profileBtn.ForeColor = System.Drawing.Color.White;
            this.profileBtn.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.profileBtn.HoverState.ForeColor = System.Drawing.Color.White;
            this.profileBtn.Image = global::ClientWinform.Properties.Resources.user;
            this.profileBtn.ImageOffset = new System.Drawing.Point(-5, 0);
            this.profileBtn.Location = new System.Drawing.Point(0, 177);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.profileBtn.Size = new System.Drawing.Size(125, 58);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextOffset = new System.Drawing.Point(-1, 0);
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // pictureAva
            // 
            this.pictureAva.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.pictureAva.ImageRotate = 0F;
            this.pictureAva.Location = new System.Drawing.Point(20, 161);
            this.pictureAva.Margin = new System.Windows.Forms.Padding(0);
            this.pictureAva.Name = "pictureAva";
            this.pictureAva.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pictureAva.Size = new System.Drawing.Size(100, 100);
            this.pictureAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureAva.TabIndex = 0;
            this.pictureAva.TabStop = false;
            // 
            // lableUsername
            // 
            this.lableUsername.AutoSize = true;
            this.lableUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.lableUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableUsername.ForeColor = System.Drawing.Color.White;
            this.lableUsername.Location = new System.Drawing.Point(3, 208);
            this.lableUsername.Name = "lableUsername";
            this.lableUsername.Size = new System.Drawing.Size(119, 23);
            this.lableUsername.TabIndex = 1;
            this.lableUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControlBox
            // 
            this.panelControlBox.Controls.Add(this.closeBtn);
            this.panelControlBox.Controls.Add(this.maxBtn);
            this.panelControlBox.Controls.Add(this.minBtn);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(125, 26);
            this.panelControlBox.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::ClientWinform.Properties.Resources.max_btn;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(80, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShowIcon = false;
            this.closeBtn.Size = new System.Drawing.Size(40, 26);
            this.closeBtn.TabIndex = 4;
            // 
            // maxBtn
            // 
            this.maxBtn.BackgroundImage = global::ClientWinform.Properties.Resources.min_btn;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.maxBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.maxBtn.FillColor = System.Drawing.Color.Transparent;
            this.maxBtn.IconColor = System.Drawing.Color.White;
            this.maxBtn.Location = new System.Drawing.Point(40, 0);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.ShowIcon = false;
            this.maxBtn.Size = new System.Drawing.Size(40, 26);
            this.maxBtn.TabIndex = 3;
            // 
            // minBtn
            // 
            this.minBtn.BackgroundImage = global::ClientWinform.Properties.Resources.close_btn;
            this.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.minBtn.FillColor = System.Drawing.Color.Transparent;
            this.minBtn.IconColor = System.Drawing.Color.White;
            this.minBtn.Location = new System.Drawing.Point(0, 0);
            this.minBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minBtn.Name = "minBtn";
            this.minBtn.ShowIcon = false;
            this.minBtn.Size = new System.Drawing.Size(40, 26);
            this.minBtn.TabIndex = 2;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Controls.Add(this.panelExplore);
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(125, 0);
            this.panelChild.Margin = new System.Windows.Forms.Padding(0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(922, 629);
            this.panelChild.TabIndex = 0;
            // 
            // panelExplore
            // 
            this.panelExplore.BackColor = System.Drawing.Color.White;
            this.panelExplore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelExplore.Controls.Add(this.tableLayoutPanelExplore);
            this.panelExplore.Location = new System.Drawing.Point(0, 0);
            this.panelExplore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelExplore.Name = "panelExplore";
            this.panelExplore.Size = new System.Drawing.Size(344, 630);
            this.panelExplore.TabIndex = 2;
            // 
            // tableLayoutPanelExplore
            // 
            this.tableLayoutPanelExplore.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelExplore.ColumnCount = 1;
            this.tableLayoutPanelExplore.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelExplore.Controls.Add(this.searchTxt, 0, 0);
            this.tableLayoutPanelExplore.Controls.Add(this.flowLayoutPanelListExplore, 0, 1);
            this.tableLayoutPanelExplore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelExplore.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelExplore.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelExplore.Name = "tableLayoutPanelExplore";
            this.tableLayoutPanelExplore.RowCount = 2;
            this.tableLayoutPanelExplore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.894212F));
            this.tableLayoutPanelExplore.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.10579F));
            this.tableLayoutPanelExplore.Size = new System.Drawing.Size(340, 626);
            this.tableLayoutPanelExplore.TabIndex = 1;
            // 
            // searchTxt
            // 
            this.searchTxt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchTxt.AutoRoundedCorners = true;
            this.searchTxt.BorderColor = System.Drawing.Color.Black;
            this.searchTxt.BorderRadius = 20;
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
            this.searchTxt.Location = new System.Drawing.Point(12, 3);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(0);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.PasswordChar = '\0';
            this.searchTxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.searchTxt.PlaceholderText = "Search...";
            this.searchTxt.SelectedText = "";
            this.searchTxt.Size = new System.Drawing.Size(316, 42);
            this.searchTxt.TabIndex = 13;
            // 
            // flowLayoutPanelListExplore
            // 
            this.flowLayoutPanelListExplore.AutoScroll = true;
            this.flowLayoutPanelListExplore.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanelListExplore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelListExplore.Location = new System.Drawing.Point(0, 49);
            this.flowLayoutPanelListExplore.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelListExplore.Name = "flowLayoutPanelListExplore";
            this.flowLayoutPanelListExplore.Size = new System.Drawing.Size(340, 577);
            this.flowLayoutPanelListExplore.TabIndex = 0;
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 629);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.tableLayoutPanelMenu.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureAva)).EndInit();
            this.panelControlBox.ResumeLayout(false);
            this.panelChild.ResumeLayout(false);
            this.panelExplore.ResumeLayout(false);
            this.tableLayoutPanelExplore.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelNavigation;
        private System.Windows.Forms.Panel panelChild;
        private System.Windows.Forms.Panel panelControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox minBtn;
        private Guna.UI2.WinForms.Guna2ControlBox maxBtn;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenu;
        private Guna.UI2.WinForms.Guna2Button chatBtn;
        private Guna.UI2.WinForms.Guna2Button exploreBtn;
        private Guna.UI2.WinForms.Guna2Button profileBtn;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pictureAva;
        private System.Windows.Forms.Label lableUsername;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelBtn;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelListExplore;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelExplore;
        private Guna.UI2.WinForms.Guna2TextBox searchTxt;
        private System.Windows.Forms.Panel panelExplore;
    }
}