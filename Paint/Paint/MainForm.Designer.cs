namespace Paint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelDrawPad = new System.Windows.Forms.Panel();
            this.buttonAddColor = new System.Windows.Forms.Button();
            this.numericStroke = new System.Windows.Forms.NumericUpDown();
            this.btnClear = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnconnect = new System.Windows.Forms.Button();
            this.combocom = new System.Windows.Forms.ComboBox();
            this.lblgcode = new System.Windows.Forms.TextBox();
            this.btnsave = new System.Windows.Forms.Button();
            this.btndraw = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelColorCodes = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageGrayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageBlackWhiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dXFFileRasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.progressbar = new System.Windows.Forms.ToolStripProgressBar();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.chkPowerGrayScale = new System.Windows.Forms.CheckBox();
            this.BtnRefresh = new System.Windows.Forms.Button();
            this.btnZoomInDXF = new System.Windows.Forms.Button();
            this.btnZoomOutDXF = new System.Windows.Forms.Button();
            this.grpDXF = new System.Windows.Forms.GroupBox();
            this.btnMoveDownDXF = new System.Windows.Forms.Button();
            this.btnMoveUpDXF = new System.Windows.Forms.Button();
            this.btnMoveRightDXF = new System.Windows.Forms.Button();
            this.btnMoveLeftDXF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericStroke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpDXF.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelDrawPad
            // 
            this.panelDrawPad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDrawPad.BackColor = System.Drawing.Color.White;
            this.panelDrawPad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDrawPad.Location = new System.Drawing.Point(195, 35);
            this.panelDrawPad.Name = "panelDrawPad";
            this.panelDrawPad.Size = new System.Drawing.Size(415, 415);
            this.panelDrawPad.TabIndex = 0;
            this.panelDrawPad.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panelDrawPad.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panelDrawPad.MouseEnter += new System.EventHandler(this.panel1_MouseEnter);
            this.panelDrawPad.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panelDrawPad.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panelDrawPad.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // buttonAddColor
            // 
            this.buttonAddColor.Location = new System.Drawing.Point(15, 37);
            this.buttonAddColor.Name = "buttonAddColor";
            this.buttonAddColor.Size = new System.Drawing.Size(174, 37);
            this.buttonAddColor.TabIndex = 2;
            this.buttonAddColor.Text = "Add Color";
            this.buttonAddColor.UseVisualStyleBackColor = true;
            this.buttonAddColor.Click += new System.EventHandler(this.btnAddColor_Click);
            // 
            // numericStroke
            // 
            this.numericStroke.DecimalPlaces = 2;
            this.numericStroke.Location = new System.Drawing.Point(96, 80);
            this.numericStroke.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericStroke.Name = "numericStroke";
            this.numericStroke.Size = new System.Drawing.Size(76, 20);
            this.numericStroke.TabIndex = 3;
            this.numericStroke.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericStroke.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(44, 444);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnconnect
            // 
            this.btnconnect.BackColor = System.Drawing.Color.Lime;
            this.btnconnect.Location = new System.Drawing.Point(44, 343);
            this.btnconnect.Name = "btnconnect";
            this.btnconnect.Size = new System.Drawing.Size(123, 23);
            this.btnconnect.TabIndex = 6;
            this.btnconnect.Text = "Connect";
            this.btnconnect.UseVisualStyleBackColor = false;
            this.btnconnect.Click += new System.EventHandler(this.btnconnect_Click);
            // 
            // combocom
            // 
            this.combocom.FormattingEnabled = true;
            this.combocom.Location = new System.Drawing.Point(70, 316);
            this.combocom.Name = "combocom";
            this.combocom.Size = new System.Drawing.Size(58, 21);
            this.combocom.TabIndex = 7;
            // 
            // lblgcode
            // 
            this.lblgcode.Location = new System.Drawing.Point(195, 456);
            this.lblgcode.Multiline = true;
            this.lblgcode.Name = "lblgcode";
            this.lblgcode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.lblgcode.Size = new System.Drawing.Size(650, 52);
            this.lblgcode.TabIndex = 8;
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(44, 474);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(123, 35);
            this.btnsave.TabIndex = 9;
            this.btnsave.Text = "Save Output";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndraw
            // 
            this.btndraw.Location = new System.Drawing.Point(44, 373);
            this.btndraw.Name = "btndraw";
            this.btndraw.Size = new System.Drawing.Size(123, 65);
            this.btndraw.TabIndex = 10;
            this.btndraw.Text = "Draw";
            this.btndraw.UseVisualStyleBackColor = true;
            this.btndraw.Click += new System.EventHandler(this.btndraw_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stroke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 319);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Com Port";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panelColorCodes);
            this.groupBox1.Location = new System.Drawing.Point(15, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(174, 210);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties";
            // 
            // panelColorCodes
            // 
            this.panelColorCodes.AutoScroll = true;
            this.panelColorCodes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelColorCodes.Location = new System.Drawing.Point(3, 16);
            this.panelColorCodes.Name = "panelColorCodes";
            this.panelColorCodes.Size = new System.Drawing.Size(168, 191);
            this.panelColorCodes.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(44, 10);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(128, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.openToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.newToolStripMenuItem.Text = "New..";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(111, 6);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageGrayToolStripMenuItem,
            this.imageBlackWhiteToolStripMenuItem,
            this.dXFFileRasterToolStripMenuItem});
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // imageGrayToolStripMenuItem
            // 
            this.imageGrayToolStripMenuItem.Name = "imageGrayToolStripMenuItem";
            this.imageGrayToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.imageGrayToolStripMenuItem.Text = "Image (Gray Scale)";
            this.imageGrayToolStripMenuItem.Click += new System.EventHandler(this.imageGrayToolStripMenuItem_Click);
            // 
            // imageBlackWhiteToolStripMenuItem
            // 
            this.imageBlackWhiteToolStripMenuItem.Name = "imageBlackWhiteToolStripMenuItem";
            this.imageBlackWhiteToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.imageBlackWhiteToolStripMenuItem.Text = "Image (Black & White)";
            this.imageBlackWhiteToolStripMenuItem.Click += new System.EventHandler(this.imageBlackWhiteToolStripMenuItem_Click);
            // 
            // dXFFileRasterToolStripMenuItem
            // 
            this.dXFFileRasterToolStripMenuItem.Name = "dXFFileRasterToolStripMenuItem";
            this.dXFFileRasterToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.dXFFileRasterToolStripMenuItem.Text = "DXF File (Raster)";
            this.dXFFileRasterToolStripMenuItem.Click += new System.EventHandler(this.dXFFileRasterToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(111, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblstatus,
            this.progressbar,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(195, 511);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(87, 22);
            this.statusStrip1.TabIndex = 15;
            // 
            // lblstatus
            // 
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(0, 17);
            // 
            // progressbar
            // 
            this.progressbar.Name = "progressbar";
            this.progressbar.Size = new System.Drawing.Size(100, 16);
            this.progressbar.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 17);
            this.statusLabel.Text = "Status Label";
            // 
            // chkPowerGrayScale
            // 
            this.chkPowerGrayScale.AutoSize = true;
            this.chkPowerGrayScale.Location = new System.Drawing.Point(424, 514);
            this.chkPowerGrayScale.Name = "chkPowerGrayScale";
            this.chkPowerGrayScale.Size = new System.Drawing.Size(226, 17);
            this.chkPowerGrayScale.TabIndex = 16;
            this.chkPowerGrayScale.Text = "Raster Power depends on gray scale color";
            this.chkPowerGrayScale.UseVisualStyleBackColor = true;
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.Location = new System.Drawing.Point(134, 314);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(55, 23);
            this.BtnRefresh.TabIndex = 17;
            this.BtnRefresh.Text = "Refresh";
            this.BtnRefresh.UseVisualStyleBackColor = true;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // btnZoomInDXF
            // 
            this.btnZoomInDXF.Enabled = false;
            this.btnZoomInDXF.Location = new System.Drawing.Point(17, 19);
            this.btnZoomInDXF.Name = "btnZoomInDXF";
            this.btnZoomInDXF.Size = new System.Drawing.Size(66, 28);
            this.btnZoomInDXF.TabIndex = 18;
            this.btnZoomInDXF.Text = "Zoom In";
            this.btnZoomInDXF.UseVisualStyleBackColor = true;
            this.btnZoomInDXF.Click += new System.EventHandler(this.btnZoomInDXF_Click);
            // 
            // btnZoomOutDXF
            // 
            this.btnZoomOutDXF.Enabled = false;
            this.btnZoomOutDXF.Location = new System.Drawing.Point(89, 19);
            this.btnZoomOutDXF.Name = "btnZoomOutDXF";
            this.btnZoomOutDXF.Size = new System.Drawing.Size(64, 28);
            this.btnZoomOutDXF.TabIndex = 19;
            this.btnZoomOutDXF.Text = "Zoom Out";
            this.btnZoomOutDXF.UseVisualStyleBackColor = true;
            this.btnZoomOutDXF.Click += new System.EventHandler(this.btnZoomOutDXF_Click);
            // 
            // grpDXF
            // 
            this.grpDXF.Controls.Add(this.btnMoveDownDXF);
            this.grpDXF.Controls.Add(this.btnMoveUpDXF);
            this.grpDXF.Controls.Add(this.btnMoveRightDXF);
            this.grpDXF.Controls.Add(this.btnMoveLeftDXF);
            this.grpDXF.Controls.Add(this.btnZoomOutDXF);
            this.grpDXF.Controls.Add(this.btnZoomInDXF);
            this.grpDXF.Location = new System.Drawing.Point(642, 278);
            this.grpDXF.Name = "grpDXF";
            this.grpDXF.Size = new System.Drawing.Size(168, 145);
            this.grpDXF.TabIndex = 20;
            this.grpDXF.TabStop = false;
            this.grpDXF.Text = "DXF View";
            // 
            // btnMoveDownDXF
            // 
            this.btnMoveDownDXF.Enabled = false;
            this.btnMoveDownDXF.Location = new System.Drawing.Point(59, 113);
            this.btnMoveDownDXF.Name = "btnMoveDownDXF";
            this.btnMoveDownDXF.Size = new System.Drawing.Size(74, 28);
            this.btnMoveDownDXF.TabIndex = 23;
            this.btnMoveDownDXF.Text = "Move Down";
            this.btnMoveDownDXF.UseVisualStyleBackColor = true;
            this.btnMoveDownDXF.Click += new System.EventHandler(this.btnMoveDownDXF_Click);
            // 
            // btnMoveUpDXF
            // 
            this.btnMoveUpDXF.Enabled = false;
            this.btnMoveUpDXF.Location = new System.Drawing.Point(59, 53);
            this.btnMoveUpDXF.Name = "btnMoveUpDXF";
            this.btnMoveUpDXF.Size = new System.Drawing.Size(66, 28);
            this.btnMoveUpDXF.TabIndex = 22;
            this.btnMoveUpDXF.Text = "Move Up";
            this.btnMoveUpDXF.UseVisualStyleBackColor = true;
            this.btnMoveUpDXF.Click += new System.EventHandler(this.btnMoveUpDXF_Click);
            // 
            // btnMoveRightDXF
            // 
            this.btnMoveRightDXF.Enabled = false;
            this.btnMoveRightDXF.Location = new System.Drawing.Point(87, 82);
            this.btnMoveRightDXF.Name = "btnMoveRightDXF";
            this.btnMoveRightDXF.Size = new System.Drawing.Size(75, 28);
            this.btnMoveRightDXF.TabIndex = 21;
            this.btnMoveRightDXF.Text = "Move Right";
            this.btnMoveRightDXF.UseVisualStyleBackColor = true;
            this.btnMoveRightDXF.Click += new System.EventHandler(this.btnMoveRightDXF_Click);
            // 
            // btnMoveLeftDXF
            // 
            this.btnMoveLeftDXF.Enabled = false;
            this.btnMoveLeftDXF.Location = new System.Drawing.Point(17, 82);
            this.btnMoveLeftDXF.Name = "btnMoveLeftDXF";
            this.btnMoveLeftDXF.Size = new System.Drawing.Size(66, 28);
            this.btnMoveLeftDXF.TabIndex = 20;
            this.btnMoveLeftDXF.Text = "Move Left";
            this.btnMoveLeftDXF.UseVisualStyleBackColor = true;
            this.btnMoveLeftDXF.Click += new System.EventHandler(this.btnMoveLeftDXF_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Paint.Properties.Resources.back6;
            this.ClientSize = new System.Drawing.Size(860, 545);
            this.Controls.Add(this.grpDXF);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.chkPowerGrayScale);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btndraw);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.lblgcode);
            this.Controls.Add(this.combocom);
            this.Controls.Add(this.btnconnect);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.numericStroke);
            this.Controls.Add(this.buttonAddColor);
            this.Controls.Add(this.panelDrawPad);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reesha Paint Controller";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            ((System.ComponentModel.ISupportInitialize)(this.numericStroke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpDXF.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelDrawPad;
        private System.Windows.Forms.Button buttonAddColor;
        private System.Windows.Forms.NumericUpDown numericStroke;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnconnect;
        private System.Windows.Forms.ComboBox combocom;
        private System.Windows.Forms.TextBox lblgcode;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button btndraw;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Panel panelColorCodes;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblstatus;
        private System.Windows.Forms.ToolStripProgressBar progressbar;
        private System.Windows.Forms.ToolStripMenuItem imageGrayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageBlackWhiteToolStripMenuItem;
        private System.Windows.Forms.CheckBox chkPowerGrayScale;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Button BtnRefresh;
        private System.Windows.Forms.ToolStripMenuItem dXFFileRasterToolStripMenuItem;
        private System.Windows.Forms.Button btnZoomInDXF;
        private System.Windows.Forms.Button btnZoomOutDXF;
        private System.Windows.Forms.GroupBox grpDXF;
        private System.Windows.Forms.Button btnMoveRightDXF;
        private System.Windows.Forms.Button btnMoveLeftDXF;
        private System.Windows.Forms.Button btnMoveDownDXF;
        private System.Windows.Forms.Button btnMoveUpDXF;
    }
}

