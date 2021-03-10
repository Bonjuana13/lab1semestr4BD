using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1semestr4BD.Model
{
    /// <summary>
    /// Экспонаты
    /// </summary>
    public class Exhibit
    {
        public int ExhibitId { get; set; }

        /// <summary>
        /// Название экспоната
        /// </summary>
        public string ExhibitName { get; set; }

        /// <summary>
        /// Название материала
        /// </summary>
        public string ExhibitMaterial { get; set; }

        /// <summary>
        /// Внешний ключ от залов
        /// </summary>
        public int HallHallId { get; set; }
        public Hall Hall { get; set; }
    }
}
