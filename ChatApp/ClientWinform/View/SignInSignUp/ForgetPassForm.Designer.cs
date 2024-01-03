namespace ClientWinform.View
{
    partial class ForgetPassForm
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
            this.minBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.closeBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.panelControlBox = new System.Windows.Forms.Panel();
            this.maxBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lableBack = new System.Windows.Forms.Label();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lineUserPnl = new System.Windows.Forms.Panel();
            this.usernameLbl = new Guna.UI2.WinForms.Guna2TextBox();
            this.passPnl = new System.Windows.Forms.Panel();
            this.txtEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNote = new System.Windows.Forms.Label();
            this.labelWelcomback = new System.Windows.Forms.Label();
            this.usernamePnl = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelContent = new System.Windows.Forms.Panel();
            this.slogan = new System.Windows.Forms.Label();
            this.nameApp = new System.Windows.Forms.Label();
            this.imgLogin = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelImage = new System.Windows.Forms.TableLayoutPanel();
            this.panelIntro = new System.Windows.Forms.Panel();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.panelControlBox.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.passPnl.SuspendLayout();
            this.usernamePnl.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelImage.SuspendLayout();
            this.panelIntro.SuspendLayout();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // minBtn
            // 
            this.minBtn.BackgroundImage = global::ClientWinform.Properties.Resources.Minimal;
            this.minBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.minBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.minBtn.FillColor = System.Drawing.Color.Transparent;
            this.minBtn.IconColor = System.Drawing.Color.White;
            this.minBtn.Location = new System.Drawing.Point(373, 0);
            this.minBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minBtn.Name = "minBtn";
            this.minBtn.ShowIcon = false;
            this.minBtn.Size = new System.Drawing.Size(36, 21);
            this.minBtn.TabIndex = 2;
            // 
            // closeBtn
            // 
            this.closeBtn.BackgroundImage = global::ClientWinform.Properties.Resources.Group_3;
            this.closeBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closeBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MaximizeBox;
            this.closeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeBtn.FillColor = System.Drawing.Color.Transparent;
            this.closeBtn.IconColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(445, 0);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.ShowIcon = false;
            this.closeBtn.Size = new System.Drawing.Size(36, 21);
            this.closeBtn.TabIndex = 0;
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
            this.panelControlBox.Size = new System.Drawing.Size(481, 21);
            this.panelControlBox.TabIndex = 0;
            this.panelControlBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.panelControlBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.panelControlBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // maxBtn
            // 
            this.maxBtn.BackgroundImage = global::ClientWinform.Properties.Resources.ScaleButton;
            this.maxBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.maxBtn.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.maxBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.maxBtn.FillColor = System.Drawing.Color.Transparent;
            this.maxBtn.IconColor = System.Drawing.Color.White;
            this.maxBtn.Location = new System.Drawing.Point(409, 0);
            this.maxBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maxBtn.Name = "maxBtn";
            this.maxBtn.ShowIcon = false;
            this.maxBtn.Size = new System.Drawing.Size(36, 21);
            this.maxBtn.TabIndex = 1;
            // 
            // lableBack
            // 
            this.lableBack.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lableBack.AutoSize = true;
            this.lableBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lableBack.Location = new System.Drawing.Point(115, 58);
            this.lableBack.Name = "lableBack";
            this.lableBack.Size = new System.Drawing.Size(94, 17);
            this.lableBack.TabIndex = 9;
            this.lableBack.Text = "Back to Login";
            this.lableBack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lableBack.Click += new System.EventHandler(this.lableBack_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSubmit.AutoRoundedCorners = true;
            this.btnSubmit.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.BorderRadius = 17;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(82, 20);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.ShadowDecoration.BorderRadius = 5;
            this.btnSubmit.ShadowDecoration.Depth = 15;
            this.btnSubmit.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0);
            this.btnSubmit.Size = new System.Drawing.Size(160, 36);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.293413F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 93.11377F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 3.293413F));
            this.tableLayoutPanel4.Controls.Add(this.lableBack, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.btnSubmit, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.13376F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.86624F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(327, 125);
            this.tableLayoutPanel4.TabIndex = 9;
            // 
            // lineUserPnl
            // 
            this.lineUserPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.lineUserPnl.Dock = System.Windows.Forms.DockStyle.Top;
            this.lineUserPnl.Location = new System.Drawing.Point(0, 0);
            this.lineUserPnl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lineUserPnl.Name = "lineUserPnl";
            this.lineUserPnl.Size = new System.Drawing.Size(327, 2);
            this.lineUserPnl.TabIndex = 1;
            // 
            // usernameLbl
            // 
            this.usernameLbl.BorderThickness = 0;
            this.usernameLbl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernameLbl.DefaultText = "Email address";
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
            this.usernameLbl.Location = new System.Drawing.Point(0, 82);
            this.usernameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.PasswordChar = '\0';
            this.usernameLbl.PlaceholderText = "";
            this.usernameLbl.SelectedText = "";
            this.usernameLbl.Size = new System.Drawing.Size(327, 21);
            this.usernameLbl.TabIndex = 1;
            this.usernameLbl.TextOffset = new System.Drawing.Point(-9, 0);
            // 
            // passPnl
            // 
            this.passPnl.Controls.Add(this.lineUserPnl);
            this.passPnl.Controls.Add(this.tableLayoutPanel4);
            this.passPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.passPnl.Location = new System.Drawing.Point(76, 290);
            this.passPnl.Margin = new System.Windows.Forms.Padding(0);
            this.passPnl.Name = "passPnl";
            this.passPnl.Size = new System.Drawing.Size(327, 125);
            this.passPnl.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderThickness = 0;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.DefaultText = "";
            this.txtEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmail.Location = new System.Drawing.Point(0, 103);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PlaceholderText = "";
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(327, 31);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.TextOffset = new System.Drawing.Point(-9, 0);
            // 
            // labelNote
            // 
            this.labelNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNote.AutoSize = true;
            this.labelNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.labelNote.Location = new System.Drawing.Point(79, 139);
            this.labelNote.Name = "labelNote";
            this.labelNote.Size = new System.Drawing.Size(321, 17);
            this.labelNote.TabIndex = 2;
            this.labelNote.Text = "Don\'t worry! We\'ll send you reset instruction\r\n";
            this.labelNote.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelWelcomback
            // 
            this.labelWelcomback.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelWelcomback.AutoSize = true;
            this.labelWelcomback.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcomback.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.labelWelcomback.Location = new System.Drawing.Point(79, 103);
            this.labelWelcomback.Name = "labelWelcomback";
            this.labelWelcomback.Size = new System.Drawing.Size(321, 29);
            this.labelWelcomback.TabIndex = 2;
            this.labelWelcomback.Text = "F O R G E T  P A S S";
            this.labelWelcomback.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernamePnl
            // 
            this.usernamePnl.Controls.Add(this.usernameLbl);
            this.usernamePnl.Controls.Add(this.txtEmail);
            this.usernamePnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usernamePnl.Location = new System.Drawing.Point(76, 156);
            this.usernamePnl.Margin = new System.Windows.Forms.Padding(0);
            this.usernamePnl.Name = "usernamePnl";
            this.usernamePnl.Size = new System.Drawing.Size(327, 134);
            this.usernamePnl.TabIndex = 6;
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
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 21);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.67671F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.626886F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.11211F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.46786F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.118087F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.85501F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(481, 535);
            this.tableLayoutPanel2.TabIndex = 1;
            this.tableLayoutPanel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.tableLayoutPanel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.tableLayoutPanel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
            // 
            // panelContent
            // 
            this.panelContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.tableLayoutPanel2);
            this.panelContent.Controls.Add(this.panelControlBox);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(481, 0);
            this.panelContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(481, 556);
            this.panelContent.TabIndex = 1;
            // 
            // slogan
            // 
            this.slogan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.slogan.AutoSize = true;
            this.slogan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.slogan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.slogan.Location = new System.Drawing.Point(190, 100);
            this.slogan.Name = "slogan";
            this.slogan.Size = new System.Drawing.Size(259, 18);
            this.slogan.TabIndex = 1;
            this.slogan.Text = "\"Connect, Communicate, Collaborate\"\r\n";
            // 
            // nameApp
            // 
            this.nameApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nameApp.AutoSize = true;
            this.nameApp.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameApp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(127)))), ((int)(((byte)(244)))));
            this.nameApp.Location = new System.Drawing.Point(248, 65);
            this.nameApp.Name = "nameApp";
            this.nameApp.Size = new System.Drawing.Size(201, 29);
            this.nameApp.TabIndex = 0;
            this.nameApp.Text = "W e C o n n e c t\r\n";
            // 
            // imgLogin
            // 
            this.imgLogin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imgLogin.Image = global::ClientWinform.Properties.Resources.Group_Chat_rafiki;
            this.imgLogin.Location = new System.Drawing.Point(0, 118);
            this.imgLogin.Margin = new System.Windows.Forms.Padding(0);
            this.imgLogin.Name = "imgLogin";
            this.imgLogin.Size = new System.Drawing.Size(481, 343);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(481, 118);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseDown);
            this.tableLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseMove);
            this.tableLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseUp);
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
            this.tableLayoutPanelImage.Size = new System.Drawing.Size(481, 556);
            this.tableLayoutPanelImage.TabIndex = 0;
            // 
            // panelIntro
            // 
            this.panelIntro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.panelIntro.Controls.Add(this.tableLayoutPanelImage);
            this.panelIntro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelIntro.Location = new System.Drawing.Point(0, 0);
            this.panelIntro.Margin = new System.Windows.Forms.Padding(0);
            this.panelIntro.Name = "panelIntro";
            this.panelIntro.Size = new System.Drawing.Size(481, 556);
            this.panelIntro.TabIndex = 0;
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
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 1;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(962, 556);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // ForgetPassForm
            // 
            this.AcceptButton = this.btnSubmit;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(962, 556);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 80);
            this.Name = "ForgetPassForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ForgetPassForm";
            this.Load += new System.EventHandler(this.ForgetPassForm_Load);
            this.panelControlBox.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.passPnl.ResumeLayout(false);
            this.usernamePnl.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogin)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelImage.ResumeLayout(false);
            this.panelIntro.ResumeLayout(false);
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox minBtn;
        private Guna.UI2.WinForms.Guna2ControlBox closeBtn;
        private System.Windows.Forms.Panel panelControlBox;
        private Guna.UI2.WinForms.Guna2ControlBox maxBtn;
        private System.Windows.Forms.Label lableBack;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Panel lineUserPnl;
        private Guna.UI2.WinForms.Guna2TextBox usernameLbl;
        private System.Windows.Forms.Panel passPnl;
        private Guna.UI2.WinForms.Guna2TextBox txtEmail;
        private System.Windows.Forms.Label labelNote;
        private System.Windows.Forms.Label labelWelcomback;
        private System.Windows.Forms.Panel usernamePnl;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Label slogan;
        private System.Windows.Forms.Label nameApp;
        private System.Windows.Forms.PictureBox imgLogin;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelImage;
        private System.Windows.Forms.Panel panelIntro;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
    }
}