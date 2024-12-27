using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    internal class Laptop
    {
        public Laptop(string v1, int v2, int v3, int v4)
        {
        }

        internal object Quality()
        {
            throw new NotImplementedException();
        }

        class Laptops : Computer
        {
            // Поле класса Laptop
            public double HDD { get; set; } // Объем винчестера в Гб

            // Конструктор
            public Laptops(string processorName, double clockFrequency, double ram, double hdd)
                : base(processorName, clockFrequency, ram)
            {
                HDD = hdd;
            }

            // Переопределяем метод для вычисления качества Qp
            public override double Quality()
            {
                return base.Quality() + (0.5 * HDD);
            }
        }

    }
}
