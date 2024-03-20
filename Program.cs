using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone Nokia = new Nokia(numero: "987654", modelo: "Nokia 2289", imei: "abc", memoria: 4);
Nokia.Ligar();
Nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero:"123456", modelo: "Iphone 15", imei: "541235", memoria: 256);
Iphone.ReceberLigacao();
Iphone.InstalarAplicativo("Telegram");
