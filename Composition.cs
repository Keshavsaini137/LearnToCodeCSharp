using System;

namespace CompositionApp{

  public class Logger{
    public void Log(String message){
      Console.WriteLine(message);
    }
  }

  class DbMigrator{
    private readonly Logger _logger;

    public DbMigrator(Logger logger){
      _logger = logger;
    }

    public void Migrate(){
      _logger.Log("We are Migrating");
    }
  }

  public class Installer{
    private readonly Logger _logger;

    public Installer(Logger logger){
      _logger = logger;
    }
    public void Install(){
      _logger.Log("We are Installing the App.");
    }
  }

  class Composition{
    public static void Main(String []args){

      var dbMigrator = new DbMigrator(new Logger());

      var logger = new Logger();
      var installer = new Installer(logger);

      dbMigrator.Migrate();

      installer.Install();
    }
  }
}
