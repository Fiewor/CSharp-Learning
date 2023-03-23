public partial class Program
{
    public class DbCommand
    {
        private string _instruction;
        private DbConnection _dbConnection;
        public DbCommand(string instruction, DbConnection dbConnection)
        {
            //if (dbConnection)
            //    throw new ArgumentException("Database connection must be a valid string, not null or white space.");

            if (String.IsNullOrWhiteSpace(instruction))
                throw new ArgumentException("Instruction cannot be null or white space.");

            _instruction = instruction;
            _dbConnection = dbConnection;
        }
        public void Execute()
        {
            Console.WriteLine("Performing {0} on {1}", _instruction, _dbConnection);
            if (_instruction == "open")
                _dbConnection.OpenConnection();
            if (_instruction == "close")
                _dbConnection.CloseConnection();
        }
    }
    }
