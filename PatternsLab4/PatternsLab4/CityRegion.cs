using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab4
{
    class CityRegion
    {
        /// <summary>
        /// Шифр
        /// </summary>
        public int ID;
        /// <summary>
        /// Название
        /// </summary>
        public string Name;
        /// <summary>
        /// Адрес районной администрации
        /// </summary>
        public string Address;
        /// <summary>
        /// Количество жителей
        /// </summary>
        public int AmountOfInhabitats;
        /// <summary>
        /// Площадь
        /// </summary>
        public float Area;
        public CityRegion(int id, string name, string address, int amountOfInhabitats, float area)
        {
            this.ID = id;
            this.Name = name;
            this.Address = address;
            this.AmountOfInhabitats = amountOfInhabitats;
            this.Area = area;
        }
        public override string ToString()
        {
            return "(id=" + this.ID.ToString() + "; Name=" + this.Name +
                  "; Address=" + this.Address+ "; Amount of inhabitats=" +
                  this.AmountOfInhabitats.ToString() + "; Area=" + this.Area.ToString();
        }

    }
}
