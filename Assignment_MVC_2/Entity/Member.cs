using System.Collections.ObjectModel;

namespace Assignment_MVC_2.Entity
{
    public class Member:GymUser
    {
        public string ?photo { get; set; }
        public Collection<MemberShip> MemberShip { get; set; } = default!;
    }
}
