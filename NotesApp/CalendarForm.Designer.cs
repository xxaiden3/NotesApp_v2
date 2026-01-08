namespace NotesApp
{
    partial class CalendarForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlCalendar = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlDays = new System.Windows.Forms.Panel();
            this.updatereminder = new Guna.UI2.WinForms.Guna2Panel();
            this.saveupdatereminder = new FontAwesome.Sharp.IconButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtupdatereminderdes = new System.Windows.Forms.TextBox();
            this.txtupdateremindertitle = new System.Windows.Forms.TextBox();
            this.pnlWeekDays = new System.Windows.Forms.Panel();
            this.lblSu = new System.Windows.Forms.Label();
            this.lblSt = new System.Windows.Forms.Label();
            this.lblFr = new System.Windows.Forms.Label();
            this.lblTh = new System.Windows.Forms.Label();
            this.lblTu = new System.Windows.Forms.Label();
            this.lblWe = new System.Windows.Forms.Label();
            this.lblMo = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblMonthYear = new System.Windows.Forms.Label();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPrev = new FontAwesome.Sharp.IconButton();
            this.paneladdreminder = new Guna.UI2.WinForms.Guna2Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.savereminder = new FontAwesome.Sharp.IconButton();
            this.remindertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.remindertitle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedDate = new System.Windows.Forms.Label();
            this.pnlcontrol = new System.Windows.Forms.Panel();
            this.dgvReminders = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.deletereminderr = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.updatereminderr = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addreminder = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.pnlCalendar.SuspendLayout();
            this.updatereminder.SuspendLayout();
            this.pnlWeekDays.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.paneladdreminder.SuspendLayout();
            this.pnlcontrol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminders)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCalendar
            // 
            this.pnlCalendar.BackColor = System.Drawing.Color.Transparent;
            this.pnlCalendar.Controls.Add(this.pnlDays);
            this.pnlCalendar.Controls.Add(this.pnlWeekDays);
            this.pnlCalendar.Controls.Add(this.pnlHeader);
            this.pnlCalendar.FillColor = System.Drawing.Color.White;
            this.pnlCalendar.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.pnlCalendar.Location = new System.Drawing.Point(12, 17);
            this.pnlCalendar.Name = "pnlCalendar";
            this.pnlCalendar.Padding = new System.Windows.Forms.Padding(10);
            this.pnlCalendar.Size = new System.Drawing.Size(612, 635);
            this.pnlCalendar.TabIndex = 21;
            // 
            // pnlDays
            // 
            this.pnlDays.BackColor = System.Drawing.Color.White;
            this.pnlDays.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDays.Location = new System.Drawing.Point(10, 90);
            this.pnlDays.Name = "pnlDays";
            this.pnlDays.Size = new System.Drawing.Size(592, 535);
            this.pnlDays.TabIndex = 2;
            // 
            // updatereminder
            // 
            this.updatereminder.BackColor = System.Drawing.Color.Transparent;
            this.updatereminder.BorderRadius = 12;
            this.updatereminder.Controls.Add(this.label6);
            this.updatereminder.Controls.Add(this.saveupdatereminder);
            this.updatereminder.Controls.Add(this.label4);
            this.updatereminder.Controls.Add(this.label5);
            this.updatereminder.Controls.Add(this.txtupdatereminderdes);
            this.updatereminder.Controls.Add(this.txtupdateremindertitle);
            this.updatereminder.FillColor = System.Drawing.Color.White;
            this.updatereminder.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.updatereminder.Location = new System.Drawing.Point(631, 453);
            this.updatereminder.Name = "updatereminder";
            this.updatereminder.Size = new System.Drawing.Size(419, 199);
            this.updatereminder.TabIndex = 23;
            this.updatereminder.Visible = false;
            // 
            // saveupdatereminder
            // 
            this.saveupdatereminder.BackColor = System.Drawing.Color.White;
            this.saveupdatereminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveupdatereminder.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveupdatereminder.ForeColor = System.Drawing.Color.Black;
            this.saveupdatereminder.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.saveupdatereminder.IconColor = System.Drawing.Color.Black;
            this.saveupdatereminder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveupdatereminder.IconSize = 38;
            this.saveupdatereminder.Location = new System.Drawing.Point(358, 74);
            this.saveupdatereminder.Name = "saveupdatereminder";
            this.saveupdatereminder.Size = new System.Drawing.Size(47, 84);
            this.saveupdatereminder.TabIndex = 7;
            this.saveupdatereminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveupdatereminder.UseVisualStyleBackColor = false;
            this.saveupdatereminder.Click += new System.EventHandler(this.saveupdatereminder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(22, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Description ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(22, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Title";
            // 
            // txtupdatereminderdes
            // 
            this.txtupdatereminderdes.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtupdatereminderdes.Location = new System.Drawing.Point(22, 134);
            this.txtupdatereminderdes.Name = "txtupdatereminderdes";
            this.txtupdatereminderdes.Size = new System.Drawing.Size(321, 24);
            this.txtupdatereminderdes.TabIndex = 5;
            // 
            // txtupdateremindertitle
            // 
            this.txtupdateremindertitle.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtupdateremindertitle.Location = new System.Drawing.Point(22, 74);
            this.txtupdateremindertitle.Name = "txtupdateremindertitle";
            this.txtupdateremindertitle.Size = new System.Drawing.Size(321, 24);
            this.txtupdateremindertitle.TabIndex = 4;
            // 
            // pnlWeekDays
            // 
            this.pnlWeekDays.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlWeekDays.Controls.Add(this.lblSu);
            this.pnlWeekDays.Controls.Add(this.lblSt);
            this.pnlWeekDays.Controls.Add(this.lblFr);
            this.pnlWeekDays.Controls.Add(this.lblTh);
            this.pnlWeekDays.Controls.Add(this.lblTu);
            this.pnlWeekDays.Controls.Add(this.lblWe);
            this.pnlWeekDays.Controls.Add(this.lblMo);
            this.pnlWeekDays.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlWeekDays.Location = new System.Drawing.Point(10, 60);
            this.pnlWeekDays.Name = "pnlWeekDays";
            this.pnlWeekDays.Size = new System.Drawing.Size(592, 30);
            this.pnlWeekDays.TabIndex = 1;
            // 
            // lblSu
            // 
            this.lblSu.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSu.Location = new System.Drawing.Point(527, 1);
            this.lblSu.Name = "lblSu";
            this.lblSu.Size = new System.Drawing.Size(45, 27);
            this.lblSu.TabIndex = 8;
            this.lblSu.Text = "Su";
            this.lblSu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSt
            // 
            this.lblSt.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSt.Location = new System.Drawing.Point(443, 2);
            this.lblSt.Name = "lblSt";
            this.lblSt.Size = new System.Drawing.Size(45, 27);
            this.lblSt.TabIndex = 7;
            this.lblSt.Text = "St";
            this.lblSt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFr
            // 
            this.lblFr.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFr.Location = new System.Drawing.Point(357, 2);
            this.lblFr.Name = "lblFr";
            this.lblFr.Size = new System.Drawing.Size(45, 27);
            this.lblFr.TabIndex = 6;
            this.lblFr.Text = "Fr";
            this.lblFr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTh
            // 
            this.lblTh.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTh.Location = new System.Drawing.Point(273, 2);
            this.lblTh.Name = "lblTh";
            this.lblTh.Size = new System.Drawing.Size(45, 27);
            this.lblTh.TabIndex = 5;
            this.lblTh.Text = "Th";
            this.lblTh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTu
            // 
            this.lblTu.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTu.Location = new System.Drawing.Point(103, 3);
            this.lblTu.Name = "lblTu";
            this.lblTu.Size = new System.Drawing.Size(45, 27);
            this.lblTu.TabIndex = 4;
            this.lblTu.Text = "Tu";
            this.lblTu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblWe
            // 
            this.lblWe.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWe.Location = new System.Drawing.Point(189, 3);
            this.lblWe.Name = "lblWe";
            this.lblWe.Size = new System.Drawing.Size(45, 27);
            this.lblWe.TabIndex = 3;
            this.lblWe.Text = "We";
            this.lblWe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMo
            // 
            this.lblMo.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMo.Location = new System.Drawing.Point(21, 3);
            this.lblMo.Name = "lblMo";
            this.lblMo.Size = new System.Drawing.Size(45, 27);
            this.lblMo.TabIndex = 2;
            this.lblMo.Text = "Mo";
            this.lblMo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.Silver;
            this.pnlHeader.Controls.Add(this.lblMonthYear);
            this.pnlHeader.Controls.Add(this.btnNext);
            this.pnlHeader.Controls.Add(this.btnPrev);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(10, 10);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(592, 50);
            this.pnlHeader.TabIndex = 0;
            // 
            // lblMonthYear
            // 
            this.lblMonthYear.BackColor = System.Drawing.Color.White;
            this.lblMonthYear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMonthYear.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMonthYear.Location = new System.Drawing.Point(50, 0);
            this.lblMonthYear.Name = "lblMonthYear";
            this.lblMonthYear.Size = new System.Drawing.Size(492, 50);
            this.lblMonthYear.TabIndex = 2;
            this.lblMonthYear.Text = "May 2026";
            this.lblMonthYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.ArrowRightLong;
            this.btnNext.IconColor = System.Drawing.Color.Black;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.IconSize = 35;
            this.btnNext.Location = new System.Drawing.Point(542, 0);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 50);
            this.btnNext.TabIndex = 1;
            this.btnNext.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.White;
            this.btnPrev.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPrev.FlatAppearance.BorderSize = 0;
            this.btnPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrev.IconChar = FontAwesome.Sharp.IconChar.LongArrowLeft;
            this.btnPrev.IconColor = System.Drawing.Color.Black;
            this.btnPrev.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPrev.IconSize = 35;
            this.btnPrev.Location = new System.Drawing.Point(0, 0);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(50, 50);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.UseVisualStyleBackColor = false;
            // 
            // paneladdreminder
            // 
            this.paneladdreminder.BackColor = System.Drawing.Color.Transparent;
            this.paneladdreminder.BorderRadius = 12;
            this.paneladdreminder.Controls.Add(this.checkBox1);
            this.paneladdreminder.Controls.Add(this.savereminder);
            this.paneladdreminder.Controls.Add(this.remindertxt);
            this.paneladdreminder.Controls.Add(this.label1);
            this.paneladdreminder.Controls.Add(this.remindertitle);
            this.paneladdreminder.Controls.Add(this.label2);
            this.paneladdreminder.Controls.Add(this.lblSelectedDate);
            this.paneladdreminder.FillColor = System.Drawing.Color.White;
            this.paneladdreminder.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.paneladdreminder.Location = new System.Drawing.Point(630, 453);
            this.paneladdreminder.Name = "paneladdreminder";
            this.paneladdreminder.Size = new System.Drawing.Size(419, 199);
            this.paneladdreminder.TabIndex = 22;
            this.paneladdreminder.Visible = false;
            this.paneladdreminder.Paint += new System.Windows.Forms.PaintEventHandler(this.paneladdreminder_Paint);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBox1.Location = new System.Drawing.Point(24, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(171, 21);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Only Description";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // savereminder
            // 
            this.savereminder.BackColor = System.Drawing.Color.White;
            this.savereminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savereminder.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.savereminder.ForeColor = System.Drawing.Color.Black;
            this.savereminder.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            this.savereminder.IconColor = System.Drawing.Color.Black;
            this.savereminder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.savereminder.IconSize = 38;
            this.savereminder.Location = new System.Drawing.Point(358, 76);
            this.savereminder.Name = "savereminder";
            this.savereminder.Size = new System.Drawing.Size(47, 84);
            this.savereminder.TabIndex = 7;
            this.savereminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.savereminder.UseVisualStyleBackColor = false;
            this.savereminder.Click += new System.EventHandler(this.SaveIB_Click);
            // 
            // remindertxt
            // 
            this.remindertxt.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.remindertxt.Location = new System.Drawing.Point(24, 136);
            this.remindertxt.Name = "remindertxt";
            this.remindertxt.Size = new System.Drawing.Size(321, 24);
            this.remindertxt.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Title";
            // 
            // remindertitle
            // 
            this.remindertitle.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.remindertitle.Location = new System.Drawing.Point(24, 76);
            this.remindertitle.Name = "remindertitle";
            this.remindertitle.Size = new System.Drawing.Size(321, 24);
            this.remindertitle.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Description";
            // 
            // lblSelectedDate
            // 
            this.lblSelectedDate.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSelectedDate.Location = new System.Drawing.Point(292, 10);
            this.lblSelectedDate.Name = "lblSelectedDate";
            this.lblSelectedDate.Size = new System.Drawing.Size(106, 23);
            this.lblSelectedDate.TabIndex = 0;
            this.lblSelectedDate.Text = "01.01.2026";
            this.lblSelectedDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlcontrol
            // 
            this.pnlcontrol.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnlcontrol.Controls.Add(this.dgvReminders);
            this.pnlcontrol.Location = new System.Drawing.Point(631, 17);
            this.pnlcontrol.Name = "pnlcontrol";
            this.pnlcontrol.Size = new System.Drawing.Size(418, 346);
            this.pnlcontrol.TabIndex = 23;
            // 
            // dgvReminders
            // 
            this.dgvReminders.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(244)))));
            this.dgvReminders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReminders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dgvReminders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReminders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReminders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Select,
            this.Title,
            this.des,
            this.createdate});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReminders.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReminders.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvReminders.Location = new System.Drawing.Point(0, 0);
            this.dgvReminders.Name = "dgvReminders";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReminders.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReminders.RowHeadersVisible = false;
            this.dgvReminders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReminders.Size = new System.Drawing.Size(418, 346);
            this.dgvReminders.TabIndex = 28;
            this.dgvReminders.SelectionChanged += new System.EventHandler(this.dgvReminders_SelectionChanged);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Select
            // 
            this.Select.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Select.HeaderText = "";
            this.Select.Name = "Select";
            this.Select.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select.Width = 19;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Title.DataPropertyName = "title";
            this.Title.HeaderText = "Reminder Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 96;
            // 
            // des
            // 
            this.des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.des.DataPropertyName = "Description";
            this.des.HeaderText = "Reminder Description";
            this.des.Name = "des";
            this.des.ReadOnly = true;
            // 
            // createdate
            // 
            this.createdate.DataPropertyName = "CreatedAt";
            this.createdate.HeaderText = "Created Date";
            this.createdate.Name = "createdate";
            this.createdate.ReadOnly = true;
            this.createdate.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.panel5.Controls.Add(this.deletereminderr);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.updatereminderr);
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Controls.Add(this.addreminder);
            this.panel5.Location = new System.Drawing.Point(631, 400);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(418, 47);
            this.panel5.TabIndex = 28;
            // 
            // deletereminderr
            // 
            this.deletereminderr.BackColor = System.Drawing.Color.White;
            this.deletereminderr.Dock = System.Windows.Forms.DockStyle.Left;
            this.deletereminderr.FlatAppearance.BorderSize = 0;
            this.deletereminderr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletereminderr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deletereminderr.ForeColor = System.Drawing.Color.Black;
            this.deletereminderr.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deletereminderr.IconColor = System.Drawing.Color.Black;
            this.deletereminderr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deletereminderr.IconSize = 38;
            this.deletereminderr.Location = new System.Drawing.Point(284, 0);
            this.deletereminderr.Name = "deletereminderr";
            this.deletereminderr.Size = new System.Drawing.Size(132, 47);
            this.deletereminderr.TabIndex = 10;
            this.deletereminderr.Text = "Delete";
            this.deletereminderr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deletereminderr.UseVisualStyleBackColor = false;
            this.deletereminderr.Click += new System.EventHandler(this.deletereminderr_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(274, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 47);
            this.panel2.TabIndex = 9;
            // 
            // updatereminderr
            // 
            this.updatereminderr.BackColor = System.Drawing.Color.White;
            this.updatereminderr.Dock = System.Windows.Forms.DockStyle.Left;
            this.updatereminderr.FlatAppearance.BorderSize = 0;
            this.updatereminderr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatereminderr.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updatereminderr.ForeColor = System.Drawing.Color.Black;
            this.updatereminderr.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.updatereminderr.IconColor = System.Drawing.Color.Black;
            this.updatereminderr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updatereminderr.IconSize = 38;
            this.updatereminderr.Location = new System.Drawing.Point(142, 0);
            this.updatereminderr.Name = "updatereminderr";
            this.updatereminderr.Size = new System.Drawing.Size(132, 47);
            this.updatereminderr.TabIndex = 8;
            this.updatereminderr.Text = "Update";
            this.updatereminderr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.updatereminderr.UseVisualStyleBackColor = false;
            this.updatereminderr.Click += new System.EventHandler(this.updatereminderr_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(132, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 47);
            this.panel1.TabIndex = 7;
            // 
            // addreminder
            // 
            this.addreminder.BackColor = System.Drawing.Color.White;
            this.addreminder.Dock = System.Windows.Forms.DockStyle.Left;
            this.addreminder.FlatAppearance.BorderSize = 0;
            this.addreminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addreminder.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addreminder.ForeColor = System.Drawing.Color.Black;
            this.addreminder.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.addreminder.IconColor = System.Drawing.Color.Black;
            this.addreminder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.addreminder.IconSize = 38;
            this.addreminder.Location = new System.Drawing.Point(0, 0);
            this.addreminder.Name = "addreminder";
            this.addreminder.Size = new System.Drawing.Size(132, 47);
            this.addreminder.TabIndex = 6;
            this.addreminder.Text = "Add ";
            this.addreminder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addreminder.UseVisualStyleBackColor = false;
            this.addreminder.Click += new System.EventHandler(this.addreminder_Click_1);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(631, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(418, 31);
            this.label3.TabIndex = 29;
            this.label3.Text = "Control Your Reminders";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(292, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 23);
            this.label6.TabIndex = 8;
            this.label6.Text = "01.01.2026";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CalendarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(1060, 670);
            this.Controls.Add(this.paneladdreminder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.updatereminder);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pnlcontrol);
            this.Controls.Add(this.pnlCalendar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CalendarForm";
            this.Text = "CalendarForm";
            this.Load += new System.EventHandler(this.CalendarForm_Load);
            this.pnlCalendar.ResumeLayout(false);
            this.updatereminder.ResumeLayout(false);
            this.updatereminder.PerformLayout();
            this.pnlWeekDays.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.paneladdreminder.ResumeLayout(false);
            this.paneladdreminder.PerformLayout();
            this.pnlcontrol.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminders)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlCalendar;
        private System.Windows.Forms.Panel pnlDays;
        private System.Windows.Forms.Label lblSelectedDate;
        private System.Windows.Forms.Panel pnlWeekDays;
        private System.Windows.Forms.Label lblSu;
        private System.Windows.Forms.Label lblSt;
        private System.Windows.Forms.Label lblFr;
        private System.Windows.Forms.Label lblTh;
        private System.Windows.Forms.Label lblTu;
        private System.Windows.Forms.Label lblWe;
        private System.Windows.Forms.Label lblMo;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblMonthYear;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPrev;
        private Guna.UI2.WinForms.Guna2Panel paneladdreminder;
        private FontAwesome.Sharp.IconButton savereminder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox remindertxt;
        private System.Windows.Forms.TextBox remindertitle;
        private System.Windows.Forms.Panel pnlcontrol;
        private System.Windows.Forms.DataGridView dgvReminders;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton addreminder;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton updatereminderr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdate;
        private FontAwesome.Sharp.IconButton deletereminderr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private Guna.UI2.WinForms.Guna2Panel updatereminder;
        private FontAwesome.Sharp.IconButton saveupdatereminder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtupdatereminderdes;
        private System.Windows.Forms.TextBox txtupdateremindertitle;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label6;
    }
}