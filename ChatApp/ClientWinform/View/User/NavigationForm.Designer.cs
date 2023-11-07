
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
            this.chatBtn = new Guna.UI2.WinForms.Guna2Button();
            this.exploreBtn = new Guna.UI2.WinForms.Guna2Button();
            this.profileBtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CirclePictureBox1 = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.usernameLable = new System.Windows.Forms.Label();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.minBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelLeftMenu = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            this.tableLayoutPanelMenu.SuspendLayout();
            this.panelBtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).BeginInit();
            this.panelControlBox.SuspendLayout();
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
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1178, 786);
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
            this.panelNavigation.Size = new System.Drawing.Size(141, 786);
            this.panelNavigation.TabIndex = 0;
            // 
            // tableLayoutPanelMenu
            // 
            this.tableLayoutPanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.tableLayoutPanelMenu.ColumnCount = 1;
            this.tableLayoutPanelMenu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMenu.Controls.Add(this.panelBtn, 0, 2);
            this.tableLayoutPanelMenu.Controls.Add(this.guna2CirclePictureBox1, 0, 0);
            this.tableLayoutPanelMenu.Controls.Add(this.usernameLable, 0, 1);
            this.tableLayoutPanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanelMenu.Location = new System.Drawing.Point(0, 33);
            this.tableLayoutPanelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMenu.Name = "tableLayoutPanelMenu";
            this.tableLayoutPanelMenu.RowCount = 3;
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.902357F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15825F));
            this.tableLayoutPanelMenu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelMenu.Size = new System.Drawing.Size(141, 594);
            this.tableLayoutPanelMenu.TabIndex = 1;
            // 
            // panelBtn
            // 
            this.panelBtn.Controls.Add(this.panelLeftMenu);
            this.panelBtn.Controls.Add(this.chatBtn);
            this.panelBtn.Controls.Add(this.exploreBtn);
            this.panelBtn.Controls.Add(this.profileBtn);
            this.panelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBtn.Location = new System.Drawing.Point(0, 301);
            this.panelBtn.Margin = new System.Windows.Forms.Padding(0);
            this.panelBtn.Name = "panelBtn";
            this.panelBtn.Size = new System.Drawing.Size(141, 293);
            this.panelBtn.TabIndex = 3;
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
            this.chatBtn.Location = new System.Drawing.Point(0, 78);
            this.chatBtn.Margin = new System.Windows.Forms.Padding(0);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.chatBtn.Size = new System.Drawing.Size(141, 71);
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
            this.exploreBtn.Location = new System.Drawing.Point(0, 149);
            this.exploreBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exploreBtn.Name = "exploreBtn";
            this.exploreBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.exploreBtn.Size = new System.Drawing.Size(141, 71);
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
            this.profileBtn.Location = new System.Drawing.Point(0, 220);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(0);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.profileBtn.Size = new System.Drawing.Size(141, 73);
            this.profileBtn.TabIndex = 2;
            this.profileBtn.Text = "Profile";
            this.profileBtn.TextOffset = new System.Drawing.Point(-1, 0);
            this.profileBtn.Click += new System.EventHandler(this.profileBtn_Click);
            // 
            // guna2CirclePictureBox1
            // 
            this.guna2CirclePictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2CirclePictureBox1.Image = global::ClientWinform.Properties.Resources.Ava_img;
            this.guna2CirclePictureBox1.ImageRotate = 0F;
            this.guna2CirclePictureBox1.Location = new System.Drawing.Point(0, 161);
            this.guna2CirclePictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2CirclePictureBox1.Name = "guna2CirclePictureBox1";
            this.guna2CirclePictureBox1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CirclePictureBox1.Size = new System.Drawing.Size(141, 100);
            this.guna2CirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2CirclePictureBox1.TabIndex = 0;
            this.guna2CirclePictureBox1.TabStop = false;
            // 
            // usernameLable
            // 
            this.usernameLable.AutoSize = true;
            this.usernameLable.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameLable.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLable.ForeColor = System.Drawing.Color.White;
            this.usernameLable.Location = new System.Drawing.Point(3, 261);
            this.usernameLable.Name = "usernameLable";
            this.usernameLable.Size = new System.Drawing.Size(135, 28);
            this.usernameLable.TabIndex = 1;
            this.usernameLable.Text = "Viez_taho";
            this.usernameLable.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.panelControlBox.Size = new System.Drawing.Size(141, 33);
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
            this.closeBtn.Location = new System.Drawing.Point(90, 0);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShowIcon = false;
            this.closeBtn.Size = new System.Drawing.Size(45, 33);
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
            this.maxBtn.Location = new System.Drawing.Point(45, 0);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.ShowIcon = false;
            this.maxBtn.Size = new System.Drawing.Size(45, 33);
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
            this.minBtn.Name = "minBtn";
            this.minBtn.ShowIcon = false;
            this.minBtn.Size = new System.Drawing.Size(45, 33);
            this.minBtn.TabIndex = 2;
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.White;
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(141, 0);
            this.panelChild.Margin = new System.Windows.Forms.Padding(0);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(1037, 786);
            this.panelChild.TabIndex = 0;
            // 
            // panelLeftMenu
            // 
            this.panelLeftMenu.BackColor = System.Drawing.Color.White;
            this.panelLeftMenu.Location = new System.Drawing.Point(0, 78);
            this.panelLeftMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelLeftMenu.Name = "panelLeftMenu";
            this.panelLeftMenu.Size = new System.Drawing.Size(10, 71);
            this.panelLeftMenu.TabIndex = 0;
            this.panelLeftMenu.Visible = false;
            // 
            // NavigationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 786);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NavigationForm";
            this.Text = "NavigationForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelNavigation.ResumeLayout(false);
            this.tableLayoutPanelMenu.ResumeLayout(false);
            this.tableLayoutPanelMenu.PerformLayout();
            this.panelBtn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2CirclePictureBox1)).EndInit();
            this.panelControlBox.ResumeLayout(false);
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
        private Guna.UI2.WinForms.Guna2CirclePictureBox guna2CirclePictureBox1;
        private System.Windows.Forms.Label usernameLable;
        private System.Windows.Forms.Panel panelLeftMenu;
        private System.Windows.Forms.Panel panelBtn;
    }
}