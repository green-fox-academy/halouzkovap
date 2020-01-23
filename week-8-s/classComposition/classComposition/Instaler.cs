namespace classComposition
{
    public class Instaler
    {
        private readonly Logger _logger;

        public Instaler(Logger logger)
        {
            _logger = logger;
        }
        public void Install()
        {
            _logger.Log("we are intalling");

        }
    }
}
