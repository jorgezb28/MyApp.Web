namespace MyApp.UI.Models
{
    public class Member
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime JoinDate { get; set; }
        public MembershipPlan MembershipPlan { get; set; }
    }
}
