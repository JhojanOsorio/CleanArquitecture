using Clean.Arquitecture.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Arquitecture.Domain
{
    public class AcademicProgram : Audit
    {
        public string? Name { get; set; } = default;

        public string? Code { get; set; } = default;

        public string?  AcademicDirector { get; set; }

        public bool? State { get; set; }

        public string? Schedule { get; set; }

        public string? Modality { get; set;}
        


    }
}
