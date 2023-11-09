// See https://aka.ms/new-console-template for more information

using OOP3;

IKrediManager ihtiyacKrediManager =new IhtiyacKrediManager();
IKrediManager tasitKrediManager = new TasitKrediManager();
IKrediManager konutKrediManager =new KonutKrediManager();
//IKrediManager esnafKrediManager=new EsnafKrediManager();

ILoggerService databaseLoggerService = new DatabaseLoggerService();
ILoggerService fileLoggerService=new FileLoggerService();
//ILoggerService smsLoggerService=new SmsLoggerService();

BasvuruManager basvuruManager =new BasvuruManager();
basvuruManager.BasvuruYap(new EsnafKrediManager(), new SmsLoggerService());

List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyacKrediManager,tasitKrediManager };

//basvuruManager.KrediOnBilgilendirmesiYap(krediler);