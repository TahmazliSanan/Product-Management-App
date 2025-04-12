using System;

namespace ProductManagementApp.Exceptions
{
    public class RowIsNotSelectedException : Exception
    {
        public override string Message => "Row is not selected!";
    }
}
