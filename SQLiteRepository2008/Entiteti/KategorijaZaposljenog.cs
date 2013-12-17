using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class KategorijaZaposljenog
    {
      
        public virtual int code { get; protected set; }
        public virtual string opisKategorije { get; set; } //eg Doctor, Nurse, Cleaner
    }
}
