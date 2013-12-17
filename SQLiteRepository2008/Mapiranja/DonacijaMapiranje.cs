using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;

namespace SQLiteRepository2008.Mapiranja
{
    public class DonacijaMapiranje : ClassMap<Donacija>
    {
        public DonacijaMapiranje()
        {
            //mapiranje primarnog kljuca
            Id(x => x.Id);

            References(x => x.donor);
            Map(x => x.datumDoniranja);
            Map(x => x.detalji);
        }
    }
}
