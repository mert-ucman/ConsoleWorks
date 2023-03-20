public class Database
{
    private static List<Customer> _customer;
    static Database()
    {
        _customer=new()
        {
            new Customer{IdNo="1",Name="Mert",Surname="Uçman",Password="1905",AccountBalance=0},
            new Customer{IdNo="2",Name="Ali",Surname="Otman",Password="3131",AccountBalance=0},
            new Customer{IdNo="3",Name="Aksel",Surname="Asma",Password="9198",AccountBalance=0},
        };
    }

    public static List<Customer>customer=>_customer;
}