using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1semestr4BD.Model
{
    /// <summary>
    /// Сотрудники
    /// </summary>
    public class Staff
    {
        public int StaffId { get; set; }

        /// <summary>
        /// Фамилия
        /// </summary>
        public string StaffSecondName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        public string StaffFirstName { get; set; }

        /// <summary>
        /// Должность
        /// </summary>
        public string StaffVacancy { get; set; }

        /// <summary>
        /// Связь 1 - сотрудники, много - залы
        /// </summary>
        public List<Hall> Halls { get; set; }
    }
}
