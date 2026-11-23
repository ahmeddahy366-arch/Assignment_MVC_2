using System.Collections.ObjectModel;

namespace Assignment_MVC_2.Entity
{
    public class Plan:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Description { get; set; } = default!;
        public int DurationDays { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; }
        public Collection<MemberShip> MemberShip { get; set; } = default!;

    }
}
