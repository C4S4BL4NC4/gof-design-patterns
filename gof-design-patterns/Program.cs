using gof_design_patterns.OOP.Principles.Abstraction;
using gof_design_patterns.OOP.Principles.Coupling;
using gof_design_patterns.OOP.Principles.Encapsulation;
using gof_design_patterns.OOP.Principles.Inheritance;

/*
 Encapsulation is hiding complexity  and only exposing what is necessary to the user.
 Users also don't have worry about the internal implementation of the class, as they can interact with it through the provided methods without needing to know how the balance is stored or managed internally.
*/
Console.WriteLine("Encapsulation:");

// Bad Encapsulation: Directly accessing and modifying the balance field of the BadBankAccount class, which violates the principle of encapsulation.
BadBankAccount alex = new BadBankAccount();
Console.WriteLine("Alex's balance: " + alex.balance);
alex.balance = -100000;
Console.WriteLine("Alex's balance: " + alex.balance);

// Good Encapsulation: Using methods to access and modify the balance of the BetterBankAccount class, which adheres to the principle of encapsulation.
BetterBankAccount bob = new BetterBankAccount(1000);

// Only accesable through methods, not directly
//bob.GetBalance() = 1000; // Invalid, cannot assign to method result

Console.WriteLine("Bob's balance: " + bob.GetBalance());

//bob.Deposit(-200); // Invalid, will throw an exception
bob.Deposit(200);
Console.WriteLine("Bob's balance: " + bob.GetBalance());

/**************************************************************/

// Abstraction is reducing complexity by hiding unnecessary details from the user.
Console.WriteLine("\n" + "Abstraction:");

// Bad Abstraction: The BadEmailService class exposes all the details of connecting, authenticating, sending, and disconnecting from an email service, which can overwhelm the user with unnecessary complexity.
BadEmailService emailService = new BadEmailService();
emailService.Connect();
emailService.Authenticate();
emailService.Send();
emailService.Disconnect();

// Good Abstraction: The BetterEmailService class provides a simplified interface for sending an email, hiding the underlying complexity of connecting, authenticating, and disconnecting from the email service.
BetterEmailService betterEmailService = new BetterEmailService("Hello, this is a test email.");
betterEmailService.SendEmail();

/**************************************************************/

// Inheritance is creating classes that are based on existing classes, allowing for code reuse and the creation of a class hierarchy.
// Polymorphism is to make an object take many forms. It allows methods to do different things based on the object it is acting upon, even if they share the same name.
Console.WriteLine("\n" + "Inheritance and Polymorphism:");

Car car = new Car("Toyota", "Camry", 2024, 4);
Console.WriteLine(car.ToString());
car.Start();
car.Stop();
Bike bike = new Bike("Giant", "Escape", 2023, 2);
Console.WriteLine(bike.ToString());
bike.Start();
bike.Stop();

/**************************************************************/

/*
Coupling is the degree of dependency of that one class has to another.
It refers to how closely connected two classes are, and how much one class relies on the other.
In general, lower/loose coupling is preferred, as it makes the code more modular, easier to understand, and easier to maintain.
*/
Console.WriteLine("\n" + "Coupling:");

// Bad Coupling: The HighOrder class is tightly coupled to the TightCouplingEmailSender class, which means that any changes to the TightCouplingEmailSender class will require changes to the HighOrder class as well. This makes the code less flexible and harder to maintain.
HighOrder badOrder = new HighOrder();
badOrder.PlaceOrder();

// Good Coupling: The LowOrder class is loosely coupled to the INotificationService interface, which means that it can work with any implementation of the INotificationService interface. This makes the code more flexible and easier to maintain.
LowOrder goodOrder = new LowOrder();
goodOrder.PlaceOrder();


/*************************************************************/
