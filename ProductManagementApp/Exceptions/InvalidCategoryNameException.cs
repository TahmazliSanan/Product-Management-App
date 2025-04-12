using System;

namespace ProductManagementApp.Exceptions
{
    public class InvalidCategoryNameException : Exception
    {
        public override string Message => "Invalid category name!";
    }
}
