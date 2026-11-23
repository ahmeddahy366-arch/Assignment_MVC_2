using Assignment_MVC_2.Enm;

namespace Assignment_MVC_2.Entity
{
    public class GymUser:BaseEntity
    {
        public string Name { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string Phone { get; set; } = default!;
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public Address Address { get; set; } = default!;

    }
}
