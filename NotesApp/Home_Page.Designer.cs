namespace NotesApp
{
    partial class Home_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home_Page));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelMenu = new Guna.UI2.WinForms.Guna2Panel();
            this.btncalender = new Guna.UI2.WinForms.Guna2Button();
            this.btneditnotes = new Guna.UI2.WinForms.Guna2Button();
            this.btnshownotes = new Guna.UI2.WinForms.Guna2Button();
            this.btncreatenote = new Guna.UI2.WinForms.Guna2Button();
            this.home = new Guna.UI2.WinForms.Guna2Button();
            this.btnsupport = new Guna.UI2.WinForms.Guna2Button();
            this.btnmenu = new Guna.UI2.WinForms.Guna2Button();
            this.lbldate = new System.Windows.Forms.Label();
            this.timerlabel = new System.Windows.Forms.Timer(this.components);
            this.PanelForm = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.WeatherCondution = new Guna.UI2.WinForms.Guna2Button();
            this.SearchCity = new Guna.UI2.WinForms.Guna2TextBox();
            this.cityandcountry = new Guna.UI2.WinForms.Guna2Button();
            this.Temperature = new Guna.UI2.WinForms.Guna2Button();
            this.magnifyingglass = new FontAwesome.Sharp.IconButton();
            this.Humidity = new Guna.UI2.WinForms.Guna2Button();
            this.WindySpeed = new Guna.UI2.WinForms.Guna2Button();
            this.editreminder = new FontAwesome.Sharp.IconButton();
            this.deletereminder = new FontAwesome.Sharp.IconButton();
            this.dgvReminders = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.des = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReminderDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelcard1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lbltags1 = new System.Windows.Forms.Label();
            this.lblcreatedate1 = new System.Windows.Forms.Label();
            this.txtcontent1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttitle1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.panelcard = new Guna.UI2.WinForms.Guna2Panel();
            this.lbltags = new System.Windows.Forms.Label();
            this.lblcreatedate = new System.Windows.Forms.Label();
            this.txtcontent = new Guna.UI2.WinForms.Guna2TextBox();
            this.txttitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblformname = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editNotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.PanelMenu.SuspendLayout();
            this.PanelForm.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminders)).BeginInit();
            this.panelcard1.SuspendLayout();
            this.panelcard.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelMenu.Controls.Add(this.btncalender);
            this.PanelMenu.Controls.Add(this.btneditnotes);
            this.PanelMenu.Controls.Add(this.btnshownotes);
            this.PanelMenu.Controls.Add(this.btncreatenote);
            this.PanelMenu.Controls.Add(this.home);
            this.PanelMenu.Controls.Add(this.btnsupport);
            this.PanelMenu.Controls.Add(this.btnmenu);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.PanelMenu.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PanelMenu.ForeColor = System.Drawing.Color.Black;
            this.PanelMenu.Location = new System.Drawing.Point(20, 60);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(200, 670);
            this.PanelMenu.TabIndex = 0;
            // 
            // btncalender
            // 
            this.btncalender.Animated = true;
            this.btncalender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btncalender.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncalender.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncalender.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncalender.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncalender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncalender.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btncalender.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncalender.ForeColor = System.Drawing.Color.White;
            this.btncalender.Image = global::NotesApp.Properties.Resources.calender_White;
            this.btncalender.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncalender.ImageSize = new System.Drawing.Size(32, 32);
            this.btncalender.Location = new System.Drawing.Point(0, 225);
            this.btncalender.Name = "btncalender";
            this.btncalender.Size = new System.Drawing.Size(200, 45);
            this.btncalender.TabIndex = 16;
            this.btncalender.Text = "Calender";
            this.btncalender.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncalender.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btneditnotes
            // 
            this.btneditnotes.Animated = true;
            this.btneditnotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btneditnotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btneditnotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btneditnotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btneditnotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btneditnotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btneditnotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btneditnotes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btneditnotes.ForeColor = System.Drawing.Color.White;
            this.btneditnotes.Image = global::NotesApp.Properties.Resources.editnotes_white;
            this.btneditnotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btneditnotes.ImageSize = new System.Drawing.Size(32, 32);
            this.btneditnotes.Location = new System.Drawing.Point(0, 180);
            this.btneditnotes.Name = "btneditnotes";
            this.btneditnotes.Size = new System.Drawing.Size(200, 45);
            this.btneditnotes.TabIndex = 15;
            this.btneditnotes.Text = "Edit Notes";
            this.btneditnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btneditnotes.Click += new System.EventHandler(this.btneditnotes_Click);
            // 
            // btnshownotes
            // 
            this.btnshownotes.Animated = true;
            this.btnshownotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btnshownotes.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnshownotes.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnshownotes.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnshownotes.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnshownotes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnshownotes.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btnshownotes.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnshownotes.ForeColor = System.Drawing.Color.White;
            this.btnshownotes.Image = global::NotesApp.Properties.Resources.shownotes_white;
            this.btnshownotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnshownotes.ImageSize = new System.Drawing.Size(32, 32);
            this.btnshownotes.Location = new System.Drawing.Point(0, 135);
            this.btnshownotes.Name = "btnshownotes";
            this.btnshownotes.Size = new System.Drawing.Size(200, 45);
            this.btnshownotes.TabIndex = 14;
            this.btnshownotes.Text = "Show Notes";
            this.btnshownotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnshownotes.Click += new System.EventHandler(this.btnshownotes_Click);
            // 
            // btncreatenote
            // 
            this.btncreatenote.Animated = true;
            this.btncreatenote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btncreatenote.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncreatenote.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncreatenote.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncreatenote.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncreatenote.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncreatenote.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btncreatenote.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btncreatenote.ForeColor = System.Drawing.Color.White;
            this.btncreatenote.Image = ((System.Drawing.Image)(resources.GetObject("btncreatenote.Image")));
            this.btncreatenote.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncreatenote.ImageSize = new System.Drawing.Size(30, 30);
            this.btncreatenote.Location = new System.Drawing.Point(0, 90);
            this.btncreatenote.Name = "btncreatenote";
            this.btncreatenote.Size = new System.Drawing.Size(200, 45);
            this.btncreatenote.TabIndex = 13;
            this.btncreatenote.Text = "Create Note";
            this.btncreatenote.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btncreatenote.Click += new System.EventHandler(this.btncreatenote_Click);
            // 
            // home
            // 
            this.home.Animated = true;
            this.home.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.home.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.home.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.home.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.home.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.home.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.Image = global::NotesApp.Properties.Resources.homee_white;
            this.home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.home.ImageSize = new System.Drawing.Size(32, 32);
            this.home.Location = new System.Drawing.Point(0, 45);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(200, 45);
            this.home.TabIndex = 10;
            this.home.Text = "Home";
            this.home.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // btnsupport
            // 
            this.btnsupport.Animated = true;
            this.btnsupport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btnsupport.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnsupport.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnsupport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnsupport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnsupport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnsupport.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btnsupport.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnsupport.ForeColor = System.Drawing.Color.White;
            this.btnsupport.Image = global::NotesApp.Properties.Resources.info_white;
            this.btnsupport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsupport.ImageSize = new System.Drawing.Size(30, 30);
            this.btnsupport.Location = new System.Drawing.Point(0, 625);
            this.btnsupport.Name = "btnsupport";
            this.btnsupport.Size = new System.Drawing.Size(200, 45);
            this.btnsupport.TabIndex = 8;
            this.btnsupport.Text = "Support";
            this.btnsupport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnsupport.Click += new System.EventHandler(this.btnsupport_Click);
            // 
            // btnmenu
            // 
            this.btnmenu.Animated = true;
            this.btnmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(215)))), ((int)(((byte)(132)))));
            this.btnmenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnmenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnmenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnmenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnmenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(70)))), ((int)(((byte)(158)))));
            this.btnmenu.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnmenu.ForeColor = System.Drawing.Color.White;
            this.btnmenu.Image = global::NotesApp.Properties.Resources.Panelkücült_white;
            this.btnmenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenu.ImageSize = new System.Drawing.Size(29, 29);
            this.btnmenu.Location = new System.Drawing.Point(0, 0);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(200, 45);
            this.btnmenu.TabIndex = 4;
            this.btnmenu.Text = "Hide Menu";
            this.btnmenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnmenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lbldate
            // 
            this.lbldate.BackColor = System.Drawing.Color.Transparent;
            this.lbldate.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbldate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.lbldate.Location = new System.Drawing.Point(1051, 22);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(231, 35);
            this.lbldate.TabIndex = 2;
            this.lbldate.Text = "01 Ocak 2026 ";
            this.lbldate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbldate.Click += new System.EventHandler(this.labeldate_Click);
            // 
            // timerlabel
            // 
            this.timerlabel.Enabled = true;
            this.timerlabel.Interval = 1000;
            this.timerlabel.Tick += new System.EventHandler(this.timerlabel_Tick);
            // 
            // PanelForm
            // 
            this.PanelForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.PanelForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelForm.Controls.Add(this.guna2Panel1);
            this.PanelForm.Controls.Add(this.editreminder);
            this.PanelForm.Controls.Add(this.deletereminder);
            this.PanelForm.Controls.Add(this.dgvReminders);
            this.PanelForm.Controls.Add(this.panelcard1);
            this.PanelForm.Controls.Add(this.panelcard);
            this.PanelForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelForm.Location = new System.Drawing.Point(220, 60);
            this.PanelForm.Name = "PanelForm";
            this.PanelForm.ShadowDecoration.Depth = 5;
            this.PanelForm.Size = new System.Drawing.Size(1060, 670);
            this.PanelForm.TabIndex = 1;
            this.PanelForm.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelForm_Paint);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.Controls.Add(this.WeatherCondution);
            this.guna2Panel1.Controls.Add(this.SearchCity);
            this.guna2Panel1.Controls.Add(this.cityandcountry);
            this.guna2Panel1.Controls.Add(this.Temperature);
            this.guna2Panel1.Controls.Add(this.magnifyingglass);
            this.guna2Panel1.Controls.Add(this.Humidity);
            this.guna2Panel1.Controls.Add(this.WindySpeed);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.guna2Panel1.Location = new System.Drawing.Point(698, 29);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(345, 300);
            this.guna2Panel1.TabIndex = 32;
            // 
            // WeatherCondution
            // 
            this.WeatherCondution.Animated = true;
            this.WeatherCondution.BackColor = System.Drawing.Color.White;
            this.WeatherCondution.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WeatherCondution.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WeatherCondution.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WeatherCondution.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WeatherCondution.FillColor = System.Drawing.SystemColors.Window;
            this.WeatherCondution.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WeatherCondution.ForeColor = System.Drawing.Color.Black;
            this.WeatherCondution.HoverState.FillColor = System.Drawing.Color.White;
            this.WeatherCondution.ImageSize = new System.Drawing.Size(25, 25);
            this.WeatherCondution.Location = new System.Drawing.Point(0, 137);
            this.WeatherCondution.Name = "WeatherCondution";
            this.WeatherCondution.Size = new System.Drawing.Size(342, 27);
            this.WeatherCondution.TabIndex = 36;
            this.WeatherCondution.Text = "Weather Condition";
            // 
            // SearchCity
            // 
            this.SearchCity.BorderRadius = 20;
            this.SearchCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchCity.DefaultText = "";
            this.SearchCity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.SearchCity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.SearchCity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchCity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.SearchCity.FocusedState.BorderColor = System.Drawing.Color.Black;
            this.SearchCity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SearchCity.ForeColor = System.Drawing.Color.Black;
            this.SearchCity.HoverState.BorderColor = System.Drawing.Color.Black;
            this.SearchCity.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.SearchCity.Location = new System.Drawing.Point(27, 11);
            this.SearchCity.Name = "SearchCity";
            this.SearchCity.PlaceholderText = "Search City";
            this.SearchCity.SelectedText = "";
            this.SearchCity.Size = new System.Drawing.Size(236, 45);
            this.SearchCity.TabIndex = 35;
            // 
            // cityandcountry
            // 
            this.cityandcountry.Animated = true;
            this.cityandcountry.BackColor = System.Drawing.Color.White;
            this.cityandcountry.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.cityandcountry.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.cityandcountry.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.cityandcountry.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.cityandcountry.FillColor = System.Drawing.SystemColors.Window;
            this.cityandcountry.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cityandcountry.ForeColor = System.Drawing.Color.Black;
            this.cityandcountry.Image = global::NotesApp.Properties.Resources.location_black;
            this.cityandcountry.ImageSize = new System.Drawing.Size(25, 25);
            this.cityandcountry.Location = new System.Drawing.Point(3, 158);
            this.cityandcountry.Name = "cityandcountry";
            this.cityandcountry.Size = new System.Drawing.Size(339, 60);
            this.cityandcountry.TabIndex = 34;
            this.cityandcountry.Text = "Ankara, TR";
            this.cityandcountry.Click += new System.EventHandler(this.cityandcountry_Click);
            // 
            // Temperature
            // 
            this.Temperature.Animated = true;
            this.Temperature.BackColor = System.Drawing.Color.White;
            this.Temperature.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Temperature.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Temperature.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Temperature.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Temperature.FillColor = System.Drawing.SystemColors.Window;
            this.Temperature.Font = new System.Drawing.Font("Courier New", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Temperature.ForeColor = System.Drawing.Color.Black;
            this.Temperature.HoverState.BorderColor = System.Drawing.Color.White;
            this.Temperature.HoverState.FillColor = System.Drawing.Color.White;
            this.Temperature.Image = global::NotesApp.Properties.Resources.tempature_black;
            this.Temperature.ImageSize = new System.Drawing.Size(35, 35);
            this.Temperature.Location = new System.Drawing.Point(3, 84);
            this.Temperature.Name = "Temperature";
            this.Temperature.Size = new System.Drawing.Size(339, 56);
            this.Temperature.TabIndex = 33;
            this.Temperature.Text = "18C°";
            // 
            // magnifyingglass
            // 
            this.magnifyingglass.BackColor = System.Drawing.Color.White;
            this.magnifyingglass.FlatAppearance.BorderSize = 0;
            this.magnifyingglass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.magnifyingglass.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.magnifyingglass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(74)))), ((int)(((byte)(166)))));
            this.magnifyingglass.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.magnifyingglass.IconColor = System.Drawing.Color.Black;
            this.magnifyingglass.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.magnifyingglass.IconSize = 28;
            this.magnifyingglass.Location = new System.Drawing.Point(278, 11);
            this.magnifyingglass.Name = "magnifyingglass";
            this.magnifyingglass.Size = new System.Drawing.Size(55, 48);
            this.magnifyingglass.TabIndex = 32;
            this.magnifyingglass.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.magnifyingglass.UseVisualStyleBackColor = false;
            this.magnifyingglass.Click += new System.EventHandler(this.ıconButton1_Click);
            // 
            // Humidity
            // 
            this.Humidity.Animated = true;
            this.Humidity.BackColor = System.Drawing.Color.White;
            this.Humidity.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Humidity.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Humidity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Humidity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Humidity.FillColor = System.Drawing.SystemColors.Window;
            this.Humidity.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Humidity.ForeColor = System.Drawing.Color.Black;
            this.Humidity.HoverState.FillColor = System.Drawing.Color.White;
            this.Humidity.Image = global::NotesApp.Properties.Resources.humidity_black;
            this.Humidity.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Humidity.ImageSize = new System.Drawing.Size(45, 45);
            this.Humidity.Location = new System.Drawing.Point(0, 239);
            this.Humidity.Name = "Humidity";
            this.Humidity.Size = new System.Drawing.Size(174, 61);
            this.Humidity.TabIndex = 22;
            this.Humidity.Text = "Humidity";
            this.Humidity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // WindySpeed
            // 
            this.WindySpeed.Animated = true;
            this.WindySpeed.BackColor = System.Drawing.Color.White;
            this.WindySpeed.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WindySpeed.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WindySpeed.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WindySpeed.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WindySpeed.FillColor = System.Drawing.SystemColors.Window;
            this.WindySpeed.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.WindySpeed.ForeColor = System.Drawing.Color.Black;
            this.WindySpeed.HoverState.FillColor = System.Drawing.Color.White;
            this.WindySpeed.Image = global::NotesApp.Properties.Resources.windyblack;
            this.WindySpeed.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.WindySpeed.ImageSize = new System.Drawing.Size(45, 45);
            this.WindySpeed.Location = new System.Drawing.Point(171, 239);
            this.WindySpeed.Name = "WindySpeed";
            this.WindySpeed.Size = new System.Drawing.Size(174, 61);
            this.WindySpeed.TabIndex = 20;
            this.WindySpeed.Text = "Windy Speed";
            this.WindySpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // editreminder
            // 
            this.editreminder.BackColor = System.Drawing.Color.White;
            this.editreminder.FlatAppearance.BorderSize = 0;
            this.editreminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editreminder.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.editreminder.ForeColor = System.Drawing.Color.Black;
            this.editreminder.IconChar = FontAwesome.Sharp.IconChar.Wrench;
            this.editreminder.IconColor = System.Drawing.Color.Black;
            this.editreminder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editreminder.IconSize = 38;
            this.editreminder.Location = new System.Drawing.Point(615, 180);
            this.editreminder.Name = "editreminder";
            this.editreminder.Size = new System.Drawing.Size(66, 149);
            this.editreminder.TabIndex = 31;
            this.editreminder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.editreminder.UseVisualStyleBackColor = false;
            this.editreminder.Click += new System.EventHandler(this.editreminder_Click);
            // 
            // deletereminder
            // 
            this.deletereminder.BackColor = System.Drawing.Color.White;
            this.deletereminder.FlatAppearance.BorderSize = 0;
            this.deletereminder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletereminder.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deletereminder.ForeColor = System.Drawing.Color.Black;
            this.deletereminder.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.deletereminder.IconColor = System.Drawing.Color.Black;
            this.deletereminder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deletereminder.IconSize = 38;
            this.deletereminder.Location = new System.Drawing.Point(615, 29);
            this.deletereminder.Name = "deletereminder";
            this.deletereminder.Size = new System.Drawing.Size(66, 145);
            this.deletereminder.TabIndex = 30;
            this.deletereminder.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deletereminder.UseVisualStyleBackColor = false;
            this.deletereminder.Click += new System.EventHandler(this.deletereminder_Click);
            // 
            // dgvReminders
            // 
            this.dgvReminders.AllowUserToAddRows = false;
            this.dgvReminders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.dgvReminders.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(227)))), ((int)(((byte)(234)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReminders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReminders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReminders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Select,
            this.Title,
            this.des,
            this.ReminderDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(199)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReminders.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvReminders.Location = new System.Drawing.Point(18, 29);
            this.dgvReminders.Name = "dgvReminders";
            this.dgvReminders.RowHeadersVisible = false;
            this.dgvReminders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReminders.Size = new System.Drawing.Size(594, 300);
            this.dgvReminders.TabIndex = 29;
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
            this.Title.Width = 88;
            // 
            // des
            // 
            this.des.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.des.DataPropertyName = "Description";
            this.des.HeaderText = "Reminder Description";
            this.des.Name = "des";
            this.des.ReadOnly = true;
            // 
            // ReminderDate
            // 
            this.ReminderDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ReminderDate.DataPropertyName = "ReminderDate";
            this.ReminderDate.HeaderText = "Reminder Date";
            this.ReminderDate.Name = "ReminderDate";
            this.ReminderDate.ReadOnly = true;
            this.ReminderDate.Width = 88;
            // 
            // panelcard1
            // 
            this.panelcard1.BackColor = System.Drawing.Color.Transparent;
            this.panelcard1.Controls.Add(this.lbltags1);
            this.panelcard1.Controls.Add(this.lblcreatedate1);
            this.panelcard1.Controls.Add(this.txtcontent1);
            this.panelcard1.Controls.Add(this.txttitle1);
            this.panelcard1.FillColor = System.Drawing.Color.White;
            this.panelcard1.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.panelcard1.Location = new System.Drawing.Point(354, 335);
            this.panelcard1.Name = "panelcard1";
            this.panelcard1.Size = new System.Drawing.Size(330, 300);
            this.panelcard1.TabIndex = 2;
            // 
            // lbltags1
            // 
            this.lbltags1.AutoSize = true;
            this.lbltags1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltags1.Location = new System.Drawing.Point(6, 275);
            this.lbltags1.Name = "lbltags1";
            this.lbltags1.Size = new System.Drawing.Size(39, 16);
            this.lbltags1.TabIndex = 20;
            this.lbltags1.Text = "Tags";
            // 
            // lblcreatedate1
            // 
            this.lblcreatedate1.AutoSize = true;
            this.lblcreatedate1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcreatedate1.Location = new System.Drawing.Point(229, 275);
            this.lblcreatedate1.Name = "lblcreatedate1";
            this.lblcreatedate1.Size = new System.Drawing.Size(98, 17);
            this.lblcreatedate1.TabIndex = 18;
            this.lblcreatedate1.Text = "01.01.2026";
            // 
            // txtcontent1
            // 
            this.txtcontent1.BackColor = System.Drawing.Color.Transparent;
            this.txtcontent1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontent1.DefaultText = "";
            this.txtcontent1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcontent1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcontent1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontent1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontent1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontent1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcontent1.ForeColor = System.Drawing.Color.Black;
            this.txtcontent1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontent1.Location = new System.Drawing.Point(6, 44);
            this.txtcontent1.Multiline = true;
            this.txtcontent1.Name = "txtcontent1";
            this.txtcontent1.PlaceholderText = "";
            this.txtcontent1.ReadOnly = true;
            this.txtcontent1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcontent1.SelectedText = "";
            this.txtcontent1.Size = new System.Drawing.Size(321, 228);
            this.txtcontent1.TabIndex = 17;
            // 
            // txttitle1
            // 
            this.txttitle1.BackColor = System.Drawing.Color.Transparent;
            this.txttitle1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttitle1.DefaultText = "";
            this.txttitle1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttitle1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttitle1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttitle1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttitle1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttitle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttitle1.ForeColor = System.Drawing.Color.Black;
            this.txttitle1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttitle1.Location = new System.Drawing.Point(6, 14);
            this.txttitle1.Name = "txttitle1";
            this.txttitle1.PlaceholderText = "";
            this.txttitle1.ReadOnly = true;
            this.txttitle1.SelectedText = "";
            this.txttitle1.Size = new System.Drawing.Size(321, 25);
            this.txttitle1.TabIndex = 16;
            this.txttitle1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelcard
            // 
            this.panelcard.BackColor = System.Drawing.Color.Transparent;
            this.panelcard.Controls.Add(this.lbltags);
            this.panelcard.Controls.Add(this.lblcreatedate);
            this.panelcard.Controls.Add(this.txtcontent);
            this.panelcard.Controls.Add(this.txttitle);
            this.panelcard.FillColor = System.Drawing.Color.White;
            this.panelcard.Font = new System.Drawing.Font("Courier New", 15.75F);
            this.panelcard.Location = new System.Drawing.Point(18, 335);
            this.panelcard.Name = "panelcard";
            this.panelcard.Size = new System.Drawing.Size(330, 300);
            this.panelcard.TabIndex = 0;
            // 
            // lbltags
            // 
            this.lbltags.AutoSize = true;
            this.lbltags.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltags.Location = new System.Drawing.Point(6, 275);
            this.lbltags.Name = "lbltags";
            this.lbltags.Size = new System.Drawing.Size(39, 16);
            this.lbltags.TabIndex = 19;
            this.lbltags.Text = "Tags";
            // 
            // lblcreatedate
            // 
            this.lblcreatedate.AutoSize = true;
            this.lblcreatedate.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblcreatedate.Location = new System.Drawing.Point(226, 275);
            this.lblcreatedate.Name = "lblcreatedate";
            this.lblcreatedate.Size = new System.Drawing.Size(98, 17);
            this.lblcreatedate.TabIndex = 18;
            this.lblcreatedate.Text = "01.01.2026";
            // 
            // txtcontent
            // 
            this.txtcontent.BackColor = System.Drawing.Color.Transparent;
            this.txtcontent.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtcontent.DefaultText = "";
            this.txtcontent.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtcontent.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtcontent.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontent.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtcontent.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtcontent.ForeColor = System.Drawing.Color.Black;
            this.txtcontent.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtcontent.Location = new System.Drawing.Point(6, 41);
            this.txtcontent.Multiline = true;
            this.txtcontent.Name = "txtcontent";
            this.txtcontent.PlaceholderText = "";
            this.txtcontent.ReadOnly = true;
            this.txtcontent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtcontent.SelectedText = "";
            this.txtcontent.Size = new System.Drawing.Size(318, 231);
            this.txtcontent.TabIndex = 17;
            // 
            // txttitle
            // 
            this.txttitle.BackColor = System.Drawing.Color.Transparent;
            this.txttitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txttitle.DefaultText = "";
            this.txttitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txttitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txttitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txttitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txttitle.ForeColor = System.Drawing.Color.Black;
            this.txttitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txttitle.Location = new System.Drawing.Point(6, 13);
            this.txttitle.Name = "txttitle";
            this.txttitle.PlaceholderText = "";
            this.txttitle.ReadOnly = true;
            this.txttitle.SelectedText = "";
            this.txttitle.Size = new System.Drawing.Size(318, 23);
            this.txttitle.TabIndex = 16;
            this.txttitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblformname
            // 
            this.lblformname.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblformname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.lblformname.Location = new System.Drawing.Point(20, 17);
            this.lblformname.Name = "lblformname";
            this.lblformname.Size = new System.Drawing.Size(200, 35);
            this.lblformname.TabIndex = 4;
            this.lblformname.Text = "Welcome";
            this.lblformname.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbltime
            // 
            this.lbltime.BackColor = System.Drawing.Color.Transparent;
            this.lbltime.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbltime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(102)))), ((int)(((byte)(177)))));
            this.lbltime.Location = new System.Drawing.Point(915, 22);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(121, 35);
            this.lbltime.TabIndex = 5;
            this.lbltime.Text = "00:00:00";
            this.lbltime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateToolStripMenuItem,
            this.showNotesToolStripMenuItem,
            this.editNotesToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(163, 92);
            // 
            // CreateToolStripMenuItem
            // 
            this.CreateToolStripMenuItem.Image = global::NotesApp.Properties.Resources.createnote_black;
            this.CreateToolStripMenuItem.Name = "CreateToolStripMenuItem";
            this.CreateToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.CreateToolStripMenuItem.Text = "Create Note";
            this.CreateToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // showNotesToolStripMenuItem
            // 
            this.showNotesToolStripMenuItem.Image = global::NotesApp.Properties.Resources.shownotes_black;
            this.showNotesToolStripMenuItem.Name = "showNotesToolStripMenuItem";
            this.showNotesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.showNotesToolStripMenuItem.Text = "Show Notes";
            this.showNotesToolStripMenuItem.Click += new System.EventHandler(this.showNotesToolStripMenuItem_Click);
            // 
            // editNotesToolStripMenuItem
            // 
            this.editNotesToolStripMenuItem.Image = global::NotesApp.Properties.Resources.editnotes_black;
            this.editNotesToolStripMenuItem.Name = "editNotesToolStripMenuItem";
            this.editNotesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editNotesToolStripMenuItem.Text = "Edit Notes";
            this.editNotesToolStripMenuItem.Click += new System.EventHandler(this.editNotesToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("exitToolStripMenuItem1.Image")));
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Home_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 750);
            this.Controls.Add(this.lbltime);
            this.Controls.Add(this.lblformname);
            this.Controls.Add(this.PanelForm);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.lbldate);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Home_Page";
            this.Resizable = false;
            this.Text = "Home Page";
            this.Load += new System.EventHandler(this.Home_Page_Load);
            this.Shown += new System.EventHandler(this.Home_Page_Shown);
            this.PanelMenu.ResumeLayout(false);
            this.PanelForm.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReminders)).EndInit();
            this.panelcard1.ResumeLayout(false);
            this.panelcard1.PerformLayout();
            this.panelcard.ResumeLayout(false);
            this.panelcard.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel PanelMenu;
        private Guna.UI2.WinForms.Guna2Button btnmenu;
        private System.Windows.Forms.Label lbldate;
        private Guna.UI2.WinForms.Guna2Button btnsupport;
        private System.Windows.Forms.Timer timerlabel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblformname;
        private Guna.UI2.WinForms.Guna2Button home;
        private Guna.UI2.WinForms.Guna2Button btncreatenote;
        private Guna.UI2.WinForms.Guna2Button btneditnotes;
        private Guna.UI2.WinForms.Guna2Button btnshownotes;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem CreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editNotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private Guna.UI2.WinForms.Guna2Panel panelcard;
        private Guna.UI2.WinForms.Guna2TextBox txtcontent;
        private Guna.UI2.WinForms.Guna2TextBox txttitle;
        private System.Windows.Forms.Label lblcreatedate;
        private Guna.UI2.WinForms.Guna2Panel panelcard1;
        private System.Windows.Forms.Label lblcreatedate1;
        private Guna.UI2.WinForms.Guna2TextBox txtcontent1;
        private Guna.UI2.WinForms.Guna2TextBox txttitle1;
        private System.Windows.Forms.Label lbltags1;
        private System.Windows.Forms.Label lbltags;
        public Guna.UI2.WinForms.Guna2Panel PanelForm;
        private Guna.UI2.WinForms.Guna2Button btncalender;
        private System.Windows.Forms.DataGridView dgvReminders;
        private FontAwesome.Sharp.IconButton deletereminder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn des;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReminderDate;
        private FontAwesome.Sharp.IconButton editreminder;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private FontAwesome.Sharp.IconButton magnifyingglass;
        private Guna.UI2.WinForms.Guna2Button WindySpeed;
        private Guna.UI2.WinForms.Guna2Button Humidity;
        private Guna.UI2.WinForms.Guna2Button Temperature;
        private Guna.UI2.WinForms.Guna2Button cityandcountry;
        private Guna.UI2.WinForms.Guna2TextBox SearchCity;
        private Guna.UI2.WinForms.Guna2Button WeatherCondution;
    }
}