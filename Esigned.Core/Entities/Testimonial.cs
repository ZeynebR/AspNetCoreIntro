
using Esigned.Core.Entities.BaseEntities;

namespace Esigned.Core.Entities
{
    public class Testimonial :BaseEntity
    {
        public string FullName { get; set; } = null!;
        public string Description { get; set; } = null!;
        public int PositionId { get; set; } 
        public Position Position { get; set; } = null!; 

    }
}
