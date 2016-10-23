using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class Mercedes : AbstractCar
    {
        public string description;
        public int price;

        public Mercedes(int n)
        {

        }

        public Mercedes()
        {
            Description = "E Class";
            Price = 68000;

            Putere = 131;
            Transmisie = "Automata";

            Consum = 8;
            Model = "Sport";

        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }

        public int Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        protected int putere;
        protected string transmisie;

        protected int Putere
        {
            get
            {
                return putere;
            }
            set
            {
                putere = value;
            }
        }

        protected string Transmisie
        {
            get
            {
                return transmisie;
            }
            set
            {
                transmisie = value;
            }
        }

        internal int consum;
        internal string model;

        internal int Consum
        {
            get
            {
                return consum;
            }
            set
            {
                consum = value;
            }
        }
        internal string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
    }
}
