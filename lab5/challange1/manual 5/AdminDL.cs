using System.Collections.Generic;
using System.Linq;

public class AdminDL
{
    public static List<AdminBL> Admins = new List<AdminBL>();

    public static void AddAdmin(AdminBL admin)
    {
        Admins.Add(admin);
    }

    public static List<AdminBL> GetAdmins()
    {
        return Admins;
    }

    public static AdminBL FindAdmin(string username, string password)
    {
        return Admins.FirstOrDefault(a => a.Username == username && a.Password == password);
    }
}