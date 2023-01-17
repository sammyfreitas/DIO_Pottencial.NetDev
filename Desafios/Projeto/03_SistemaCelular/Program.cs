using DesafioPOO.Models;

Iphone iphone =  new Iphone("11998485082", "6S", "JFBASHFJJA1212", 250);

iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Google Chrome");
Console.WriteLine("...");
iphone.InstalarAplicativo("WhatsApp");
Console.WriteLine("....");

Nokia nokia =  new Nokia("11889885083", "7G", "JDSAJDBNANB22232", 500);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Binance");
Console.WriteLine("...");
nokia.InstalarAplicativo("Telegram");
Console.WriteLine("...");