using NHibernate.Mapping.ByCode;
using NHibernate.Mapping.ByCode.Conformist;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Odev.Models
{
    [Serializable]
    public class musteriler1
    {
        public virtual int MusteriId { get; set; }
        public virtual string Ad { get; set; }
        public virtual string Soyad { get; set; }
        public virtual ICollection<Models.musteriler2> musteriler2 { get; set; } = new List<Models.musteriler2>();
    }

    public class musteriler1Map : ClassMapping<musteriler1>
    {
        public musteriler1Map()
        {
            Table("musteriler1");

            Id(x => x.MusteriId, m => m.Generator(Generators.Native));     
            Property(x => x.Ad, c => c.Length(20));
            Property(x => x.Soyad, c => c.Length(20));

            Set(e => e.musteriler2,
                mapper =>
                {
                    mapper.Key(k => k.Column("musteriler1"));
                    mapper.Inverse(true);
                    mapper.Cascade(Cascade.All);
                },
                relation => relation.OneToMany(mapping => mapping.Class(typeof(musteriler2))));
        }
    }
        

        

        

}

