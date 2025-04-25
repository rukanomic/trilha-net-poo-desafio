using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia:");
Nokia nokia = new Nokia("123456789", "Nokia 3310", "123456789012345", 128);
nokia.Ligar();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Iphone iphone = new Iphone("987654321", "iPhone 12", "987654321098765", 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Nubank");