using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;

namespace SQLiteRepository2008.Mapiranja
{
    public class BolestMapiranje : ClassMap<Bolest>
    {
        public BolestMapiranje()
        {
            //mapiranje primarnog kljuca
            Id(x => x.Id);

            Map(x => x.nazivBolesti);
            Map(x => x.simptomi);

            HasMany(x => x.imaDijagnozu)
                .Inverse()
                .Cascade.All();
        }
    }
}
