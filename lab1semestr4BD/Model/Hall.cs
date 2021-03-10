using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1semestr4BD.Model
{
    /// <summary>
    /// Залы
    /// </summary>
    public class Hall
    {
        public int HallId { get; set; }

        /// <summary>
        /// Название зала
        /// </summary>
        public string HallName { get; set; }

        /// <summary>
        /// Внешний ключ от сотрудников
        /// </summary>
        public int StaffStaffId { get; set; }
        public Staff Staff { get; set; }

        /// <summary>
        /// Связь 1 - зал, много - экспонатов
        /// </summary>
        public List<Exhibit> Exhibits { get; set; }

        /// <summary>
        /// Связь 1 - зал, много - выставки
        /// </summary>
        public List<Trip> Trips { get; set; }
    }
}
