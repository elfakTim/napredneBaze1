using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class Donor
    {
        public virtual int Id { get; protected set; }
        public virtual Adresa adresa { get; set; }
        public virtual Banka bankaKrvi { get; set; }
        public virtual Religija religija { get; set; }
        public virtual string brKartona { get; set; }
        public virtual char pol { get; set; }
        public virtual DateTime datumRodjenja { get; set; }
        public virtual string ime { get; set; }
        public virtual string srednjeSlovo { get; set; }
        public virtual string prezime { get; set; }
        public virtual string brTelefona { get; set; }

        public virtual IList<Donacija> donacije { get; set; }
        public virtual IList<PijeLek> pijeLekove { get; set; }
        public virtual IList<ImaDijagnozu> imaDijagnozu { get; set; }

        public Donor()
        {
            donacije = new List<Donacija>();
            pijeLekove = new List<PijeLek>();
            imaDijagnozu = new List<ImaDijagnozu>();
        }

    }
}
