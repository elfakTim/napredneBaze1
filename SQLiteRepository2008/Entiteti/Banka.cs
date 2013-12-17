using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class Banka
    {
        public virtual int Id { get; protected set; }
        public virtual string nazivBanke { get; set; }
        public virtual Adresa adresaBanke { get; set; }
        public virtual IList<Zaposlen> zaposljeni { get; set; }
        public virtual IList<Donor> donori { get; set; }

        public Banka()
        {
            zaposljeni = new List<Zaposlen>();
            donori = new List<Donor>();
        }

    }
}
