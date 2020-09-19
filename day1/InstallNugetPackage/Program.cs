﻿using System;
using Newtonsoft.Json;

namespace InstallNugetPackage
{
    class Program
    {
        public class Account
{
    public string Name { get; set; }
    public string Email { get; set; }
    public DateTime DOB { get; set; }
}
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Account account = new Account
    {
        Name = "John Doe",
        Email = "john@nuget.org",
        DOB = new DateTime(1980, 2, 20, 0, 0, 0, DateTimeKind.Utc),
    };

    string json = JsonConvert.SerializeObject(account, Formatting.Indented);
    Console.WriteLine(json);

        }
    }
}
