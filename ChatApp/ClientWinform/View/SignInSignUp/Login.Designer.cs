
namespace ClientWinform
{
    partial class loginForm
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
            this.panelIntro = new System.Windows.Forms.Panel();
            this.tableLayoutPanelImage = new System.Windows.Forms.TableLayoutPanel();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.slogan = new System.Windows.Forms.Label();
            this.nameApp = new System.Windows.Forms.Label();
            this.panelContent = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelWelcomback = new System.Windows.Forms.Label();
            this.usernamePnl = new System.Windows.Forms.Panel();
            this.usernameLbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.passPnl = new System.Windows.Forms.Panel();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.lineUserPnl = new System.Windows.Forms.Panel();
            this.passPanel = new System.Windows.Forms.Panel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.recoverPassBtn = new Guna.UI2.WinForms.Guna2Button();
            this.rememberLoginCb = new System.Windows.Forms.CheckBox();
            this.linePassPnl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnSignIn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.signUpBtn = new Guna.UI2.WinForms.Guna2Button();
            this.labelDontHaveAnAccount = new System.Windows.Forms.Label();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.minBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.maxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanelMain.SuspendLayout();
            this.panelIntro.SuspendLayout();
            this.tableLayoutPanelImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelContent.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.usernamePnl.SuspendLayout();
            this.passPnl.SuspendLayout();
            this.passPanel.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.panelControlBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanelMain.ColumnCount = 2;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Controls.Add(this.panelIntro, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.panelContent, 1, 0);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1000, 730);
            this.tableLayoutPanelMain.TabIndex = 0;
            this.tableLayoutPanelMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.tableLayoutPanelMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.tableLayoutPanelMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // panelIntro
            // 
            this.panelIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.panelIntro.Controls.Add(this.tableLayoutPanelImage);
            this.panelIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIntro.Location = new System.Drawing.Point(0, 0);
            this.panelIntro.Margin = new System.Windows.Forms.Padding(0);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(500, 730);
            this.panelIntro.TabIndex = 0;
            // 
            // tableLayoutPanelImage
            // 
            this.tableLayoutPanelImage.ColumnCount = 1;
            this.tableLayoutPanelImage.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelImage.Controls.Add(this.imgLogin, 0, 1);
            this.tableLayoutPanelImage.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanelImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelImage.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelImage.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelImage.Name = "tableLayoutPanelImage";
            this.tableLayoutPanelImage.RowCount = 3;
            this.tableLayoutPanelImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36986F));
            this.tableLayoutPanelImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.64384F));
            this.tableLayoutPanelImage.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.89373F));
            this.tableLayoutPanelImage.Size = new System.Drawing.Size(500, 730);
            this.tableLayoutPanelImage.TabIndex = 0;
            this.tableLayoutPanelImage.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.tableLayoutPanelImage.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.tableLayoutPanelImage.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // imgLogin
            // 
            this.imgLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLogin.Image = global::ClientWinform.Properties.Resources.Group_Chat_rafiki;
            this.imgLogin.Location = new System.Drawing.Point(0, 156);
            this.imgLogin.Margin = new System.Windows.Forms.Padding(0);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(500, 450);
            this.imgLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgLogin.TabIndex = 0;
            this.imgLogin.TabStop = false;
            this.imgLogin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.imgLogin.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.imgLogin.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 94.12955F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.870445F));
            this.tableLayoutPanel1.Controls.Add(this.slogan, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.nameApp, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(500, 156);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // slogan
            // 
            this.slogan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.slogan.Location = new System.Drawing.Point(157, 134);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(310, 22);
            this.slogan.TabIndex = 1;
            this.slogan.Text = "\"Connect, Communicate, Collaborate\"\r\n";
            // 
            // nameApp
            // 
            this.nameApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameApp.AutoSize = true;
            this.nameApp.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.nameApp.Location = new System.Drawing.Point(233, 85);
            this.nameApp.Name = "nameApp";
            this.nameApp.Size = new System.Drawing.Size(234, 33);
            this.nameApp.TabIndex = 0;
            this.nameApp.Text = "W e C o n n e c t\r\n";
            // 
            // panelContent
            // 
            this.panelContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.tableLayoutPanel2);
            this.panelContent.Controls.Add(this.panelControlBox);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(500, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(500, 730);
            this.panelContent.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel2.Controls.Add(this.labelNote, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.labelWelcomback, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.usernamePnl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.passPnl, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.passPanel, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 1, 5);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 32);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.67671F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.626886F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.34218F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.89857F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.62554F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.2726F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(500, 698);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // labelNote
            // 
            this.labelNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.labelNote.Location = new System.Drawing.Point(83, 160);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(334, 20);
            this.labelNote.TabIndex = 2;
            this.labelNote.Text = "Fill your data to enter. Thank you!!!\r\n";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWelcomback
            // 
            this.labelWelcomback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcomback.AutoSize = true;
            this.labelWelcomback.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.labelWelcomback.Location = new System.Drawing.Point(83, 119);
            this.labelWelcomback.Name = "labelWelcomback";
            this.labelWelcomback.Size = new System.Drawing.Size(334, 33);
            this.labelWelcomback.TabIndex = 2;
            this.labelWelcomback.Text = "W E L C O M E  B A C K\r\n";
            this.labelWelcomback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernamePnl
            // 
            this.usernamePnl.Controls.Add(this.usernameLbl);
            this.usernamePnl.Controls.Add(this.txtUsername);
            this.usernamePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernamePnl.Location = new System.Drawing.Point(80, 180);
            this.usernamePnl.Margin = new System.Windows.Forms.Padding(0);
            this.usernamePnl.Name = "usernamePnl";
            this.usernamePnl.Size = new System.Drawing.Size(340, 107);
            this.usernamePnl.TabIndex = 6;
            // 
            // usernameLbl
            // 
            this.usernameLbl.BorderThickness = 0;
            this.usernameLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameLbl.DefaultText = "Username";
            this.usernameLbl.DisabledState.BorderColor = System.Drawing.Color.White;
            this.usernameLbl.DisabledState.FillColor = System.Drawing.Color.White;
            this.usernameLbl.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.usernameLbl.DisabledState.PlaceholderForeColor = System.Drawing.Color.White;
            this.usernameLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.usernameLbl.Enabled = false;
            this.usernameLbl.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameLbl.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.usernameLbl.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameLbl.Location = new System.Drawing.Point(0, 75);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.PasswordChar = '\0';
            this.usernameLbl.PlaceholderText = "";
            this.usernameLbl.SelectedText = "";
            this.usernameLbl.Size = new System.Drawing.Size(340, 32);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.TextOffset = new System.Drawing.Point(-9, 0);
            // 
            // passPnl
            // 
            this.passPnl.Controls.Add(this.txtPassword);
            this.passPnl.Controls.Add(this.lineUserPnl);
            this.passPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passPnl.Location = new System.Drawing.Point(80, 287);
            this.passPnl.Margin = new System.Windows.Forms.Padding(0);
            this.passPnl.Name = "passPnl";
            this.passPnl.Size = new System.Drawing.Size(340, 67);
            this.passPnl.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.txtPassword.BorderThickness = 0;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(0, 35);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(340, 32);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextOffset = new System.Drawing.Point(-9, 0);
            // 
            // lineUserPnl
            // 
            this.lineUserPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.lineUserPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineUserPnl.Location = new System.Drawing.Point(0, 0);
            this.lineUserPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineUserPnl.Name = "lineUserPnl";
            this.lineUserPnl.Size = new System.Drawing.Size(340, 2);
            this.lineUserPnl.TabIndex = 1;
            // 
            // passPanel
            // 
            this.passPanel.Controls.Add(this.tableLayoutPanel3);
            this.passPanel.Controls.Add(this.linePassPnl);
            this.passPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passPanel.Location = new System.Drawing.Point(80, 354);
            this.passPanel.Margin = new System.Windows.Forms.Padding(0);
            this.passPanel.Name = "passPanel";
            this.passPanel.Size = new System.Drawing.Size(340, 77);
            this.passPanel.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.47059F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.52941F));
            this.tableLayoutPanel3.Controls.Add(this.recoverPassBtn, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.rememberLoginCb, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(340, 75);
            this.tableLayoutPanel3.TabIndex = 3;
            // 
            // recoverPassBtn
            // 
            this.recoverPassBtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.recoverPassBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.recoverPassBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.recoverPassBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.recoverPassBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.recoverPassBtn.FillColor = System.Drawing.Color.White;
            this.recoverPassBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.recoverPassBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.recoverPassBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.recoverPassBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.recoverPassBtn.Location = new System.Drawing.Point(161, 18);
            this.recoverPassBtn.Margin = new System.Windows.Forms.Padding(0);
            this.recoverPassBtn.Name = "recoverPassBtn";
            this.recoverPassBtn.PressedColor = System.Drawing.Color.White;
            this.recoverPassBtn.Size = new System.Drawing.Size(179, 38);
            this.recoverPassBtn.TabIndex = 1;
            this.recoverPassBtn.Text = "Recover password";
            this.recoverPassBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.recoverPassBtn.TextOffset = new System.Drawing.Point(7, 0);
            // 
            // rememberLoginCb
            // 
            this.rememberLoginCb.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rememberLoginCb.AutoSize = true;
            this.rememberLoginCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberLoginCb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.rememberLoginCb.Location = new System.Drawing.Point(3, 25);
            this.rememberLoginCb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rememberLoginCb.Name = "rememberLoginCb";
            this.rememberLoginCb.Size = new System.Drawing.Size(151, 24);
            this.rememberLoginCb.TabIndex = 3;
            this.rememberLoginCb.Text = "Remember login";
            this.rememberLoginCb.UseVisualStyleBackColor = true;
            // 
            // linePassPnl
            // 
            this.linePassPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.linePassPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.linePassPnl.Location = new System.Drawing.Point(0, 0);
            this.linePassPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.linePassPnl.Name = "linePassPnl";
            this.linePassPnl.Size = new System.Drawing.Size(340, 2);
            this.linePassPnl.TabIndex = 2;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.293413F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.11377F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.293413F));
            this.tableLayoutPanel4.Controls.Add(this.btnSignIn, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(80, 431);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 37.77778F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 62.22222F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(340, 186);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // btnSignIn
            // 
            this.btnSignIn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSignIn.AutoRoundedCorners = true;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BorderRadius = 21;
            this.btnSignIn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSignIn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSignIn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSignIn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.btnSignIn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(79, 23);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.ShadowDecoration.BorderRadius = 5;
            this.btnSignIn.ShadowDecoration.Depth = 15;
            this.btnSignIn.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnSignIn.Size = new System.Drawing.Size(180, 45);
            this.btnSignIn.TabIndex = 0;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.58503F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.41497F));
            this.tableLayoutPanel5.Controls.Add(this.signUpBtn, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelDontHaveAnAccount, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(11, 70);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(317, 116);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // signUpBtn
            // 
            this.signUpBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signUpBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signUpBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signUpBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signUpBtn.FillColor = System.Drawing.Color.White;
            this.signUpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.signUpBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.signUpBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.signUpBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.signUpBtn.Location = new System.Drawing.Point(198, 0);
            this.signUpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.signUpBtn.Name = "signUpBtn";
            this.signUpBtn.PressedColor = System.Drawing.Color.White;
            this.signUpBtn.Size = new System.Drawing.Size(101, 28);
            this.signUpBtn.TabIndex = 4;
            this.signUpBtn.Text = "Sign up";
            this.signUpBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.signUpBtn.TextOffset = new System.Drawing.Point(-12, -2);
            this.signUpBtn.Click += new System.EventHandler(this.signUpBtn_Click);
            // 
            // labelDontHaveAnAccount
            // 
            this.labelDontHaveAnAccount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelDontHaveAnAccount.AutoSize = true;
            this.labelDontHaveAnAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDontHaveAnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.labelDontHaveAnAccount.Location = new System.Drawing.Point(18, 0);
            this.labelDontHaveAnAccount.Name = "labelDontHaveAnAccount";
            this.labelDontHaveAnAccount.Size = new System.Drawing.Size(177, 20);
            this.labelDontHaveAnAccount.TabIndex = 9;
            this.labelDontHaveAnAccount.Text = "Don\'t have an account?";
            this.labelDontHaveAnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelControlBox
            // 
            this.panelControlBox.Controls.Add(this.minBtn);
            this.panelControlBox.Controls.Add(this.maxBtn);
            this.panelControlBox.Controls.Add(this.closeBtn);
            this.panelControlBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBox.Location = new System.Drawing.Point(0, 0);
            this.panelControlBox.Margin = new System.Windows.Forms.Padding(0);
            this.panelControlBox.Name = "panelControlBox";
            this.panelControlBox.Size = new System.Drawing.Size(500, 32);
            this.panelControlBox.TabIndex = 0;
            this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.panelControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // minBtn
            // 
            this.minBtn.BackgroundImage = global::ClientWinform.Properties.Resources.Minimal;
            this.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBtn.FillColor = System.Drawing.Color.Transparent;
            this.minBtn.IconColor = System.Drawing.Color.White;
            this.minBtn.Location = new System.Drawing.Point(365, 0);
            this.minBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minBtn.Name = "minBtn";
            this.minBtn.ShowIcon = false;
            this.minBtn.Size = new System.Drawing.Size(45, 32);
            this.minBtn.TabIndex = 2;
            // 
            // maxBtn
            // 
            this.maxBtn.BackgroundImage = global::ClientWinform.Properties.Resources.ScaleButton;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.maxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxBtn.FillColor = System.Drawing.Color.Transparent;
            this.maxBtn.IconColor = System.Drawing.Color.White;
            this.maxBtn.Location = new System.Drawing.Point(410, 0);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.ShowIcon = false;
            this.maxBtn.Size = new System.Drawing.Size(45, 32);
            this.maxBtn.TabIndex = 1;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::ClientWinform.Properties.Resources.Group_3;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(455, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShowIcon = false;
            this.closeBtn.Size = new System.Drawing.Size(45, 32);
            this.closeBtn.TabIndex = 0;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderThickness = 0;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(0, 36);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(340, 39);
            this.txtUsername.TabIndex = 4;
            this.txtUsername.TextOffset = new System.Drawing.Point(-9, 0);
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 730);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 80);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "loginForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.panelIntro.ResumeLayout(false);
            this.tableLayoutPanelImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelContent.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.usernamePnl.ResumeLayout(false);
            this.passPnl.ResumeLayout(false);
            this.passPanel.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.panelControlBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelImage;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.Label nameApp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private Guna.UI2.WinForms.Guna2ControlBox minBtn;
        private Guna.UI2.WinForms.Guna2ControlBox maxBtn;
        private System.Windows.Forms.Label labelWelcomback;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Panel passPanel;
        private System.Windows.Forms.Panel usernamePnl;
        private System.Windows.Forms.Panel passPnl;
        private System.Windows.Forms.Panel lineUserPnl;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Panel linePassPnl;
        private Guna.UI2.WinForms.Guna2TextBox usernameLbl;
        private System.Windows.Forms.CheckBox rememberLoginCb;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private Guna.UI2.WinForms.Guna2Button recoverPassBtn;
        private Guna.UI2.WinForms.Guna2Button btnSignIn;
        private Guna.UI2.WinForms.Guna2Button signUpBtn;
        private System.Windows.Forms.Label labelDontHaveAnAccount;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
    }
}

