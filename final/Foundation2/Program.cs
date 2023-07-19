using System;

class Program
{
    static void Main(string[] args)
    {
        
        Product item1 = new Product("Tacos", "32", 32, 5);
        Product item2 = new Product("Green Beans", "42", 5, 10);
        Product item3 = new Product("Computer", "55", 450, 1);
        Address addrestest = new Address("3246 w 8512 s", "West jordan", "utah", "USA");
        Customer customer = new Customer("Aaron Lopez", addrestest);
        Order orderOne = new Order(customer);
        orderOne.GetProduct().Add(item1);
        orderOne.GetProduct().Add(item2);
        orderOne.GetProduct().Add(item3);
        orderOne.PackingLabel();
       orderOne.ShippingLabel();


       Product item1_1 = new Product("Apple Mouse", "112", 50, 2);
       Product item1_2 = new Product("Bowling Balls", "85", 12, 8);
       Product item1_3 = new Product("String Cheese", "25", 2, 30);
       Address address1 = new Address("555 e 5555 s", "Layton", "Utah", "USA");
       Customer customer1 = new Customer("Bob Greenberry", address1);
       Order order2 = new Order(customer1);
       order2.GetProduct().Add(item1_1);
       order2.GetProduct().Add(item1_2);
       order2.GetProduct().Add(item1_3);

       order2.PackingLabel();
       order2.ShippingLabel();


        Product item2_1 = new Product("Small desk", "450", 245, 1);
        Product item2_2 = new Product("Dog", "76", 550, 1);
        Product item2_3 = new Product("Pencils", "78", 3, 30);
        Address address2 = new Address("685 Cool Street", "Midvale", "Utah", "USA");
        Customer Customer3 = new Customer("Kevin Thomas", address2);
        Order order3 = new Order(Customer3);

        order3.GetProduct().Add(item2_1);
        order3.GetProduct().Add(item2_2);
        order3.GetProduct().Add(item2_3);

        order3.PackingLabel();
        order3.ShippingLabel();


     
    }
}