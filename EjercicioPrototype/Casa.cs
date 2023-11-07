using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioPrototype
{
    public class Casa :ICloneable
    {
        public int NumExt { get; set; }
        public string? Calle { get; set; }
        public int NumHabitaciones { get; set; }
        public string? Extras { get; set; }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
