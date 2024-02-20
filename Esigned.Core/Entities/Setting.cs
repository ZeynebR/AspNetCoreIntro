

using Esigned.Core.Entities.BaseEntities;

namespace Esigned.Core.Entities
{
    public class Setting : BaseEntity
    {
        public string AboutImage { get; set; } = null!;
        public string AboutTitle { get; set; } = null!;
        public string AboutDescription { get; set; } = null!;
        public int YearsOfBusiness { get; set; }
        public int Projects { get; set; }
        public int Satisfied { get; set; }
        public int Coffee { get; set; }
        public string Address { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string Email { get; set; } = null!;

    }
}