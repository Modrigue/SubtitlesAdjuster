namespace SA
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonQuit = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.labelVersion = new System.Windows.Forms.Label();
            this.labelStatus = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textboxFilename = new System.Windows.Forms.TextBox();
            this.tooltipFilename = new System.Windows.Forms.ToolTip(this.components);
            this.numericupdownSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelDelay = new System.Windows.Forms.Label();
            this.numericupdownDelay = new System.Windows.Forms.NumericUpDown();
            this.labelDelayMs = new System.Windows.Forms.Label();
            this.tooltipSpeed = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipDelay = new System.Windows.Forms.ToolTip(this.components);
            this.labelX = new System.Windows.Forms.Label();
            this.panelSpeedDelay = new System.Windows.Forms.Panel();
            this.panelAdjust = new System.Windows.Forms.Panel();
            this.panelPositions = new System.Windows.Forms.Panel();
            this.labelComputedDelay = new System.Windows.Forms.Label();
            this.labelComputedSpeed = new System.Windows.Forms.Label();
            this.numericupdownMilliPosExp2 = new System.Windows.Forms.NumericUpDown();
            this.numericupdownMilliPosExp1 = new System.Windows.Forms.NumericUpDown();
            this.numericupdownMilliPosCur2 = new System.Windows.Forms.NumericUpDown();
            this.numericupdownMilliPosCur1 = new System.Windows.Forms.NumericUpDown();
            this.timepickerPosExp2 = new System.Windows.Forms.DateTimePicker();
            this.labelPosExp2 = new System.Windows.Forms.Label();
            this.timepickerPosExp1 = new System.Windows.Forms.DateTimePicker();
            this.labelPosExp1 = new System.Windows.Forms.Label();
            this.timepickerPosCur2 = new System.Windows.Forms.DateTimePicker();
            this.labelPosCur2 = new System.Windows.Forms.Label();
            this.timepickerPosCur1 = new System.Windows.Forms.DateTimePicker();
            this.labelPosCur1 = new System.Windows.Forms.Label();
            this.radiobuttonPositions = new System.Windows.Forms.RadioButton();
            this.radiobuttonSpeedDelay = new System.Windows.Forms.RadioButton();
            this.tooltipSpeedDelay = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipPositions = new System.Windows.Forms.ToolTip(this.components);
            this.tooltipMilliseconds = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownDelay)).BeginInit();
            this.panelSpeedDelay.SuspendLayout();
            this.panelAdjust.SuspendLayout();
            this.panelPositions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownMilliPosExp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownMilliPosExp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownMilliPosCur2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownMilliPosCur1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonQuit
            // 
            this.buttonQuit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonQuit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonQuit.Location = new System.Drawing.Point(616, 487);
            this.buttonQuit.Name = "buttonQuit";
            this.buttonQuit.Size = new System.Drawing.Size(108, 44);
            this.buttonQuit.TabIndex = 0;
            this.buttonQuit.Text = "Quit";
            this.buttonQuit.UseVisualStyleBackColor = true;
            this.buttonQuit.Click += new System.EventHandler(this.buttonQuit_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOpen.Location = new System.Drawing.Point(17, 49);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(190, 44);
            this.buttonOpen.TabIndex = 4;
            this.buttonOpen.Text = "Open subtitle file...";
            this.buttonOpen.UseVisualStyleBackColor = true;
            this.buttonOpen.Click += new System.EventHandler(this.buttonOpen_Click);
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersion.ForeColor = System.Drawing.Color.Gray;
            this.labelVersion.Location = new System.Drawing.Point(18, 12);
            this.labelVersion.Margin = new System.Windows.Forms.Padding(3);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(62, 13);
            this.labelVersion.TabIndex = 5;
            this.labelVersion.Text = "Version X.Y";
            // 
            // labelStatus
            // 
            this.labelStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatus.ForeColor = System.Drawing.Color.Green;
            this.labelStatus.Location = new System.Drawing.Point(18, 487);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(581, 44);
            this.labelStatus.TabIndex = 8;
            this.labelStatus.Text = "Result";
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelStatus.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(-3, 0);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Maximum = 100000;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(754, 4);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 9;
            this.progressBar1.Visible = false;
            // 
            // buttonSave
            // 
            this.buttonSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Enabled = false;
            this.buttonSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.Location = new System.Drawing.Point(616, 420);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 44);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textboxFilename
            // 
            this.textboxFilename.BackColor = System.Drawing.Color.White;
            this.textboxFilename.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxFilename.Location = new System.Drawing.Point(18, 99);
            this.textboxFilename.Name = "textboxFilename";
            this.textboxFilename.ReadOnly = true;
            this.textboxFilename.Size = new System.Drawing.Size(480, 22);
            this.textboxFilename.TabIndex = 12;
            // 
            // numericupdownSpeed
            // 
            this.numericupdownSpeed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericupdownSpeed.DecimalPlaces = 3;
            this.numericupdownSpeed.Enabled = false;
            this.numericupdownSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdownSpeed.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericupdownSpeed.Location = new System.Drawing.Point(80, 11);
            this.numericupdownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericupdownSpeed.Name = "numericupdownSpeed";
            this.numericupdownSpeed.Size = new System.Drawing.Size(120, 26);
            this.numericupdownSpeed.TabIndex = 14;
            this.tooltipSpeed.SetToolTip(this.numericupdownSpeed, "Subtitles speed\r\n\r\n< 1,0 if current subtitles are too early\r\n> 1,0 if current sub" +
        "titles are too late");
            this.numericupdownSpeed.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericupdownSpeed.ValueChanged += new System.EventHandler(this.numericupdownSpeedDelay_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSpeed.Location = new System.Drawing.Point(8, 13);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(56, 20);
            this.labelSpeed.TabIndex = 15;
            this.labelSpeed.Text = "Speed";
            this.tooltipSpeed.SetToolTip(this.labelSpeed, "Subtitles speed\r\n\r\n< 1,0 if current subtitles are too early\r\n> 1,0 if current sub" +
        "titles are too late");
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Cursor = System.Windows.Forms.Cursors.Help;
            this.labelDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelay.Location = new System.Drawing.Point(8, 48);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(49, 20);
            this.labelDelay.TabIndex = 17;
            this.labelDelay.Text = "Delay";
            this.tooltipDelay.SetToolTip(this.labelDelay, "Subtitles delay\r\n\r\n> 0 if current subtitles are too early\r\n< 0 if current subtitl" +
        "es are too late");
            // 
            // numericupdownDelay
            // 
            this.numericupdownDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericupdownDelay.Enabled = false;
            this.numericupdownDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdownDelay.Increment = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numericupdownDelay.Location = new System.Drawing.Point(80, 46);
            this.numericupdownDelay.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericupdownDelay.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericupdownDelay.Name = "numericupdownDelay";
            this.numericupdownDelay.Size = new System.Drawing.Size(120, 26);
            this.numericupdownDelay.TabIndex = 16;
            this.tooltipDelay.SetToolTip(this.numericupdownDelay, "Subtitles delay\r\n\r\n> 0 if current subtitles are too early\r\n< 0 if current subtitl" +
        "es are too late");
            this.numericupdownDelay.ValueChanged += new System.EventHandler(this.numericupdownSpeedDelay_ValueChanged);
            // 
            // labelDelayMs
            // 
            this.labelDelayMs.AutoSize = true;
            this.labelDelayMs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelayMs.Location = new System.Drawing.Point(203, 48);
            this.labelDelayMs.Name = "labelDelayMs";
            this.labelDelayMs.Size = new System.Drawing.Size(30, 20);
            this.labelDelayMs.TabIndex = 18;
            this.labelDelayMs.Text = "ms";
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(203, 13);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(16, 20);
            this.labelX.TabIndex = 19;
            this.labelX.Text = "x";
            // 
            // panelSpeedDelay
            // 
            this.panelSpeedDelay.Controls.Add(this.numericupdownSpeed);
            this.panelSpeedDelay.Controls.Add(this.labelX);
            this.panelSpeedDelay.Controls.Add(this.labelSpeed);
            this.panelSpeedDelay.Controls.Add(this.labelDelayMs);
            this.panelSpeedDelay.Controls.Add(this.numericupdownDelay);
            this.panelSpeedDelay.Controls.Add(this.labelDelay);
            this.panelSpeedDelay.Location = new System.Drawing.Point(34, 41);
            this.panelSpeedDelay.Name = "panelSpeedDelay";
            this.panelSpeedDelay.Size = new System.Drawing.Size(250, 86);
            this.panelSpeedDelay.TabIndex = 20;
            // 
            // panelAdjust
            // 
            this.panelAdjust.Controls.Add(this.panelPositions);
            this.panelAdjust.Controls.Add(this.radiobuttonPositions);
            this.panelAdjust.Controls.Add(this.radiobuttonSpeedDelay);
            this.panelAdjust.Controls.Add(this.panelSpeedDelay);
            this.panelAdjust.Enabled = false;
            this.panelAdjust.Location = new System.Drawing.Point(18, 137);
            this.panelAdjust.Name = "panelAdjust";
            this.panelAdjust.Size = new System.Drawing.Size(581, 327);
            this.panelAdjust.TabIndex = 21;
            // 
            // panelPositions
            // 
            this.panelPositions.Controls.Add(this.labelComputedDelay);
            this.panelPositions.Controls.Add(this.labelComputedSpeed);
            this.panelPositions.Controls.Add(this.numericupdownMilliPosExp2);
            this.panelPositions.Controls.Add(this.numericupdownMilliPosExp1);
            this.panelPositions.Controls.Add(this.numericupdownMilliPosCur2);
            this.panelPositions.Controls.Add(this.numericupdownMilliPosCur1);
            this.panelPositions.Controls.Add(this.timepickerPosExp2);
            this.panelPositions.Controls.Add(this.labelPosExp2);
            this.panelPositions.Controls.Add(this.timepickerPosExp1);
            this.panelPositions.Controls.Add(this.labelPosExp1);
            this.panelPositions.Controls.Add(this.timepickerPosCur2);
            this.panelPositions.Controls.Add(this.labelPosCur2);
            this.panelPositions.Controls.Add(this.timepickerPosCur1);
            this.panelPositions.Controls.Add(this.labelPosCur1);
            this.panelPositions.Location = new System.Drawing.Point(34, 185);
            this.panelPositions.Name = "panelPositions";
            this.panelPositions.Size = new System.Drawing.Size(544, 113);
            this.panelPositions.TabIndex = 21;
            // 
            // labelComputedDelay
            // 
            this.labelComputedDelay.AutoSize = true;
            this.labelComputedDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputedDelay.ForeColor = System.Drawing.Color.DimGray;
            this.labelComputedDelay.Location = new System.Drawing.Point(356, 82);
            this.labelComputedDelay.Name = "labelComputedDelay";
            this.labelComputedDelay.Size = new System.Drawing.Size(46, 16);
            this.labelComputedDelay.TabIndex = 34;
            this.labelComputedDelay.Text = "Delay:";
            this.labelComputedDelay.Visible = false;
            // 
            // labelComputedSpeed
            // 
            this.labelComputedSpeed.AutoSize = true;
            this.labelComputedSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComputedSpeed.ForeColor = System.Drawing.Color.DimGray;
            this.labelComputedSpeed.Location = new System.Drawing.Point(61, 82);
            this.labelComputedSpeed.Name = "labelComputedSpeed";
            this.labelComputedSpeed.Size = new System.Drawing.Size(51, 16);
            this.labelComputedSpeed.TabIndex = 33;
            this.labelComputedSpeed.Text = "Speed:";
            this.labelComputedSpeed.Visible = false;
            // 
            // numericupdownMilliPosExp2
            // 
            this.numericupdownMilliPosExp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericupdownMilliPosExp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdownMilliPosExp2.Location = new System.Drawing.Point(490, 46);
            this.numericupdownMilliPosExp2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericupdownMilliPosExp2.Name = "numericupdownMilliPosExp2";
            this.numericupdownMilliPosExp2.Size = new System.Drawing.Size(45, 22);
            this.numericupdownMilliPosExp2.TabIndex = 32;
            this.tooltipMilliseconds.SetToolTip(this.numericupdownMilliPosExp2, "Milliseconds");
            this.numericupdownMilliPosExp2.ValueChanged += new System.EventHandler(this.timepickerPosition_ValueChanged);
            this.numericupdownMilliPosExp2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericupdownMilliseconds_KeyPress);
            // 
            // numericupdownMilliPosExp1
            // 
            this.numericupdownMilliPosExp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericupdownMilliPosExp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdownMilliPosExp1.Location = new System.Drawing.Point(490, 11);
            this.numericupdownMilliPosExp1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericupdownMilliPosExp1.Name = "numericupdownMilliPosExp1";
            this.numericupdownMilliPosExp1.Size = new System.Drawing.Size(45, 22);
            this.numericupdownMilliPosExp1.TabIndex = 31;
            this.tooltipMilliseconds.SetToolTip(this.numericupdownMilliPosExp1, "Milliseconds");
            this.numericupdownMilliPosExp1.ValueChanged += new System.EventHandler(this.timepickerPosition_ValueChanged);
            this.numericupdownMilliPosExp1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericupdownMilliseconds_KeyPress);
            // 
            // numericupdownMilliPosCur2
            // 
            this.numericupdownMilliPosCur2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericupdownMilliPosCur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdownMilliPosCur2.Location = new System.Drawing.Point(200, 46);
            this.numericupdownMilliPosCur2.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericupdownMilliPosCur2.Name = "numericupdownMilliPosCur2";
            this.numericupdownMilliPosCur2.Size = new System.Drawing.Size(45, 22);
            this.numericupdownMilliPosCur2.TabIndex = 30;
            this.tooltipMilliseconds.SetToolTip(this.numericupdownMilliPosCur2, "Milliseconds");
            this.numericupdownMilliPosCur2.ValueChanged += new System.EventHandler(this.timepickerPosition_ValueChanged);
            this.numericupdownMilliPosCur2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericupdownMilliseconds_KeyPress);
            // 
            // numericupdownMilliPosCur1
            // 
            this.numericupdownMilliPosCur1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.numericupdownMilliPosCur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericupdownMilliPosCur1.Location = new System.Drawing.Point(200, 11);
            this.numericupdownMilliPosCur1.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericupdownMilliPosCur1.Name = "numericupdownMilliPosCur1";
            this.numericupdownMilliPosCur1.Size = new System.Drawing.Size(45, 22);
            this.numericupdownMilliPosCur1.TabIndex = 20;
            this.tooltipMilliseconds.SetToolTip(this.numericupdownMilliPosCur1, "Milliseconds");
            this.numericupdownMilliPosCur1.ValueChanged += new System.EventHandler(this.timepickerPosition_ValueChanged);
            this.numericupdownMilliPosCur1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.numericupdownMilliseconds_KeyDown);
            this.numericupdownMilliPosCur1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numericupdownMilliseconds_KeyPress);
            // 
            // timepickerPosExp2
            // 
            this.timepickerPosExp2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timepickerPosExp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepickerPosExp2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepickerPosExp2.Location = new System.Drawing.Point(405, 44);
            this.timepickerPosExp2.Name = "timepickerPosExp2";
            this.timepickerPosExp2.ShowUpDown = true;
            this.timepickerPosExp2.Size = new System.Drawing.Size(85, 26);
            this.timepickerPosExp2.TabIndex = 29;
            this.timepickerPosExp2.Value = new System.DateTime(2017, 2, 2, 1, 0, 0, 0);
            this.timepickerPosExp2.ValueChanged += new System.EventHandler(this.timepickerPosition_ValueChanged);
            // 
            // labelPosExp2
            // 
            this.labelPosExp2.AutoSize = true;
            this.labelPosExp2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPosExp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosExp2.Location = new System.Drawing.Point(284, 48);
            this.labelPosExp2.Name = "labelPosExp2";
            this.labelPosExp2.Size = new System.Drawing.Size(119, 20);
            this.labelPosExp2.TabIndex = 28;
            this.labelPosExp2.Text = "Expected pos 2";
            // 
            // timepickerPosExp1
            // 
            this.timepickerPosExp1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timepickerPosExp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepickerPosExp1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepickerPosExp1.Location = new System.Drawing.Point(405, 9);
            this.timepickerPosExp1.Name = "timepickerPosExp1";
            this.timepickerPosExp1.ShowUpDown = true;
            this.timepickerPosExp1.Size = new System.Drawing.Size(85, 26);
            this.timepickerPosExp1.TabIndex = 27;
            this.timepickerPosExp1.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
            this.timepickerPosExp1.ValueChanged += new System.EventHandler(this.timepickerPosition_ValueChanged);
            // 
            // labelPosExp1
            // 
            this.labelPosExp1.AutoSize = true;
            this.labelPosExp1.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPosExp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosExp1.Location = new System.Drawing.Point(284, 13);
            this.labelPosExp1.Name = "labelPosExp1";
            this.labelPosExp1.Size = new System.Drawing.Size(119, 20);
            this.labelPosExp1.TabIndex = 26;
            this.labelPosExp1.Text = "Expected pos 1";
            // 
            // timepickerPosCur2
            // 
            this.timepickerPosCur2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timepickerPosCur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepickerPosCur2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepickerPosCur2.Location = new System.Drawing.Point(115, 44);
            this.timepickerPosCur2.Name = "timepickerPosCur2";
            this.timepickerPosCur2.ShowUpDown = true;
            this.timepickerPosCur2.Size = new System.Drawing.Size(85, 26);
            this.timepickerPosCur2.TabIndex = 25;
            this.timepickerPosCur2.Value = new System.DateTime(2017, 2, 2, 1, 0, 0, 0);
            this.timepickerPosCur2.ValueChanged += new System.EventHandler(this.timepickerPosition_ValueChanged);
            // 
            // labelPosCur2
            // 
            this.labelPosCur2.AutoSize = true;
            this.labelPosCur2.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPosCur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosCur2.Location = new System.Drawing.Point(8, 48);
            this.labelPosCur2.Name = "labelPosCur2";
            this.labelPosCur2.Size = new System.Drawing.Size(105, 20);
            this.labelPosCur2.TabIndex = 24;
            this.labelPosCur2.Text = "Current pos 2";
            // 
            // timepickerPosCur1
            // 
            this.timepickerPosCur1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.timepickerPosCur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timepickerPosCur1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timepickerPosCur1.Location = new System.Drawing.Point(115, 9);
            this.timepickerPosCur1.Name = "timepickerPosCur1";
            this.timepickerPosCur1.ShowUpDown = true;
            this.timepickerPosCur1.Size = new System.Drawing.Size(85, 26);
            this.timepickerPosCur1.TabIndex = 23;
            this.timepickerPosCur1.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
            this.timepickerPosCur1.ValueChanged += new System.EventHandler(this.timepickerPosition_ValueChanged);
            // 
            // labelPosCur1
            // 
            this.labelPosCur1.AutoSize = true;
            this.labelPosCur1.Cursor = System.Windows.Forms.Cursors.Default;
            this.labelPosCur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPosCur1.Location = new System.Drawing.Point(8, 13);
            this.labelPosCur1.Name = "labelPosCur1";
            this.labelPosCur1.Size = new System.Drawing.Size(105, 20);
            this.labelPosCur1.TabIndex = 15;
            this.labelPosCur1.Text = "Current pos 1";
            // 
            // radiobuttonPositions
            // 
            this.radiobuttonPositions.AutoSize = true;
            this.radiobuttonPositions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobuttonPositions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonPositions.Location = new System.Drawing.Point(9, 151);
            this.radiobuttonPositions.Name = "radiobuttonPositions";
            this.radiobuttonPositions.Size = new System.Drawing.Size(184, 28);
            this.radiobuttonPositions.TabIndex = 22;
            this.radiobuttonPositions.TabStop = true;
            this.radiobuttonPositions.Text = "Adjust by positions";
            this.tooltipPositions.SetToolTip(this.radiobuttonPositions, "Use this option if you don\'t know the speed and delay to ajust your subtitles");
            this.radiobuttonPositions.UseVisualStyleBackColor = true;
            this.radiobuttonPositions.CheckedChanged += new System.EventHandler(this.radiobuttonPositions_CheckedChanged);
            // 
            // radiobuttonSpeedDelay
            // 
            this.radiobuttonSpeedDelay.AutoSize = true;
            this.radiobuttonSpeedDelay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobuttonSpeedDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobuttonSpeedDelay.Location = new System.Drawing.Point(9, 7);
            this.radiobuttonSpeedDelay.Name = "radiobuttonSpeedDelay";
            this.radiobuttonSpeedDelay.Size = new System.Drawing.Size(250, 28);
            this.radiobuttonSpeedDelay.TabIndex = 21;
            this.radiobuttonSpeedDelay.TabStop = true;
            this.radiobuttonSpeedDelay.Text = "Adjust by speed and delay";
            this.tooltipSpeedDelay.SetToolTip(this.radiobuttonSpeedDelay, "Use this option if you know the speed and delay to ajust your subtitles");
            this.radiobuttonSpeedDelay.UseVisualStyleBackColor = true;
            this.radiobuttonSpeedDelay.CheckedChanged += new System.EventHandler(this.radiobuttonSpeedDelay_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 543);
            this.Controls.Add(this.panelAdjust);
            this.Controls.Add(this.textboxFilename);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.labelStatus);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonQuit);
            this.Cursor = System.Windows.Forms.Cursors.Help;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subtitles Adjuster";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownDelay)).EndInit();
            this.panelSpeedDelay.ResumeLayout(false);
            this.panelSpeedDelay.PerformLayout();
            this.panelAdjust.ResumeLayout(false);
            this.panelAdjust.PerformLayout();
            this.panelPositions.ResumeLayout(false);
            this.panelPositions.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownMilliPosExp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownMilliPosExp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownMilliPosCur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericupdownMilliPosCur1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonQuit;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Label labelStatus;
        public System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textboxFilename;
        private System.Windows.Forms.ToolTip tooltipFilename;
        private System.Windows.Forms.NumericUpDown numericupdownSpeed;
        private System.Windows.Forms.Label labelSpeed;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.NumericUpDown numericupdownDelay;
        private System.Windows.Forms.Label labelDelayMs;
        private System.Windows.Forms.ToolTip tooltipSpeed;
        private System.Windows.Forms.ToolTip tooltipDelay;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.Panel panelSpeedDelay;
        private System.Windows.Forms.Panel panelAdjust;
        private System.Windows.Forms.RadioButton radiobuttonPositions;
        private System.Windows.Forms.RadioButton radiobuttonSpeedDelay;
        private System.Windows.Forms.Panel panelPositions;
        private System.Windows.Forms.Label labelPosCur1;
        private System.Windows.Forms.ToolTip tooltipSpeedDelay;
        private System.Windows.Forms.ToolTip tooltipPositions;
        private System.Windows.Forms.DateTimePicker timepickerPosCur1;
        private System.Windows.Forms.DateTimePicker timepickerPosCur2;
        private System.Windows.Forms.Label labelPosCur2;
        private System.Windows.Forms.DateTimePicker timepickerPosExp2;
        private System.Windows.Forms.Label labelPosExp2;
        private System.Windows.Forms.DateTimePicker timepickerPosExp1;
        private System.Windows.Forms.Label labelPosExp1;
        private System.Windows.Forms.NumericUpDown numericupdownMilliPosCur1;
        private System.Windows.Forms.ToolTip tooltipMilliseconds;
        private System.Windows.Forms.NumericUpDown numericupdownMilliPosExp1;
        private System.Windows.Forms.NumericUpDown numericupdownMilliPosCur2;
        private System.Windows.Forms.NumericUpDown numericupdownMilliPosExp2;
        private System.Windows.Forms.Label labelComputedSpeed;
        private System.Windows.Forms.Label labelComputedDelay;
    }
}

