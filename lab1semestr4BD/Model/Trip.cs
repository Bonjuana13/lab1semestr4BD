using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1semestr4BD.Model
{
    /// <summary>
    /// Выставки
    /// </summary>
    public class Trip
    {
        public int TripId { get; set; }

        /// <summary>
        /// Количество участников
        /// </summary>
        public int TripParticipantsCount { get; set; }

        /// <summary>
        /// Дата экскурсии
        /// </summary>
        public DateTime TripData { get; set; }

        /// <summary>
        /// Внешний ключ от залов
        /// </summary>
        public int HallHallId { get; set; }
        public Hall Hall { get; set; }
    }
}
