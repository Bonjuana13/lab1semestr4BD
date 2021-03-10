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

            ShowMeAllHalls();
            ShowMeAllExhibit();
            ShowMeAllStaff();
            ShowMeAllTrip();

            PanelStaff.Visible = false;
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
        public void ShowMeAllHalls()
        {
            db.Halls.Load();
            /*DGVstaff.DataSource = db.Halls.Local.ToBindingList();*/
/*            DGVstaff.Columns[0].HeaderText = "Айди";
            DGVstaff.Columns[1].HeaderText = "Фамилия";
            DGVstaff.Columns[2].HeaderText = "Имя";
            DGVstaff.Columns[3].HeaderText = "Должность";*/
        }

        /// <summary>
        /// Вывести экспонаты
        /// </summary>
        public void ShowMeAllExhibit()
        {
            db.Exhibits.Load();
            /*DGVstaff.DataSource = db.Exhibits.Local.ToBindingList();*/
/*            DGVstaff.Columns[0].HeaderText = "Айди";
            DGVstaff.Columns[1].HeaderText = "Фамилия";
            DGVstaff.Columns[2].HeaderText = "Имя";
            DGVstaff.Columns[3].HeaderText = "Должность";*/
        }

        /// <summary>
        /// Вывести выставки
        /// </summary>
        public void ShowMeAllTrip()
        {
            db.Trips.Load();
            /*DGVstaff.DataSource = db.Trips.Local.ToBindingList();*/
/*            DGVstaff.Columns[0].HeaderText = "Айди";
            DGVstaff.Columns[1].HeaderText = "Фамилия";
            DGVstaff.Columns[2].HeaderText = "Имя";
            DGVstaff.Columns[3].HeaderText = "Должность";*/
        }

        private void CloseAllTables()
        {
            PanelStaff.Visible = false;

        }

        /// <summary>
        /// Открытие сотрудников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenStaff_Click(object sender, EventArgs e)
        {
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
            CloseAllTables();
            ShowMeAllHalls();
        }

        /// <summary>
        /// Открытие экспонатов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenExhibit_Click(object sender, EventArgs e)
        {
            CloseAllTables();
            ShowMeAllExhibit();
        }

        /// <summary>
        /// Открытие выставки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OpenTrips_Click(object sender, EventArgs e)
        {
            CloseAllTables();
            ShowMeAllTrip();
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



        /*Залы*/


    }
}
