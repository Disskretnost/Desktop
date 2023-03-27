
namespace CrimeaCloud
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuPanel1 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuPanel3 = new Bunifu.UI.WinForms.BunifuPanel();
            this.MyDrive = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel2 = new Bunifu.UI.WinForms.BunifuPanel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.Close = new System.Windows.Forms.Label();
            this.History = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuPanel1
            // 
            this.bunifuPanel1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel1.BackgroundImage")));
            this.bunifuPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel1.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel1.BorderRadius = 0;
            this.bunifuPanel1.BorderThickness = 0;
            this.bunifuPanel1.Controls.Add(this.History);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel3);
            this.bunifuPanel1.Controls.Add(this.MyDrive);
            this.bunifuPanel1.Controls.Add(this.bunifuPanel2);
            this.bunifuPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel1.Name = "bunifuPanel1";
            this.bunifuPanel1.ShowBorders = true;
            this.bunifuPanel1.Size = new System.Drawing.Size(273, 894);
            this.bunifuPanel1.TabIndex = 0;
            this.bunifuPanel1.Click += new System.EventHandler(this.bunifuPanel1_Click);
            // 
            // bunifuPanel3
            // 
            this.bunifuPanel3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuPanel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel3.BackgroundImage")));
            this.bunifuPanel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuPanel3.BorderRadius = 0;
            this.bunifuPanel3.BorderThickness = 0;
            this.bunifuPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel3.Location = new System.Drawing.Point(0, 225);
            this.bunifuPanel3.Name = "bunifuPanel3";
            this.bunifuPanel3.ShowBorders = true;
            this.bunifuPanel3.Size = new System.Drawing.Size(273, 49);
            this.bunifuPanel3.TabIndex = 6;
            // 
            // MyDrive
            // 
            this.MyDrive.AllowAnimations = true;
            this.MyDrive.AllowMouseEffects = true;
            this.MyDrive.AllowToggling = false;
            this.MyDrive.AnimationSpeed = 200;
            this.MyDrive.AutoGenerateColors = false;
            this.MyDrive.AutoRoundBorders = false;
            this.MyDrive.AutoSizeLeftIcon = true;
            this.MyDrive.AutoSizeRightIcon = true;
            this.MyDrive.BackColor = System.Drawing.Color.Transparent;
            this.MyDrive.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MyDrive.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MyDrive.BackgroundImage")));
            this.MyDrive.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MyDrive.ButtonText = "My Drive";
            this.MyDrive.ButtonTextMarginLeft = 0;
            this.MyDrive.ColorContrastOnClick = 45;
            this.MyDrive.ColorContrastOnHover = 45;
            this.MyDrive.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.MyDrive.CustomizableEdges = borderEdges2;
            this.MyDrive.DialogResult = System.Windows.Forms.DialogResult.None;
            this.MyDrive.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.MyDrive.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MyDrive.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.MyDrive.Dock = System.Windows.Forms.DockStyle.Top;
            this.MyDrive.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.MyDrive.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyDrive.ForeColor = System.Drawing.Color.White;
            this.MyDrive.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.MyDrive.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.MyDrive.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.MyDrive.IconMarginLeft = 11;
            this.MyDrive.IconPadding = 10;
            this.MyDrive.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.MyDrive.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.MyDrive.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.MyDrive.IconSize = 25;
            this.MyDrive.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MyDrive.IdleBorderRadius = 1;
            this.MyDrive.IdleBorderThickness = 1;
            this.MyDrive.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MyDrive.IdleIconLeftImage = null;
            this.MyDrive.IdleIconRightImage = null;
            this.MyDrive.IndicateFocus = false;
            this.MyDrive.Location = new System.Drawing.Point(0, 170);
            this.MyDrive.Name = "MyDrive";
            this.MyDrive.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.MyDrive.OnDisabledState.BorderRadius = 1;
            this.MyDrive.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MyDrive.OnDisabledState.BorderThickness = 1;
            this.MyDrive.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.MyDrive.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.MyDrive.OnDisabledState.IconLeftImage = null;
            this.MyDrive.OnDisabledState.IconRightImage = null;
            this.MyDrive.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.MyDrive.onHoverState.BorderRadius = 1;
            this.MyDrive.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MyDrive.onHoverState.BorderThickness = 1;
            this.MyDrive.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.MyDrive.onHoverState.ForeColor = System.Drawing.Color.White;
            this.MyDrive.onHoverState.IconLeftImage = null;
            this.MyDrive.onHoverState.IconRightImage = null;
            this.MyDrive.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MyDrive.OnIdleState.BorderRadius = 1;
            this.MyDrive.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MyDrive.OnIdleState.BorderThickness = 1;
            this.MyDrive.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MyDrive.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.MyDrive.OnIdleState.IconLeftImage = null;
            this.MyDrive.OnIdleState.IconRightImage = null;
            this.MyDrive.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MyDrive.OnPressedState.BorderRadius = 1;
            this.MyDrive.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.MyDrive.OnPressedState.BorderThickness = 1;
            this.MyDrive.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.MyDrive.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.MyDrive.OnPressedState.IconLeftImage = null;
            this.MyDrive.OnPressedState.IconRightImage = null;
            this.MyDrive.Size = new System.Drawing.Size(273, 55);
            this.MyDrive.TabIndex = 2;
            this.MyDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MyDrive.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.MyDrive.TextMarginLeft = 0;
            this.MyDrive.TextPadding = new System.Windows.Forms.Padding(0);
            this.MyDrive.UseDefaultRadiusAndThickness = true;
            this.MyDrive.Click += new System.EventHandler(this.MyDrive_Click);
            // 
            // bunifuPanel2
            // 
            this.bunifuPanel2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bunifuPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuPanel2.BackgroundImage")));
            this.bunifuPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuPanel2.BorderColor = System.Drawing.Color.Transparent;
            this.bunifuPanel2.BorderRadius = 0;
            this.bunifuPanel2.BorderThickness = 0;
            this.bunifuPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuPanel2.Location = new System.Drawing.Point(0, 0);
            this.bunifuPanel2.Name = "bunifuPanel2";
            this.bunifuPanel2.ShowBorders = true;
            this.bunifuPanel2.Size = new System.Drawing.Size(273, 170);
            this.bunifuPanel2.TabIndex = 1;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 25;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(1485, 12);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(21, 21);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 36;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // Close
            // 
            this.Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Close.Font = new System.Drawing.Font("Berlin Sans FB", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.Color.MintCream;
            this.Close.Location = new System.Drawing.Point(1512, 9);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(27, 30);
            this.Close.TabIndex = 37;
            this.Close.Text = "X";
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // History
            // 
            this.History.AllowAnimations = true;
            this.History.AllowMouseEffects = true;
            this.History.AllowToggling = false;
            this.History.AnimationSpeed = 200;
            this.History.AutoGenerateColors = false;
            this.History.AutoRoundBorders = false;
            this.History.AutoSizeLeftIcon = true;
            this.History.AutoSizeRightIcon = true;
            this.History.BackColor = System.Drawing.Color.Transparent;
            this.History.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.History.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("History.BackgroundImage")));
            this.History.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.History.ButtonText = "History";
            this.History.ButtonTextMarginLeft = 0;
            this.History.ColorContrastOnClick = 45;
            this.History.ColorContrastOnHover = 45;
            this.History.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.History.CustomizableEdges = borderEdges1;
            this.History.DialogResult = System.Windows.Forms.DialogResult.None;
            this.History.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.History.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.History.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.History.Dock = System.Windows.Forms.DockStyle.Top;
            this.History.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.History.Font = new System.Drawing.Font("Microsoft Tai Le", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.History.ForeColor = System.Drawing.Color.White;
            this.History.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.History.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.History.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.History.IconMarginLeft = 11;
            this.History.IconPadding = 10;
            this.History.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.History.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.History.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.History.IconSize = 25;
            this.History.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.History.IdleBorderRadius = 1;
            this.History.IdleBorderThickness = 1;
            this.History.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.History.IdleIconLeftImage = null;
            this.History.IdleIconRightImage = null;
            this.History.IndicateFocus = false;
            this.History.Location = new System.Drawing.Point(0, 274);
            this.History.Name = "History";
            this.History.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.History.OnDisabledState.BorderRadius = 1;
            this.History.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.History.OnDisabledState.BorderThickness = 1;
            this.History.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.History.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.History.OnDisabledState.IconLeftImage = null;
            this.History.OnDisabledState.IconRightImage = null;
            this.History.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.History.onHoverState.BorderRadius = 1;
            this.History.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.History.onHoverState.BorderThickness = 1;
            this.History.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(147)))), ((int)(((byte)(147)))));
            this.History.onHoverState.ForeColor = System.Drawing.Color.White;
            this.History.onHoverState.IconLeftImage = null;
            this.History.onHoverState.IconRightImage = null;
            this.History.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.History.OnIdleState.BorderRadius = 1;
            this.History.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.History.OnIdleState.BorderThickness = 1;
            this.History.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.History.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.History.OnIdleState.IconLeftImage = null;
            this.History.OnIdleState.IconRightImage = null;
            this.History.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.History.OnPressedState.BorderRadius = 1;
            this.History.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.History.OnPressedState.BorderThickness = 1;
            this.History.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.History.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.History.OnPressedState.IconLeftImage = null;
            this.History.OnPressedState.IconRightImage = null;
            this.History.Size = new System.Drawing.Size(273, 55);
            this.History.TabIndex = 7;
            this.History.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.History.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.History.TextMarginLeft = 0;
            this.History.TextPadding = new System.Windows.Forms.Padding(0);
            this.History.UseDefaultRadiusAndThickness = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1551, 894);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.bunifuPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.bunifuPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label Close;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel2;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton MyDrive;
        private Bunifu.UI.WinForms.BunifuPanel bunifuPanel3;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton History;
    }
}