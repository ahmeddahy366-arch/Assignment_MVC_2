using Assignment_MVC_2.Enm;

namespace Assignment_MVC_2.Entity
{
    public class Trainer:GymUser
    {
        public Speciality speciality { get; set; } = default!;
        public ICollection<Session>sessions { get; set; }= default!;
    }
}
