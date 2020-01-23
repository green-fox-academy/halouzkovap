namespace classComposition
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DbMigrator(new Logger());

            var logger = new Logger();
            var installer = new Instaler(logger);

            dbMigrator.Migrate();
            installer.Install();

            System.Console.ReadLine();
        }
    }
}
