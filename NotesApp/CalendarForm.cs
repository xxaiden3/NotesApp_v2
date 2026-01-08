using NotesApp.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotesApp
{
    public partial class CalendarForm : Form
    {
        private DateTime _currentMonth = DateTime.Today;
        private readonly CultureInfo _tr = new CultureInfo("tr-TR");

        public CalendarForm()
        {
            InitializeComponent();

            // Eventleri koddan bağlamak istersen:
            btnPrev.Click += btnPrev_Click;
            btnNext.Click += btnNext_Click;

            // Panel resize olunca yeniden çizsin (opsiyonel ama güzel)
            pnlDays.Resize += (s, e) => DrawCalendar();
        }
        private Button _selectedButton;
        private DateTime? _selectedDate;
        private void ApplySoftGrayTheme(DataGridView dgv)
        {
            // Genel
            dgv.BackgroundColor = Color.FromArgb(244, 246, 248); // #F4F6F8
            dgv.BorderStyle = BorderStyle.None;


            // Header (Başlık)
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(221, 227, 234); // #DDE3EA
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(44, 44, 44);   // #2C2C2C
            //dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            //dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeight = 40;

            // Hücreler
            dgv.DefaultCellStyle.BackColor = Color.White; // #FFFFFF
            dgv.DefaultCellStyle.ForeColor = Color.FromArgb(44, 44, 44);
            //dgv.DefaultCellStyle.Font = new Font("Segoe UI", 9.5F, FontStyle.Regular);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(167, 199, 231); // #A7C7E7
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;

            // Alternatif Satırlar
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 241, 244); // #EEF1F4
        }

        private void CalendarForm_Load(object sender, EventArgs e)
        {

            toolTip1.SetToolTip(addreminder, "Add Reminder");
            toolTip1.SetToolTip(updatereminderr, "Update Reminder");
            toolTip1.SetToolTip(deletereminderr, "Delete Reminder");
            toolTip1.SetToolTip(btnNext, "Next Mounth");
            toolTip1.SetToolTip(btnPrev, "Previous Mounth");
            //ApplySoftGrayTheme(dgvReminders);
            DrawCalendar();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _currentMonth = _currentMonth.AddMonths(-1);
            DrawCalendar();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _currentMonth = _currentMonth.AddMonths(1);
            DrawCalendar();
        }

        private void DrawCalendar()
        {
            Button todayButton = null;


            pnlDays.SuspendLayout();
            pnlDays.Controls.Clear();

            // Başlık
            lblMonthYear.Text = _currentMonth.ToString("MMMM yyyy", _tr);

            // Ay bilgileri
            var firstDay = new DateTime(_currentMonth.Year, _currentMonth.Month, 1);
            int daysInMonth = DateTime.DaysInMonth(_currentMonth.Year, _currentMonth.Month);

            // Pazartesi başlangıç indexi (0=Mon ... 6=Sun)
            int startIndex = ((int)firstDay.DayOfWeek + 6) % 7;

            // Grid ölçüleri (42 hücre)
            int cols = 7, rows = 6;
            int cellW = Math.Max(40, (pnlDays.ClientSize.Width - (cols - 1) * 6) / cols);
            int cellH = Math.Max(40, (pnlDays.ClientSize.Height - (rows - 1) * 6) / rows);
            int gap = 6;

            int day = 1;

            for (int i = 0; i < 42; i++)
            {
                int r = i / cols;
                int c = i % cols;

                var btn = new Button();
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Font = new Font("Courier New", 10, FontStyle.Regular);
                btn.Width = cellW;
                btn.Height = cellH;
                btn.Left = c * (cellW + gap);
                btn.Top = r * (cellH + gap);

                // default stil
                btn.BackColor = Color.FromArgb(234, 239, 243);

                btn.ForeColor = Color.Black;

                if (i >= startIndex && day <= daysInMonth)
                {
                    btn.Text = day.ToString();

                    DateTime thisDate = new DateTime(_currentMonth.Year, _currentMonth.Month, day);
                    if (thisDate.Date == DateTime.Today)
                    {
                        btn.BackColor = Color.FromArgb(0, 122, 204);
                        todayButton = btn; // 👈 BUGÜNÜN BUTONUNU YAKALA
                    }

                    //// Bugün vurgusu
                    //if (thisDate.Date == DateTime.Today)
                    //    btn.BackColor = Color.FromArgb(0, 122, 204);

                    // Tıklanınca seç
                    btn.Click += (s, e) => OnDateSelected(thisDate, btn);

                    btn.MouseEnter += (s, e) =>
                    {
                        if (btn != _selectedButton)
                            btn.BackColor = Color.FromArgb(239, 247, 249);
                    };

                    btn.MouseLeave += (s, e) =>
                    {
                        if (btn != _selectedButton && btn.Enabled)
                            btn.BackColor = Color.FromArgb(234, 239, 243);
                    };

                    day++;
                }
                else
                {
                    // Boş hücreler
                    btn.Enabled = false;
                    btn.Text = "";
                    btn.BackColor = Color.FromArgb(208, 208, 208);
                }

                pnlDays.Controls.Add(btn);
            }
            if (todayButton != null)
            {
                OnDateSelected(DateTime.Today, todayButton);
            }


            pnlDays.ResumeLayout();
        }

        private void OnDateSelected(DateTime date, Button btn)
        {
            // Eski seçimi temizle
            if (_selectedButton != null)
                _selectedButton.BackColor = Color.FromArgb(234, 239, 243);

            // Yeni seçimi boya
            btn.BackColor = Color.FromArgb(0, 153, 255);
            // seçili gün
            _selectedButton = btn;
            _selectedDate = date;
            lblSelectedDate.Text = date.ToString("dd.MM.yyyy");

            LoadRemindersByDate(date);
        }

        private void SaveIB_Click(object sender, EventArgs e)
        {
            if (_selectedDate == null)
            {
                MessageBox.Show("Please select a day in calendar.");
                return;
            }

            if (checkBox1.Checked == true)
            {
                if (!string.IsNullOrEmpty(remindertxt.Text))
                {
                    DatabaseHelper.SaveReminder(
                        lblSelectedDate.Text.Trim(),
                        remindertxt.Text.Trim(),
                        _selectedDate.Value);
                }
                else
                {
                    MessageBox.Show("Description can not be empty");
                    return;
                }
            }
            else
            {
                if (string.IsNullOrEmpty(remindertitle.Text))
                {
                    MessageBox.Show("Title can not be empty");
                    return;
                }
                DatabaseHelper.SaveReminder(
                remindertitle.Text.Trim(),
                remindertxt.Text.Trim(),
                _selectedDate.Value);
            }


            //if (checkBox1.Checked == true)
            //{


            //}
            //if (String.IsNullOrEmpty(remindertitle.Text) && string.IsNullOrEmpty(txtupdatereminderdes.Text))
            //{

            //    MessageBox.Show("Title or desciption can not be empty!");
            //    return;
            //}
            //DatabaseHelper.SaveReminder(
            //     remindertitle.Text.Trim(),
            //     remindertxt.Text.Trim(),
            //     _selectedDate.Value
            // );

            //MessageBox.Show("Reminder saved ✔");

            remindertitle.Clear();
            remindertxt.Clear();

            LoadRemindersByDate(_selectedDate.Value);
        }
        void LoadRemindersByDate(DateTime date)
        {
            dgvReminders.DataSource = DatabaseHelper.GetRemindersByDate(date);
        }

        private void addreminder_Click_1(object sender, EventArgs e)
        {
            if (_selectedDate == null)
            {
                MessageBox.Show("Please select a day in calendar.");
                return;
            }
            if (updatereminder.Visible == true)
            {
                updatereminder.Visible = false;
            }
            //updatereminder.Visible = false;
            updatereminderr.BackColor = Color.White;
            addreminder.BackColor = Color.FromArgb(0, 153, 255);
            if (paneladdreminder.Visible == false)
            {
                paneladdreminder.Visible = true;
            }

        }
        int reminderid;
        string updatetitle;
        string updatedes;
        private void saveupdatereminder_Click(object sender, EventArgs e)
        {
            string utitle = txtupdateremindertitle.Text;
            string udes = txtupdatereminderdes.Text;
            DatabaseHelper.UpdateReminder(reminderid, utitle, udes);

            LoadRemindersByDate(_selectedDate.Value);
            MessageBox.Show("Reminder Updated ✔");


        }

        private void deletereminderr_Click(object sender, EventArgs e)
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
            LoadRemindersByDate(_selectedDate.Value);
            addreminder.BackColor = Color.White;
            updatereminderr.BackColor = Color.White;
            if (paneladdreminder.Visible == true || updatereminder.Visible == true)
            {
                paneladdreminder.Visible = false;
                updatereminder.Visible = false;
            }
        }

        int checkedCount = 0;
        private void updatereminderr_Click(object sender, EventArgs e)
        {
            checkedCount = 0;
            dgvReminders.EndEdit();
            dgvReminders.EndEdit();
            DataGridViewRow selectedRow = null;
            foreach (DataGridViewRow row in dgvReminders.Rows)
            {
                if (Convert.ToBoolean(row.Cells["Select"].Value))
                {
                    checkedCount++;
                    selectedRow = row;
                    reminderid = Convert.ToInt32(row.Cells["Id"].Value);
                    updatetitle = row.Cells["Title"].Value.ToString();
                    updatedes = row.Cells["des"].Value.ToString();
                }
            }
            if (checkedCount == 0)
            {
                MessageBox.Show(
                    "Please select a reminder!",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
                return;
            }

            if (checkedCount > 1)
            {
                MessageBox.Show(
                    "U can chose only one reminder!",
                    "Uyarı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }
            paneladdreminder.Visible = false;
            updatereminderr.BackColor = Color.FromArgb(0, 153, 255);
            addreminder.BackColor = Color.White;
            txtupdateremindertitle.Text = updatetitle;
            txtupdatereminderdes.Text = updatedes;
            //dgvReminders.DataSource = DatabaseHelper.GetREmindersForUpdate(_selectedDate);
            if (updatereminder.Visible == false)
            {
                updatereminder.Visible = true;
            }
        }
        private void dgvReminders_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void paneladdreminder_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                remindertitle.Enabled = false;
            }
            else
            {
                remindertitle.Enabled = true;
            }
        }
    }
}
