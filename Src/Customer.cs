namespace Tests
{
    public class Customer : EntityBase<Customer>
    {
        public Customer(string _firstName, string _lastName, Address _address)
        {
            FirstName = _firstName;
            LastName = _lastName;
            Address = _address;
        }
        public Customer()
        {

        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Customer p = (Customer)obj;
            return (Id == p.Id) && (FirstName == p.FirstName) && (LastName == p.LastName)
             && (Address.Equals(p.Address));
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ FirstName.GetHashCode() ^ LastName.GetHashCode() ^ Address.GetHashCode();
        }

    }

}