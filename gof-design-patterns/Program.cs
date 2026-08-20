using gof_design_patterns.OOP.Principles.Abstraction;
using gof_design_patterns.OOP.Principles.Composition;
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

gof_design_patterns.OOP.Principles.Inheritance.Car car =
    new gof_design_patterns.OOP.Principles.Inheritance.Car("Toyota", "Camry", 2024, 4);
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
LowOrder goodOrder = new LowOrder(new BetterEmailSender());
goodOrder.PlaceOrder();
LowOrder smsOrder = new LowOrder(new SmsSender());
smsOrder.PlaceOrder();

/*************************************************************/

// Composition of parts is a design principle that allows you to build complex objects by combining simpler ones, rather than relying on inheritance. It promotes code reuse and flexibility by allowing you to change the behavior of an object at runtime by changing its components.
Console.WriteLine("\n" + "Composition:");

// Generally composition is preferred over inheritance, as it allows for more flexibility and code reuse.

gof_design_patterns.OOP.Principles.Composition.Car civic =
    new gof_design_patterns.OOP.Principles.Composition.Car();

civic.StartCar();

/*************************************************************/

/*
 *
 *
UML is a standardized modeling language that is used to visualize the design of a system.
It provides a set of graphical notations to create visual models of object-oriented software systems.
UML diagrams can be used to represent various aspects of a system, including its structure, behavior, and interactions between components.
 *
 *
 */

/*************************************************************/

/*
SOLID PRINCIPLES:
S: Single Responsibility Principle (SRP): A class should have only one reason to change, meaning it should have only one responsibility or job. This makes the class easier to understand, maintain, and test.
O: Open/Closed Principle (OCP): Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification. This means that you should be able to add new functionality to a class without changing its existing code, which helps to prevent introducing bugs and breaking existing functionality.
L: Liskov Substitution Principle (LSP): Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. This means that subclasses should behave in a way that is consistent with the expectations set by their superclass, ensuring that the program remains correct when using polymorphism.
I: Interface Segregation Principle (ISP): Clients should not be forced to depend on interfaces they do not use. This means that you should create small, specific interfaces rather than large, general ones, which helps to reduce coupling and increase flexibility.
D: Dependency Inversion Principle (DIP): High-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces). This means that you should depend on abstractions rather than concrete implementations, which helps to reduce coupling and increase flexibility.
*/

/*************************************************************/

// SRP: Single Responsibility Principle (SRP)
// A class should only do one thing, and do it well.
// SRP classes can use (borrow) methods from other classes to accomplish its task, but it should not implement raw logic that is not related to its primary responsibility.

Console.WriteLine("\n" + "SOLID Principles::SRP");

/*************************************************************/
