﻿
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties25 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties26 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties27 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties28 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties29 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties30 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties31 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties32 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            this.FormBorder = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.LeftPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.ShowPasswordLabel = new System.Windows.Forms.Label();
            this.ShowPasswordCheckBox = new Bunifu.UI.WinForms.BunifuCheckBox();
            this.SignUpButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.PasswordTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.EmailTextBox = new Bunifu.UI.WinForms.BunifuTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.RightPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.DragLeft = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.DragRight = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.RightPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FormBorder
            // 
            this.FormBorder.ElipseRadius = 20;
            this.FormBorder.TargetControl = this;
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
            this.LeftPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.ShowBorders = true;
            this.LeftPanel.Size = new System.Drawing.Size(500, 583);
            this.LeftPanel.TabIndex = 2;
            // 
            // ShowPasswordLabel
            // 
            this.ShowPasswordLabel.AutoSize = true;
            this.ShowPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordLabel.Font = new System.Drawing.Font("Quicksand", 11F, System.Drawing.FontStyle.Bold);
            this.ShowPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ShowPasswordLabel.Location = new System.Drawing.Point(107, 441);
            this.ShowPasswordLabel.Name = "ShowPasswordLabel";
            this.ShowPasswordLabel.Size = new System.Drawing.Size(155, 28);
            this.ShowPasswordLabel.TabIndex = 6;
            this.ShowPasswordLabel.Text = "Show password";
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AllowBindingControlAnimation = true;
            this.ShowPasswordCheckBox.AllowBindingControlColorChanges = false;
            this.ShowPasswordCheckBox.AllowBindingControlLocation = true;
            this.ShowPasswordCheckBox.AllowCheckBoxAnimation = true;
            this.ShowPasswordCheckBox.AllowCheckmarkAnimation = true;
            this.ShowPasswordCheckBox.AllowOnHoverStates = true;
            this.ShowPasswordCheckBox.AutoCheck = true;
            this.ShowPasswordCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowPasswordCheckBox.BackgroundImage")));
            this.ShowPasswordCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ShowPasswordCheckBox.BindingControlPosition = Bunifu.UI.WinForms.BunifuCheckBox.BindingControlPositions.Right;
            this.ShowPasswordCheckBox.BorderRadius = 10;
            this.ShowPasswordCheckBox.Checked = false;
            this.ShowPasswordCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
            this.ShowPasswordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ShowPasswordCheckBox.CustomCheckmarkImage = null;
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(66, 438);
            this.ShowPasswordCheckBox.MinimumSize = new System.Drawing.Size(17, 17);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.OnCheck.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ShowPasswordCheckBox.OnCheck.BorderRadius = 10;
            this.ShowPasswordCheckBox.OnCheck.BorderThickness = 2;
            this.ShowPasswordCheckBox.OnCheck.CheckBoxColor = System.Drawing.Color.DodgerBlue;
            this.ShowPasswordCheckBox.OnCheck.CheckmarkColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.OnCheck.CheckmarkThickness = 2;
            this.ShowPasswordCheckBox.OnDisable.BorderColor = System.Drawing.Color.LightGray;
            this.ShowPasswordCheckBox.OnDisable.BorderRadius = 10;
            this.ShowPasswordCheckBox.OnDisable.BorderThickness = 2;
            this.ShowPasswordCheckBox.OnDisable.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.OnDisable.CheckmarkColor = System.Drawing.Color.LightGray;
            this.ShowPasswordCheckBox.OnDisable.CheckmarkThickness = 2;
            this.ShowPasswordCheckBox.OnHoverChecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ShowPasswordCheckBox.OnHoverChecked.BorderRadius = 10;
            this.ShowPasswordCheckBox.OnHoverChecked.BorderThickness = 2;
            this.ShowPasswordCheckBox.OnHoverChecked.CheckBoxColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ShowPasswordCheckBox.OnHoverChecked.CheckmarkColor = System.Drawing.Color.White;
            this.ShowPasswordCheckBox.OnHoverChecked.CheckmarkThickness = 2;
            this.ShowPasswordCheckBox.OnHoverUnchecked.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.ShowPasswordCheckBox.OnHoverUnchecked.BorderRadius = 10;
            this.ShowPasswordCheckBox.OnHoverUnchecked.BorderThickness = 1;
            this.ShowPasswordCheckBox.OnHoverUnchecked.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.OnUncheck.BorderColor = System.Drawing.Color.DarkGray;
            this.ShowPasswordCheckBox.OnUncheck.BorderRadius = 10;
            this.ShowPasswordCheckBox.OnUncheck.BorderThickness = 1;
            this.ShowPasswordCheckBox.OnUncheck.CheckBoxColor = System.Drawing.Color.Transparent;
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(35, 35);
            this.ShowPasswordCheckBox.Style = Bunifu.UI.WinForms.BunifuCheckBox.CheckBoxStyles.Bunifu;
            this.ShowPasswordCheckBox.TabIndex = 5;
            this.ShowPasswordCheckBox.ThreeState = false;
            this.ShowPasswordCheckBox.ToolTipText = null;
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
            this.SignUpButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.SignUpButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SignUpButton.BackgroundImage")));
            this.SignUpButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.ButtonText = "Sign Up";
            this.SignUpButton.ButtonTextMarginLeft = 0;
            this.SignUpButton.ColorContrastOnClick = 45;
            this.SignUpButton.ColorContrastOnHover = 45;
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.SignUpButton.CustomizableEdges = borderEdges4;
            this.SignUpButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SignUpButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpButton.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpButton.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SignUpButton.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold);
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
            this.SignUpButton.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.SignUpButton.IdleIconLeftImage = null;
            this.SignUpButton.IdleIconRightImage = null;
            this.SignUpButton.IndicateFocus = false;
            this.SignUpButton.Location = new System.Drawing.Point(56, 510);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SignUpButton.OnDisabledState.BorderRadius = 20;
            this.SignUpButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.OnDisabledState.BorderThickness = 1;
            this.SignUpButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SignUpButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SignUpButton.OnDisabledState.IconLeftImage = null;
            this.SignUpButton.OnDisabledState.IconRightImage = null;
            this.SignUpButton.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SignUpButton.onHoverState.BorderRadius = 20;
            this.SignUpButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.onHoverState.BorderThickness = 1;
            this.SignUpButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.SignUpButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SignUpButton.onHoverState.IconLeftImage = null;
            this.SignUpButton.onHoverState.IconRightImage = null;
            this.SignUpButton.OnIdleState.BorderColor = System.Drawing.Color.Transparent;
            this.SignUpButton.OnIdleState.BorderRadius = 20;
            this.SignUpButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SignUpButton.OnIdleState.BorderThickness = 1;
            this.SignUpButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
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
            this.SignUpButton.Size = new System.Drawing.Size(400, 60);
            this.SignUpButton.TabIndex = 4;
            this.SignUpButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SignUpButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SignUpButton.TextMarginLeft = 0;
            this.SignUpButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.SignUpButton.UseDefaultRadiusAndThickness = true;
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
            this.PasswordTextBox.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.PasswordTextBox.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PasswordTextBox.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            this.PasswordTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PasswordTextBox.BorderRadius = 20;
            this.PasswordTextBox.BorderThickness = 2;
            this.PasswordTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordTextBox.DefaultText = "";
            this.PasswordTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.PasswordTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PasswordTextBox.HideSelection = true;
            this.PasswordTextBox.IconLeft = null;
            this.PasswordTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.IconPadding = 10;
            this.PasswordTextBox.IconRight = null;
            this.PasswordTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(56, 369);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.PasswordTextBox.Modified = false;
            this.PasswordTextBox.Multiline = false;
            this.PasswordTextBox.Name = "PasswordTextBox";
            stateProperties25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            stateProperties25.FillColor = System.Drawing.Color.Empty;
            stateProperties25.ForeColor = System.Drawing.Color.Empty;
            stateProperties25.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTextBox.OnActiveState = stateProperties25;
            stateProperties26.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties26.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties26.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties26.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.OnDisabledState = stateProperties26;
            stateProperties27.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(31)))), ((int)(((byte)(84)))));
            stateProperties27.FillColor = System.Drawing.Color.Empty;
            stateProperties27.ForeColor = System.Drawing.Color.Empty;
            stateProperties27.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTextBox.OnHoverState = stateProperties27;
            stateProperties28.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties28.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            stateProperties28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties28.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.PasswordTextBox.OnIdleState = stateProperties28;
            this.PasswordTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.PasswordTextBox.PlaceholderText = "Password";
            this.PasswordTextBox.ReadOnly = false;
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.SelectionLength = 0;
            this.PasswordTextBox.SelectionStart = 0;
            this.PasswordTextBox.ShortcutsEnabled = true;
            this.PasswordTextBox.Size = new System.Drawing.Size(400, 60);
            this.PasswordTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.PasswordTextBox.TabIndex = 3;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PasswordTextBox.TextMarginBottom = 0;
            this.PasswordTextBox.TextMarginLeft = 0;
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
            this.EmailTextBox.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EmailTextBox.BorderRadius = 20;
            this.EmailTextBox.BorderThickness = 2;
            this.EmailTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.DefaultFont = new System.Drawing.Font("Segoe UI", 12F);
            this.EmailTextBox.DefaultText = "";
            this.EmailTextBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.EmailTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EmailTextBox.HideSelection = true;
            this.EmailTextBox.IconLeft = null;
            this.EmailTextBox.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.IconPadding = 10;
            this.EmailTextBox.IconRight = null;
            this.EmailTextBox.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailTextBox.Lines = new string[0];
            this.EmailTextBox.Location = new System.Drawing.Point(56, 244);
            this.EmailTextBox.MaxLength = 32767;
            this.EmailTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.EmailTextBox.Modified = false;
            this.EmailTextBox.Multiline = false;
            this.EmailTextBox.Name = "EmailTextBox";
            stateProperties29.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            stateProperties29.FillColor = System.Drawing.Color.Empty;
            stateProperties29.ForeColor = System.Drawing.Color.Empty;
            stateProperties29.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailTextBox.OnActiveState = stateProperties29;
            stateProperties30.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties30.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties30.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.EmailTextBox.OnDisabledState = stateProperties30;
            stateProperties31.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(64)))), ((int)(((byte)(120)))));
            stateProperties31.FillColor = System.Drawing.Color.Empty;
            stateProperties31.ForeColor = System.Drawing.Color.Empty;
            stateProperties31.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailTextBox.OnHoverState = stateProperties31;
            stateProperties32.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties32.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            stateProperties32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            stateProperties32.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.EmailTextBox.OnIdleState = stateProperties32;
            this.EmailTextBox.Padding = new System.Windows.Forms.Padding(5);
            this.EmailTextBox.PasswordChar = '\0';
            this.EmailTextBox.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.EmailTextBox.PlaceholderText = "Email ";
            this.EmailTextBox.ReadOnly = false;
            this.EmailTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailTextBox.SelectedText = "";
            this.EmailTextBox.SelectionLength = 0;
            this.EmailTextBox.SelectionStart = 0;
            this.EmailTextBox.ShortcutsEnabled = true;
            this.EmailTextBox.Size = new System.Drawing.Size(400, 60);
            this.EmailTextBox.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.EmailTextBox.TabIndex = 0;
            this.EmailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailTextBox.TextMarginBottom = 0;
            this.EmailTextBox.TextMarginLeft = 0;
            this.EmailTextBox.TextMarginTop = 0;
            this.EmailTextBox.TextPlaceholder = "Email ";
            this.EmailTextBox.UseSystemPasswordChar = false;
            this.EmailTextBox.WordWrap = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label3.Location = new System.Drawing.Point(60, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 35);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label2.Location = new System.Drawing.Point(60, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Quicksand", 40.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(50, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sign In";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // RightPanel
            // 
            this.RightPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.RightPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightPanel.BackgroundImage")));
            this.RightPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(17)))), ((int)(((byte)(40)))));
            this.RightPanel.BorderRadius = 0;
            this.RightPanel.BorderThickness = 0;
            this.RightPanel.Controls.Add(this.ShowPasswordLabel);
            this.RightPanel.Controls.Add(this.ShowPasswordCheckBox);
            this.RightPanel.Controls.Add(this.SignUpButton);
            this.RightPanel.Controls.Add(this.PasswordTextBox);
            this.RightPanel.Controls.Add(this.EmailTextBox);
            this.RightPanel.Controls.Add(this.label3);
            this.RightPanel.Controls.Add(this.label2);
            this.RightPanel.Controls.Add(this.label1);
            this.RightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPanel.Location = new System.Drawing.Point(482, 0);
            this.RightPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RightPanel.Name = "RightPanel";
            this.RightPanel.ShowBorders = true;
            this.RightPanel.Size = new System.Drawing.Size(500, 583);
            this.RightPanel.TabIndex = 3;
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
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 583);
            this.Controls.Add(this.LeftPanel);
            this.Controls.Add(this.RightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LogIn_Load);
            this.RightPanel.ResumeLayout(false);
            this.RightPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormBorder;
        private Bunifu.UI.WinForms.BunifuPanel LeftPanel;
        private Bunifu.UI.WinForms.BunifuPanel RightPanel;
        private System.Windows.Forms.Label ShowPasswordLabel;
        private Bunifu.UI.WinForms.BunifuCheckBox ShowPasswordCheckBox;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SignUpButton;
        private Bunifu.UI.WinForms.BunifuTextBox PasswordTextBox;
        private Bunifu.UI.WinForms.BunifuTextBox EmailTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl DragLeft;
        private Bunifu.Framework.UI.BunifuDragControl DragRight;
    }
}

