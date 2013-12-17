using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class Bolest
    {
        public virtual int Id { get; protected set; }
        public virtual string nazivBolesti { get; set; }
        public virtual string simptomi { get; set; } // description
        public virtual IList<ImaDijagnozu> imaDijagnozu { get; set; }

        public Bolest()
        {
            imaDijagnozu = new List<ImaDijagnozu>();
        }
    }
}
