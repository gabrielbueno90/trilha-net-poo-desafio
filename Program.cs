using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//Feito


Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "1111-2222", modelo: "n289n", imei: "77777", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Google Maps");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Iphone(numero: "4444-7777", modelo: "XR", imei: "010101", memoria: 256);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Calculadora");