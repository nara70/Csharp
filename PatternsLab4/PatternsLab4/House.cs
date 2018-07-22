using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsLab4
{
    class House
    {
        /// <summary>
        ///Шифр 
        /// </summary>
        public int ID;
        /// <summary>
        /// Тип проекта
        /// </summary>
        public string TypeOfProject;
        /// <summary>
        /// Число этажей
        /// </summary>
        public int AmountOfFloors;
        /// <summary>
        /// Число подъездов
        /// </summary>
        public int AmountOfEntrances;
        /// <summary>
        /// Дата постройки
        /// </summary>
        public string Date;
        public House(int id, string typeOfProject, int amountOfFloors, int amountOfEntrances, string date)
        {
            this.ID = id;
            this.TypeOfProject = typeOfProject;
            this.AmountOfFloors = amountOfFloors;
            this.AmountOfEntrances = amountOfEntrances;
            this.Date = date;
        }

        public override string ToString()
        {
            return "(id=" + this.ID.ToString() + "; Type of project=" + this.TypeOfProject+ 
                  "; Amount of floors=" + this.AmountOfFloors.ToString()+ "; Amount of entrances=" +
                  this.AmountOfEntrances.ToString() + "; Data=" + this.Date;
        }

    }
}
