using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace SQLiteRepository2008.Entiteti
{
    public class Zaposlen : KategorijaZaposljenog
    {
        public virtual int Id { get; protected set; }
        public virtual Adresa adresaZaposlenog { get; set; }
        public virtual Banka bankaKrvi { get; set; }

        //izostavili smo Staff Category
        public virtual char pol { get; set; }
        public virtual string ime { get; set; }
        public virtual string srednjeSlovo { get; set; }
        public virtual string prezime { get; set; }
        public virtual string specijalizacija { get; set; }
        public virtual DateTime datumRodjenja { get; set; }

        public Zaposlen()
        {
        }
    }
}
