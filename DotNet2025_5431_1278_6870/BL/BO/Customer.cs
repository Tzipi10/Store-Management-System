namespace BO
{
    public class Customer
    {
        public int Id { get; }
        public string Name { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }


        public Customer(int Id, string Name, string? Address, string? PhoneNumber)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
            this.PhoneNumber = PhoneNumber;
        }
    }
}
