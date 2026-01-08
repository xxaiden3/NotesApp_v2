namespace NotesApp
{
    partial class ShowNotes
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvnotes = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvtitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvnote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fontsize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bold = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcolor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcontent = new System.Windows.Forms.RichTextBox();
            this.txttitle = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.CleanIB = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtsearchtags = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtsearchnotes = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtsearchtitle = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotes)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvnotes
            // 
            this.dgvnotes.AllowUserToAddRows = false;
            this.dgvnotes.AllowUserToDeleteRows = false;
            this.dgvnotes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnotes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvnotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.dgvtitle,
            this.dgvnote,
            this.fontname,
            this.fontsize,
            this.bold,
            this.txtcolor,
            this.dgvdate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvnotes.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvnotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvnotes.Location = new System.Drawing.Point(0, 0);
            this.dgvnotes.Margin = new System.Windows.Forms.Padding(5);
            this.dgvnotes.Name = "dgvnotes";
            this.dgvnotes.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvnotes.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvnotes.RowHeadersVisible = false;
            this.dgvnotes.RowTemplate.Height = 35;
            this.dgvnotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnotes.Size = new System.Drawing.Size(1060, 670);
            this.dgvnotes.TabIndex = 22;
            this.dgvnotes.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvnotes_CellFormatting);
            // 
            // id
            // 
            this.id.DataPropertyName = "Id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // dgvtitle
            // 
            this.dgvtitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvtitle.DataPropertyName = "Title";
            this.dgvtitle.HeaderText = "Title";
            this.dgvtitle.Name = "dgvtitle";
            this.dgvtitle.ReadOnly = true;
            this.dgvtitle.Width = 67;
            // 
            // dgvnote
            // 
            this.dgvnote.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvnote.DataPropertyName = "Content";
            this.dgvnote.HeaderText = "Note";
            this.dgvnote.Name = "dgvnote";
            this.dgvnote.ReadOnly = true;
            // 
            // fontname
            // 
            this.fontname.DataPropertyName = "FontName";
            this.fontname.HeaderText = "Font Name";
            this.fontname.Name = "fontname";
            this.fontname.ReadOnly = true;
            this.fontname.Visible = false;
            // 
            // fontsize
            // 
            this.fontsize.DataPropertyName = "FontSize";
            this.fontsize.HeaderText = "Font Size";
            this.fontsize.Name = "fontsize";
            this.fontsize.ReadOnly = true;
            this.fontsize.Visible = false;
            // 
            // bold
            // 
            this.bold.DataPropertyName = "IsBold";
            this.bold.HeaderText = "Bold";
            this.bold.Name = "bold";
            this.bold.ReadOnly = true;
            this.bold.Visible = false;
            // 
            // txtcolor
            // 
            this.txtcolor.DataPropertyName = "TextColor";
            this.txtcolor.HeaderText = "Text Color";
            this.txtcolor.Name = "txtcolor";
            this.txtcolor.ReadOnly = true;
            this.txtcolor.Visible = false;
            // 
            // dgvdate
            // 
            this.dgvdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dgvdate.DataPropertyName = "CreatedDate";
            this.dgvdate.HeaderText = "Create Date";
            this.dgvdate.Name = "dgvdate";
            this.dgvdate.ReadOnly = true;
            this.dgvdate.Width = 75;
            // 
            // txtcontent
            // 
            this.txtcontent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(244)))), ((int)(((byte)(246)))));
            this.txtcontent.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtcontent.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcontent.ForeColor = System.Drawing.Color.Black;
            this.txtcontent.Location = new System.Drawing.Point(650, 74);
            this.txtcontent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtcontent.Size = new System.Drawing.Size(137, 65);
            this.txtcontent.TabIndex = 24;
            this.txtcontent.Text = "Note";
            this.txtcontent.Visible = false;
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))));
            this.txttitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttitle.ForeColor = System.Drawing.Color.Black;
            this.txttitle.Location = new System.Drawing.Point(650, 55);
            this.txttitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txttitle.Name = "txttitle";
            this.txttitle.Size = new System.Drawing.Size(137, 19);
            this.txttitle.TabIndex = 23;
            this.txttitle.Text = "Title";
            this.txttitle.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.CleanIB);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel1.Location = new System.Drawing.Point(0, 606);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1060, 64);
            this.panel1.TabIndex = 25;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // radioButton2
            // 
            this.radioButton2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton2.ForeColor = System.Drawing.Color.White;
            this.radioButton2.Location = new System.Drawing.Point(687, 34);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(131, 22);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Last 1 Mounth";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // CleanIB
            // 
            this.CleanIB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.CleanIB.Dock = System.Windows.Forms.DockStyle.Right;
            this.CleanIB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CleanIB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CleanIB.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CleanIB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(50)))), ((int)(((byte)(79)))));
            this.CleanIB.IconChar = FontAwesome.Sharp.IconChar.Broom;
            this.CleanIB.IconColor = System.Drawing.Color.White;
            this.CleanIB.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CleanIB.IconSize = 40;
            this.CleanIB.Location = new System.Drawing.Point(1000, 0);
            this.CleanIB.Name = "CleanIB";
            this.CleanIB.Size = new System.Drawing.Size(60, 64);
            this.CleanIB.TabIndex = 34;
            this.CleanIB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CleanIB.UseVisualStyleBackColor = false;
            this.CleanIB.Click += new System.EventHandler(this.CleanIB_Click);
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(664, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(17, 64);
            this.panel4.TabIndex = 32;
            // 
            // radioButton1
            // 
            this.radioButton1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.radioButton1.ForeColor = System.Drawing.Color.White;
            this.radioButton1.Location = new System.Drawing.Point(687, 7);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(131, 22);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Last 7 Days";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtsearchtags);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(454, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(210, 64);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search by Tags";
            // 
            // txtsearchtags
            // 
            this.txtsearchtags.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearchtags.Location = new System.Drawing.Point(22, 25);
            this.txtsearchtags.Name = "txtsearchtags";
            this.txtsearchtags.Size = new System.Drawing.Size(163, 22);
            this.txtsearchtags.TabIndex = 1;
            this.txtsearchtags.TextChanged += new System.EventHandler(this.txtsearchtags_TextChanged);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(437, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(17, 64);
            this.panel3.TabIndex = 19;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtsearchnotes);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox4.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(227, 0);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(210, 64);
            this.groupBox4.TabIndex = 18;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Search by Notes";
            // 
            // txtsearchnotes
            // 
            this.txtsearchnotes.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearchnotes.Location = new System.Drawing.Point(21, 25);
            this.txtsearchnotes.Name = "txtsearchnotes";
            this.txtsearchnotes.Size = new System.Drawing.Size(163, 22);
            this.txtsearchnotes.TabIndex = 1;
            this.txtsearchnotes.TextChanged += new System.EventHandler(this.txtsearchnotes_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(210, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(17, 64);
            this.panel2.TabIndex = 17;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtsearchtitle);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox3.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(210, 64);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search by Title";
            // 
            // txtsearchtitle
            // 
            this.txtsearchtitle.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsearchtitle.Location = new System.Drawing.Point(23, 26);
            this.txtsearchtitle.Name = "txtsearchtitle";
            this.txtsearchtitle.Size = new System.Drawing.Size(163, 22);
            this.txtsearchtitle.TabIndex = 1;
            this.txtsearchtitle.TextChanged += new System.EventHandler(this.txtsearchtitle_TextChanged);
            // 
            // ShowNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 670);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtcontent);
            this.Controls.Add(this.txttitle);
            this.Controls.Add(this.dgvnotes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowNotes";
            this.Text = "Show Notes";
            this.Load += new System.EventHandler(this.ShowNotes_Load);
            this.Shown += new System.EventHandler(this.ShowNotes_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnotes)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvtitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvnote;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontname;
        private System.Windows.Forms.DataGridViewTextBoxColumn fontsize;
        private System.Windows.Forms.DataGridViewTextBoxColumn bold;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtcolor;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvdate;
        public System.Windows.Forms.RichTextBox txtcontent;
        public System.Windows.Forms.MaskedTextBox txttitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtsearchtitle;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtsearchnotes;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton CleanIB;
        public System.Windows.Forms.DataGridView dgvnotes;
        private System.Windows.Forms.TextBox txtsearchtags;
    }
}