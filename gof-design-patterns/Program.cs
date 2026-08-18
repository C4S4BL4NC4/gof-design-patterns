using gof_design_patterns.OOP.Pricaples.Encapulation;

// Encapsulation is a fundamental principle of object-oriented programming that restricts direct access to an object's internal state and behavior. It allows you to control how the internal state of an object is accessed and modified, promoting data integrity and security.
BadBankAccount alex = new BadBankAccount();
Console.WriteLine(alex.balance);
alex.balance = 100000;
Console.WriteLine(alex.balance);