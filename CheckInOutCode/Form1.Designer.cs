namespace CheckInOutCode
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BSignin = new MetroFramework.Controls.MetroButton();
            this.PSignin = new MetroFramework.Controls.MetroPanel();
            this.PSignout = new MetroFramework.Controls.MetroPanel();
            this.PSignedIn = new MetroFramework.Controls.MetroPanel();
            this.PSignedOut = new MetroFramework.Controls.MetroPanel();
            this.SignedOutLabel = new MetroFramework.Controls.MetroLabel();
            this.SignedInLabel = new MetroFramework.Controls.MetroLabel();
            this.LNameSoNull = new MetroFramework.Controls.MetroLabel();
            this.FNameSoNull = new MetroFramework.Controls.MetroLabel();
            this.LNameSO = new MetroFramework.Controls.MetroTextBox();
            this.SignOutLNameLabel = new MetroFramework.Controls.MetroLabel();
            this.BBackFromSignOut = new MetroFramework.Controls.MetroButton();
            this.FNameSO = new MetroFramework.Controls.MetroTextBox();
            this.BSubmitSignOut = new MetroFramework.Controls.MetroButton();
            this.SignOutFNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SignOutPanelLabel = new MetroFramework.Controls.MetroLabel();
            this.NextPsi = new MetroFramework.Controls.MetroButton();
            this.G8 = new MetroFramework.Controls.MetroRadioButton();
            this.G7 = new MetroFramework.Controls.MetroRadioButton();
            this.G6 = new MetroFramework.Controls.MetroRadioButton();
            this.SignInGradeLabel = new MetroFramework.Controls.MetroLabel();
            this.PsiID = new MetroFramework.Controls.MetroTextBox();
            this.SignInIDLabel = new MetroFramework.Controls.MetroLabel();
            this.PsiLName = new MetroFramework.Controls.MetroTextBox();
            this.SignInLNameLabel = new MetroFramework.Controls.MetroLabel();
            this.PsiFName = new MetroFramework.Controls.MetroTextBox();
            this.SignInFNameLabel = new MetroFramework.Controls.MetroLabel();
            this.SignInPanelLabel = new MetroFramework.Controls.MetroLabel();
            this.PsiBack = new MetroFramework.Controls.MetroButton();
            this.TchCh = new MetroFramework.Controls.MetroComboBox();
            this.SignInSeeingLabel = new MetroFramework.Controls.MetroLabel();
            this.TeacherNull = new MetroFramework.Controls.MetroLabel();
            this.GradeNull = new MetroFramework.Controls.MetroLabel();
            this.IDNull = new MetroFramework.Controls.MetroLabel();
            this.LNameNull = new MetroFramework.Controls.MetroLabel();
            this.FNameNull = new MetroFramework.Controls.MetroLabel();
            this.SignInTeacherLabel = new MetroFramework.Controls.MetroLabel();
            this.BSignout1 = new MetroFramework.Controls.MetroButton();
            this.Header = new MetroFramework.Controls.MetroPanel();
            this.ChargerLogo = new System.Windows.Forms.PictureBox();
            this.HeaderText = new MetroFramework.Controls.MetroLabel();
            this.SouthText = new System.Windows.Forms.PictureBox();
            this.PSignin.SuspendLayout();
            this.PSignout.SuspendLayout();
            this.PSignedIn.SuspendLayout();
            this.PSignedOut.SuspendLayout();
            this.Header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChargerLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthText)).BeginInit();
            this.SuspendLayout();
            // 
            // BSignin
            // 
            this.BSignin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BSignin.AutoSize = true;
            this.BSignin.BackColor = System.Drawing.Color.Silver;
            this.BSignin.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BSignin.Location = new System.Drawing.Point(557, 477);
            this.BSignin.Name = "BSignin";
            this.BSignin.Size = new System.Drawing.Size(212, 106);
            this.BSignin.Style = MetroFramework.MetroColorStyle.Silver;
            this.BSignin.TabIndex = 1;
            this.BSignin.TabStop = false;
            this.BSignin.Text = "Sign In";
            this.BSignin.UseCustomBackColor = true;
            this.BSignin.UseSelectable = true;
            this.BSignin.Click += new System.EventHandler(this.BSignin_Click_1);
            // 
            // PSignin
            // 
            this.PSignin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PSignin.BackColor = System.Drawing.Color.LightGray;
            this.PSignin.Controls.Add(this.PSignout);
            this.PSignin.Controls.Add(this.NextPsi);
            this.PSignin.Controls.Add(this.G8);
            this.PSignin.Controls.Add(this.G7);
            this.PSignin.Controls.Add(this.G6);
            this.PSignin.Controls.Add(this.SignInGradeLabel);
            this.PSignin.Controls.Add(this.PsiID);
            this.PSignin.Controls.Add(this.SignInIDLabel);
            this.PSignin.Controls.Add(this.PsiLName);
            this.PSignin.Controls.Add(this.SignInLNameLabel);
            this.PSignin.Controls.Add(this.PsiFName);
            this.PSignin.Controls.Add(this.SignInFNameLabel);
            this.PSignin.Controls.Add(this.SignInPanelLabel);
            this.PSignin.Controls.Add(this.PsiBack);
            this.PSignin.Controls.Add(this.TchCh);
            this.PSignin.Controls.Add(this.SignInSeeingLabel);
            this.PSignin.Controls.Add(this.TeacherNull);
            this.PSignin.Controls.Add(this.GradeNull);
            this.PSignin.Controls.Add(this.IDNull);
            this.PSignin.Controls.Add(this.LNameNull);
            this.PSignin.Controls.Add(this.FNameNull);
            this.PSignin.Controls.Add(this.SignInTeacherLabel);
            this.PSignin.HorizontalScrollbarBarColor = true;
            this.PSignin.HorizontalScrollbarHighlightOnWheel = false;
            this.PSignin.HorizontalScrollbarSize = 10;
            this.PSignin.Location = new System.Drawing.Point(0, 0);
            this.PSignin.Name = "PSignin";
            this.PSignin.Size = new System.Drawing.Size(1920, 1084);
            this.PSignin.Style = MetroFramework.MetroColorStyle.Silver;
            this.PSignin.TabIndex = 2;
            this.PSignin.VerticalScrollbarBarColor = true;
            this.PSignin.VerticalScrollbarHighlightOnWheel = false;
            this.PSignin.VerticalScrollbarSize = 10;
            // 
            // PSignout
            // 
            this.PSignout.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PSignout.Controls.Add(this.PSignedIn);
            this.PSignout.Controls.Add(this.LNameSoNull);
            this.PSignout.Controls.Add(this.FNameSoNull);
            this.PSignout.Controls.Add(this.LNameSO);
            this.PSignout.Controls.Add(this.SignOutLNameLabel);
            this.PSignout.Controls.Add(this.BBackFromSignOut);
            this.PSignout.Controls.Add(this.FNameSO);
            this.PSignout.Controls.Add(this.BSubmitSignOut);
            this.PSignout.Controls.Add(this.SignOutFNameLabel);
            this.PSignout.Controls.Add(this.SignOutPanelLabel);
            this.PSignout.HorizontalScrollbarBarColor = true;
            this.PSignout.HorizontalScrollbarHighlightOnWheel = false;
            this.PSignout.HorizontalScrollbarSize = 10;
            this.PSignout.Location = new System.Drawing.Point(0, 2);
            this.PSignout.Name = "PSignout";
            this.PSignout.Size = new System.Drawing.Size(1920, 1079);
            this.PSignout.Style = MetroFramework.MetroColorStyle.Silver;
            this.PSignout.TabIndex = 24;
            this.PSignout.VerticalScrollbarBarColor = true;
            this.PSignout.VerticalScrollbarHighlightOnWheel = false;
            this.PSignout.VerticalScrollbarSize = 10;
            // 
            // PSignedIn
            // 
            this.PSignedIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PSignedIn.BackColor = System.Drawing.Color.LightGray;
            this.PSignedIn.Controls.Add(this.PSignedOut);
            this.PSignedIn.Controls.Add(this.SignedInLabel);
            this.PSignedIn.HorizontalScrollbarBarColor = true;
            this.PSignedIn.HorizontalScrollbarHighlightOnWheel = false;
            this.PSignedIn.HorizontalScrollbarSize = 10;
            this.PSignedIn.Location = new System.Drawing.Point(0, -1);
            this.PSignedIn.Name = "PSignedIn";
            this.PSignedIn.Size = new System.Drawing.Size(1920, 1083);
            this.PSignedIn.Style = MetroFramework.MetroColorStyle.Silver;
            this.PSignedIn.TabIndex = 33;
            this.PSignedIn.VerticalScrollbarBarColor = true;
            this.PSignedIn.VerticalScrollbarHighlightOnWheel = false;
            this.PSignedIn.VerticalScrollbarSize = 10;
            // 
            // PSignedOut
            // 
            this.PSignedOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PSignedOut.BackColor = System.Drawing.Color.White;
            this.PSignedOut.Controls.Add(this.SignedOutLabel);
            this.PSignedOut.HorizontalScrollbarBarColor = true;
            this.PSignedOut.HorizontalScrollbarHighlightOnWheel = false;
            this.PSignedOut.HorizontalScrollbarSize = 10;
            this.PSignedOut.Location = new System.Drawing.Point(0, 1);
            this.PSignedOut.Name = "PSignedOut";
            this.PSignedOut.Size = new System.Drawing.Size(1920, 1079);
            this.PSignedOut.Style = MetroFramework.MetroColorStyle.Silver;
            this.PSignedOut.TabIndex = 3;
            this.PSignedOut.VerticalScrollbarBarColor = true;
            this.PSignedOut.VerticalScrollbarHighlightOnWheel = false;
            this.PSignedOut.VerticalScrollbarSize = 10;
            // 
            // SignedOutLabel
            // 
            this.SignedOutLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignedOutLabel.AutoSize = true;
            this.SignedOutLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignedOutLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignedOutLabel.Location = new System.Drawing.Point(850, 566);
            this.SignedOutLabel.Name = "SignedOutLabel";
            this.SignedOutLabel.Size = new System.Drawing.Size(238, 25);
            this.SignedOutLabel.TabIndex = 2;
            this.SignedOutLabel.Text = "Thank you, have a great day.";
            // 
            // SignedInLabel
            // 
            this.SignedInLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignedInLabel.AutoSize = true;
            this.SignedInLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignedInLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignedInLabel.Location = new System.Drawing.Point(730, 568);
            this.SignedInLabel.Name = "SignedInLabel";
            this.SignedInLabel.Size = new System.Drawing.Size(503, 25);
            this.SignedInLabel.TabIndex = 2;
            this.SignedInLabel.Text = "Thank you, please have a seat, and we will be with you shortly.";
            // 
            // LNameSoNull
            // 
            this.LNameSoNull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNameSoNull.AutoSize = true;
            this.LNameSoNull.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LNameSoNull.ForeColor = System.Drawing.Color.Red;
            this.LNameSoNull.Location = new System.Drawing.Point(1099, 700);
            this.LNameSoNull.Name = "LNameSoNull";
            this.LNameSoNull.Size = new System.Drawing.Size(223, 19);
            this.LNameSoNull.TabIndex = 11;
            this.LNameSoNull.Text = "* You must enter your last name";
            this.LNameSoNull.UseCustomForeColor = true;
            // 
            // FNameSoNull
            // 
            this.FNameSoNull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FNameSoNull.AutoSize = true;
            this.FNameSoNull.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.FNameSoNull.ForeColor = System.Drawing.Color.Red;
            this.FNameSoNull.Location = new System.Drawing.Point(1099, 585);
            this.FNameSoNull.Name = "FNameSoNull";
            this.FNameSoNull.Size = new System.Drawing.Size(226, 19);
            this.FNameSoNull.TabIndex = 10;
            this.FNameSoNull.Text = "* You must enter your first name";
            this.FNameSoNull.UseCustomForeColor = true;
            // 
            // LNameSO
            // 
            this.LNameSO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNameSO.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.LNameSO.CustomButton.Image = null;
            this.LNameSO.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.LNameSO.CustomButton.Name = "";
            this.LNameSO.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.LNameSO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.LNameSO.CustomButton.TabIndex = 1;
            this.LNameSO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.LNameSO.CustomButton.UseSelectable = true;
            this.LNameSO.CustomButton.Visible = false;
            this.LNameSO.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.LNameSO.Lines = new string[0];
            this.LNameSO.Location = new System.Drawing.Point(843, 700);
            this.LNameSO.MaxLength = 32767;
            this.LNameSO.Name = "LNameSO";
            this.LNameSO.PasswordChar = '\0';
            this.LNameSO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LNameSO.SelectedText = "";
            this.LNameSO.SelectionLength = 0;
            this.LNameSO.SelectionStart = 0;
            this.LNameSO.ShortcutsEnabled = true;
            this.LNameSO.Size = new System.Drawing.Size(250, 27);
            this.LNameSO.Style = MetroFramework.MetroColorStyle.Silver;
            this.LNameSO.TabIndex = 7;
            this.LNameSO.UseSelectable = true;
            this.LNameSO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.LNameSO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SignOutLNameLabel
            // 
            this.SignOutLNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignOutLNameLabel.AutoSize = true;
            this.SignOutLNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignOutLNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignOutLNameLabel.Location = new System.Drawing.Point(736, 700);
            this.SignOutLNameLabel.Name = "SignOutLNameLabel";
            this.SignOutLNameLabel.Size = new System.Drawing.Size(99, 25);
            this.SignOutLNameLabel.TabIndex = 8;
            this.SignOutLNameLabel.Text = "Last Name:";
            // 
            // BBackFromSignOut
            // 
            this.BBackFromSignOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BBackFromSignOut.BackColor = System.Drawing.Color.Silver;
            this.BBackFromSignOut.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BBackFromSignOut.Location = new System.Drawing.Point(1535, 1010);
            this.BBackFromSignOut.Name = "BBackFromSignOut";
            this.BBackFromSignOut.Size = new System.Drawing.Size(180, 55);
            this.BBackFromSignOut.Style = MetroFramework.MetroColorStyle.Silver;
            this.BBackFromSignOut.TabIndex = 8;
            this.BBackFromSignOut.Text = "Back";
            this.BBackFromSignOut.UseCustomBackColor = true;
            this.BBackFromSignOut.UseSelectable = true;
            this.BBackFromSignOut.Click += new System.EventHandler(this.PsoBack_Click);
            // 
            // FNameSO
            // 
            this.FNameSO.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.FNameSO.CustomButton.Image = null;
            this.FNameSO.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.FNameSO.CustomButton.Name = "";
            this.FNameSO.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.FNameSO.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.FNameSO.CustomButton.TabIndex = 1;
            this.FNameSO.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.FNameSO.CustomButton.UseSelectable = true;
            this.FNameSO.CustomButton.Visible = false;
            this.FNameSO.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.FNameSO.Lines = new string[0];
            this.FNameSO.Location = new System.Drawing.Point(843, 585);
            this.FNameSO.MaxLength = 32767;
            this.FNameSO.Name = "FNameSO";
            this.FNameSO.PasswordChar = '\0';
            this.FNameSO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FNameSO.SelectedText = "";
            this.FNameSO.SelectionLength = 0;
            this.FNameSO.SelectionStart = 0;
            this.FNameSO.ShortcutsEnabled = true;
            this.FNameSO.Size = new System.Drawing.Size(250, 27);
            this.FNameSO.Style = MetroFramework.MetroColorStyle.Silver;
            this.FNameSO.TabIndex = 6;
            this.FNameSO.UseSelectable = true;
            this.FNameSO.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.FNameSO.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // BSubmitSignOut
            // 
            this.BSubmitSignOut.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BSubmitSignOut.BackColor = System.Drawing.Color.Silver;
            this.BSubmitSignOut.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.BSubmitSignOut.Location = new System.Drawing.Point(1721, 1010);
            this.BSubmitSignOut.Name = "BSubmitSignOut";
            this.BSubmitSignOut.Size = new System.Drawing.Size(180, 55);
            this.BSubmitSignOut.Style = MetroFramework.MetroColorStyle.Silver;
            this.BSubmitSignOut.TabIndex = 9;
            this.BSubmitSignOut.Text = "Submit";
            this.BSubmitSignOut.UseCustomBackColor = true;
            this.BSubmitSignOut.UseSelectable = true;
            this.BSubmitSignOut.Click += new System.EventHandler(this.NextPso_Click);
            // 
            // SignOutFNameLabel
            // 
            this.SignOutFNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignOutFNameLabel.AutoSize = true;
            this.SignOutFNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignOutFNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignOutFNameLabel.Location = new System.Drawing.Point(736, 585);
            this.SignOutFNameLabel.Name = "SignOutFNameLabel";
            this.SignOutFNameLabel.Size = new System.Drawing.Size(101, 25);
            this.SignOutFNameLabel.TabIndex = 3;
            this.SignOutFNameLabel.Text = "First Name:";
            // 
            // SignOutPanelLabel
            // 
            this.SignOutPanelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignOutPanelLabel.AutoSize = true;
            this.SignOutPanelLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignOutPanelLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SignOutPanelLabel.Location = new System.Drawing.Point(892, 427);
            this.SignOutPanelLabel.Name = "SignOutPanelLabel";
            this.SignOutPanelLabel.Size = new System.Drawing.Size(143, 25);
            this.SignOutPanelLabel.TabIndex = 2;
            this.SignOutPanelLabel.Text = "Office Sign Out";
            // 
            // NextPsi
            // 
            this.NextPsi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.NextPsi.BackColor = System.Drawing.Color.Silver;
            this.NextPsi.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.NextPsi.Location = new System.Drawing.Point(1721, 1013);
            this.NextPsi.Name = "NextPsi";
            this.NextPsi.Size = new System.Drawing.Size(180, 55);
            this.NextPsi.Style = MetroFramework.MetroColorStyle.Silver;
            this.NextPsi.TabIndex = 9;
            this.NextPsi.Text = "Submit";
            this.NextPsi.UseCustomBackColor = true;
            this.NextPsi.UseSelectable = true;
            this.NextPsi.Click += new System.EventHandler(this.NextPsi_Click);
            // 
            // G8
            // 
            this.G8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G8.AutoSize = true;
            this.G8.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.G8.Location = new System.Drawing.Point(983, 593);
            this.G8.Name = "G8";
            this.G8.Size = new System.Drawing.Size(46, 19);
            this.G8.Style = MetroFramework.MetroColorStyle.Silver;
            this.G8.TabIndex = 6;
            this.G8.Text = "8th";
            this.G8.UseSelectable = true;
            // 
            // G7
            // 
            this.G7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G7.AutoSize = true;
            this.G7.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.G7.Location = new System.Drawing.Point(910, 593);
            this.G7.Name = "G7";
            this.G7.Size = new System.Drawing.Size(46, 19);
            this.G7.Style = MetroFramework.MetroColorStyle.Silver;
            this.G7.TabIndex = 5;
            this.G7.Text = "7th";
            this.G7.UseSelectable = true;
            // 
            // G6
            // 
            this.G6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.G6.AutoSize = true;
            this.G6.FontSize = MetroFramework.MetroCheckBoxSize.Medium;
            this.G6.Location = new System.Drawing.Point(847, 593);
            this.G6.Name = "G6";
            this.G6.Size = new System.Drawing.Size(46, 19);
            this.G6.Style = MetroFramework.MetroColorStyle.Silver;
            this.G6.TabIndex = 4;
            this.G6.Text = "6th";
            this.G6.UseSelectable = true;
            // 
            // SignInGradeLabel
            // 
            this.SignInGradeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInGradeLabel.AutoSize = true;
            this.SignInGradeLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignInGradeLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignInGradeLabel.Location = new System.Drawing.Point(743, 587);
            this.SignInGradeLabel.Name = "SignInGradeLabel";
            this.SignInGradeLabel.Size = new System.Drawing.Size(63, 25);
            this.SignInGradeLabel.TabIndex = 19;
            this.SignInGradeLabel.Text = "Grade:";
            // 
            // PsiID
            // 
            this.PsiID.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.PsiID.CustomButton.Image = null;
            this.PsiID.CustomButton.Location = new System.Drawing.Point(62, 1);
            this.PsiID.CustomButton.Name = "";
            this.PsiID.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PsiID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PsiID.CustomButton.TabIndex = 1;
            this.PsiID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PsiID.CustomButton.UseSelectable = true;
            this.PsiID.CustomButton.Visible = false;
            this.PsiID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PsiID.Lines = new string[0];
            this.PsiID.Location = new System.Drawing.Point(847, 525);
            this.PsiID.MaxLength = 5;
            this.PsiID.Name = "PsiID";
            this.PsiID.PasswordChar = '\0';
            this.PsiID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PsiID.SelectedText = "";
            this.PsiID.SelectionLength = 0;
            this.PsiID.SelectionStart = 0;
            this.PsiID.ShortcutsEnabled = true;
            this.PsiID.Size = new System.Drawing.Size(88, 27);
            this.PsiID.Style = MetroFramework.MetroColorStyle.Silver;
            this.PsiID.TabIndex = 3;
            this.PsiID.UseSelectable = true;
            this.PsiID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PsiID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SignInIDLabel
            // 
            this.SignInIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInIDLabel.AutoSize = true;
            this.SignInIDLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignInIDLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignInIDLabel.Location = new System.Drawing.Point(743, 527);
            this.SignInIDLabel.Name = "SignInIDLabel";
            this.SignInIDLabel.Size = new System.Drawing.Size(101, 25);
            this.SignInIDLabel.TabIndex = 17;
            this.SignInIDLabel.Text = "ID number:";
            // 
            // PsiLName
            // 
            this.PsiLName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.PsiLName.CustomButton.Image = null;
            this.PsiLName.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.PsiLName.CustomButton.Name = "";
            this.PsiLName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PsiLName.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.PsiLName.CustomButton.TabIndex = 1;
            this.PsiLName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PsiLName.CustomButton.UseSelectable = true;
            this.PsiLName.CustomButton.Visible = false;
            this.PsiLName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PsiLName.Lines = new string[0];
            this.PsiLName.Location = new System.Drawing.Point(847, 467);
            this.PsiLName.MaxLength = 32767;
            this.PsiLName.Name = "PsiLName";
            this.PsiLName.PasswordChar = '\0';
            this.PsiLName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PsiLName.SelectedText = "";
            this.PsiLName.SelectionLength = 0;
            this.PsiLName.SelectionStart = 0;
            this.PsiLName.ShortcutsEnabled = true;
            this.PsiLName.Size = new System.Drawing.Size(250, 27);
            this.PsiLName.Style = MetroFramework.MetroColorStyle.Silver;
            this.PsiLName.TabIndex = 2;
            this.PsiLName.UseSelectable = true;
            this.PsiLName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PsiLName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SignInLNameLabel
            // 
            this.SignInLNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInLNameLabel.AutoSize = true;
            this.SignInLNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignInLNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignInLNameLabel.Location = new System.Drawing.Point(743, 467);
            this.SignInLNameLabel.Name = "SignInLNameLabel";
            this.SignInLNameLabel.Size = new System.Drawing.Size(96, 25);
            this.SignInLNameLabel.TabIndex = 15;
            this.SignInLNameLabel.Text = "Last name:";
            // 
            // PsiFName
            // 
            this.PsiFName.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.PsiFName.CustomButton.Image = null;
            this.PsiFName.CustomButton.Location = new System.Drawing.Point(224, 1);
            this.PsiFName.CustomButton.Name = "";
            this.PsiFName.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.PsiFName.CustomButton.Style = MetroFramework.MetroColorStyle.Silver;
            this.PsiFName.CustomButton.TabIndex = 1;
            this.PsiFName.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.PsiFName.CustomButton.UseSelectable = true;
            this.PsiFName.CustomButton.Visible = false;
            this.PsiFName.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.PsiFName.Lines = new string[0];
            this.PsiFName.Location = new System.Drawing.Point(847, 407);
            this.PsiFName.MaxLength = 32767;
            this.PsiFName.Name = "PsiFName";
            this.PsiFName.PasswordChar = '\0';
            this.PsiFName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PsiFName.SelectedText = "";
            this.PsiFName.SelectionLength = 0;
            this.PsiFName.SelectionStart = 0;
            this.PsiFName.ShortcutsEnabled = true;
            this.PsiFName.Size = new System.Drawing.Size(250, 27);
            this.PsiFName.Style = MetroFramework.MetroColorStyle.Silver;
            this.PsiFName.TabIndex = 1;
            this.PsiFName.UseSelectable = true;
            this.PsiFName.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.PsiFName.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // SignInFNameLabel
            // 
            this.SignInFNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInFNameLabel.AutoSize = true;
            this.SignInFNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignInFNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignInFNameLabel.Location = new System.Drawing.Point(743, 407);
            this.SignInFNameLabel.Name = "SignInFNameLabel";
            this.SignInFNameLabel.Size = new System.Drawing.Size(98, 25);
            this.SignInFNameLabel.TabIndex = 13;
            this.SignInFNameLabel.Text = "First name:";
            // 
            // SignInPanelLabel
            // 
            this.SignInPanelLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInPanelLabel.AutoSize = true;
            this.SignInPanelLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignInPanelLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.SignInPanelLabel.Location = new System.Drawing.Point(901, 332);
            this.SignInPanelLabel.Name = "SignInPanelLabel";
            this.SignInPanelLabel.Size = new System.Drawing.Size(128, 25);
            this.SignInPanelLabel.TabIndex = 12;
            this.SignInPanelLabel.Text = "Office Sign In";
            // 
            // PsiBack
            // 
            this.PsiBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.PsiBack.BackColor = System.Drawing.Color.Silver;
            this.PsiBack.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.PsiBack.Location = new System.Drawing.Point(1535, 1013);
            this.PsiBack.Name = "PsiBack";
            this.PsiBack.Size = new System.Drawing.Size(180, 55);
            this.PsiBack.Style = MetroFramework.MetroColorStyle.Silver;
            this.PsiBack.TabIndex = 8;
            this.PsiBack.Text = "Back";
            this.PsiBack.UseCustomBackColor = true;
            this.PsiBack.UseSelectable = true;
            this.PsiBack.Click += new System.EventHandler(this.PsiBack_Click);
            // 
            // TchCh
            // 
            this.TchCh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TchCh.FormattingEnabled = true;
            this.TchCh.ItemHeight = 23;
            this.TchCh.Items.AddRange(new object[] {
            "Counselor - Maria De La Fuente",
            "Counselor - Kimberly Berny",
            "Counselor - Gina Evans",
            "AP - Summer Gault",
            "AP - Matt Myers",
            "AP - Jarred Wingfield"});
            this.TchCh.Location = new System.Drawing.Point(847, 742);
            this.TchCh.Name = "TchCh";
            this.TchCh.Size = new System.Drawing.Size(250, 29);
            this.TchCh.Style = MetroFramework.MetroColorStyle.Silver;
            this.TchCh.TabIndex = 7;
            this.TchCh.UseSelectable = true;
            // 
            // SignInSeeingLabel
            // 
            this.SignInSeeingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInSeeingLabel.AutoSize = true;
            this.SignInSeeingLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignInSeeingLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignInSeeingLabel.Location = new System.Drawing.Point(847, 680);
            this.SignInSeeingLabel.Name = "SignInSeeingLabel";
            this.SignInSeeingLabel.Size = new System.Drawing.Size(214, 25);
            this.SignInSeeingLabel.TabIndex = 25;
            this.SignInSeeingLabel.Text = "Who are you here to see?";
            // 
            // TeacherNull
            // 
            this.TeacherNull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TeacherNull.AutoSize = true;
            this.TeacherNull.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.TeacherNull.ForeColor = System.Drawing.Color.Red;
            this.TeacherNull.Location = new System.Drawing.Point(1103, 742);
            this.TeacherNull.Name = "TeacherNull";
            this.TeacherNull.Size = new System.Drawing.Size(189, 19);
            this.TeacherNull.TabIndex = 31;
            this.TeacherNull.Text = "* You must select a teacher";
            this.TeacherNull.UseCustomForeColor = true;
            // 
            // GradeNull
            // 
            this.GradeNull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GradeNull.AutoSize = true;
            this.GradeNull.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.GradeNull.ForeColor = System.Drawing.Color.Red;
            this.GradeNull.Location = new System.Drawing.Point(1035, 593);
            this.GradeNull.Name = "GradeNull";
            this.GradeNull.Size = new System.Drawing.Size(179, 19);
            this.GradeNull.TabIndex = 30;
            this.GradeNull.Text = "* You must select a grade";
            this.GradeNull.UseCustomForeColor = true;
            // 
            // IDNull
            // 
            this.IDNull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.IDNull.AutoSize = true;
            this.IDNull.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.IDNull.ForeColor = System.Drawing.Color.Red;
            this.IDNull.Location = new System.Drawing.Point(941, 525);
            this.IDNull.Name = "IDNull";
            this.IDNull.Size = new System.Drawing.Size(173, 19);
            this.IDNull.TabIndex = 29;
            this.IDNull.Text = "* You must enter your ID";
            this.IDNull.UseCustomForeColor = true;
            // 
            // LNameNull
            // 
            this.LNameNull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LNameNull.AutoSize = true;
            this.LNameNull.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.LNameNull.ForeColor = System.Drawing.Color.Red;
            this.LNameNull.Location = new System.Drawing.Point(1103, 467);
            this.LNameNull.Name = "LNameNull";
            this.LNameNull.Size = new System.Drawing.Size(223, 19);
            this.LNameNull.TabIndex = 28;
            this.LNameNull.Text = "* You must enter your last name";
            this.LNameNull.UseCustomForeColor = true;
            // 
            // FNameNull
            // 
            this.FNameNull.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.FNameNull.AutoSize = true;
            this.FNameNull.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.FNameNull.ForeColor = System.Drawing.Color.Red;
            this.FNameNull.Location = new System.Drawing.Point(1103, 405);
            this.FNameNull.Name = "FNameNull";
            this.FNameNull.Size = new System.Drawing.Size(226, 19);
            this.FNameNull.TabIndex = 27;
            this.FNameNull.Text = "* You must enter your first name";
            this.FNameNull.UseCustomForeColor = true;
            // 
            // SignInTeacherLabel
            // 
            this.SignInTeacherLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignInTeacherLabel.AutoSize = true;
            this.SignInTeacherLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.SignInTeacherLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.SignInTeacherLabel.Location = new System.Drawing.Point(743, 742);
            this.SignInTeacherLabel.Name = "SignInTeacherLabel";
            this.SignInTeacherLabel.Size = new System.Drawing.Size(76, 25);
            this.SignInTeacherLabel.TabIndex = 32;
            this.SignInTeacherLabel.Text = "Teacher:";
            // 
            // BSignout1
            // 
            this.BSignout1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BSignout1.AutoSize = true;
            this.BSignout1.BackColor = System.Drawing.Color.Silver;
            this.BSignout1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.BSignout1.Location = new System.Drawing.Point(1179, 477);
            this.BSignout1.Name = "BSignout1";
            this.BSignout1.Size = new System.Drawing.Size(212, 106);
            this.BSignout1.Style = MetroFramework.MetroColorStyle.Silver;
            this.BSignout1.TabIndex = 3;
            this.BSignout1.TabStop = false;
            this.BSignout1.Text = "Sign Out";
            this.BSignout1.UseCustomBackColor = true;
            this.BSignout1.UseSelectable = true;
            this.BSignout1.Click += new System.EventHandler(this.BSignout_Click);
            // 
            // Header
            // 
            this.Header.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Header.AutoSize = true;
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(35)))), ((int)(((byte)(64)))));
            this.Header.Controls.Add(this.ChargerLogo);
            this.Header.Controls.Add(this.HeaderText);
            this.Header.ForeColor = System.Drawing.Color.White;
            this.Header.HorizontalScrollbarBarColor = true;
            this.Header.HorizontalScrollbarHighlightOnWheel = false;
            this.Header.HorizontalScrollbarSize = 10;
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Header.Size = new System.Drawing.Size(1923, 183);
            this.Header.Style = MetroFramework.MetroColorStyle.White;
            this.Header.TabIndex = 4;
            this.Header.UseCustomBackColor = true;
            this.Header.UseCustomForeColor = true;
            this.Header.UseStyleColors = true;
            this.Header.VerticalScrollbarBarColor = true;
            this.Header.VerticalScrollbarHighlightOnWheel = false;
            this.Header.VerticalScrollbarSize = 10;
            // 
            // ChargerLogo
            // 
            this.ChargerLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ChargerLogo.Image = ((System.Drawing.Image)(resources.GetObject("ChargerLogo.Image")));
            this.ChargerLogo.Location = new System.Drawing.Point(365, 22);
            this.ChargerLogo.Name = "ChargerLogo";
            this.ChargerLogo.Size = new System.Drawing.Size(160, 135);
            this.ChargerLogo.TabIndex = 4;
            this.ChargerLogo.TabStop = false;
            // 
            // HeaderText
            // 
            this.HeaderText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderText.AutoSize = true;
            this.HeaderText.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.HeaderText.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.HeaderText.ForeColor = System.Drawing.SystemColors.Control;
            this.HeaderText.Location = new System.Drawing.Point(911, 91);
            this.HeaderText.Name = "HeaderText";
            this.HeaderText.Size = new System.Drawing.Size(119, 25);
            this.HeaderText.TabIndex = 3;
            this.HeaderText.Text = "Office Sign In";
            this.HeaderText.UseCustomBackColor = true;
            this.HeaderText.UseCustomForeColor = true;
            // 
            // SouthText
            // 
            this.SouthText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SouthText.BackColor = System.Drawing.Color.White;
            this.SouthText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SouthText.BackgroundImage")));
            this.SouthText.Location = new System.Drawing.Point(25, 963);
            this.SouthText.Name = "SouthText";
            this.SouthText.Size = new System.Drawing.Size(1149, 94);
            this.SouthText.TabIndex = 5;
            this.SouthText.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.SouthText);
            this.Controls.Add(this.PSignin);
            this.Controls.Add(this.BSignin);
            this.Controls.Add(this.BSignout1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Movable = false;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.NavyBlue;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.PSignin.ResumeLayout(false);
            this.PSignin.PerformLayout();
            this.PSignout.ResumeLayout(false);
            this.PSignout.PerformLayout();
            this.PSignedIn.ResumeLayout(false);
            this.PSignedIn.PerformLayout();
            this.PSignedOut.ResumeLayout(false);
            this.PSignedOut.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChargerLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SouthText)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton BSignin;
        private MetroFramework.Controls.MetroButton BSignout1;
        private MetroFramework.Controls.MetroPanel PSignin;
        private MetroFramework.Controls.MetroLabel SignInPanelLabel;
        private MetroFramework.Controls.MetroLabel SignInFNameLabel;
        private MetroFramework.Controls.MetroTextBox PsiFName;
        private MetroFramework.Controls.MetroLabel SignInLNameLabel;
        private MetroFramework.Controls.MetroTextBox PsiLName;
        private MetroFramework.Controls.MetroLabel SignInIDLabel;
        private MetroFramework.Controls.MetroTextBox PsiID;
        private MetroFramework.Controls.MetroLabel SignInGradeLabel;
        private MetroFramework.Controls.MetroRadioButton G6;
        private MetroFramework.Controls.MetroRadioButton G7;
        private MetroFramework.Controls.MetroRadioButton G8;
        private MetroFramework.Controls.MetroButton NextPsi;
        private MetroFramework.Controls.MetroPanel PSignout;
        private MetroFramework.Controls.MetroLabel SignOutPanelLabel;
        private MetroFramework.Controls.MetroLabel SignOutFNameLabel;
        private MetroFramework.Controls.MetroButton BSubmitSignOut;
        private MetroFramework.Controls.MetroTextBox FNameSO;
        private MetroFramework.Controls.MetroButton PsiBack;
        private MetroFramework.Controls.MetroButton BBackFromSignOut;
        private MetroFramework.Controls.MetroLabel SignInSeeingLabel;
        private MetroFramework.Controls.MetroComboBox TchCh;
        private MetroFramework.Controls.MetroLabel FNameNull;
        private MetroFramework.Controls.MetroLabel LNameNull;
        private MetroFramework.Controls.MetroLabel TeacherNull;
        private MetroFramework.Controls.MetroLabel GradeNull;
        private MetroFramework.Controls.MetroLabel IDNull;
        private MetroFramework.Controls.MetroLabel SignInTeacherLabel;
        private MetroFramework.Controls.MetroTextBox LNameSO;
        private MetroFramework.Controls.MetroLabel SignOutLNameLabel;
        private MetroFramework.Controls.MetroLabel LNameSoNull;
        private MetroFramework.Controls.MetroLabel FNameSoNull;
        private MetroFramework.Controls.MetroPanel PSignedIn;
        private MetroFramework.Controls.MetroLabel SignedInLabel;
        private MetroFramework.Controls.MetroPanel PSignedOut;
        private MetroFramework.Controls.MetroLabel SignedOutLabel;
        private MetroFramework.Controls.MetroPanel Header;
        private MetroFramework.Controls.MetroLabel HeaderText;
        private System.Windows.Forms.PictureBox ChargerLogo;
        private System.Windows.Forms.PictureBox SouthText;
    }
}

