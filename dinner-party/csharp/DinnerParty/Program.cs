using System;
using System.Collections.Generic;
using System.Linq;

namespace DinnerParty
{
  class Program
  {
    static void Main(string[] args)
    {
      List<Guest> allGuest = AllGuest();
      List<Guest> TableOne = new List<Guest>();
      List<Guest> TableTwo = new List<Guest>();
      Table Table1 = new Table("Table 1", TableOne);
      Table Table2 = new Table("Table 2", TableTwo);

      // List<string> table1Occupations = new List<string>();
      IEnumerable<string> table1Occupations = from g in TableOne select g.Occupation;

      // foreach (Guest guest in allGuest)
      // {
      //   table1Occupations.Add(guest.Occupation);
      // }

      foreach (Guest guest in allGuest)
      {
        if (table1Occupations.Contains(guest.Occupation))
        {
          TableTwo.Add(guest);
        }
        else
        {
          TableOne.Add(guest);
        }
      }

      //display
      Display(Table1);
      Display(Table2);
    }

    static void Display(Table table)
    {
      Console.WriteLine(table.TableName);
      foreach (Guest guest in table.GuestsOfTable)
      {
        Console.WriteLine($"{ guest.Name} { guest.Occupation} { guest.Bio}");
      }
    }

    static List<Guest> AllGuest()
    {
      List<Guest> allGuest = new List<Guest>();
      Guest marilyn = new Guest
      {
        Name = "Marilyn Monroe",
        Occupation = "entertainer",
        Bio = "(1926 - 1962) American actress, singer, model",
      };
      allGuest.Add(marilyn);
      Guest abraham = new Guest
      {
        Name = "Abraham Lincoln",
        Occupation = "politician",
        Bio = "(1809 - 1865) US President during American civil war",
      };
      allGuest.Add(abraham);
      Guest martin = new Guest
      {
        Name = "Martin Luther King",
        Occupation = "activist",
        Bio = "(1929 - 1968)  American civil rights campaigner",
      };
      allGuest.Add(martin);
      Guest rosa = new Guest
      {
        Name = "Rosa Parks",
        Occupation = "activist",
        Bio = "(1913 - 2005)  American civil rights activist",
      };
      allGuest.Add(rosa);
      Guest alan = new Guest
      {
        Name = "Alan Turing",
        Occupation = "computer scientist",
        Bio =
      "(1912 - 1954) - British computing pioneer, Turing machine, algorithms, cryptology, computer architecture, saved the world",
      };
      allGuest.Add(alan);
      Guest admiral = new Guest
      {
        Name =
          "Admiral Grace Hopper (1906–1992) – developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds",
        Occupation = "computer scientist",
        Bio =
        "(1906–1992) - developed early compilers: FLOW-Matic, COBOL; worked on UNIVAC; gave speeches on computer history, where she gave out nano-seconds",
      };
      allGuest.Add(admiral);
      Guest indira = new Guest
      {
        Name = "Indira Gandhi",
        Occupation = "politician",
        Bio = "(1917 - 1984) Prime Minister of India 1966 - 1977",
      };
      allGuest.Add(indira);
      return allGuest;
    }

    public class Guest
    {
      public string Name { get; set; }
      public string Occupation { get; set; }
      public string Bio { get; set; }
    }

    public class Table
    {
      public Table(string tableName, List<Guest> guestsOfTable)
      {
        TableName = tableName;
        GuestsOfTable = guestsOfTable;
      }
      public List<Guest> GuestsOfTable { get; set; }
      public string TableName { get; set; }
    }
  }
}
