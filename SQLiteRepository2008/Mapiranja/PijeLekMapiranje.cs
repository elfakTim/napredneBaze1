using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;

namespace SQLiteRepository2008.Mapiranja
{
    public class PijeLekMapiranje : ClassMap<PijeLek>
    {
        public PijeLekMapiranje()
        {
            Id(x => x.Id);
            References(x => x.donor);

            References(x => x.lek);

            Map(x => x.duzinaTerapije);
        }
    }
}
