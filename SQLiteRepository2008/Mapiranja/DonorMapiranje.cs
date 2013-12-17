using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;

namespace SQLiteRepository2008.Mapiranja
{
    public class DonorMapiranje : ClassMap<Donor>
    {
        public DonorMapiranje()
        {
            //mapiranje primarnog kljuca
            Id(x => x.Id);

            References(x => x.adresa);
            References(x => x.bankaKrvi);
            References(x => x.religija);
            Map(x => x.brKartona);
            Map(x => x.pol);
            Map(x => x.datumRodjenja);
            Map(x => x.ime);
            Map(x => x.srednjeSlovo);
            Map(x => x.prezime);
            Map(x => x.brTelefona);

            HasMany(x => x.donacije)
                .Inverse()
                .Cascade.All();

            HasMany(x => x.pijeLekove)
                .Inverse()
                .Cascade.All();

            HasMany(x => x.imaDijagnozu)
                .Inverse()
                .Cascade.All();
        }
    }
}
