using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;

namespace SQLiteRepository2008.Mapiranja
{
    class AdresaMapiranje : ClassMap<Adresa>
    {
         AdresaMapiranje()
        {
            //mapiranje primarnog kljuca
            Id(x => x.Id);

            //mapiranje svojstava
            Map(x => x.brZgrade);
            Map(x => x.brUlice);
            Map(x => x.opstina);
            Map(x => x.grad);
            Map(x => x.postanskiKod);
            Map(x => x.drzava);

        }
    }
}
