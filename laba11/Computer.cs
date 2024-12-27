using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba11
{
    internal class Computer
    {
        // Поля класса Computer
        public string ProcessorName { get; set; }
        public double ClockFrequency { get; set; } 
        public double RAM { get; set; } 

        public Computer(string processorName, double clockFrequency, double ram)
        {
            ProcessorName = processorName;
            ClockFrequency = clockFrequency;
            RAM = ram;
        }

        public virtual double Quality()
        {
            return (0.1 * ClockFrequency) + RAM;
        }
    }
}

