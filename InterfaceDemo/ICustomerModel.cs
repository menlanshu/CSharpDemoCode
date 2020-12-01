namespace InterfaceDemo
{
    public interface ICustomerModel
    {
        string City { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string Phone { get; set; }
        string StreetAddress { get; set; }
    }
}