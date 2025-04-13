using System;

namespace ProductManagementApp.Exceptions
{
    public class InvalidUnitNameException : Exception
    {
        public override string Message => "Invalid unit name!";
    }
}
