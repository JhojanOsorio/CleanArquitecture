using Clean.Arquitecture.Domain.Common;

namespace Clean.Arquitecture.Domain
{
    public class User : Audit
    {
        public int DocumentType { get; set; }
        public string DocumentNumber { get; set; } = default!;
        public string Name { get; set; } = default!;
        public string SecondName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string SecondLastName { get; set; } = default!;
        public DateTime BirthDate { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Telephone { get; set; }
        public string? Email { get; set; }
        public string? Addres { get; set; }



    }
}
