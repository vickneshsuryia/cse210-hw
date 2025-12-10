using System;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {   
        Order order1 = new Order(new Customer("Suryia", new Address("Jalan Stephen Yong", "Kuching", "Sarawak", "Malaysia")));
        order1.AppendProducts(new Product("Beads", "003", 3.15f, 10));
        order1.AppendProducts(new Product("Remote", "032", 15f, 2));
        order1.Display();

        Order order2 = new Order(new Customer("Johnson", new Address("Main Street", "Rexburg", "Idaho", "USA")));
        order2.AppendProducts(new Product("Jesus Painting", "142", 200f, 1));
        order2.AppendProducts(new Product("Takis", "864", 2.2f, 5));
        order2.Display();
    }
}