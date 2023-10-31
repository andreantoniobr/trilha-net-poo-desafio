using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "999999999", modelo: "Modelo 01", imei: "111111111", memoria: 256);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "888888888", modelo: "Modelo 02", imei: "222222222", memoria: 512);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Facebook");