public class CustomerBL
{
    public string Username { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string Contact { get; set; }

    public CustomerBL(string username, string password, string email, string address, string contact)
    {
        Username = username;
        Password = password;
        Email = email;
        Address = address;
        Contact = contact;
    }
}