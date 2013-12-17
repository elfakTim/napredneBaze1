using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SQLiteRepository2008.Entiteti
{
    public class Adresa
    {
        public virtual int Id { get; protected set; }
        /// <summary>
        /// Fali lista zaposljenih, lista donora i objekat banka??????????!!!!! Ne znamo da li treba!!!
        /// </summary>
        
        public virtual int brZgrade { get; set; }
        public virtual int brUlice { get; set; }
        public virtual string opstina { get; set; }
        public virtual string grad { get; set; }
        public virtual string postanskiKod { get; set; }
        public virtual string drzava { get; set; }

        public Adresa()
        {
        }

    }
}