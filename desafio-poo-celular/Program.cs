using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "1197159-6652", modelo: "Iphone 11", imei: "222233", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1197159-5266", modelo: "Nokia tijolão", imei: "332222", memoria: 4);
iphone.Ligar();
iphone.InstalarAplicativo("Snake Game");