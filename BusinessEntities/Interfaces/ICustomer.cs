namespace BusinessEntities.Interfaces
{
    public interface ICustomer : IBusinessEntity
    {
        string Address1 { get; set; }
        string Address2 { get; set; }
        string Address3 { get; set; }
        string ContactName { get; set; }
        string ContactSurname { get; set; }
        string Email { get; set; }
        string Id { get; set; }
        string Name { get; set; }
        string Phone { get; set; }
    }
}