using Microsoft.Extensions.DependencyInjection;

/*
You can register different implementations of ISmsProvider (e.g., TwilioSmsProvider, AnotherSmsProvider) 
in the Programs.cs using the serviceCollection. 
This provides flexibility and makes testing easier by injecting mock implementations of ISmsProvider for unit tests.
  
Let's take the NotificationService class (without and with dependency injection)

If we want to change the SMS provide:
-> without dependency injection(DI):
    -> create a new class with the implementation of the new provider
    -> change the NotificationService.cs class so the input parameter be of the new type class 

-> with dependency injection(DI):
    -> create a new class with the implementation of the new provider
    -> NotificationService.cs will remain the same, the input parameter is the same: ISmsProvider
*/


// Example 1 - Without Dependency Injection (Tight Coupling):
var smsProvider = new TwilioSmsProvider_WithoutDI(); // Can be Orange, Vodafone or other SMS provider

// Create a service that depends on the SMS provider
var notificationService1 = new NotificationService_WithoutDI(smsProvider);

// Use the service
notificationService1.SendOrderConfirmation("1234567890", "Your order #100 has been placed!");


// Example 2 - With Dependency Injection (Loose Coupling):
// Register dependencies (loose coupling)
var serviceCollection = new ServiceCollection();
serviceCollection.AddTransient<ISmsProvider, TwilioSmsProvider_WithDI>(); //  Can be Orange, Vodafone or other SMS provider
serviceCollection.AddTransient<NotificationService_WithDI>();

// Create service provider
var serviceProvider = serviceCollection.BuildServiceProvider();

// Resolve the notification service from the container
var notificationService2 = serviceProvider.GetService<NotificationService_WithDI>();

// Use the service
notificationService2.SendOrderConfirmation("1234567890", "Your order #100 has been placed!");
