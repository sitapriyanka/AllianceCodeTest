namespace Tests
{
    public class Company : EntityBase<Company>
    {
        public Company(string _name, Address _address)
        {
            Name = _name;
            Address = _address;
        }

        public Company()
        {

        }
        public string Name { get; set; }
        public Address Address { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Company p = (Company)obj;
            return (Id == p.Id) && (Name == p.Name)
             && (Address.Equals(p.Address));
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode() ^ Name.GetHashCode() ^ Address.GetHashCode();

        }
    }
}


