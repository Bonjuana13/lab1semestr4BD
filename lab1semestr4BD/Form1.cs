using lab1semestr4BD.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1semestr4BD
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Связь с контекстом данных
        /// </summary>
        myDBcontext db = new myDBcontext();

        /// <summary>
        /// Инициализация формы
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            ShowMeAllHall();
            ShowMeAllExhibit();
            ShowMeAllStaff();
            ShowMeAllTrip();

            CloseAllTables();
        }



        /*Общее*/

        /// <summary>
        /// Вывести сотрудников
        /// </summary>
        public void ShowMeAllStaff()
        {
            db.Staffs.Load();
            DGVstaff.DataSource = db.Staffs.Local.ToBindingList();
            DGVstaff.Columns[0].HeaderText = "Айди";
            DGVstaff.Columns[1].HeaderText = "Фамилия";
            DGVstaff.Columns[2].HeaderText = "Имя";
            DGVstaff.Columns[3].HeaderText = "Должность";
        }

        /// <summary>
        /// Вывести залы
        /// </summary>
        public void ShowMeAllHall()
        {
            var halllist = (from hall in db.Halls
                          join staff in db.Staffs on hall.StaffStaffId equals staff.StaffId
                          select new { hall.HallId, hall.HallName, staff.StaffSecondName } ).ToList();
            /*db.Halls.Load();*/
            DGVhall.DataSource = halllist;
            DGVhall.Columns[0].HeaderText = "Айди";
            DGVhall.Columns[1].HeaderText = "Название зала";
            DGVhall.Columns[2].HeaderText = "Сотрудник";
        }

        /// <summary>
        /// Вывести экспонаты
        /// </summary>
        public void ShowMeAllExhibit()
        {
            var exhibitlist = (from ex in db.Exhibits
                            join hall in db.Halls on ex.HallHallId equals hall.HallId
                            select new { ex.ExhibitId, ex.ExhibitName, ex.ExhibitMaterial, hall.HallName }).ToList();
            /*db.Exhibits.Load();*/
            DGVexhibit.DataSource = exhibitlist;
            DGVexhibit.Columns[0].HeaderText = "Айди";
            DGVexhibit.Columns[1].HeaderText = "Экспонат";
            DGVexhibit.Columns[2].HeaderText = "Материал";
            DGVexhibit.Columns[3].HeaderText = "Зал";
        }

        /// <summary>
        /// Вывести выставки
        /// </summary>
        public void ShowMeAllTrip()
        {
            var triplist = (from trip in db.Trips
                               join hall in db.Halls on trip.HallHallId equals hall.HallId
                               select new { trip.TripId, trip.TripParticipantsCount, trip.TripData, hall.HallName }).ToList();
            /*db.Exhibits.Load();*/
            DGVtrip.DataSource = triplist;
            DGVtrip.Columns[0].HeaderText = "Айди";
            DGVtrip.Columns[1].HeaderText = "Кол-во людей";
            DGVtrip.Columns[2].HeaderText = "Дата проведения";
            DGVtrip.Columns[3].HeaderText = "Зал";
        }

        /// <summary>
        /// Закрытие всех панелей
        /// </summary>
        private void CloseAllTables()
        {
            PanelStaff.Visible = false;
            PanelHall.Visible = false;
            PanelExhibit.Visible = false;
            PanelTrip.Visible = false;
        }

        /// <summary>
        /// Убрать цвет с кнопок
        /// </summary>
        private void OffColor()
        {
            OpenStaff.BackColor = SystemColors.ActiveCaption;
            OpenHalls.BackColor = SystemColors.ActiveCaption;
            OpenExhibit.BackColor = SystemColors.ActiveCaption;
            OpenTrips.BackColor = SystemColors.ActiveCaption;
        }

        /// <summary>
        /// Открытие сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenStaff_Click(object sender, EventArgs e)
        {
            OffColor();
            OpenStaff.BackColor = Color.GreenYellow;
            CloseAllTables();
            PanelStaff.Visible = true;
            ShowMeAllStaff();
        }

        /// <summary>
        /// Открыте залов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenHalls_Click(object sender, EventArgs e)
        {
            OffColor();
            OpenHalls.BackColor = Color.GreenYellow;
            CloseAllTables();
            PanelHall.Visible = true;
            ShowMeAllHall();

            //Добавление в комбобокс
            var tocom1 = (from staff in db.Staffs
                          select new { staff.StaffId, staff.StaffSecondName }).ToList();
            comboBox1.DataSource = tocom1;
            comboBox1.DisplayMember = "StaffSecondName";
            comboBox1.ValueMember = "StaffId";
        }

        /// <summary>
        /// Открытие экспонатов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenExhibit_Click(object sender, EventArgs e)
        {
            OffColor();
            OpenExhibit.BackColor = Color.GreenYellow;
            CloseAllTables();
            PanelExhibit.Visible = true;
            ShowMeAllExhibit();

            //Добавление в комбобокс
            var tocom2 = (from hall in db.Halls
                          select new { hall.HallId, hall.HallName }).ToList();
            comboBox2.DataSource = tocom2;
            comboBox2.DisplayMember = "HallName";
            comboBox2.ValueMember = "HallId";
        }

        /// <summary>
        /// Открытие выставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTrips_Click(object sender, EventArgs e)
        {
            OffColor();
            OpenTrips.BackColor = Color.GreenYellow;
            CloseAllTables();
            PanelTrip.Visible = true;
            ShowMeAllTrip();

            //Добавление в комбобокс
            var tocom3 = (from hall in db.Halls
                          select new { hall.HallId, hall.HallName }).ToList();
            comboBox3.DataSource = tocom3;
            comboBox3.DisplayMember = "HallName";
            comboBox3.ValueMember = "HallId";
        }



        /*СОТРУДНИКИ*/

        /// <summary>
        /// Очистка сотрудников
        /// </summary>
        private void CleanStaff()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        /// <summary>
        /// Добавление сотрудника в Staff
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddStaff_But_Click(object sender, EventArgs e)
        {
            try
            {
                Staff staff = new Staff { StaffSecondName = textBox1.Text, StaffFirstName = textBox2.Text, StaffVacancy = textBox3.Text };
                db.Staffs.Add(staff);
                db.SaveChanges();
                CleanStaff();
                ShowMeAllStaff();
                MessageBox.Show("Запись добавлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Изменение сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeStaff_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Staffs.Find(DGVstaff[0, DGVstaff.CurrentRow.Index].Value);
                currentrow.StaffSecondName = textBox1.Text;
                currentrow.StaffFirstName = textBox2.Text;
                currentrow.StaffVacancy = textBox3.Text;
                db.SaveChanges();
                CleanStaff();
                DGVstaff.Refresh();
                /*ShowMeAllStaff();*/
                MessageBox.Show("Запись обновлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteStaff_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Staffs.Find(DGVstaff[0, DGVstaff.CurrentRow.Index].Value);
                db.Staffs.Remove(currentrow);
                db.SaveChanges();
                ShowMeAllStaff();
                MessageBox.Show("Запись удалена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }



        /*ЗАЛЫ*/

        /// <summary>
        /// Очистка залов
        /// </summary>
        private void CleanHall()
        {
            textBox6.Text = "";
        }

        /// <summary>
        /// Добавить залы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddHall_But_Click(object sender, EventArgs e)
        {
            try
            {
                Hall hall = new Hall { HallName = textBox6.Text, StaffStaffId = Convert.ToInt32(comboBox1.SelectedValue) };
                db.Halls.Add(hall);
                db.SaveChanges();
                CleanHall();
                ShowMeAllHall();
                MessageBox.Show("Запись добавлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Изменение зала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeHall_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Halls.Find(DGVhall[0, DGVhall.CurrentRow.Index].Value);
                currentrow.HallName = textBox6.Text;
                currentrow.StaffStaffId = Convert.ToInt32(comboBox1.SelectedValue);
                db.SaveChanges();
                CleanHall();
                DGVhall.Refresh();
                ShowMeAllHall();
                MessageBox.Show("Запись обновлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление зала
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteHall_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Halls.Find(DGVhall[0, DGVhall.CurrentRow.Index].Value);
                db.Halls.Remove(currentrow);
                db.SaveChanges();
                ShowMeAllHall();
                MessageBox.Show("Запись удалена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }



        /*Экспонаты*/
        /// <summary>
        /// Очистка экспонатов
        /// </summary>
        private void CleanExhibit()
        {
            textBox4.Text = "";
            textBox5.Text = "";
        }

        /// <summary>
        /// Добавить экспонат
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddExhibit_But_Click(object sender, EventArgs e)
        {
            try
            {
                Exhibit exhibit = new Exhibit { ExhibitName = textBox4.Text, ExhibitMaterial = textBox5.Text, HallHallId = Convert.ToInt32(comboBox2.SelectedValue) };
                db.Exhibits.Add(exhibit);
                db.SaveChanges();
                CleanExhibit();
                ShowMeAllExhibit();
                MessageBox.Show("Запись добавлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Изменение экспоната
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeExhibit_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Exhibits.Find(DGVexhibit[0, DGVexhibit.CurrentRow.Index].Value);
                currentrow.ExhibitName = textBox4.Text;
                currentrow.ExhibitMaterial = textBox5.Text;
                currentrow.HallHallId = Convert.ToInt32(comboBox2.SelectedValue);
                db.SaveChanges();
                CleanExhibit();
                DGVexhibit.Refresh();
                ShowMeAllExhibit();
                MessageBox.Show("Запись обновлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление экспоната
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteExhibit_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Exhibits.Find(DGVexhibit[0, DGVexhibit.CurrentRow.Index].Value);
                db.Exhibits.Remove(currentrow);
                db.SaveChanges();
                ShowMeAllExhibit();
                MessageBox.Show("Запись удалена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }




        /*Выставки*/
        /// <summary>
        /// Очистка выставок
        /// </summary>
        private void CleanTrip()
        {
            textBox7.Text = "";
            textBox8.Text = "";
        }

        /// <summary>
        /// Добавление выставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrip_But_Click(object sender, EventArgs e)
        {
            try
            {
                Trip trip = new Trip { TripParticipantsCount = Convert.ToInt32(textBox7.Text), TripData = Convert.ToDateTime(textBox8.Text), HallHallId = Convert.ToInt32(comboBox3.SelectedValue) };
                db.Trips.Add(trip);
                db.SaveChanges();
                CleanTrip();
                ShowMeAllTrip();
                MessageBox.Show("Запись добавлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Изменение выставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChangeTrip_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Trips.Find(DGVtrip[0, DGVtrip.CurrentRow.Index].Value);
                currentrow.TripParticipantsCount = Convert.ToInt32(textBox7.Text);
                currentrow.TripData = Convert.ToDateTime(textBox8.Text);
                currentrow.HallHallId = Convert.ToInt32(comboBox3.SelectedValue);
                db.SaveChanges();
                CleanTrip();
                DGVtrip.Refresh();
                ShowMeAllTrip();
                MessageBox.Show("Запись обновлена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }

        /// <summary>
        /// Удаление выставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DeleteTrip_But_Click(object sender, EventArgs e)
        {
            try
            {
                var currentrow = db.Trips.Find(DGVtrip[0, DGVtrip.CurrentRow.Index].Value);
                db.Trips.Remove(currentrow);
                db.SaveChanges();
                ShowMeAllTrip();
                MessageBox.Show("Запись удалена!", "Ура!!!", MessageBoxButtons.OK);
            }
            catch
            {
                MessageBox.Show("Проблемы с подключением или заполненными данными.", "Увы", MessageBoxButtons.OK);
            }
        }
    }
}
