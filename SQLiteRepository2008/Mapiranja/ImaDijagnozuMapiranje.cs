using System;
using System.Collections.Generic;
using FluentNHibernate.Mapping;
using SQLiteRepository2008.Entiteti;


namespace SQLiteRepository2008.Mapiranja
{
    public class ImaDijagnozuMapiranje : ClassMap<ImaDijagnozu>
    {
        public ImaDijagnozuMapiranje()
        {
            Id(x => x.Id);
            //mapiranje primarnog kljuca
            References(x => x.donor);
            References(x => x.bolest);

            Map(x => x.ozbiljnost);

        }
    }
}
