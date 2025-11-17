using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaTecnicaLlamada.Domain.SeedWork
{
    public abstract class Entity
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        protected Entity()
        {
            CreateDate = DateTime.Now;
            UpdateDate = DateTime.Now;
        }

        public void SetUpdate()
        {
            UpdateDate = DateTime.Now;
        }
    }
}
