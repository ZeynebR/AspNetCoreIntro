

using Esigned.Core.Entities.BaseEntities;

namespace Esigned.Core.Entities
{
    public class Position: BaseEntity
    {
        public string Name { get; set; } = null!;   
        public HashSet<Testimonial> Testimonials { get; set;}

        public Position() 
        { 
            Testimonials = new HashSet<Testimonial>();  
        }
    }
}
