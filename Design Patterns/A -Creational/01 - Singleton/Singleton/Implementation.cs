
namespace Singleton
{
    public class Logger
    {
        private static readonly Lazy< Logger> _lazyLooger= new Lazy< Logger>(() => new Logger() );
        private static Logger? _instance;
        
        protected Logger()
        {

        }

        public static Logger? Instance
        {

        get {
                return _lazyLooger.Value;
                //if(_instance == null)
                //{
                //    return new Logger();

                //}
                //return _instance;

            }


        }
        public void Log(string message)
        {
            Console.WriteLine($"Message to log{ message}");
        }
    
    
    }
}
