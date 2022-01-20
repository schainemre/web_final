using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev.Models
{
    public class musteriler2
    {
        public virtual int Id { get; set; }
        public virtual int TCKimlik { get; set; }
        public virtual int TelNO { get; set; }
        public virtual musteriler1 MusteriId { get; set; }
    }

    public class musteriler2Map : ClassMapping<musteriler2>
    {
        public musteriler2Map()
        {
            Table("musteriler2");
            Id(x => x.Id, m => m.Generator(Generators.Native));
            Property(x => x.TCKimlik, c => c.Length(20));
            Property(x => x.TelNO, c => c.Length(20));
            ManyToOne(x => x.MusteriId);

        }
    }
}
