﻿public class AdminBL
{
    public string Username { get; set; }
    public string Password { get; set; }

    public AdminBL(string username, string password)
    {
        Username = username;
        Password = password;
    }
}