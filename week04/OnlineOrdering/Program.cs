using System;

class Program
{
    static void Main(string[] args)
    {
        //Order 1
        Order order1 = new Order();
        Address address1 = new Address();
        address1.setAddress("123 Park Street", "Park City", "Park State", "USA");

        Customer customer1 = new Customer();
        customer1.setName("Nate");
        customer1.setAddress(address1);

        order1.setCustomer(customer1);
        Product product11 = new Product();
        product11.setProduct("Trampoline", 125, 50, 1);
        order1.addProduct(product11);

        Product product12 = new Product();
        product12.setProduct("Pillow", 70, 5, 3);
        order1.addProduct(product12);

        Console.WriteLine("Order 1:");
        order1.displayOrder();


        //Second Order
        Order order2 = new Order();
        Address address2 = new Address();
        address2.setAddress("456 Mountain Street", "Mountain City", "Mountain State", "Canada");

        Customer customer2 = new Customer();
        customer2.setName("Ben");
        customer2.setAddress(address2);
        order2.setCustomer(customer2);

        Product product21 = new Product();
        product21.setProduct("Cat toys", 92, 5, 4);
        order2.addProduct(product21);

        Product product22 = new Product();
        product22.setProduct("Glass cups", 5, 4, 10);
        order2.addProduct(product22);

        Console.WriteLine("Order 2:");
        order2.displayOrder();
    }
}