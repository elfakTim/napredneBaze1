using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;


namespace SQLiteRepository2008.Mapiranja
{
    public class ZaposlenMapiranje : ClassMap<Zaposlen>
    {
        public ZaposlenMapiranje()
        {

            Id(x => x.Id);

            References(x=>x.adresaZaposlenog);
            References(x=>x.bankaKrvi);

            Map(x=>x.pol);
            Map(x=>x.ime);
            Map(x=>x.srednjeSlovo);
            Map(x=>x.prezime);
            Map(x=>x.specijalizacija);
            Map(x=>x.datumRodjenja);
        }
    }
}
