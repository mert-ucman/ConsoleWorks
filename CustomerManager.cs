
class CustomerManager {
    List<Customer> list;

    public CustomerManager() {
        list = new List<Customer>();
    }
    public void Add(Customer customer){
        
        list.Add(customer);
        Console.WriteLine(customer.Name+" "+customer.Surname+" adlı müşteri eklendi.");
    }

    public void Delete(Customer customer){
        list.Remove(customer);
        Console.WriteLine(customer.Name+" "+customer.Surname+" adlı müşteri silindi.");
    }

    public void Listing(){
        foreach (Customer customers in list){
            Console.WriteLine(customers.Name+" "+customers.Surname);
            Console.WriteLine(list.Count + " adet müşteri listelendi");
        }
    }
}