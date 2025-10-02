using IfsBeforeRefactor;

var paymentProcessor = new PaymentProcessor();
paymentProcessor.ProcessPayment(new CreditCard(), 100);
paymentProcessor.ProcessPayment(new PayPal(), 200);
paymentProcessor.ProcessPayment(new BankTransfer(), 50);
