using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;

namespace SQLiteRepository2008.Mapiranja
{
    public class BankaMapiranje : ClassMap<Banka>
    {
        public BankaMapiranje()
        {
            //mapiranje primarnog kljuca
            Id(x => x.Id);

            Map(x => x.nazivBanke);

            References(x => x.adresaBanke);

            HasMany(x => x.zaposljeni)
                .Inverse()
                .Cascade.All();
            
            HasMany(x => x.donori) 
                .Inverse()
                .Cascade.All();

        }
    }
}
