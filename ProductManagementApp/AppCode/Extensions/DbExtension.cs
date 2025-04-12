using System.Data;

namespace ProductManagementApp.AppCode.Extensions
{
    public static partial class Extension
    {
        public static IDbCommand CreateCommand(this IDbConnection connection, string commandText)
        {
            IDbCommand command = connection.CreateCommand();
            command.CommandText = commandText;

            if (command.Connection.State != ConnectionState.Open)
            {
                command.Connection.Open();
            }

            return command;
        }

        public static IDbCommand AddParameter(this IDbCommand command, string parameterName, object parameterValue)
        {
            IDbDataParameter parameter = command.CreateParameter();
            parameter.ParameterName = parameterName;
            parameter.Value = parameterValue;
            command.Parameters.Add(parameter);
            return command;
        }
    }
}
