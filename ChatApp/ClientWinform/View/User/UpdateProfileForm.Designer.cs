
namespace ClientWinform.View.User
{
    partial class UpdateProfileForm
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
            this.genderGroupBox = new Guna.UI2.WinForms.Guna2GroupBox();
            this.femaleBtn = new System.Windows.Forms.RadioButton();
            this.maleBtn = new System.Windows.Forms.RadioButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelBio = new System.Windows.Forms.Panel();
            this.txtBio = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelEmail = new System.Windows.Forms.Panel();
            this.labelInvalidemail = new System.Windows.Forms.Label();
            this.txtMail = new Guna.UI2.WinForms.Guna2TextBox();
            this.labeBio = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.dtPickerBirth = new System.Windows.Forms.DateTimePicker();
            this.labelBirth = new System.Windows.Forms.Label();
            this.panelBirthday = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.txtName = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelGender = new System.Windows.Forms.Label();
            this.panelGender = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.panelUsernameEdit = new System.Windows.Forms.Panel();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelUsernameEdit = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.panelUserName = new System.Windows.Forms.Panel();
            this.tableLayoutPanelHead = new System.Windows.Forms.TableLayoutPanel();
            this.changeAvaBtn = new Guna.UI2.WinForms.Guna2Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelTittle = new System.Windows.Forms.TableLayoutPanel();
            this.picBoxAva = new Guna.UI2.WinForms.Guna2PictureBox();
            this.tableLayoutPanelMain = new System.Windows.Forms.TableLayoutPanel();
            this.genderGroupBox.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelBio.SuspendLayout();
            this.panelEmail.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panelBirthday.SuspendLayout();
            this.panelName.SuspendLayout();
            this.panelGender.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.panelUsernameEdit.SuspendLayout();
            this.panelUserName.SuspendLayout();
            this.tableLayoutPanelHead.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanelTittle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAva)).BeginInit();
            this.tableLayoutPanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // genderGroupBox
            // 
            this.genderGroupBox.BorderColor = System.Drawing.Color.Empty;
            this.genderGroupBox.Controls.Add(this.femaleBtn);
            this.genderGroupBox.Controls.Add(this.maleBtn);
            this.genderGroupBox.CustomBorderColor = System.Drawing.Color.Empty;
            this.genderGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.genderGroupBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.genderGroupBox.Location = new System.Drawing.Point(0, 0);
            this.genderGroupBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genderGroupBox.Name = "genderGroupBox";
            this.genderGroupBox.Size = new System.Drawing.Size(459, 63);
            this.genderGroupBox.TabIndex = 8;
            // 
            // femaleBtn
            // 
            this.femaleBtn.AutoSize = true;
            this.femaleBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.femaleBtn.Location = new System.Drawing.Point(171, 22);
            this.femaleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femaleBtn.Name = "femaleBtn";
            this.femaleBtn.Size = new System.Drawing.Size(85, 27);
            this.femaleBtn.TabIndex = 8;
            this.femaleBtn.TabStop = true;
            this.femaleBtn.Text = "Female";
            this.femaleBtn.UseVisualStyleBackColor = true;
            // 
            // maleBtn
            // 
            this.maleBtn.AutoSize = true;
            this.maleBtn.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.maleBtn.Location = new System.Drawing.Point(4, 22);
            this.maleBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.maleBtn.Name = "maleBtn";
            this.maleBtn.Size = new System.Drawing.Size(68, 27);
            this.maleBtn.TabIndex = 7;
            this.maleBtn.TabStop = true;
            this.maleBtn.Text = "Male";
            this.maleBtn.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panelBio, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.panelEmail, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(85, 278);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.86047F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.7907F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.34884F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(459, 401);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // panelBio
            // 
            this.panelBio.Controls.Add(this.txtBio);
            this.panelBio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBio.Location = new System.Drawing.Point(0, 127);
            this.panelBio.Margin = new System.Windows.Forms.Padding(0);
            this.panelBio.Name = "panelBio";
            this.panelBio.Padding = new System.Windows.Forms.Padding(0, 24, 39, 0);
            this.panelBio.Size = new System.Drawing.Size(459, 131);
            this.panelBio.TabIndex = 11;
            // 
            // txtBio
            // 
            this.txtBio.AutoRoundedCorners = true;
            this.txtBio.BorderColor = System.Drawing.Color.Black;
            this.txtBio.BorderRadius = 20;
            this.txtBio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBio.DefaultText = "";
            this.txtBio.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBio.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBio.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBio.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtBio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.txtBio.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBio.Location = new System.Drawing.Point(0, 24);
            this.txtBio.Margin = new System.Windows.Forms.Padding(0);
            this.txtBio.Name = "txtBio";
            this.txtBio.PasswordChar = '\0';
            this.txtBio.PlaceholderText = "";
            this.txtBio.SelectedText = "";
            this.txtBio.Size = new System.Drawing.Size(420, 42);
            this.txtBio.TabIndex = 10;
            // 
            // panelEmail
            // 
            this.panelEmail.Controls.Add(this.labelInvalidemail);
            this.panelEmail.Controls.Add(this.txtMail);
            this.panelEmail.Controls.Add(this.labeBio);
            this.panelEmail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEmail.Location = new System.Drawing.Point(0, 0);
            this.panelEmail.Margin = new System.Windows.Forms.Padding(0);
            this.panelEmail.Name = "panelEmail";
            this.panelEmail.Padding = new System.Windows.Forms.Padding(0, 24, 39, 0);
            this.panelEmail.Size = new System.Drawing.Size(459, 127);
            this.panelEmail.TabIndex = 0;
            // 
            // labelInvalidemail
            // 
            this.labelInvalidemail.AutoSize = true;
            this.labelInvalidemail.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelInvalidemail.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInvalidemail.ForeColor = System.Drawing.Color.Red;
            this.labelInvalidemail.Location = new System.Drawing.Point(0, 66);
            this.labelInvalidemail.Name = "labelInvalidemail";
            this.labelInvalidemail.Size = new System.Drawing.Size(130, 19);
            this.labelInvalidemail.TabIndex = 12;
            this.labelInvalidemail.Text = "Invalid email format";
            this.labelInvalidemail.Visible = false;
            // 
            // txtMail
            // 
            this.txtMail.AutoRoundedCorners = true;
            this.txtMail.BorderColor = System.Drawing.Color.Black;
            this.txtMail.BorderRadius = 20;
            this.txtMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMail.DefaultText = "";
            this.txtMail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMail.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtMail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtMail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.txtMail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMail.Location = new System.Drawing.Point(0, 24);
            this.txtMail.Margin = new System.Windows.Forms.Padding(0);
            this.txtMail.Name = "txtMail";
            this.txtMail.PasswordChar = '\0';
            this.txtMail.PlaceholderText = "";
            this.txtMail.SelectedText = "";
            this.txtMail.Size = new System.Drawing.Size(420, 42);
            this.txtMail.TabIndex = 10;
            this.txtMail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // labeBio
            // 
            this.labeBio.AutoSize = true;
            this.labeBio.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labeBio.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeBio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.labeBio.Location = new System.Drawing.Point(0, 102);
            this.labeBio.Name = "labeBio";
            this.labeBio.Size = new System.Drawing.Size(39, 25);
            this.labeBio.TabIndex = 9;
            this.labeBio.Text = "Bio";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.btnCancel, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.btnSubmit, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 258);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(459, 143);
            this.tableLayoutPanel4.TabIndex = 6;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BorderRadius = 8;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(233)))), ((int)(((byte)(236)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.btnCancel.Location = new System.Drawing.Point(264, 2);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 39, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(156, 42);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 8;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(218)))), ((int)(((byte)(251)))));
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.btnSubmit.Location = new System.Drawing.Point(3, 2);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(156, 42);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dtPickerBirth
            // 
            this.dtPickerBirth.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPickerBirth.Location = new System.Drawing.Point(7, 25);
            this.dtPickerBirth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPickerBirth.Name = "dtPickerBirth";
            this.dtPickerBirth.Size = new System.Drawing.Size(444, 30);
            this.dtPickerBirth.TabIndex = 9;
            // 
            // labelBirth
            // 
            this.labelBirth.AutoSize = true;
            this.labelBirth.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelBirth.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.labelBirth.Location = new System.Drawing.Point(0, 133);
            this.labelBirth.Name = "labelBirth";
            this.labelBirth.Size = new System.Drawing.Size(85, 25);
            this.labelBirth.TabIndex = 6;
            this.labelBirth.Text = "Birthday";
            // 
            // panelBirthday
            // 
            this.panelBirthday.Controls.Add(this.dtPickerBirth);
            this.panelBirthday.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBirthday.Location = new System.Drawing.Point(544, 158);
            this.panelBirthday.Margin = new System.Windows.Forms.Padding(0);
            this.panelBirthday.Name = "panelBirthday";
            this.panelBirthday.Size = new System.Drawing.Size(884, 120);
            this.panelBirthday.TabIndex = 10;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.labelEmail.Location = new System.Drawing.Point(0, 95);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(59, 25);
            this.labelEmail.TabIndex = 6;
            this.labelEmail.Text = "Email";
            // 
            // panelName
            // 
            this.panelName.Controls.Add(this.txtName);
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Controls.Add(this.labelGender);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelName.Location = new System.Drawing.Point(85, 0);
            this.panelName.Margin = new System.Windows.Forms.Padding(0);
            this.panelName.Name = "panelName";
            this.panelName.Padding = new System.Windows.Forms.Padding(0, 0, 39, 0);
            this.panelName.Size = new System.Drawing.Size(459, 158);
            this.panelName.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.AutoRoundedCorners = true;
            this.txtName.BorderColor = System.Drawing.Color.Black;
            this.txtName.BorderRadius = 20;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.DefaultText = "";
            this.txtName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtName.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.txtName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtName.Location = new System.Drawing.Point(0, 49);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.PlaceholderText = "";
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(420, 42);
            this.txtName.TabIndex = 11;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.labelName.Location = new System.Drawing.Point(0, 0);
            this.labelName.Margin = new System.Windows.Forms.Padding(0);
            this.labelName.Name = "labelName";
            this.labelName.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.labelName.Size = new System.Drawing.Size(64, 49);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Name";
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelGender.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.labelGender.Location = new System.Drawing.Point(0, 133);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(74, 25);
            this.labelGender.TabIndex = 5;
            this.labelGender.Text = "Gender";
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.genderGroupBox);
            this.panelGender.Controls.Add(this.labelEmail);
            this.panelGender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelGender.Location = new System.Drawing.Point(85, 158);
            this.panelGender.Margin = new System.Windows.Forms.Padding(0);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(459, 120);
            this.panelGender.TabIndex = 11;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.18391F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.8774F));
            this.tableLayoutPanel1.Controls.Add(this.panelName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelBirthday, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.panelGender, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panelUsernameEdit, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 203);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.24324F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.7027F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.78378F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1428, 679);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Image = global::ClientWinform.Properties.Resources.Setup_amico_1;
            this.pictureBox.Location = new System.Drawing.Point(547, 280);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(878, 397);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 12;
            this.pictureBox.TabStop = false;
            // 
            // panelUsernameEdit
            // 
            this.panelUsernameEdit.Controls.Add(this.txtUsername);
            this.panelUsernameEdit.Controls.Add(this.labelUsernameEdit);
            this.panelUsernameEdit.Controls.Add(this.labelBirth);
            this.panelUsernameEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUsernameEdit.Location = new System.Drawing.Point(544, 0);
            this.panelUsernameEdit.Margin = new System.Windows.Forms.Padding(0);
            this.panelUsernameEdit.Name = "panelUsernameEdit";
            this.panelUsernameEdit.Size = new System.Drawing.Size(884, 158);
            this.panelUsernameEdit.TabIndex = 13;
            // 
            // txtUsername
            // 
            this.txtUsername.AutoRoundedCorners = true;
            this.txtUsername.BorderColor = System.Drawing.Color.Black;
            this.txtUsername.BorderRadius = 20;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(7, 48);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(444, 42);
            this.txtUsername.TabIndex = 13;
            // 
            // labelUsernameEdit
            // 
            this.labelUsernameEdit.AutoSize = true;
            this.labelUsernameEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelUsernameEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsernameEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.labelUsernameEdit.Location = new System.Drawing.Point(0, 0);
            this.labelUsernameEdit.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsernameEdit.Name = "labelUsernameEdit";
            this.labelUsernameEdit.Padding = new System.Windows.Forms.Padding(0, 0, 0, 24);
            this.labelUsernameEdit.Size = new System.Drawing.Size(98, 49);
            this.labelUsernameEdit.TabIndex = 13;
            this.labelUsernameEdit.Text = "Username";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelUsername.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(16)))), ((int)(((byte)(14)))));
            this.labelUsername.Location = new System.Drawing.Point(0, 84);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Padding = new System.Windows.Forms.Padding(0, 0, 0, 12);
            this.labelUsername.Size = new System.Drawing.Size(0, 44);
            this.labelUsername.TabIndex = 3;
            // 
            // panelUserName
            // 
            this.panelUserName.Controls.Add(this.labelUsername);
            this.panelUserName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUserName.Location = new System.Drawing.Point(0, 0);
            this.panelUserName.Margin = new System.Windows.Forms.Padding(0);
            this.panelUserName.Name = "panelUserName";
            this.panelUserName.Size = new System.Drawing.Size(213, 128);
            this.panelUserName.TabIndex = 4;
            // 
            // tableLayoutPanelHead
            // 
            this.tableLayoutPanelHead.ColumnCount = 1;
            this.tableLayoutPanelHead.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelHead.Controls.Add(this.changeAvaBtn, 0, 1);
            this.tableLayoutPanelHead.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanelHead.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelHead.Location = new System.Drawing.Point(238, 0);
            this.tableLayoutPanelHead.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelHead.Name = "tableLayoutPanelHead";
            this.tableLayoutPanelHead.RowCount = 3;
            this.tableLayoutPanelHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.51064F));
            this.tableLayoutPanelHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.48936F));
            this.tableLayoutPanelHead.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelHead.Size = new System.Drawing.Size(1190, 203);
            this.tableLayoutPanelHead.TabIndex = 2;
            // 
            // changeAvaBtn
            // 
            this.changeAvaBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.changeAvaBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.changeAvaBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.changeAvaBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.changeAvaBtn.FillColor = System.Drawing.Color.White;
            this.changeAvaBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAvaBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(122)))), ((int)(((byte)(151)))), ((int)(((byte)(244)))));
            this.changeAvaBtn.HoverState.FillColor = System.Drawing.Color.White;
            this.changeAvaBtn.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(83)))), ((int)(((byte)(164)))));
            this.changeAvaBtn.Location = new System.Drawing.Point(0, 128);
            this.changeAvaBtn.Margin = new System.Windows.Forms.Padding(0);
            this.changeAvaBtn.Name = "changeAvaBtn";
            this.changeAvaBtn.PressedColor = System.Drawing.Color.White;
            this.changeAvaBtn.Size = new System.Drawing.Size(259, 37);
            this.changeAvaBtn.TabIndex = 5;
            this.changeAvaBtn.Text = "Change profile photo";
            this.changeAvaBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.changeAvaBtn.TextOffset = new System.Drawing.Point(-12, -2);
            this.changeAvaBtn.Click += new System.EventHandler(this.changeAvaBtn_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.93103F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.06896F));
            this.tableLayoutPanel2.Controls.Add(this.panelUserName, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1190, 128);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanelTittle
            // 
            this.tableLayoutPanelTittle.ColumnCount = 2;
            this.tableLayoutPanelTittle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.68274F));
            this.tableLayoutPanelTittle.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.31726F));
            this.tableLayoutPanelTittle.Controls.Add(this.picBoxAva, 0, 0);
            this.tableLayoutPanelTittle.Controls.Add(this.tableLayoutPanelHead, 1, 0);
            this.tableLayoutPanelTittle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelTittle.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelTittle.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelTittle.Name = "tableLayoutPanelTittle";
            this.tableLayoutPanelTittle.RowCount = 1;
            this.tableLayoutPanelTittle.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelTittle.Size = new System.Drawing.Size(1428, 203);
            this.tableLayoutPanelTittle.TabIndex = 0;
            // 
            // picBoxAva
            // 
            this.picBoxAva.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxAva.AutoRoundedCorners = true;
            this.picBoxAva.BorderRadius = 64;
            this.picBoxAva.ImageRotate = 0F;
            this.picBoxAva.Location = new System.Drawing.Point(74, 56);
            this.picBoxAva.Margin = new System.Windows.Forms.Padding(0, 0, 18, 16);
            this.picBoxAva.Name = "picBoxAva";
            this.picBoxAva.Size = new System.Drawing.Size(146, 131);
            this.picBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxAva.TabIndex = 7;
            this.picBoxAva.TabStop = false;
            // 
            // tableLayoutPanelMain
            // 
            this.tableLayoutPanelMain.ColumnCount = 1;
            this.tableLayoutPanelMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanelTittle, 0, 0);
            this.tableLayoutPanelMain.Controls.Add(this.tableLayoutPanel1, 0, 1);
            this.tableLayoutPanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelMain.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelMain.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanelMain.Name = "tableLayoutPanelMain";
            this.tableLayoutPanelMain.RowCount = 2;
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.049F));
            this.tableLayoutPanelMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.951F));
            this.tableLayoutPanelMain.Size = new System.Drawing.Size(1428, 882);
            this.tableLayoutPanelMain.TabIndex = 1;
            // 
            // UpdateProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1428, 882);
            this.Controls.Add(this.tableLayoutPanelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UpdateProfileForm";
            this.Text = "UpdateProfileForm";
            this.genderGroupBox.ResumeLayout(false);
            this.genderGroupBox.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelBio.ResumeLayout(false);
            this.panelEmail.ResumeLayout(false);
            this.panelEmail.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panelBirthday.ResumeLayout(false);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.panelUsernameEdit.ResumeLayout(false);
            this.panelUsernameEdit.PerformLayout();
            this.panelUserName.ResumeLayout(false);
            this.panelUserName.PerformLayout();
            this.tableLayoutPanelHead.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanelTittle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBoxAva)).EndInit();
            this.tableLayoutPanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GroupBox genderGroupBox;
        private System.Windows.Forms.RadioButton femaleBtn;
        private System.Windows.Forms.RadioButton maleBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelBio;
        private Guna.UI2.WinForms.Guna2TextBox txtBio;
        private System.Windows.Forms.Panel panelEmail;
        private Guna.UI2.WinForms.Guna2TextBox txtMail;
        private System.Windows.Forms.Label labeBio;
        private System.Windows.Forms.DateTimePicker dtPickerBirth;
        private System.Windows.Forms.Label labelBirth;
        private System.Windows.Forms.Panel panelBirthday;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Panel panelUserName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelHead;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelTittle;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMain;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Label labelName;
        private Guna.UI2.WinForms.Guna2TextBox txtName;
        private System.Windows.Forms.Panel panelUsernameEdit;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private System.Windows.Forms.Label labelUsernameEdit;
        private Guna.UI2.WinForms.Guna2Button changeAvaBtn;
        protected System.Windows.Forms.Label labelInvalidemail;
        private Guna.UI2.WinForms.Guna2PictureBox picBoxAva;
    }
}