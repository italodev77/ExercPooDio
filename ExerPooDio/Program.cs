// See https://aka.ms/new-console-template for more information
using ExerPooDio.Models;

Console.WriteLine("Hello, World!");

Console.WriteLine("nokia");

Smartphone nokia = new Nokia(numero: "12345678", modelo: "novo", imei: "11111", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("whatsapp");

Console.WriteLine("iphone");

Smartphone iphone = new Nokia(numero: "12345678", modelo: "novo", imei: "11111", memoria: 64);
iphone.Ligar();
iphone.InstalarAplicativo("whatsapp");
