using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class PijeLek
    {
        public virtual int Id { get; protected set; }
        public virtual Donor donor { get; set; }
        public virtual Lek lek { get; set; }
        public virtual string duzinaTerapije { get; set; } // 1dan, 5dana, mesec dana

        public PijeLek()
        {

        }
    }


}
