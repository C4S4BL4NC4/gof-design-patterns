using gof_design_patterns.OOP.DesignPatterns.Behavioral.State;
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

var car = new gof_design_patterns.OOP.Principles.Inheritance.Car("Toyota", "Camry", 2024, 4);
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

var civic = new gof_design_patterns.OOP.Principles.Composition.Car();

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

Console.WriteLine("\n" + "SOLID Principles:");

// SRP: Single Responsibility Principle (SRP)
// A class should only do one thing, and do it well.
// SRP classes can use (borrow) methods from other classes to accomplish its task, but it should not implement raw logic that is not related to its primary responsibility.

Console.WriteLine("> SRP: A class should only do one thing, and do it well.");

/*************************************************************/

// OCP: Open/Closed Principle (OCP)
// Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification.
// Extension without modification.

Console.WriteLine(
    "> OCP: Software entities (classes, modules, functions, etc.) should be open for extension but closed for modification."
);

/*************************************************************/

// LSP: Liskov Substitution Principle (LSP)

/*
Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program.
*/

Console.WriteLine(
    "> LSP: Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program."
);

var rectangle = new gof_design_patterns.OOP.SOLID.LSP.BadExample.Rectangle
{
    Width = 10,
    Height = 5,
};
Console.WriteLine("Expected area of rectangle: 50");
Console.WriteLine("Area of rectangle: " + rectangle.GetArea());

var square = new gof_design_patterns.OOP.SOLID.LSP.Square { SideLength = 10 };
Console.WriteLine("Expected area of square: 100");
Console.WriteLine("Area of square: " + square.GetArea());

/*************************************************************/

// ISP: Interface Segregation Principle (ISP)
// Clients should not be forced to depend on interfaces they do not use.
Console.WriteLine(
    "\n" + "> ISP: Clients should not be forced to depend on interfaces they do not use."
);

var circle = new gof_design_patterns.OOP.SOLID.ISP.BadExample.Circle { Radius = 5 };
Console.WriteLine("Expected area of circle: " + circle.Area());
Console.WriteLine("Circle does not have a volume."); // This will throw an exception, as Circle does not have a volume.

var goodCircle = new gof_design_patterns.OOP.SOLID.ISP.Circle { Radius = 5 };
Console.WriteLine("Expected area of good circle: " + goodCircle.Area());

var sphere = new gof_design_patterns.OOP.SOLID.ISP.Sphere { Radius = 5 };
Console.WriteLine("Expected area of sphere: " + sphere.Area());
Console.WriteLine("Expected volume of sphere: " + sphere.Volume());

/*************************************************************/

// DIP: Dependency Inversion Principle (DIP) (or Dependancy Injection)
// High-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces).
Console.WriteLine(
    "\n"
        + "> DIP: High-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces)."
);

var tesla = new gof_design_patterns.OOP.SOLID.DIP.Car(
    new gof_design_patterns.OOP.SOLID.DIP.ElectricEngine()
);
tesla.StartCar();
tesla.StopCar();

/*************************************************************/

/*
 
Design patterns
    Provide standardized solutions to common problems in software design.
    There are many design patterns, but the most common ones are the following:
 
 - Creational patterns: (different ways to create objects) These patterns deal with object creation mechanisms, trying to create objects in a manner suitable to the situation.
                        The basic form of object creation could result in design problems or added complexity to the design.
                        Creational design patterns solve this problem by somehow controlling this object creation.

                        Examples: Singleton, Factory Method, Abstract Factory, Builder, Prototype


 - Structural patterns: (relationships between objects) These patterns deal with object composition, creating relationships between objects to form larger structures.
                        They help ensure that if one part of a system changes, the entire system doesn't need to do the same.

                        Examples: Adapter, Bridge, Composite, Decorator, Facade, Flyweight, Proxy


 - Behavioral patterns: (communication and interaction between these objects) These patterns deal with object collaboration and responsibility.
                        They help ensure that objects can communicate and work together effectively, while also promoting flexibility and reusability.

                        Examples: Chain of Responsibility, Command, Interpreter, Iterator, Mediator, Memento, Observer, State, Strategy, Template Method, Visitor


*/

/*************************************************************/

// Memento Pattern: most useful for implementing undo functionality and implementing snapshots of an object's state.
// The downsight is that it can be memory intensive, as it requires storing the entire state of an object at a given point in time.

Console.WriteLine("\n" + "Design Patterns:");
Console.WriteLine("- Behavioral Patterns:");
Console.WriteLine("Memento Pattern: most useful for implementing undo functionality.");

var editor = new gof_design_patterns.OOP.DesignPatterns.Behavioral.Memento.Editor();
var history = new gof_design_patterns.OOP.DesignPatterns.Behavioral.Memento.History(editor);
history.Backup();
editor.Title = "Forrest Gump";
history.Backup();
editor.Content = "Life is like a box of chocolates.";
history.Backup();
editor.Title = "The Shawshank Redemption";
Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");
history.Undo();
Console.WriteLine($"Title: {editor.Title}");
Console.WriteLine($"Content: {editor.Content}");
history.ShowHistory();

/*************************************************************/

// State Pattern: most useful for implementing state machines and workflow systems.
Console.WriteLine(
    "\n" + "State Pattern: most useful for implementing state machines and workflow systems."
);

var doc = new Document(UserRoles.Viewer);
doc.Publish(); // Viewer cannot publish without being in moderation state
doc.UserRole = UserRoles.Editor;
doc.Publish(); // Editor cannot publish without being in moderation state
doc.UserRole = UserRoles.Admin;
doc.Publish(); // Admin can publish, but document is still in draft state

/*************************************************************/
