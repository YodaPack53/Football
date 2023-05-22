using System.Net.NetworkInformation;
using System.Reflection.Metadata;
using System.Xml.Linq;

using System;
using System.Collections.Generic;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class FootballPlayer : Person
{
    public int Number { get; set; }
    public double Height { get; set; }
}

public class Goalkeeper : FootballPlayer { }

public class Defender : FootballPlayer { }

public class Midfielder : FootballPlayer { }

public class Striker : FootballPlayer { }

public class Coach : Person { }

public class Referee : Person { }

public class Team
{
    public Coach Coach { get; set; }
public List<FootballPlayer> Players { get; set; }
   
    public double AvrAge()
    {
    return Players.Average(player => player.Age);

}
}

public class Game
{
    public Team Team1 { get; set; }
    public Team Team2 { get; set; }
    public Referee Referee { get; set; }
    public List<Goal> Goals { get; set; }
    public string Result { get; set; }
    public Team Winner { get; set; }
}

public class Goal
{
    public int Minute { get; set; }
    public FootballPlayer Player { get; set; }
}

public class Program
{
    public static void Main(string[] args)
    {
        Goalkeeper player1 = new Goalkeeper { Name = "Йордан Цветков", Number = 3, Age = 23, Height = 181 };
        Defender player2 = new Defender { Name = "Цветан Борисов", Number = 2, Age = 26, Height = 174 };
        Midfielder player3 = new Midfielder { Name = "Магдален Магдаленов", Number = 9, Age = 24, Height = 187 };
        Striker player4 = new Striker { Name = "Димитър Маринов", Number = 4, Age = 25, Height = 175 };
        Coach coach = new Coach { Name = "Йовко Йорданов", Age = 53 };
        Team team = new Team { Coach = coach, Players = new List<FootballPlayer> { player1, player2, player3, player4 } };

        Referee referee = new Referee { Name = "Иво Янев", Age = 40 };
        List<Goal> goals = new List<Goal> { new Goal { Minute = 10, Player = player3 } };
        Game game = new Game { Team1 = team, Referee = referee, Goals = goals, Result = "3 - 2", Winner = team };
    }
}
