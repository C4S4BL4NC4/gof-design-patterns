using gof_design_patterns.OOP.Pricaples.Encapulation;
using gof_design_patterns.OOP.Principles.Abstraction;
using gof_design_patterns.OOP.Principles.Inheritance;

///*
// Encapsulation is hiding complexity  and only exposing what is necessary to the user.
// Users also don't have worry about the internal implementation of the class, as they can interact with it through the provided methods without needing to know how the balance is stored or managed internally.
//*/

//// Bad Encapsulation: Directly accessing and modifying the balance field of the BadBankAccount class, which violates the principle of encapsulation.
//BadBankAccount alex = new BadBankAccount();
//Console.WriteLine("Alex's balance: " + alex.balance);
//alex.balance = -100000;
//Console.WriteLine("Alex's balance: " + alex.balance);

//// Good Encapsulation: Using methods to access and modify the balance of the BetterBankAccount class, which adheres to the principle of encapsulation.
//BetterBankAccount bob = new BetterBankAccount(1000);

//// Only accesable through methods, not directly
////bob.GetBalance() = 1000; // Invalid, cannot assign to method result

//Console.WriteLine("Bob's balance: " + bob.GetBalance());
////bob.Deposit(-200); // Invalid, will throw an exception
//bob.Deposit(200);
//Console.WriteLine("Bob's balance: " + bob.GetBalance());

/**************************************************************/

//// Abstraction is reducing complexity by hiding unnecessary details from the user.

//// Bad Abstraction: The BadEmailService class exposes all the details of connecting, authenticating, sending, and disconnecting from an email service, which can overwhelm the user with unnecessary complexity.
//BadEmailService emailService = new BadEmailService();
//emailService.Connect();
//emailService.Authenticate();
//emailService.Send();
//emailService.Disconnect();

//// Good Abstraction: The BetterEmailService class provides a simplified interface for sending an email, hiding the underlying complexity of connecting, authenticating, and disconnecting from the email service.
//BetterEmailService betterEmailService = new BetterEmailService("Hello, this is a test email.");
//betterEmailService.SendEmail();

/**************************************************************/

// Inheritance is creating classes that are based on existing classes, allowing for code reuse and the creation of a class hierarchy.
// Polymorphism is to make an object take many forms. It allows methods to do different things based on the object it is acting upon, even if they share the same name.

Car car = new Car("Toyota", "Camry", 2020, 4);
Console.WriteLine(car.ToString());
car.Start();
car.Stop();
Bike bike = new Bike("Giant", "Escape", 2020, 2);
Console.WriteLine(bike.ToString());
bike.Start();
bike.Stop();


/**************************************************************/
