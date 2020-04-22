using UsefulUtility.Models;

namespace UsefulUtility.Services
{
    public class EmailValidator : IEmailValidator
    {

        // ## Email validator
        // - Endpoint at `/useful/email` with a query param
        // - Have a link at the main page to an example: `/useful/email?email=is@this.valid`
        // - Create a `ValidateEmail` method in the `UtilityService`
        //     - check if the string contains a `@` and a `.`
        // - Display the following to the user
        //     - `is@this.valid is a valid email address` in green
        //     - `not_valid_email.com is not a valid email address` in red
        public string Email(Email email)
        {
            if (email.Mail.Contains("@") && email.Mail.Contains("."))
            {
                return "green";
            }
            return "red";
        }
    }
}
