using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;


namespace SQLiteRepository2008.Mapiranja
{
    public class ReligijaMapiranje : ClassMap<Religija>
    {
        public ReligijaMapiranje()
        {
            Id(x => x.Id);

            HasMany(x => x.donori)
                .Inverse()
                .Cascade.All();

            Map(x=>x.nazivReligije);
            Map(x=>x.opisReligije);
        }
    }
}
