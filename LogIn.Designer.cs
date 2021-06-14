
namespace JCFracturationSystem
{
    partial class LogIn
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.FormBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.DragLeft = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragRight = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.RightPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.SignUpButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PasswordTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.EmailTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBorder
            // 
            this.FormBorder.ElipseRadius = 20;
            this.FormBorder.TargetControl = this;
            // 
            // DragLeft
            // 
            this.DragLeft.Fixed = true;
            this.DragLeft.Horizontal = true;
            this.DragLeft.TargetControl = this.LeftPanel;
            this.DragLeft.Vertical = true;
            // 
            // DragRight
            // 
            this.DragRight.Fixed = true;
            this.DragRight.Horizontal = true;
            this.DragRight.TargetControl = this.RightPanel;
            this.DragRight.Vertical = true;
            // 
            // RightPanel
            // 
            this.RightPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.RightPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightPanel.BackgroundImage")));
            this.RightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.RightPanel.BorderRadius = 0;
            this.RightPanel.BorderThickness = 0;
            this.RightPanel.Controls.Add(this.SignUpButton);
            this.RightPanel.Controls.Add(this.PasswordTextBox);
            this.RightPanel.Controls.Add(this.EmailTextBox);
            this.RightPanel.Controls.Add(this.label3);
            this.RightPanel.Controls.Add(this.label2);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(500, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.ShowBorders = true;
            this.RightPanel.Size = new System.Drawing.Size(500, 630);
            this.RightPanel.TabIndex = 3;
            this.RightPanel.Click += new System.EventHandler(this.RightPanel_Click);
            // 
            // SignUpButton
            // 
            this.SignUpButton.AllowAnimations = true;
            this.SignUpButton.AllowMouseEffects = true;
            this.SignUpButton.AllowToggling = false;
            this.SignUpButton.AnimationSpeed = 200;
            this.SignUpButton.AutoGenerateColors = false;
            this.SignUpButton.AutoRoundBorders = false;
            this.SignUpButton.AutoSizeLeftIcon = true;
            this.SignUpButton.AutoSizeRightIcon = true;
            this.SignUpButton.BackColor = System.Drawing.Color.Transparent;
            this.SignUpButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.SignUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpButton.BackgroundImage")));
            this.SignUpButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.ButtonText = "Sign Up";
            this.SignUpButton.ButtonTextMarginLeft = 0;
            this.SignUpButton.ColorContrastOnClick = 45;
            this.SignUpButton.ColorContrastOnHover = 45;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.SignUpButton.CustomizableEdges = borderEdges1;
            this.SignUpButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold);
            this.SignUpButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SignUpButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SignUpButton.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SignUpButton.IconMarginLeft = 11;
            this.SignUpButton.IconPadding = 10;
            this.SignUpButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SignUpButton.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SignUpButton.IconSize = 25;
            this.SignUpButton.IdleBorderColor = System.Drawing.Color.Transparent;
            this.SignUpButton.IdleBorderRadius = 20;
            this.SignUpButton.IdleBorderThickness = 1;
            this.SignUpButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.SignUpButton.IdleIconLeftImage = null;
            this.SignUpButton.IdleIconRightImage = null;
            this.SignUpButton.IndicateFocus = false;
            this.SignUpButton.Location = new System.Drawing.Point(51, 464);
            this.SignUpButton.Margin = new System.Windows.Forms.Padding(2);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpButton.OnDisabledState.BorderRadius = 20;
            this.SignUpButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.OnDisabledState.BorderThickness = 1;
            this.SignUpButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpButton.OnDisabledState.IconLeftImage = null;
            this.SignUpButton.OnDisabledState.IconRightImage = null;
            this.SignUpButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.SignUpButton.onHoverState.BorderRadius = 20;
            this.SignUpButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.onHoverState.BorderThickness = 1;
            this.SignUpButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.SignUpButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.onHoverState.IconLeftImage = null;
            this.SignUpButton.onHoverState.IconRightImage = null;
            this.SignUpButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.SignUpButton.OnIdleState.BorderRadius = 20;
            this.SignUpButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.OnIdleState.BorderThickness = 1;
            this.SignUpButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.SignUpButton.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.SignUpButton.OnIdleState.IconLeftImage = null;
            this.SignUpButton.OnIdleState.IconRightImage = null;
            this.SignUpButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignUpButton.OnPressedState.BorderRadius = 20;
            this.SignUpButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.OnPressedState.BorderThickness = 1;
            this.SignUpButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.SignUpButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.OnPressedState.IconLeftImage = null;
            this.SignUpButton.OnPressedState.IconRightImage = null;
            this.SignUpButton.Size = new System.Drawing.Size(405, 49);
            this.SignUpButton.TabIndex = 4;
            this.SignUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUpButton.TextMarginLeft = 0;
            this.SignUpButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignUpButton.UseDefaultRadiusAndThickness = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.AcceptsReturn = false;
            this.PasswordTextBox.AcceptsTab = false;
            this.PasswordTextBox.AnimationSpeed = 200;
            this.PasswordTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.PasswordTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PasswordTextBox.BackgroundImage")));
            this.PasswordTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.PasswordTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PasswordTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.PasswordTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.PasswordTextBox.BorderRadius = 20;
            this.PasswordTextBox.BorderThickness = 2;
            this.PasswordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PasswordTextBox.HideSelection = true;
            this.PasswordTextBox.IconLeft = global::JCFracturationSystem.Properties.Resources.padlock;
            this.PasswordTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.IconPadding = 10;
            this.PasswordTextBox.IconRight = global::JCFracturationSystem.Properties.Resources.visibility;
            this.PasswordTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(51, 370);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordTextBox.Modified = false;
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTextBox.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTextBox.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTextBox.OnIdleState = stateProperties4;
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.ReadOnly = false;
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(405, 49);
            this.PasswordTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordTextBox.TextMarginBottom = 0;
            this.PasswordTextBox.TextMarginLeft = 10;
            this.PasswordTextBox.TextMarginTop = 0;
            this.PasswordTextBox.TextPlaceholder = "Password";
            this.PasswordTextBox.UseSystemPasswordChar = false;
            this.PasswordTextBox.WordWrap = true;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.AcceptsReturn = false;
            this.EmailTextBox.AcceptsTab = false;
            this.EmailTextBox.AnimationSpeed = 200;
            this.EmailTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmailTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmailTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.EmailTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EmailTextBox.BackgroundImage")));
            this.EmailTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.EmailTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EmailTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.EmailTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            this.EmailTextBox.BorderRadius = 20;
            this.EmailTextBox.BorderThickness = 2;
            this.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
            this.EmailTextBox.DefaultText = "";
            this.EmailTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EmailTextBox.HideSelection = true;
            this.EmailTextBox.IconLeft = global::JCFracturationSystem.Properties.Resources.mail;
            this.EmailTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.IconPadding = 10;
            this.EmailTextBox.IconRight = null;
            this.EmailTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.Lines = new string[0];
            this.EmailTextBox.Location = new System.Drawing.Point(51, 268);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.EmailTextBox.MaxLength = 32767;
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmailTextBox.Modified = false;
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailTextBox.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.EmailTextBox.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailTextBox.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            stateProperties8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailTextBox.OnIdleState = stateProperties8;
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.EmailTextBox.PlaceholderText = "Email";
            this.EmailTextBox.ReadOnly = false;
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.SelectionLength = 0;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.ShortcutsEnabled = true;
            this.EmailTextBox.Size = new System.Drawing.Size(405, 49);
            this.EmailTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.EmailTextBox.TabIndex = 0;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailTextBox.TextMarginBottom = 0;
            this.EmailTextBox.TextMarginLeft = 10;
            this.EmailTextBox.TextMarginTop = 0;
            this.EmailTextBox.TextPlaceholder = "Email";
            this.EmailTextBox.UseSystemPasswordChar = false;
            this.EmailTextBox.WordWrap = true;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(53, 339);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(52, 237);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 41.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(36, 134);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 63);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.LeftPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPanel.BackgroundImage")));
            this.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.LeftPanel.BorderRadius = 0;
            this.LeftPanel.BorderThickness = 0;
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.ShowBorders = true;
            this.LeftPanel.Size = new System.Drawing.Size(500, 630);
            this.LeftPanel.TabIndex = 2;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 630);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormBorder;
        private Bunifu.UI.WinForms.BunifuPanel RightPanel;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignUpButton;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordTextBox;
        private Bunifu.UI.WinForms.BunifuTextBox EmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl DragLeft;
        private Bunifu.Framework.UI.BunifuDragControl DragRight;
        private Bunifu.UI.WinForms.BunifuPanel LeftPanel;
    }
}

