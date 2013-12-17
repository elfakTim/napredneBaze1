using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;

namespace SQLiteRepository2008.Mapiranja
{
    public class KategorijaZaposljenogMapiranje : ClassMap<KategorijaZaposljenog>
    {
        public KategorijaZaposljenogMapiranje()
        {
            Id(x => x.code);

            Map(x=> x.opisKategorije);
        }
    }
}
