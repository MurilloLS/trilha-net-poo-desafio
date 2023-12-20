using DesafioPOO.Models;

// Implementado! (TODO: Realizar os testes com as classes Nokia e Iphone)
Console.WriteLine("Smatphone Nokia: ");
Smartphone nokia = new Nokia(numero: "1398813324", modelo: "Modelo ABC", imei: "1102101001", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Youtube");

Console.WriteLine();

Console.WriteLine("Smartphone Iphone: ");
Smartphone iphone = new Iphone(numero: "13988455892", modelo: "Model XZY", imei: "1110001001", memoria: 32);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Spotfy");


