using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MODEL.Entity
{
    public class CoreEntity
    {
        public int Id { get; set; }
        public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
    }
}