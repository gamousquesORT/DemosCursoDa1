// See https://aka.ms/new-console-template for more information

using RefactoredWithDemeter;

Store store = new Store();
Customer customer = new Customer();
customer.AddMoney(100);
store.Checkout(customer, 110);

