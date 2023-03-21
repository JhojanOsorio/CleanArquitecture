using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clean.Arquitecture.Domain
{
    public class Subjects
    {
        public string? Name { get; set; }

        public int? NumberCredits { get; set; } = default;

        public string? Semester { get; set; } = default;

        public string? Modality { get; set; } = default;

        public string? Worth { get; set; } = default;
        }
}
