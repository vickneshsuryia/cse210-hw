using System;

class Program
{
    static void Main(string[] args)
    {
        Reception event1 = new Reception("Wedding", "Robby and Linda's Wedding", "November 02 2025", "2:00PM", new Address("201 Main Street", "Rexburg", "Idaho"), "robert24@gmail.com");
        event1.Display();

        Lecture event2 = new Lecture("PSYCH 201", "Introdcution to Psychology", "May 24 2024", "1:00PM", new Address("156 Central Street", "Rexburg", "Idaho"), "Brother Burton", 45);
        event2.Display();

        OutdoorGathering event3 = new OutdoorGathering("Barbeque", "Smith Park Neighborhood Barbeque", "June 11 2025", "3:00PM", new Address("394 Jump Street", "New York City", "New York"), "Sunny");
        event3.Display();
    }
}