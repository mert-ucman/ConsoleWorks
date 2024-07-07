
Customer customer1 = new Customer
{
    Id = 1,
    Name = "Mert",
    Surname = "Uçman",
    Number = "11111111111",
    Adress = "Hatay",
    Balance = 5000
};


Customer customer2 = new Customer
{
    Id = 2,
    Name = "Arda",
    Surname = "Uçman",
    Number = "22222222222",
    Adress = "Adana",
    Balance = 8000
};


CustomerManager customerManager = new CustomerManager();
customerManager.Add(customer1);
customerManager.Add(customer2);
customerManager.Delete(customer1);
customerManager.Listing();
