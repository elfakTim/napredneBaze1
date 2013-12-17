using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class Lek
    {
        public virtual int Id { get; protected set; }
        public virtual string nazivLeka { get; set; }
        public virtual string vrstaLeka { get; set; } // description
        public virtual IList<PijeLek> pijeLekove { get; set; }


        public Lek()
        {
            pijeLekove = new List<PijeLek>();
        }
    }
}
