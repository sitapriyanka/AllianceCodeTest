using System.Collections.Generic;
namespace Tests
{
    public class Address
    {
        public Address(string _address1, string _address2, string _city, string _postcode)
        {
            Address1 = _address1;
            Address2 = _address2;
            City = _city;
            PostCode = _postcode;
        }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string PostCode { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
                return false;

            Address p = (Address)obj;
            return (Address1 == p.Address1) && (Address2 == p.Address2)
             && (City == p.City) && (PostCode == p.PostCode);
        }

        public override int GetHashCode()
        {
            return Address1.GetHashCode() ^ Address2.GetHashCode() ^ City.GetHashCode()
             ^ PostCode.GetHashCode();
        }
    }
}
