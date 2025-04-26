// See https://aka.ms/new-console-template for more information

using WalletAppDomain;

Store store = new Store();
Customer customer = new Customer();
Wallet w = customer.Wallet;
w.Money = 100;
store.Checkout(customer, 110);
