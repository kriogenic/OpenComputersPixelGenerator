namespace OpenComputersPixelGenerator
{
    partial class frmMain
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtGeneration = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.lblSelectedColor = new System.Windows.Forms.Label();
            this.DoubleBufferedTable1 = new OpenComputersPixelGenerator.DoubleBufferedTable(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAmountBlack = new System.Windows.Forms.Label();
            this.lblColorBlack = new System.Windows.Forms.Label();
            this.lblAmountGray = new System.Windows.Forms.Label();
            this.lblColorGray = new System.Windows.Forms.Label();
            this.lblAmountRed = new System.Windows.Forms.Label();
            this.lblColorRed = new System.Windows.Forms.Label();
            this.lblAmountGreen = new System.Windows.Forms.Label();
            this.lblColorGreen = new System.Windows.Forms.Label();
            this.lblAmountBrown = new System.Windows.Forms.Label();
            this.lblColorBrown = new System.Windows.Forms.Label();
            this.lblAmountBlue = new System.Windows.Forms.Label();
            this.lblColorBlue = new System.Windows.Forms.Label();
            this.lblAmountPurple = new System.Windows.Forms.Label();
            this.lblColorPurple = new System.Windows.Forms.Label();
            this.lblAmountCyan = new System.Windows.Forms.Label();
            this.lblColorCyan = new System.Windows.Forms.Label();
            this.lblAmountLightGray = new System.Windows.Forms.Label();
            this.lblColorLightGray = new System.Windows.Forms.Label();
            this.lblAmountPink = new System.Windows.Forms.Label();
            this.lblColorPink = new System.Windows.Forms.Label();
            this.lblAmountLime = new System.Windows.Forms.Label();
            this.lblColorLime = new System.Windows.Forms.Label();
            this.lblAmountYellow = new System.Windows.Forms.Label();
            this.lblColorYellow = new System.Windows.Forms.Label();
            this.lblAmountLightBlue = new System.Windows.Forms.Label();
            this.lblColorLightBlue = new System.Windows.Forms.Label();
            this.lblAmountMagenta = new System.Windows.Forms.Label();
            this.lblColorMagenta = new System.Windows.Forms.Label();
            this.lblAmountOrange = new System.Windows.Forms.Label();
            this.lblColorOrange = new System.Windows.Forms.Label();
            this.lblAmountWhite = new System.Windows.Forms.Label();
            this.lblColorWhite = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Controls.Add(this.DoubleBufferedTable1);
            this.pnlMain.Controls.Add(this.panel1);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlMain.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(575, 329);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtGeneration);
            this.panel2.Controls.Add(this.btnGenerate);
            this.panel2.Controls.Add(this.lblSelectedColor);
            this.panel2.Location = new System.Drawing.Point(3, 228);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 95);
            this.panel2.TabIndex = 34;
            // 
            // txtGeneration
            // 
            this.txtGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGeneration.Location = new System.Drawing.Point(9, 3);
            this.txtGeneration.Multiline = true;
            this.txtGeneration.Name = "txtGeneration";
            this.txtGeneration.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtGeneration.Size = new System.Drawing.Size(188, 59);
            this.txtGeneration.TabIndex = 2;
            this.txtGeneration.WordWrap = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(3, 68);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(235, 24);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate OpenComputers lua code";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // lblSelectedColor
            // 
            this.lblSelectedColor.BackColor = System.Drawing.Color.White;
            this.lblSelectedColor.Location = new System.Drawing.Point(203, 3);
            this.lblSelectedColor.Margin = new System.Windows.Forms.Padding(3);
            this.lblSelectedColor.Name = "lblSelectedColor";
            this.lblSelectedColor.Size = new System.Drawing.Size(35, 35);
            this.lblSelectedColor.TabIndex = 0;
            this.lblSelectedColor.Text = "Selected";
            this.lblSelectedColor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // DoubleBufferedTable1
            // 
            this.DoubleBufferedTable1.ColumnCount = 16;
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.Location = new System.Drawing.Point(250, 3);
            this.DoubleBufferedTable1.Name = "DoubleBufferedTable1";
            this.DoubleBufferedTable1.RowCount = 16;
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.DoubleBufferedTable1.Size = new System.Drawing.Size(320, 320);
            this.DoubleBufferedTable1.TabIndex = 33;
            this.DoubleBufferedTable1.CellPaint += new System.Windows.Forms.TableLayoutCellPaintEventHandler(this.DoubleBufferedTable1_CellPaint);
            this.DoubleBufferedTable1.Click += new System.EventHandler(this.DoubleBufferedTable1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblAmountBlack);
            this.panel1.Controls.Add(this.lblColorBlack);
            this.panel1.Controls.Add(this.lblAmountGray);
            this.panel1.Controls.Add(this.lblColorGray);
            this.panel1.Controls.Add(this.lblAmountRed);
            this.panel1.Controls.Add(this.lblColorRed);
            this.panel1.Controls.Add(this.lblAmountGreen);
            this.panel1.Controls.Add(this.lblColorGreen);
            this.panel1.Controls.Add(this.lblAmountBrown);
            this.panel1.Controls.Add(this.lblColorBrown);
            this.panel1.Controls.Add(this.lblAmountBlue);
            this.panel1.Controls.Add(this.lblColorBlue);
            this.panel1.Controls.Add(this.lblAmountPurple);
            this.panel1.Controls.Add(this.lblColorPurple);
            this.panel1.Controls.Add(this.lblAmountCyan);
            this.panel1.Controls.Add(this.lblColorCyan);
            this.panel1.Controls.Add(this.lblAmountLightGray);
            this.panel1.Controls.Add(this.lblColorLightGray);
            this.panel1.Controls.Add(this.lblAmountPink);
            this.panel1.Controls.Add(this.lblColorPink);
            this.panel1.Controls.Add(this.lblAmountLime);
            this.panel1.Controls.Add(this.lblColorLime);
            this.panel1.Controls.Add(this.lblAmountYellow);
            this.panel1.Controls.Add(this.lblColorYellow);
            this.panel1.Controls.Add(this.lblAmountLightBlue);
            this.panel1.Controls.Add(this.lblColorLightBlue);
            this.panel1.Controls.Add(this.lblAmountMagenta);
            this.panel1.Controls.Add(this.lblColorMagenta);
            this.panel1.Controls.Add(this.lblAmountOrange);
            this.panel1.Controls.Add(this.lblColorOrange);
            this.panel1.Controls.Add(this.lblAmountWhite);
            this.panel1.Controls.Add(this.lblColorWhite);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 219);
            this.panel1.TabIndex = 32;
            // 
            // lblAmountBlack
            // 
            this.lblAmountBlack.Location = new System.Drawing.Point(164, 198);
            this.lblAmountBlack.Name = "lblAmountBlack";
            this.lblAmountBlack.Size = new System.Drawing.Size(35, 12);
            this.lblAmountBlack.TabIndex = 63;
            this.lblAmountBlack.Text = "1";
            this.lblAmountBlack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorBlack
            // 
            this.lblColorBlack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorBlack.BackColor = System.Drawing.Color.Black;
            this.lblColorBlack.ForeColor = System.Drawing.Color.White;
            this.lblColorBlack.Location = new System.Drawing.Point(164, 162);
            this.lblColorBlack.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorBlack.Name = "lblColorBlack";
            this.lblColorBlack.Size = new System.Drawing.Size(35, 35);
            this.lblColorBlack.TabIndex = 62;
            this.lblColorBlack.Text = "Black";
            this.lblColorBlack.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorBlack.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountGray
            // 
            this.lblAmountGray.Location = new System.Drawing.Point(164, 96);
            this.lblAmountGray.Name = "lblAmountGray";
            this.lblAmountGray.Size = new System.Drawing.Size(35, 12);
            this.lblAmountGray.TabIndex = 61;
            this.lblAmountGray.Text = "1";
            this.lblAmountGray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorGray
            // 
            this.lblColorGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorGray.BackColor = System.Drawing.Color.Gray;
            this.lblColorGray.Location = new System.Drawing.Point(164, 60);
            this.lblColorGray.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorGray.Name = "lblColorGray";
            this.lblColorGray.Size = new System.Drawing.Size(35, 35);
            this.lblColorGray.TabIndex = 60;
            this.lblColorGray.Text = "Gray";
            this.lblColorGray.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorGray.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountRed
            // 
            this.lblAmountRed.Location = new System.Drawing.Point(123, 198);
            this.lblAmountRed.Name = "lblAmountRed";
            this.lblAmountRed.Size = new System.Drawing.Size(35, 12);
            this.lblAmountRed.TabIndex = 59;
            this.lblAmountRed.Text = "1";
            this.lblAmountRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorRed
            // 
            this.lblColorRed.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorRed.BackColor = System.Drawing.Color.Red;
            this.lblColorRed.ForeColor = System.Drawing.Color.White;
            this.lblColorRed.Location = new System.Drawing.Point(123, 162);
            this.lblColorRed.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorRed.Name = "lblColorRed";
            this.lblColorRed.Size = new System.Drawing.Size(35, 35);
            this.lblColorRed.TabIndex = 58;
            this.lblColorRed.Text = "Red";
            this.lblColorRed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorRed.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountGreen
            // 
            this.lblAmountGreen.Location = new System.Drawing.Point(82, 198);
            this.lblAmountGreen.Name = "lblAmountGreen";
            this.lblAmountGreen.Size = new System.Drawing.Size(35, 12);
            this.lblAmountGreen.TabIndex = 57;
            this.lblAmountGreen.Text = "1";
            this.lblAmountGreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorGreen
            // 
            this.lblColorGreen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorGreen.BackColor = System.Drawing.Color.Green;
            this.lblColorGreen.ForeColor = System.Drawing.Color.White;
            this.lblColorGreen.Location = new System.Drawing.Point(82, 162);
            this.lblColorGreen.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorGreen.Name = "lblColorGreen";
            this.lblColorGreen.Size = new System.Drawing.Size(35, 35);
            this.lblColorGreen.TabIndex = 56;
            this.lblColorGreen.Text = "Green";
            this.lblColorGreen.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorGreen.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountBrown
            // 
            this.lblAmountBrown.Location = new System.Drawing.Point(41, 198);
            this.lblAmountBrown.Name = "lblAmountBrown";
            this.lblAmountBrown.Size = new System.Drawing.Size(35, 12);
            this.lblAmountBrown.TabIndex = 55;
            this.lblAmountBrown.Text = "1";
            this.lblAmountBrown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorBrown
            // 
            this.lblColorBrown.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorBrown.BackColor = System.Drawing.Color.Brown;
            this.lblColorBrown.ForeColor = System.Drawing.Color.White;
            this.lblColorBrown.Location = new System.Drawing.Point(41, 162);
            this.lblColorBrown.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorBrown.Name = "lblColorBrown";
            this.lblColorBrown.Size = new System.Drawing.Size(35, 35);
            this.lblColorBrown.TabIndex = 54;
            this.lblColorBrown.Text = "Brown";
            this.lblColorBrown.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorBrown.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountBlue
            // 
            this.lblAmountBlue.Location = new System.Drawing.Point(164, 147);
            this.lblAmountBlue.Name = "lblAmountBlue";
            this.lblAmountBlue.Size = new System.Drawing.Size(35, 12);
            this.lblAmountBlue.TabIndex = 53;
            this.lblAmountBlue.Text = "1";
            this.lblAmountBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorBlue
            // 
            this.lblColorBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorBlue.BackColor = System.Drawing.Color.Blue;
            this.lblColorBlue.ForeColor = System.Drawing.Color.White;
            this.lblColorBlue.Location = new System.Drawing.Point(164, 111);
            this.lblColorBlue.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorBlue.Name = "lblColorBlue";
            this.lblColorBlue.Size = new System.Drawing.Size(35, 35);
            this.lblColorBlue.TabIndex = 52;
            this.lblColorBlue.Text = "Blue";
            this.lblColorBlue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorBlue.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountPurple
            // 
            this.lblAmountPurple.Location = new System.Drawing.Point(123, 147);
            this.lblAmountPurple.Name = "lblAmountPurple";
            this.lblAmountPurple.Size = new System.Drawing.Size(35, 12);
            this.lblAmountPurple.TabIndex = 51;
            this.lblAmountPurple.Text = "1";
            this.lblAmountPurple.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorPurple
            // 
            this.lblColorPurple.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorPurple.BackColor = System.Drawing.Color.Purple;
            this.lblColorPurple.ForeColor = System.Drawing.Color.White;
            this.lblColorPurple.Location = new System.Drawing.Point(123, 111);
            this.lblColorPurple.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorPurple.Name = "lblColorPurple";
            this.lblColorPurple.Size = new System.Drawing.Size(35, 35);
            this.lblColorPurple.TabIndex = 50;
            this.lblColorPurple.Text = "Purple";
            this.lblColorPurple.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorPurple.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountCyan
            // 
            this.lblAmountCyan.Location = new System.Drawing.Point(82, 147);
            this.lblAmountCyan.Name = "lblAmountCyan";
            this.lblAmountCyan.Size = new System.Drawing.Size(35, 12);
            this.lblAmountCyan.TabIndex = 49;
            this.lblAmountCyan.Text = "1";
            this.lblAmountCyan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorCyan
            // 
            this.lblColorCyan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorCyan.BackColor = System.Drawing.Color.Cyan;
            this.lblColorCyan.Location = new System.Drawing.Point(82, 111);
            this.lblColorCyan.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorCyan.Name = "lblColorCyan";
            this.lblColorCyan.Size = new System.Drawing.Size(35, 35);
            this.lblColorCyan.TabIndex = 48;
            this.lblColorCyan.Text = "Cyan";
            this.lblColorCyan.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorCyan.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountLightGray
            // 
            this.lblAmountLightGray.Location = new System.Drawing.Point(41, 147);
            this.lblAmountLightGray.Name = "lblAmountLightGray";
            this.lblAmountLightGray.Size = new System.Drawing.Size(35, 12);
            this.lblAmountLightGray.TabIndex = 47;
            this.lblAmountLightGray.Text = "1";
            this.lblAmountLightGray.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorLightGray
            // 
            this.lblColorLightGray.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorLightGray.BackColor = System.Drawing.Color.LightGray;
            this.lblColorLightGray.Location = new System.Drawing.Point(41, 111);
            this.lblColorLightGray.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorLightGray.Name = "lblColorLightGray";
            this.lblColorLightGray.Size = new System.Drawing.Size(35, 35);
            this.lblColorLightGray.TabIndex = 46;
            this.lblColorLightGray.Text = "Light\r\nGray";
            this.lblColorLightGray.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorLightGray.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountPink
            // 
            this.lblAmountPink.Location = new System.Drawing.Point(123, 96);
            this.lblAmountPink.Name = "lblAmountPink";
            this.lblAmountPink.Size = new System.Drawing.Size(35, 12);
            this.lblAmountPink.TabIndex = 45;
            this.lblAmountPink.Text = "1";
            this.lblAmountPink.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorPink
            // 
            this.lblColorPink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorPink.BackColor = System.Drawing.Color.Pink;
            this.lblColorPink.Location = new System.Drawing.Point(123, 60);
            this.lblColorPink.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorPink.Name = "lblColorPink";
            this.lblColorPink.Size = new System.Drawing.Size(35, 35);
            this.lblColorPink.TabIndex = 44;
            this.lblColorPink.Text = "Pink";
            this.lblColorPink.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorPink.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountLime
            // 
            this.lblAmountLime.Location = new System.Drawing.Point(82, 96);
            this.lblAmountLime.Name = "lblAmountLime";
            this.lblAmountLime.Size = new System.Drawing.Size(35, 12);
            this.lblAmountLime.TabIndex = 43;
            this.lblAmountLime.Text = "1";
            this.lblAmountLime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorLime
            // 
            this.lblColorLime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorLime.BackColor = System.Drawing.Color.Lime;
            this.lblColorLime.Location = new System.Drawing.Point(82, 60);
            this.lblColorLime.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorLime.Name = "lblColorLime";
            this.lblColorLime.Size = new System.Drawing.Size(35, 35);
            this.lblColorLime.TabIndex = 42;
            this.lblColorLime.Text = "Lime";
            this.lblColorLime.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorLime.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountYellow
            // 
            this.lblAmountYellow.Location = new System.Drawing.Point(41, 96);
            this.lblAmountYellow.Name = "lblAmountYellow";
            this.lblAmountYellow.Size = new System.Drawing.Size(35, 12);
            this.lblAmountYellow.TabIndex = 41;
            this.lblAmountYellow.Text = "1";
            this.lblAmountYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorYellow
            // 
            this.lblColorYellow.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.lblColorYellow.Location = new System.Drawing.Point(41, 60);
            this.lblColorYellow.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorYellow.Name = "lblColorYellow";
            this.lblColorYellow.Size = new System.Drawing.Size(35, 35);
            this.lblColorYellow.TabIndex = 40;
            this.lblColorYellow.Text = "Yellow";
            this.lblColorYellow.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorYellow.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountLightBlue
            // 
            this.lblAmountLightBlue.Location = new System.Drawing.Point(164, 45);
            this.lblAmountLightBlue.Name = "lblAmountLightBlue";
            this.lblAmountLightBlue.Size = new System.Drawing.Size(35, 12);
            this.lblAmountLightBlue.TabIndex = 39;
            this.lblAmountLightBlue.Text = "1";
            this.lblAmountLightBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorLightBlue
            // 
            this.lblColorLightBlue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorLightBlue.BackColor = System.Drawing.Color.LightBlue;
            this.lblColorLightBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorLightBlue.Location = new System.Drawing.Point(164, 9);
            this.lblColorLightBlue.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorLightBlue.Name = "lblColorLightBlue";
            this.lblColorLightBlue.Size = new System.Drawing.Size(35, 35);
            this.lblColorLightBlue.TabIndex = 38;
            this.lblColorLightBlue.Text = "Light\r\nBlue";
            this.lblColorLightBlue.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorLightBlue.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountMagenta
            // 
            this.lblAmountMagenta.Location = new System.Drawing.Point(123, 45);
            this.lblAmountMagenta.Name = "lblAmountMagenta";
            this.lblAmountMagenta.Size = new System.Drawing.Size(35, 12);
            this.lblAmountMagenta.TabIndex = 37;
            this.lblAmountMagenta.Text = "1";
            this.lblAmountMagenta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorMagenta
            // 
            this.lblColorMagenta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorMagenta.BackColor = System.Drawing.Color.Magenta;
            this.lblColorMagenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorMagenta.Location = new System.Drawing.Point(123, 9);
            this.lblColorMagenta.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorMagenta.Name = "lblColorMagenta";
            this.lblColorMagenta.Size = new System.Drawing.Size(35, 35);
            this.lblColorMagenta.TabIndex = 36;
            this.lblColorMagenta.Text = "Magenta";
            this.lblColorMagenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorMagenta.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountOrange
            // 
            this.lblAmountOrange.Location = new System.Drawing.Point(82, 45);
            this.lblAmountOrange.Name = "lblAmountOrange";
            this.lblAmountOrange.Size = new System.Drawing.Size(35, 12);
            this.lblAmountOrange.TabIndex = 35;
            this.lblAmountOrange.Text = "1";
            this.lblAmountOrange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorOrange
            // 
            this.lblColorOrange.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorOrange.BackColor = System.Drawing.Color.Orange;
            this.lblColorOrange.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorOrange.Location = new System.Drawing.Point(82, 9);
            this.lblColorOrange.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorOrange.Name = "lblColorOrange";
            this.lblColorOrange.Size = new System.Drawing.Size(35, 35);
            this.lblColorOrange.TabIndex = 34;
            this.lblColorOrange.Text = "Orange";
            this.lblColorOrange.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorOrange.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // lblAmountWhite
            // 
            this.lblAmountWhite.Location = new System.Drawing.Point(41, 45);
            this.lblAmountWhite.Name = "lblAmountWhite";
            this.lblAmountWhite.Size = new System.Drawing.Size(35, 12);
            this.lblAmountWhite.TabIndex = 33;
            this.lblAmountWhite.Text = "1";
            this.lblAmountWhite.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblColorWhite
            // 
            this.lblColorWhite.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblColorWhite.BackColor = System.Drawing.Color.White;
            this.lblColorWhite.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColorWhite.Location = new System.Drawing.Point(41, 9);
            this.lblColorWhite.Margin = new System.Windows.Forms.Padding(3);
            this.lblColorWhite.Name = "lblColorWhite";
            this.lblColorWhite.Size = new System.Drawing.Size(35, 35);
            this.lblColorWhite.TabIndex = 32;
            this.lblColorWhite.Text = "White";
            this.lblColorWhite.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblColorWhite.Click += new System.EventHandler(this.SelectColor_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 329);
            this.Controls.Add(this.pnlMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "OpenComputers Pixel Art Drawer - Kriogenic 2020";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private DoubleBufferedTable DoubleBufferedTable1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAmountRed;
        private System.Windows.Forms.Label lblColorRed;
        private System.Windows.Forms.Label lblAmountGreen;
        private System.Windows.Forms.Label lblColorGreen;
        private System.Windows.Forms.Label lblAmountBrown;
        private System.Windows.Forms.Label lblColorBrown;
        private System.Windows.Forms.Label lblAmountBlue;
        private System.Windows.Forms.Label lblColorBlue;
        private System.Windows.Forms.Label lblAmountPurple;
        private System.Windows.Forms.Label lblColorPurple;
        private System.Windows.Forms.Label lblAmountCyan;
        private System.Windows.Forms.Label lblColorCyan;
        private System.Windows.Forms.Label lblAmountLightGray;
        private System.Windows.Forms.Label lblColorLightGray;
        private System.Windows.Forms.Label lblAmountPink;
        private System.Windows.Forms.Label lblColorPink;
        private System.Windows.Forms.Label lblAmountLime;
        private System.Windows.Forms.Label lblColorLime;
        private System.Windows.Forms.Label lblAmountYellow;
        private System.Windows.Forms.Label lblColorYellow;
        private System.Windows.Forms.Label lblAmountLightBlue;
        private System.Windows.Forms.Label lblColorLightBlue;
        private System.Windows.Forms.Label lblAmountMagenta;
        private System.Windows.Forms.Label lblColorMagenta;
        private System.Windows.Forms.Label lblAmountOrange;
        private System.Windows.Forms.Label lblColorOrange;
        private System.Windows.Forms.Label lblAmountWhite;
        private System.Windows.Forms.Label lblColorWhite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblSelectedColor;
        private System.Windows.Forms.Label lblAmountBlack;
        private System.Windows.Forms.Label lblColorBlack;
        private System.Windows.Forms.Label lblAmountGray;
        private System.Windows.Forms.Label lblColorGray;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TextBox txtGeneration;
    }
}

