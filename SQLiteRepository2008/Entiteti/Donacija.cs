using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class Donacija
    {
        public virtual int Id { get; protected set; }
        public virtual Donor donor { get; set; }
        public virtual DateTime datumDoniranja { get; set; }
        public virtual string detalji { get; set; }

        public Donacija()
        {

        }

    }
}
