using Guna.UI2.WinForms;
using Microsoft.Win32.SafeHandles;
using Newtonsoft.Json.Linq;
using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
//using System.Data.SQLite;

namespace NotesApp
{
    public partial class Home_Page : MetroFramework.Forms.MetroForm  //Form
    {
        public Home_Page()
        {
            InitializeComponent();
        }
        bool menuOpen = true;

        //DateTime now = DateTime.Now;
        private void applywhitetheme(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.FromArgb(244, 246, 248); // #F4F6F8
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.None;

            dgv.DefaultCellStyle.BackColor = Color.White; // #FFFFFF
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(44, 44, 44);

            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(167, 199, 231); // #A7C7E7
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Alternatif Satırlar
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 241, 244); // #EEF1F4
        }
        DateTime bugun = DateTime.Now.Date;
        DateTime noww;

        private void getpastdate()
        {
            foreach (DataGridViewRow row in dgvReminders.Rows)
            {
                if (row.Cells["ReminderDate"].Value != null &&
                    DateTime.TryParse(row.Cells["ReminderDate"].Value.ToString(), out noww))
                {
                    if (noww < bugun)
                    {
                        row.Cells["Select"].Style.BackColor = Color.FromArgb(253, 226, 226);
                        row.Cells["Title"].Style.BackColor = Color.FromArgb(253, 226, 226);
                        row.Cells["des"].Style.BackColor = Color.FromArgb(253, 226, 226);
                        row.Cells["ReminderDate"].Style.BackColor = Color.FromArgb(253, 226, 226);
                    }
                    /*
                    if (noww == bugun)
                    {
                        //(230, 233, 245)
                        row.Cells["Select"].Style.BackColor = Color.FromArgb(0, 153, 255);
                        row.Cells["Title"].Style.BackColor = Color.FromArgb(0, 153, 255);
                        row.Cells["des"].Style.BackColor = Color.FromArgb(0, 153, 255);
                        row.Cells["ReminderDate"].Style.BackColor = Color.FromArgb(0, 153, 255);
                    }
                    */

                }
            }
        }
        private void Home_Page_Load(object sender, EventArgs e)
        {
            timerlabel.Start();
            toolTip1.SetToolTip(btnmenu, "Hide Menu");
            toolTip1.SetToolTip(home, "Home Panel");
            toolTip1.SetToolTip(btncreatenote, "Create Note");
            toolTip1.SetToolTip(btnshownotes, "Show Notes");
            toolTip1.SetToolTip(btneditnotes, "Edit Notes");
            toolTip1.SetToolTip(btnsupport, "Support");

            panelFormOriginalControls = PanelForm.Controls
        .Cast<Control>()
        .Select(c => c)
        .ToList();
            LoadLastTwoNotes();
            dgvReminders.DataSource = DatabaseHelper.GetRemindersForHome();
            getpastdate();
            getweather(Properties.Settings.Default.LastCity);
            dgvReminders.ClearSelection();
            dgvReminders.CurrentCell = null;
        }
        private void LoadLastTwoNotes()
        {
            DataTable dt = DatabaseHelper.GetLastTwoNotes();
            if (dt.Rows.Count > 0)
            {
                txttitle.Text = dt.Rows[0]["Title"].ToString();
                txtcontent.Text = dt.Rows[0]["Content"].ToString().Replace("\n", Environment.NewLine);
                lbltags.Text = dt.Rows[0]["Tags"].ToString().Replace("\n", Environment.NewLine);
                if (lbltags.Text == "")
                {
                    lbltags.Text = "No Tag";
                }
                DateTime createdDate = Convert.ToDateTime(dt.Rows[0]["CreatedDate"]);
                lblcreatedate.Text = createdDate.ToString("dd.MM.yyyy");
            }
            else
            {
                txtcontent.Text = "U should create more note";
            }
            if (dt.Rows.Count > 1)
            {
                txttitle1.Text = dt.Rows[1]["Title"].ToString();
                txtcontent1.Text = dt.Rows[1]["Content"].ToString().Replace("\n", Environment.NewLine);
                lbltags1.Text = dt.Rows[1]["Tags"].ToString().Replace("\n", Environment.NewLine);
                DateTime createdDate = Convert.ToDateTime(dt.Rows[1]["CreatedDate"]);
                lblcreatedate1.Text = createdDate.ToString("dd.MM.yyyy");
            }
            else
            {
                txtcontent1.Text = "U should create more note";
            }
        }

        void LoadForm(Form frm)
        {
            if (frm.Parent == PanelForm)
            {
                frm.BringToFront();
                return;
            }

            PanelForm.Controls.Clear();

            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            frm.AutoScaleMode = AutoScaleMode.None;

            PanelForm.Controls.Add(frm);
            frm.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (menuOpen)
            {

                menuOpen = false;
                PanelMenu.Width = 60;
                //btnmenu
                btnmenu.Image = Properties.Resources.Panelbüyüt_white;
                toolTip1.SetToolTip(btnmenu, "Open Menu");
                btnmenu.Text = "";
                btnmenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
                //home
                home.Text = "";
                home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
                //create note btncreatenote
                btncreatenote.Text = "";
                btncreatenote.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;

                //btnshownotes
                btnshownotes.Text = "";
                btnshownotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;

                //btneditnotes
                btneditnotes.Text = "";
                btneditnotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;

                //btnsupport
                btnsupport.Text = "";
                btnsupport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;

                //btncalender
                btncalender.Text = "";
                btncalender.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            }
            else
            {
                //lbldate.Text = now.ToString("HH:mm - dddd");//now.ToShortTimeString()
                menuOpen = true;
                PanelMenu.Width = 200;
                //btnmenu
                btnmenu.Image = Properties.Resources.Panelkücült_white;
                toolTip1.SetToolTip(btnmenu, "Hide Menu");
                btnmenu.Text = "Hide Menu";
                btnmenu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                //home
                home.Text = "Home";
                home.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
                //create note btncreatenote
                btncreatenote.Text = "Create Note";
                btncreatenote.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;

                //btnshownotes
                btnshownotes.Text = "Show Notes";
                btnshownotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;

                //btneditnotes
                btneditnotes.Text = "Edit Notes";
                btneditnotes.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;

                //btnsupport
                btnsupport.Text = "Support";
                btnsupport.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;

                //btncalender
                btncalender.Text = "Calender";
                btncalender.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            }
        }

        private void PanelForm_Paint(object sender, PaintEventArgs e)
        {
            Rectangle rect = PanelForm.ClientRectangle;

            using (LinearGradientBrush brush = new LinearGradientBrush(
                rect,
                Color.FromArgb(3, 74, 166),   // Başlangıç rengi //034aa6
                Color.FromArgb(254, 236, 232),  // Bitiş rengi //feece8
                LinearGradientMode.Horizontal     // Horizontal / Vertical
            ))
            {
                e.Graphics.FillRectangle(brush, rect);
            }
        }
        private List<Control> panelFormOriginalControls;

        private void home_Click(object sender, EventArgs e)
        {

            // Panelde açık form varsa kapat
            if (PanelForm.Controls.Count > 0)
            {
                Form activeForm = PanelForm.Controls[0] as Form;

                if (activeForm != null && !activeForm.IsDisposed)
                {
                    activeForm.Close();
                }
            }
            PanelForm.Controls.Clear();
            LoadLastTwoNotes();


            // ORİJİNAL KONTROLLERİ GERİ YÜKLE
            foreach (Control ctrl in panelFormOriginalControls)
            {
                PanelForm.Controls.Add(ctrl);
                ctrl.Visible = true;
            }

            lblformname.Text = "Home";
            dgvReminders.DataSource = DatabaseHelper.GetRemindersForHome();
            getpastdate();
            dgvReminders.ClearSelection();
            dgvReminders.CurrentCell = null;
        }
        private CreateNote createNoteForm;
        private void btncreatenote_Click(object sender, EventArgs e)
        {
            if (createNoteForm == null || createNoteForm.IsDisposed)
            {
                createNoteForm = new CreateNote();
            }
            LoadForm(createNoteForm);
            lblformname.Text = "Create Note";
        }
        private ShowNotes shownotesform;
        private void btnshownotes_Click(object sender, EventArgs e)
        {

            if (shownotesform == null || shownotesform.IsDisposed)
            {
                shownotesform = new ShowNotes();
            }
            shownotesform.dgvnotes.DataSource = DatabaseHelper.GetNotes();
            LoadForm(shownotesform);
            lblformname.Text = "Show Notes";


        }
        private void btneditnotes_Click(object sender, EventArgs e)
        {
            LoadForm(new editnotes());
            lblformname.Text = "Edit Notes";
        }

        private void timerlabel_Tick(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToLongDateString();
            lbltime.Text = DateTime.Now.ToLongTimeString();
        }

        private void labeldate_Click(object sender, EventArgs e)
        {
            lbldate.Text = DateTime.Now.ToString();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new CreateNote());
            lblformname.Text = "Create Note";
        }

        private void showNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new ShowNotes());
            lblformname.Text = "Show Notes";
        }

        private void editNotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadForm(new editnotes());
            lblformname.Text = "Edit Notes";
        }

        private void btnsupport_Click(object sender, EventArgs e)
        {
            support sup = new support();
            sup.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadForm(new CalendarForm());
            lblformname.Text = "Calender";
        }
        int reminderid;
        private void deletereminder_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReminders.Rows)
            {
                bool isChecked = Convert.ToBoolean(row.Cells["Select"].Value);
                if (isChecked)
                {
                    reminderid = Convert.ToInt32(row.Cells["Id"].Value);
                    DatabaseHelper.DeleteReminder(reminderid);
                }
            }
            dgvReminders.DataSource = DatabaseHelper.GetRemindersForHome();
        }
        private const string API_KEY = "17e759de158751221d9026a298808e97"; // API anahtarını buraya ekleyin
        private const string API_URL = "http://api.openweathermap.org/data/2.5/weather";
        int sehirId;
        public async Task getweather(string cityname)
        {
            if (string.IsNullOrEmpty(cityname))
            {
                MessageBox.Show("Please give a city name.");
                return;
            }

            using (HttpClient client = new HttpClient())
            {
                string apiUrl = $"{API_URL}?q={cityname}&appid={API_KEY}&units=metric";
                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responseContent = await response.Content.ReadAsStringAsync();

                    // JSON'u parse et
                    JObject hava = JObject.Parse(responseContent);

                    // Verileri çıkar
                    sehirId = (int)hava["id"];
                    string sehirAdi = hava["name"].ToString();
                    string ulke = hava["sys"]["country"].ToString();
                    double sicaklik = (double)hava["main"]["temp"];
                    double hissedilenSicaklik = (double)hava["main"]["feels_like"];
                    int nem = (int)hava["main"]["humidity"];
                    double ruzgarHizi = (double)hava["wind"]["speed"];
                    string durum = hava["weather"][0]["description"].ToString();

                    int sicaklikk = Convert.ToInt32(sicaklik);
                    Temperature.Text = sicaklikk.ToString() + "C°";
                    cityandcountry.Text = sehirAdi + ", " + ulke;
                    Humidity.Text = nem.ToString() + "\nHumidity";
                    WindySpeed.Text = ruzgarHizi.ToString() + "\nWindy Speed";
                    WeatherCondution.Text = durum;

                    if (response.IsSuccessStatusCode)
                    {
                        Properties.Settings.Default.LastCity = cityname;
                        Properties.Settings.Default.Save();
                    }
                }
                else
                {
                    MessageBox.Show("Hava durumu bilgisi alınamadı.");
                }
            }
        }
        string searchcityy;
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            searchcityy = SearchCity.Text;
            getweather(searchcityy);

        }
        private void cityandcountry_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://openweathermap.org/city/" + sehirId);
        }

        private void Home_Page_Shown(object sender, EventArgs e)
        {
        }

        private void editreminder_Click(object sender, EventArgs e)
        {

            LoadForm(new CalendarForm());
        }
    }
}

