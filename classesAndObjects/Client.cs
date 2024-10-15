using System;

public class Client
    {
    public string Name { get; set; }
    public string SurName { get; set; }
    public string PersonalId { get; set; }
    public Account Account { get; set; }

    public Client( string name, string surName, string personalId, Account account )
        {
        Name = name;
        SurName = surName;
        PersonalId = personalId;
        Account = account;
        }
    }
