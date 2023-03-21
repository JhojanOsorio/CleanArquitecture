using Clean.Arquitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Arquitecture.Domain
{
    public class Category : Audit
    {
        public int Name { get; set; } = default;

        public string? Description { get; set; }
    }
}
