namespace Core.Domain.Domain
{
    public class EmployeeInfo
    {
        public string Id { get; set; }
        public bool Receive { get; set; }
        public bool Stow { get; set; }
        public bool Pick { get; set; }
        public bool Pack { get; set; }
        public bool Ship { get; set; }

        public virtual ApplicationUser User { get; set; }
    }
}