public class Database
{
    private static Database _instance;
    private static readonly object lockObject = new object();
    private Database(){ }
    public static Database GetInstance()
    {
        if (_instance == null)
        {
            lock(lockObject)
            {
                if (_instance == null)
                {
                    _instance = new Database();
                }
            }
        }
        return _instance;
    }
    public void Connect()
    {
        Console.WriteLine("Database connected.");
    }

}