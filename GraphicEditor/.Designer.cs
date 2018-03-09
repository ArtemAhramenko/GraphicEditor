namespace lab2
{
    partial class MainForm
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
            this.mainPane = new System.Windows.Forms.Panel();
            this.groupBoxShapes = new System.Windows.Forms.GroupBox();
            this.pointY = new System.Windows.Forms.Label();
            this.pointX = new System.Windows.Forms.Label();
            this.pictureBoxRightTriangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxColor = new System.Windows.Forms.PictureBox();
            this.label21 = new System.Windows.Forms.Label();
            this.pictureBoxRedo = new System.Windows.Forms.PictureBox();
            this.pictureBoxUndo = new System.Windows.Forms.PictureBox();
            this.pictureBoxLine = new System.Windows.Forms.PictureBox();
            this.pictureBoxSquare = new System.Windows.Forms.PictureBox();
            this.pictureBoxEllipse = new System.Windows.Forms.PictureBox();
            this.pictureBoxRectangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxTriangle = new System.Windows.Forms.PictureBox();
            this.pictureBoxCircle = new System.Windows.Forms.PictureBox();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.groupBoxRectangle = new System.Windows.Forms.GroupBox();
            this.drawRectangleBtn = new System.Windows.Forms.Button();
            this.labelHeight = new System.Windows.Forms.Label();
            this.textBoxHeightRectangle = new System.Windows.Forms.TextBox();
            this.textBoxWidthRectangle = new System.Windows.Forms.TextBox();
            this.textBoxYRectangle = new System.Windows.Forms.TextBox();
            this.textBoxXRectangle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBoxSquare = new System.Windows.Forms.GroupBox();
            this.drawSquareBtn = new System.Windows.Forms.Button();
            this.textBoxWidthSquare = new System.Windows.Forms.TextBox();
            this.textBoxYSquare = new System.Windows.Forms.TextBox();
            this.textBoxXSquare = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxTriangle = new System.Windows.Forms.GroupBox();
            this.textBoxY3Triangle = new System.Windows.Forms.TextBox();
            this.textBoxX3Triangle = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.textBoxY2Triangle = new System.Windows.Forms.TextBox();
            this.textBoxX2Triangle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.drawTriangleBtn = new System.Windows.Forms.Button();
            this.textBoxYTriangle = new System.Windows.Forms.TextBox();
            this.textBoxXTriangle = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxEllipse = new System.Windows.Forms.GroupBox();
            this.drawEllipseBtn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBoxHeightEllipse = new System.Windows.Forms.TextBox();
            this.textBoxWidthEllipse = new System.Windows.Forms.TextBox();
            this.textBoxYEllipse = new System.Windows.Forms.TextBox();
            this.textBoxXEllipse = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBoxLine = new System.Windows.Forms.GroupBox();
            this.textBoxY2Line = new System.Windows.Forms.TextBox();
            this.textBoxX2Line = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.drawLineBtn = new System.Windows.Forms.Button();
            this.textBoxYLine = new System.Windows.Forms.TextBox();
            this.textBoxXLine = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBoxShapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).BeginInit();
            this.groupBoxRectangle.SuspendLayout();
            this.groupBoxSquare.SuspendLayout();
            this.groupBoxTriangle.SuspendLayout();
            this.groupBoxEllipse.SuspendLayout();
            this.groupBoxLine.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPane
            // 
            this.mainPane.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainPane.Location = new System.Drawing.Point(0, -1);
            this.mainPane.Name = "mainPane";
            this.mainPane.Size = new System.Drawing.Size(994, 608);
            this.mainPane.TabIndex = 6;
            this.mainPane.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPane_Paint);
            this.mainPane.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainPane_MouseDown);
            this.mainPane.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainPane_MouseMove);
            this.mainPane.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainPane_MouseUp);
            // 
            // groupBoxShapes
            // 
            this.groupBoxShapes.BackColor = System.Drawing.SystemColors.Window;
            this.groupBoxShapes.Controls.Add(this.pointY);
            this.groupBoxShapes.Controls.Add(this.pointX);
            this.groupBoxShapes.Controls.Add(this.pictureBoxRightTriangle);
            this.groupBoxShapes.Controls.Add(this.pictureBoxColor);
            this.groupBoxShapes.Controls.Add(this.label21);
            this.groupBoxShapes.Controls.Add(this.pictureBoxRedo);
            this.groupBoxShapes.Controls.Add(this.pictureBoxUndo);
            this.groupBoxShapes.Controls.Add(this.pictureBoxLine);
            this.groupBoxShapes.Controls.Add(this.pictureBoxSquare);
            this.groupBoxShapes.Controls.Add(this.pictureBoxEllipse);
            this.groupBoxShapes.Controls.Add(this.pictureBoxRectangle);
            this.groupBoxShapes.Controls.Add(this.pictureBoxTriangle);
            this.groupBoxShapes.Controls.Add(this.pictureBoxCircle);
            this.groupBoxShapes.Location = new System.Drawing.Point(0, 609);
            this.groupBoxShapes.Name = "groupBoxShapes";
            this.groupBoxShapes.Size = new System.Drawing.Size(318, 104);
            this.groupBoxShapes.TabIndex = 10;
            this.groupBoxShapes.TabStop = false;
            this.groupBoxShapes.Text = "Shapes";
            // 
            // pointY
            // 
            this.pointY.AutoSize = true;
            this.pointY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.pointY.Location = new System.Drawing.Point(247, 25);
            this.pointY.Name = "pointY";
            this.pointY.Size = new System.Drawing.Size(34, 20);
            this.pointY.TabIndex = 16;
            this.pointY.Text = "Y =";
            // 
            // pointX
            // 
            this.pointX.AutoSize = true;
            this.pointX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.pointX.Location = new System.Drawing.Point(185, 25);
            this.pointX.Name = "pointX";
            this.pointX.Size = new System.Drawing.Size(35, 20);
            this.pointX.TabIndex = 15;
            this.pointX.Text = "X =";
            // 
            // pictureBoxRightTriangle
            // 
            this.pictureBoxRightTriangle.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxRightTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRightTriangle.Image = global::GraphicEditor.Properties.Resources.RightTriangle;
            this.pictureBoxRightTriangle.Location = new System.Drawing.Point(128, 21);
            this.pictureBoxRightTriangle.Name = "pictureBoxRightTriangle";
            this.pictureBoxRightTriangle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRightTriangle.TabIndex = 14;
            this.pictureBoxRightTriangle.TabStop = false;
            this.pictureBoxRightTriangle.Tag = "7";
            this.pictureBoxRightTriangle.Click += new System.EventHandler(this.PictureBoxShape_Click);
            // 
            // pictureBoxColor
            // 
            this.pictureBoxColor.BackColor = System.Drawing.SystemColors.MenuText;
            this.pictureBoxColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxColor.Location = new System.Drawing.Point(267, 59);
            this.pictureBoxColor.Name = "pictureBoxColor";
            this.pictureBoxColor.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxColor.TabIndex = 13;
            this.pictureBoxColor.TabStop = false;
            this.pictureBoxColor.Click += new System.EventHandler(this.PictureBoxColor_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label21.Location = new System.Drawing.Point(7, 73);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(0, 13);
            this.label21.TabIndex = 1;
            // 
            // pictureBoxRedo
            // 
            this.pictureBoxRedo.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxRedo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRedo.Image = global::GraphicEditor.Properties.Resources.redo;
            this.pictureBoxRedo.Location = new System.Drawing.Point(227, 59);
            this.pictureBoxRedo.Name = "pictureBoxRedo";
            this.pictureBoxRedo.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRedo.TabIndex = 2;
            this.pictureBoxRedo.TabStop = false;
            this.pictureBoxRedo.Click += new System.EventHandler(this.PictureBoxRedo_Click);
            // 
            // pictureBoxUndo
            // 
            this.pictureBoxUndo.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxUndo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxUndo.Image = global::GraphicEditor.Properties.Resources.undo;
            this.pictureBoxUndo.Location = new System.Drawing.Point(187, 59);
            this.pictureBoxUndo.Name = "pictureBoxUndo";
            this.pictureBoxUndo.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxUndo.TabIndex = 11;
            this.pictureBoxUndo.TabStop = false;
            this.pictureBoxUndo.Click += new System.EventHandler(this.PictureBoxUndo_Click);
            // 
            // pictureBoxLine
            // 
            this.pictureBoxLine.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLine.Image = global::GraphicEditor.Properties.Resources.blackLine;
            this.pictureBoxLine.Location = new System.Drawing.Point(87, 59);
            this.pictureBoxLine.Name = "pictureBoxLine";
            this.pictureBoxLine.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxLine.TabIndex = 0;
            this.pictureBoxLine.TabStop = false;
            this.pictureBoxLine.Tag = "6";
            this.pictureBoxLine.Click += new System.EventHandler(this.PictureBoxShape_Click);
            // 
            // pictureBoxSquare
            // 
            this.pictureBoxSquare.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxSquare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSquare.Image = global::GraphicEditor.Properties.Resources.blackSquare;
            this.pictureBoxSquare.Location = new System.Drawing.Point(46, 21);
            this.pictureBoxSquare.Name = "pictureBoxSquare";
            this.pictureBoxSquare.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxSquare.TabIndex = 0;
            this.pictureBoxSquare.TabStop = false;
            this.pictureBoxSquare.Tag = "2";
            this.pictureBoxSquare.Click += new System.EventHandler(this.PictureBoxShape_Click);
            // 
            // pictureBoxEllipse
            // 
            this.pictureBoxEllipse.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxEllipse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxEllipse.Image = global::GraphicEditor.Properties.Resources.blackEllipse;
            this.pictureBoxEllipse.Location = new System.Drawing.Point(46, 59);
            this.pictureBoxEllipse.Name = "pictureBoxEllipse";
            this.pictureBoxEllipse.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxEllipse.TabIndex = 0;
            this.pictureBoxEllipse.TabStop = false;
            this.pictureBoxEllipse.Tag = "5";
            this.pictureBoxEllipse.Click += new System.EventHandler(this.PictureBoxShape_Click);
            // 
            // pictureBoxRectangle
            // 
            this.pictureBoxRectangle.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxRectangle.Image = global::GraphicEditor.Properties.Resources.blackRectangle;
            this.pictureBoxRectangle.Location = new System.Drawing.Point(87, 21);
            this.pictureBoxRectangle.Name = "pictureBoxRectangle";
            this.pictureBoxRectangle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxRectangle.TabIndex = 0;
            this.pictureBoxRectangle.TabStop = false;
            this.pictureBoxRectangle.Tag = "3";
            this.pictureBoxRectangle.Click += new System.EventHandler(this.PictureBoxShape_Click);
            // 
            // pictureBoxTriangle
            // 
            this.pictureBoxTriangle.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxTriangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxTriangle.Image = global::GraphicEditor.Properties.Resources.blackTriangle;
            this.pictureBoxTriangle.Location = new System.Drawing.Point(6, 59);
            this.pictureBoxTriangle.Name = "pictureBoxTriangle";
            this.pictureBoxTriangle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxTriangle.TabIndex = 0;
            this.pictureBoxTriangle.TabStop = false;
            this.pictureBoxTriangle.Tag = "4";
            this.pictureBoxTriangle.Click += new System.EventHandler(this.PictureBoxShape_Click);
            // 
            // pictureBoxCircle
            // 
            this.pictureBoxCircle.BackColor = System.Drawing.SystemColors.Window;
            this.pictureBoxCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCircle.Image = global::GraphicEditor.Properties.Resources.blackCircle;
            this.pictureBoxCircle.Location = new System.Drawing.Point(6, 21);
            this.pictureBoxCircle.Name = "pictureBoxCircle";
            this.pictureBoxCircle.Size = new System.Drawing.Size(30, 30);
            this.pictureBoxCircle.TabIndex = 0;
            this.pictureBoxCircle.TabStop = false;
            this.pictureBoxCircle.Tag = "1";
            this.pictureBoxCircle.Click += new System.EventHandler(this.PictureBoxShape_Click);
            // 
            // groupBoxRectangle
            // 
            this.groupBoxRectangle.Controls.Add(this.drawRectangleBtn);
            this.groupBoxRectangle.Controls.Add(this.labelHeight);
            this.groupBoxRectangle.Controls.Add(this.textBoxHeightRectangle);
            this.groupBoxRectangle.Controls.Add(this.textBoxWidthRectangle);
            this.groupBoxRectangle.Controls.Add(this.textBoxYRectangle);
            this.groupBoxRectangle.Controls.Add(this.textBoxXRectangle);
            this.groupBoxRectangle.Controls.Add(this.label1);
            this.groupBoxRectangle.Controls.Add(this.label2);
            this.groupBoxRectangle.Controls.Add(this.label3);
            this.groupBoxRectangle.Location = new System.Drawing.Point(447, 738);
            this.groupBoxRectangle.Name = "groupBoxRectangle";
            this.groupBoxRectangle.Size = new System.Drawing.Size(127, 205);
            this.groupBoxRectangle.TabIndex = 8;
            this.groupBoxRectangle.TabStop = false;
            this.groupBoxRectangle.Text = "Rectangle";
            this.groupBoxRectangle.Visible = false;
            // 
            // drawRectangleBtn
            // 
            this.drawRectangleBtn.Location = new System.Drawing.Point(0, 173);
            this.drawRectangleBtn.Name = "drawRectangleBtn";
            this.drawRectangleBtn.Size = new System.Drawing.Size(127, 32);
            this.drawRectangleBtn.TabIndex = 6;
            this.drawRectangleBtn.Text = "Draw";
            this.drawRectangleBtn.UseVisualStyleBackColor = true;
            // 
            // labelHeight
            // 
            this.labelHeight.AutoSize = true;
            this.labelHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.labelHeight.Location = new System.Drawing.Point(2, 134);
            this.labelHeight.Name = "labelHeight";
            this.labelHeight.Size = new System.Drawing.Size(62, 22);
            this.labelHeight.TabIndex = 7;
            this.labelHeight.Text = "Height";
            // 
            // textBoxHeightRectangle
            // 
            this.textBoxHeightRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxHeightRectangle.Location = new System.Drawing.Point(69, 132);
            this.textBoxHeightRectangle.MaxLength = 3;
            this.textBoxHeightRectangle.Name = "textBoxHeightRectangle";
            this.textBoxHeightRectangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxHeightRectangle.TabIndex = 6;
            // 
            // textBoxWidthRectangle
            // 
            this.textBoxWidthRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxWidthRectangle.Location = new System.Drawing.Point(69, 95);
            this.textBoxWidthRectangle.MaxLength = 3;
            this.textBoxWidthRectangle.Name = "textBoxWidthRectangle";
            this.textBoxWidthRectangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxWidthRectangle.TabIndex = 5;
            // 
            // textBoxYRectangle
            // 
            this.textBoxYRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxYRectangle.Location = new System.Drawing.Point(52, 52);
            this.textBoxYRectangle.MaxLength = 3;
            this.textBoxYRectangle.Name = "textBoxYRectangle";
            this.textBoxYRectangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxYRectangle.TabIndex = 4;
            // 
            // textBoxXRectangle
            // 
            this.textBoxXRectangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxXRectangle.Location = new System.Drawing.Point(52, 19);
            this.textBoxXRectangle.MaxLength = 3;
            this.textBoxXRectangle.Name = "textBoxXRectangle";
            this.textBoxXRectangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxXRectangle.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label1.Location = new System.Drawing.Point(2, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label2.Location = new System.Drawing.Point(23, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label3.Location = new System.Drawing.Point(23, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "x";
            // 
            // groupBoxSquare
            // 
            this.groupBoxSquare.Controls.Add(this.drawSquareBtn);
            this.groupBoxSquare.Controls.Add(this.textBoxWidthSquare);
            this.groupBoxSquare.Controls.Add(this.textBoxYSquare);
            this.groupBoxSquare.Controls.Add(this.textBoxXSquare);
            this.groupBoxSquare.Controls.Add(this.label4);
            this.groupBoxSquare.Controls.Add(this.label5);
            this.groupBoxSquare.Controls.Add(this.label6);
            this.groupBoxSquare.Location = new System.Drawing.Point(2, 719);
            this.groupBoxSquare.Name = "groupBoxSquare";
            this.groupBoxSquare.Size = new System.Drawing.Size(127, 171);
            this.groupBoxSquare.TabIndex = 8;
            this.groupBoxSquare.TabStop = false;
            this.groupBoxSquare.Text = "Square";
            this.groupBoxSquare.Visible = false;
            // 
            // drawSquareBtn
            // 
            this.drawSquareBtn.Location = new System.Drawing.Point(0, 139);
            this.drawSquareBtn.Name = "drawSquareBtn";
            this.drawSquareBtn.Size = new System.Drawing.Size(127, 32);
            this.drawSquareBtn.TabIndex = 6;
            this.drawSquareBtn.Text = "Draw";
            this.drawSquareBtn.UseVisualStyleBackColor = true;
            // 
            // textBoxWidthSquare
            // 
            this.textBoxWidthSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxWidthSquare.Location = new System.Drawing.Point(64, 96);
            this.textBoxWidthSquare.MaxLength = 3;
            this.textBoxWidthSquare.Name = "textBoxWidthSquare";
            this.textBoxWidthSquare.Size = new System.Drawing.Size(49, 27);
            this.textBoxWidthSquare.TabIndex = 5;
            // 
            // textBoxYSquare
            // 
            this.textBoxYSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxYSquare.Location = new System.Drawing.Point(52, 52);
            this.textBoxYSquare.MaxLength = 3;
            this.textBoxYSquare.Name = "textBoxYSquare";
            this.textBoxYSquare.Size = new System.Drawing.Size(49, 27);
            this.textBoxYSquare.TabIndex = 4;
            // 
            // textBoxXSquare
            // 
            this.textBoxXSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxXSquare.Location = new System.Drawing.Point(52, 19);
            this.textBoxXSquare.MaxLength = 3;
            this.textBoxXSquare.Name = "textBoxXSquare";
            this.textBoxXSquare.Size = new System.Drawing.Size(49, 27);
            this.textBoxXSquare.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 22);
            this.label4.TabIndex = 2;
            this.label4.Text = "Width";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label5.Location = new System.Drawing.Point(23, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label6.Location = new System.Drawing.Point(23, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "x";
            // 
            // groupBoxTriangle
            // 
            this.groupBoxTriangle.Controls.Add(this.textBoxY3Triangle);
            this.groupBoxTriangle.Controls.Add(this.textBoxX3Triangle);
            this.groupBoxTriangle.Controls.Add(this.label11);
            this.groupBoxTriangle.Controls.Add(this.label12);
            this.groupBoxTriangle.Controls.Add(this.textBoxY2Triangle);
            this.groupBoxTriangle.Controls.Add(this.textBoxX2Triangle);
            this.groupBoxTriangle.Controls.Add(this.label7);
            this.groupBoxTriangle.Controls.Add(this.label10);
            this.groupBoxTriangle.Controls.Add(this.drawTriangleBtn);
            this.groupBoxTriangle.Controls.Add(this.textBoxYTriangle);
            this.groupBoxTriangle.Controls.Add(this.textBoxXTriangle);
            this.groupBoxTriangle.Controls.Add(this.label8);
            this.groupBoxTriangle.Controls.Add(this.label9);
            this.groupBoxTriangle.Location = new System.Drawing.Point(0, 872);
            this.groupBoxTriangle.Name = "groupBoxTriangle";
            this.groupBoxTriangle.Size = new System.Drawing.Size(127, 283);
            this.groupBoxTriangle.TabIndex = 9;
            this.groupBoxTriangle.TabStop = false;
            this.groupBoxTriangle.Text = "Triangle";
            this.groupBoxTriangle.Visible = false;
            // 
            // textBoxY3Triangle
            // 
            this.textBoxY3Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxY3Triangle.Location = new System.Drawing.Point(52, 203);
            this.textBoxY3Triangle.MaxLength = 3;
            this.textBoxY3Triangle.Name = "textBoxY3Triangle";
            this.textBoxY3Triangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxY3Triangle.TabIndex = 14;
            // 
            // textBoxX3Triangle
            // 
            this.textBoxX3Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxX3Triangle.Location = new System.Drawing.Point(52, 170);
            this.textBoxX3Triangle.MaxLength = 3;
            this.textBoxX3Triangle.Name = "textBoxX3Triangle";
            this.textBoxX3Triangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxX3Triangle.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label11.Location = new System.Drawing.Point(12, 203);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 25);
            this.label11.TabIndex = 12;
            this.label11.Text = "y3";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label12.Location = new System.Drawing.Point(12, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 25);
            this.label12.TabIndex = 11;
            this.label12.Text = "x3";
            // 
            // textBoxY2Triangle
            // 
            this.textBoxY2Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxY2Triangle.Location = new System.Drawing.Point(52, 128);
            this.textBoxY2Triangle.MaxLength = 3;
            this.textBoxY2Triangle.Name = "textBoxY2Triangle";
            this.textBoxY2Triangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxY2Triangle.TabIndex = 10;
            // 
            // textBoxX2Triangle
            // 
            this.textBoxX2Triangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxX2Triangle.Location = new System.Drawing.Point(52, 95);
            this.textBoxX2Triangle.MaxLength = 3;
            this.textBoxX2Triangle.Name = "textBoxX2Triangle";
            this.textBoxX2Triangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxX2Triangle.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label7.Location = new System.Drawing.Point(12, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "y2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label10.Location = new System.Drawing.Point(12, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 25);
            this.label10.TabIndex = 7;
            this.label10.Text = "x2";
            // 
            // drawTriangleBtn
            // 
            this.drawTriangleBtn.Location = new System.Drawing.Point(0, 251);
            this.drawTriangleBtn.Name = "drawTriangleBtn";
            this.drawTriangleBtn.Size = new System.Drawing.Size(127, 32);
            this.drawTriangleBtn.TabIndex = 6;
            this.drawTriangleBtn.Text = "Draw";
            this.drawTriangleBtn.UseVisualStyleBackColor = true;
            // 
            // textBoxYTriangle
            // 
            this.textBoxYTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxYTriangle.Location = new System.Drawing.Point(52, 52);
            this.textBoxYTriangle.MaxLength = 3;
            this.textBoxYTriangle.Name = "textBoxYTriangle";
            this.textBoxYTriangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxYTriangle.TabIndex = 4;
            // 
            // textBoxXTriangle
            // 
            this.textBoxXTriangle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxXTriangle.Location = new System.Drawing.Point(52, 19);
            this.textBoxXTriangle.MaxLength = 3;
            this.textBoxXTriangle.Name = "textBoxXTriangle";
            this.textBoxXTriangle.Size = new System.Drawing.Size(49, 27);
            this.textBoxXTriangle.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label8.Location = new System.Drawing.Point(24, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "y";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label9.Location = new System.Drawing.Point(24, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "x";
            // 
            // groupBoxEllipse
            // 
            this.groupBoxEllipse.Controls.Add(this.drawEllipseBtn);
            this.groupBoxEllipse.Controls.Add(this.label13);
            this.groupBoxEllipse.Controls.Add(this.textBoxHeightEllipse);
            this.groupBoxEllipse.Controls.Add(this.textBoxWidthEllipse);
            this.groupBoxEllipse.Controls.Add(this.textBoxYEllipse);
            this.groupBoxEllipse.Controls.Add(this.textBoxXEllipse);
            this.groupBoxEllipse.Controls.Add(this.label14);
            this.groupBoxEllipse.Controls.Add(this.label15);
            this.groupBoxEllipse.Controls.Add(this.label16);
            this.groupBoxEllipse.Location = new System.Drawing.Point(144, 719);
            this.groupBoxEllipse.Name = "groupBoxEllipse";
            this.groupBoxEllipse.Size = new System.Drawing.Size(127, 205);
            this.groupBoxEllipse.TabIndex = 9;
            this.groupBoxEllipse.TabStop = false;
            this.groupBoxEllipse.Text = "Ellipse";
            this.groupBoxEllipse.Visible = false;
            // 
            // drawEllipseBtn
            // 
            this.drawEllipseBtn.Location = new System.Drawing.Point(0, 173);
            this.drawEllipseBtn.Name = "drawEllipseBtn";
            this.drawEllipseBtn.Size = new System.Drawing.Size(123, 32);
            this.drawEllipseBtn.TabIndex = 6;
            this.drawEllipseBtn.Text = "Draw";
            this.drawEllipseBtn.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label13.Location = new System.Drawing.Point(2, 134);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 22);
            this.label13.TabIndex = 7;
            this.label13.Text = "Height";
            // 
            // textBoxHeightEllipse
            // 
            this.textBoxHeightEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxHeightEllipse.Location = new System.Drawing.Point(69, 132);
            this.textBoxHeightEllipse.Name = "textBoxHeightEllipse";
            this.textBoxHeightEllipse.Size = new System.Drawing.Size(49, 27);
            this.textBoxHeightEllipse.TabIndex = 6;
            // 
            // textBoxWidthEllipse
            // 
            this.textBoxWidthEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxWidthEllipse.Location = new System.Drawing.Point(69, 95);
            this.textBoxWidthEllipse.MaxLength = 3;
            this.textBoxWidthEllipse.Name = "textBoxWidthEllipse";
            this.textBoxWidthEllipse.Size = new System.Drawing.Size(49, 27);
            this.textBoxWidthEllipse.TabIndex = 5;
            // 
            // textBoxYEllipse
            // 
            this.textBoxYEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxYEllipse.Location = new System.Drawing.Point(52, 52);
            this.textBoxYEllipse.MaxLength = 3;
            this.textBoxYEllipse.Name = "textBoxYEllipse";
            this.textBoxYEllipse.Size = new System.Drawing.Size(49, 27);
            this.textBoxYEllipse.TabIndex = 4;
            // 
            // textBoxXEllipse
            // 
            this.textBoxXEllipse.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxXEllipse.Location = new System.Drawing.Point(52, 19);
            this.textBoxXEllipse.MaxLength = 3;
            this.textBoxXEllipse.Name = "textBoxXEllipse";
            this.textBoxXEllipse.Size = new System.Drawing.Size(49, 27);
            this.textBoxXEllipse.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.label14.Location = new System.Drawing.Point(2, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 22);
            this.label14.TabIndex = 2;
            this.label14.Text = "Width";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label15.Location = new System.Drawing.Point(23, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 25);
            this.label15.TabIndex = 1;
            this.label15.Text = "y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label16.Location = new System.Drawing.Point(23, 20);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 25);
            this.label16.TabIndex = 0;
            this.label16.Text = "x";
            // 
            // groupBoxLine
            // 
            this.groupBoxLine.Controls.Add(this.textBoxY2Line);
            this.groupBoxLine.Controls.Add(this.textBoxX2Line);
            this.groupBoxLine.Controls.Add(this.label17);
            this.groupBoxLine.Controls.Add(this.label20);
            this.groupBoxLine.Controls.Add(this.drawLineBtn);
            this.groupBoxLine.Controls.Add(this.textBoxYLine);
            this.groupBoxLine.Controls.Add(this.textBoxXLine);
            this.groupBoxLine.Controls.Add(this.label18);
            this.groupBoxLine.Controls.Add(this.label19);
            this.groupBoxLine.Location = new System.Drawing.Point(289, 726);
            this.groupBoxLine.Name = "groupBoxLine";
            this.groupBoxLine.Size = new System.Drawing.Size(127, 198);
            this.groupBoxLine.TabIndex = 8;
            this.groupBoxLine.TabStop = false;
            this.groupBoxLine.Text = "Line";
            this.groupBoxLine.Visible = false;
            // 
            // textBoxY2Line
            // 
            this.textBoxY2Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxY2Line.Location = new System.Drawing.Point(53, 127);
            this.textBoxY2Line.Name = "textBoxY2Line";
            this.textBoxY2Line.Size = new System.Drawing.Size(49, 27);
            this.textBoxY2Line.TabIndex = 10;
            // 
            // textBoxX2Line
            // 
            this.textBoxX2Line.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxX2Line.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxX2Line.Location = new System.Drawing.Point(53, 94);
            this.textBoxX2Line.MaxLength = 3;
            this.textBoxX2Line.Name = "textBoxX2Line";
            this.textBoxX2Line.Size = new System.Drawing.Size(49, 27);
            this.textBoxX2Line.TabIndex = 9;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label17.Location = new System.Drawing.Point(15, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 25);
            this.label17.TabIndex = 8;
            this.label17.Text = "y2";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label20.Location = new System.Drawing.Point(15, 95);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 25);
            this.label20.TabIndex = 7;
            this.label20.Text = "x2";
            // 
            // drawLineBtn
            // 
            this.drawLineBtn.Location = new System.Drawing.Point(0, 166);
            this.drawLineBtn.Name = "drawLineBtn";
            this.drawLineBtn.Size = new System.Drawing.Size(127, 32);
            this.drawLineBtn.TabIndex = 6;
            this.drawLineBtn.Text = "Draw";
            this.drawLineBtn.UseVisualStyleBackColor = true;
            // 
            // textBoxYLine
            // 
            this.textBoxYLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxYLine.Location = new System.Drawing.Point(53, 52);
            this.textBoxYLine.MaxLength = 3;
            this.textBoxYLine.Name = "textBoxYLine";
            this.textBoxYLine.Size = new System.Drawing.Size(49, 27);
            this.textBoxYLine.TabIndex = 4;
            // 
            // textBoxXLine
            // 
            this.textBoxXLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.textBoxXLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.textBoxXLine.Location = new System.Drawing.Point(53, 19);
            this.textBoxXLine.MaxLength = 3;
            this.textBoxXLine.Name = "textBoxXLine";
            this.textBoxXLine.Size = new System.Drawing.Size(49, 27);
            this.textBoxXLine.TabIndex = 3;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label18.Location = new System.Drawing.Point(21, 52);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(23, 25);
            this.label18.TabIndex = 1;
            this.label18.Text = "y";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.label19.Location = new System.Drawing.Point(20, 20);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(23, 25);
            this.label19.TabIndex = 0;
            this.label19.Text = "x";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(994, 712);
            this.Controls.Add(this.groupBoxShapes);
            this.Controls.Add(this.groupBoxLine);
            this.Controls.Add(this.groupBoxEllipse);
            this.Controls.Add(this.groupBoxTriangle);
            this.Controls.Add(this.groupBoxRectangle);
            this.Controls.Add(this.groupBoxSquare);
            this.Controls.Add(this.mainPane);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Pane";
            this.groupBoxShapes.ResumeLayout(false);
            this.groupBoxShapes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUndo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSquare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxEllipse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRectangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTriangle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCircle)).EndInit();
            this.groupBoxRectangle.ResumeLayout(false);
            this.groupBoxRectangle.PerformLayout();
            this.groupBoxSquare.ResumeLayout(false);
            this.groupBoxSquare.PerformLayout();
            this.groupBoxTriangle.ResumeLayout(false);
            this.groupBoxTriangle.PerformLayout();
            this.groupBoxEllipse.ResumeLayout(false);
            this.groupBoxEllipse.PerformLayout();
            this.groupBoxLine.ResumeLayout(false);
            this.groupBoxLine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainPane;
        private System.Windows.Forms.GroupBox groupBoxRectangle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelHeight;
        private System.Windows.Forms.TextBox textBoxHeightRectangle;
        private System.Windows.Forms.TextBox textBoxWidthRectangle;
        private System.Windows.Forms.TextBox textBoxYRectangle;
        private System.Windows.Forms.TextBox textBoxXRectangle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button drawRectangleBtn;
        private System.Windows.Forms.GroupBox groupBoxSquare;
        private System.Windows.Forms.Button drawSquareBtn;
        private System.Windows.Forms.TextBox textBoxWidthSquare;
        private System.Windows.Forms.TextBox textBoxYSquare;
        private System.Windows.Forms.TextBox textBoxXSquare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxTriangle;
        private System.Windows.Forms.TextBox textBoxY3Triangle;
        private System.Windows.Forms.TextBox textBoxX3Triangle;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBoxY2Triangle;
        private System.Windows.Forms.TextBox textBoxX2Triangle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button drawTriangleBtn;
        private System.Windows.Forms.TextBox textBoxYTriangle;
        private System.Windows.Forms.TextBox textBoxXTriangle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBoxEllipse;
        private System.Windows.Forms.Button drawEllipseBtn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textBoxHeightEllipse;
        private System.Windows.Forms.TextBox textBoxWidthEllipse;
        private System.Windows.Forms.TextBox textBoxYEllipse;
        private System.Windows.Forms.TextBox textBoxXEllipse;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBoxLine;
        private System.Windows.Forms.Button drawLineBtn;
        private System.Windows.Forms.TextBox textBoxYLine;
        private System.Windows.Forms.TextBox textBoxXLine;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxY2Line;
        private System.Windows.Forms.TextBox textBoxX2Line;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.GroupBox groupBoxShapes;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.PictureBox pictureBoxLine;
        private System.Windows.Forms.PictureBox pictureBoxSquare;
        private System.Windows.Forms.PictureBox pictureBoxEllipse;
        private System.Windows.Forms.PictureBox pictureBoxRectangle;
        private System.Windows.Forms.PictureBox pictureBoxTriangle;
        private System.Windows.Forms.PictureBox pictureBoxCircle;
        private System.Windows.Forms.PictureBox pictureBoxRedo;
        private System.Windows.Forms.PictureBox pictureBoxUndo;
        private System.Windows.Forms.Label pointY;
        private System.Windows.Forms.Label pointX;
        private System.Windows.Forms.PictureBox pictureBoxRightTriangle;
        private System.Windows.Forms.PictureBox pictureBoxColor;
    }
}

