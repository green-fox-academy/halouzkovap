namespace DIHelloWord.Models
{
    public interface IColor
    {
        void PrintColor(string color);
    }

    // Any kind of color class (for i.e. RedColor) can implement this interface overriding `PrintColor()` printing i.e. `"It is red in color..."` to the console.

    // - Implement the interface multiple times for different colors
    // - Add one of the implementations with the interface to the services in the `ConfigureServices` method
    // - Use the `PrintColor` method in the previously created middleware
    //     - Observe the output of the ASP.NET Core Web Server
    // - Replace the color implementation with another one in the `ConfigureServices` method
    //     - Check the output again, now you should see a different output without changing the middleware
    // - Change the implementations to use the `Printer` service using dependency injection 
}
