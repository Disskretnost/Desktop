
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties21 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties22 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties23 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties24 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties17 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties18 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties19 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties20 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.registerlabel = new System.Windows.Forms.Label();
            this.resetLabel = new System.Windows.Forms.Label();
            this.Close = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LoginAuto = new Bunifu.UI.WinForms.BunifuTextBox();
            this.PasswordAuto = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuButton2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // registerlabel
            // 
            this.registerlabel.AutoSize = true;
            this.registerlabel.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerlabel.ForeColor = System.Drawing.Color.White;
            this.registerlabel.Location = new System.Drawing.Point(71, 470);
            this.registerlabel.Name = "registerlabel";
            this.registerlabel.Size = new System.Drawing.Size(128, 27);
            this.registerlabel.TabIndex = 9;
            this.registerlabel.Text = "Регистрация";
            this.registerlabel.Click += new System.EventHandler(this.registerlabel_Click);
            this.registerlabel.MouseLeave += new System.EventHandler(this.registerlabel_MouseLeave);
            this.registerlabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.registerlabel_MouseMove);
            // 
            // resetLabel
            // 
            this.resetLabel.AutoSize = true;
            this.resetLabel.Font = new System.Drawing.Font("Bell MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetLabel.ForeColor = System.Drawing.Color.White;
            this.resetLabel.Location = new System.Drawing.Point(247, 470);
            this.resetLabel.Name = "resetLabel";
            this.resetLabel.Size = new System.Drawing.Size(160, 27);
            this.resetLabel.TabIndex = 10;
            this.resetLabel.Text = "Забыли пароль?";
            this.resetLabel.Click += new System.EventHandler(this.resetLabel_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Rockwell", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Location = new System.Drawing.Point(420, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(28, 32);
            this.Close.TabIndex = 11;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            this.Close.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Close_MouseMove);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(190, 33);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(110, 110);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(69, 234);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(69, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 35;
            this.bunifuElipse1.TargetControl = this;
            // 
            // LoginAuto
            // 
            this.LoginAuto.AcceptsReturn = false;
            this.LoginAuto.AcceptsTab = false;
            this.LoginAuto.AnimationSpeed = 200;
            this.LoginAuto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LoginAuto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LoginAuto.BackColor = System.Drawing.Color.Transparent;
            this.LoginAuto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginAuto.BackgroundImage")));
            this.LoginAuto.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.LoginAuto.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoginAuto.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.LoginAuto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoginAuto.BorderRadius = 20;
            this.LoginAuto.BorderThickness = 1;
            this.LoginAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LoginAuto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginAuto.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.LoginAuto.DefaultText = "";
            this.LoginAuto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.LoginAuto.ForeColor = System.Drawing.Color.White;
            this.LoginAuto.HideSelection = true;
            this.LoginAuto.IconLeft = null;
            this.LoginAuto.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginAuto.IconPadding = 10;
            this.LoginAuto.IconRight = null;
            this.LoginAuto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.LoginAuto.Lines = new string[0];
            this.LoginAuto.Location = new System.Drawing.Point(118, 234);
            this.LoginAuto.MaxLength = 32767;
            this.LoginAuto.MinimumSize = new System.Drawing.Size(1, 1);
            this.LoginAuto.Modified = false;
            this.LoginAuto.Multiline = false;
            this.LoginAuto.Name = "LoginAuto";
            stateProperties21.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            stateProperties21.FillColor = System.Drawing.Color.Empty;
            stateProperties21.ForeColor = System.Drawing.Color.Empty;
            stateProperties21.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LoginAuto.OnActiveState = stateProperties21;
            stateProperties22.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties22.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties22.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.LoginAuto.OnDisabledState = stateProperties22;
            stateProperties23.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            stateProperties23.FillColor = System.Drawing.Color.Empty;
            stateProperties23.ForeColor = System.Drawing.Color.Empty;
            stateProperties23.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LoginAuto.OnHoverState = stateProperties23;
            stateProperties24.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            stateProperties24.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            stateProperties24.ForeColor = System.Drawing.Color.White;
            stateProperties24.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.LoginAuto.OnIdleState = stateProperties24;
            this.LoginAuto.Padding = new System.Windows.Forms.Padding(3);
            this.LoginAuto.PasswordChar = '\0';
            this.LoginAuto.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.LoginAuto.PlaceholderText = "Login";
            this.LoginAuto.ReadOnly = false;
            this.LoginAuto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LoginAuto.SelectedText = "";
            this.LoginAuto.SelectionLength = 0;
            this.LoginAuto.SelectionStart = 0;
            this.LoginAuto.ShortcutsEnabled = true;
            this.LoginAuto.Size = new System.Drawing.Size(260, 43);
            this.LoginAuto.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.LoginAuto.TabIndex = 13;
            this.LoginAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LoginAuto.TextMarginBottom = 0;
            this.LoginAuto.TextMarginLeft = 3;
            this.LoginAuto.TextMarginTop = 0;
            this.LoginAuto.TextPlaceholder = "Login";
            this.LoginAuto.UseSystemPasswordChar = false;
            this.LoginAuto.WordWrap = true;
            this.LoginAuto.TextChanged += new System.EventHandler(this.LoginAuto_TextChanged);
            // 
            // PasswordAuto
            // 
            this.PasswordAuto.AcceptsReturn = false;
            this.PasswordAuto.AcceptsTab = false;
            this.PasswordAuto.AnimationSpeed = 200;
            this.PasswordAuto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordAuto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordAuto.BackColor = System.Drawing.Color.Transparent;
            this.PasswordAuto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordAuto.BackgroundImage")));
            this.PasswordAuto.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.PasswordAuto.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordAuto.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.PasswordAuto.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PasswordAuto.BorderRadius = 20;
            this.PasswordAuto.BorderThickness = 1;
            this.PasswordAuto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordAuto.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordAuto.DefaultFont = new System.Drawing.Font("Segoe UI", 9.25F);
            this.PasswordAuto.DefaultText = "";
            this.PasswordAuto.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.PasswordAuto.ForeColor = System.Drawing.Color.White;
            this.PasswordAuto.HideSelection = true;
            this.PasswordAuto.IconLeft = null;
            this.PasswordAuto.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordAuto.IconPadding = 10;
            this.PasswordAuto.IconRight = null;
            this.PasswordAuto.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordAuto.Lines = new string[0];
            this.PasswordAuto.Location = new System.Drawing.Point(118, 298);
            this.PasswordAuto.MaxLength = 32767;
            this.PasswordAuto.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordAuto.Modified = false;
            this.PasswordAuto.Multiline = false;
            this.PasswordAuto.Name = "PasswordAuto";
            stateProperties17.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            stateProperties17.FillColor = System.Drawing.Color.Empty;
            stateProperties17.ForeColor = System.Drawing.Color.Empty;
            stateProperties17.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordAuto.OnActiveState = stateProperties17;
            stateProperties18.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties18.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties18.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordAuto.OnDisabledState = stateProperties18;
            stateProperties19.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            stateProperties19.FillColor = System.Drawing.Color.Empty;
            stateProperties19.ForeColor = System.Drawing.Color.Empty;
            stateProperties19.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordAuto.OnHoverState = stateProperties19;
            stateProperties20.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            stateProperties20.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            stateProperties20.ForeColor = System.Drawing.Color.White;
            stateProperties20.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordAuto.OnIdleState = stateProperties20;
            this.PasswordAuto.Padding = new System.Windows.Forms.Padding(3);
            this.PasswordAuto.PasswordChar = '\0';
            this.PasswordAuto.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordAuto.PlaceholderText = "Password";
            this.PasswordAuto.ReadOnly = false;
            this.PasswordAuto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordAuto.SelectedText = "";
            this.PasswordAuto.SelectionLength = 0;
            this.PasswordAuto.SelectionStart = 0;
            this.PasswordAuto.ShortcutsEnabled = true;
            this.PasswordAuto.Size = new System.Drawing.Size(260, 43);
            this.PasswordAuto.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PasswordAuto.TabIndex = 14;
            this.PasswordAuto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordAuto.TextMarginBottom = 0;
            this.PasswordAuto.TextMarginLeft = 3;
            this.PasswordAuto.TextMarginTop = 0;
            this.PasswordAuto.TextPlaceholder = "Password";
            this.PasswordAuto.UseSystemPasswordChar = false;
            this.PasswordAuto.WordWrap = true;
            this.PasswordAuto.TextChange += new System.EventHandler(this.PasswordAuto_TextChange);
            this.PasswordAuto.TextChanged += new System.EventHandler(this.PasswordAuto_TextChanged);
            // 
            // bunifuButton2
            // 
            this.bunifuButton2.AllowAnimations = true;
            this.bunifuButton2.AllowMouseEffects = true;
            this.bunifuButton2.AllowToggling = false;
            this.bunifuButton2.AnimationSpeed = 200;
            this.bunifuButton2.AutoGenerateColors = false;
            this.bunifuButton2.AutoRoundBorders = false;
            this.bunifuButton2.AutoSizeLeftIcon = true;
            this.bunifuButton2.AutoSizeRightIcon = true;
            this.bunifuButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton2.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton2.BackgroundImage")));
            this.bunifuButton2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.ButtonText = "Войти";
            this.bunifuButton2.ButtonTextMarginLeft = 0;
            this.bunifuButton2.ColorContrastOnClick = 45;
            this.bunifuButton2.ColorContrastOnHover = 45;
            this.bunifuButton2.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.bunifuButton2.CustomizableEdges = borderEdges3;
            this.bunifuButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuButton2.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.bunifuButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bunifuButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuButton2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.bunifuButton2.IconMarginLeft = 11;
            this.bunifuButton2.IconPadding = 10;
            this.bunifuButton2.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bunifuButton2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton2.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.bunifuButton2.IconSize = 25;
            this.bunifuButton2.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton2.IdleBorderRadius = 25;
            this.bunifuButton2.IdleBorderThickness = 1;
            this.bunifuButton2.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton2.IdleIconLeftImage = null;
            this.bunifuButton2.IdleIconRightImage = null;
            this.bunifuButton2.IndicateFocus = false;
            this.bunifuButton2.Location = new System.Drawing.Point(160, 377);
            this.bunifuButton2.Name = "bunifuButton2";
            this.bunifuButton2.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.bunifuButton2.OnDisabledState.BorderRadius = 25;
            this.bunifuButton2.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnDisabledState.BorderThickness = 1;
            this.bunifuButton2.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.bunifuButton2.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.bunifuButton2.OnDisabledState.IconLeftImage = null;
            this.bunifuButton2.OnDisabledState.IconRightImage = null;
            this.bunifuButton2.onHoverState.BorderColor = System.Drawing.Color.Teal;
            this.bunifuButton2.onHoverState.BorderRadius = 25;
            this.bunifuButton2.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.onHoverState.BorderThickness = 1;
            this.bunifuButton2.onHoverState.FillColor = System.Drawing.Color.Teal;
            this.bunifuButton2.onHoverState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.onHoverState.IconLeftImage = null;
            this.bunifuButton2.onHoverState.IconRightImage = null;
            this.bunifuButton2.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton2.OnIdleState.BorderRadius = 25;
            this.bunifuButton2.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnIdleState.BorderThickness = 1;
            this.bunifuButton2.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton2.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnIdleState.IconLeftImage = null;
            this.bunifuButton2.OnIdleState.IconRightImage = null;
            this.bunifuButton2.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton2.OnPressedState.BorderRadius = 25;
            this.bunifuButton2.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.bunifuButton2.OnPressedState.BorderThickness = 1;
            this.bunifuButton2.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.bunifuButton2.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.bunifuButton2.OnPressedState.IconLeftImage = null;
            this.bunifuButton2.OnPressedState.IconRightImage = null;
            this.bunifuButton2.Size = new System.Drawing.Size(156, 45);
            this.bunifuButton2.TabIndex = 16;
            this.bunifuButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton2.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.bunifuButton2.TextMarginLeft = 0;
            this.bunifuButton2.TextPadding = new System.Windows.Forms.Padding(0);
            this.bunifuButton2.UseDefaultRadiusAndThickness = true;
            this.bunifuButton2.Click += new System.EventHandler(this.bunifuButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bell MT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(154, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Авторизация";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(460, 550);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuButton2);
            this.Controls.Add(this.PasswordAuto);
            this.Controls.Add(this.LoginAuto);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.resetLabel);
            this.Controls.Add(this.registerlabel);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label registerlabel;
        private System.Windows.Forms.Label resetLabel;
        private System.Windows.Forms.Label Close;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuTextBox LoginAuto;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordAuto;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton2;
        private System.Windows.Forms.Label label1;
    }
}

