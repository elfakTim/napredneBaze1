using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;

namespace SQLiteRepository2008.Mapiranja
{
    public class LekMapiranje : ClassMap<Lek>
    {
        public LekMapiranje()
        {
            Id(x => x.Id);

            Map(x => x.nazivLeka);
            Map(x => x.vrstaLeka);

            HasMany(x => x.pijeLekove)
               .Inverse()
               .Cascade.All();
        }
    }
}
