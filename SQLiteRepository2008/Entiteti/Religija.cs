using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class Religija
    {
        public virtual int Id { get; protected set; }
        public virtual IList<Donor> donori { get; set; } //ili  preko for petlje da izdvojimo sve iz iste religije ili da napravimo posebne izvedene klase za svaku religiju zbog eg Roman, Catholic...
        public virtual string nazivReligije { get; set; }
        public virtual string opisReligije { get; set; }

        public Religija()
        {
            donori = new List<Donor>();
        }

    }
}
