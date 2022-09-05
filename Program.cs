using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
System.Console.WriteLine("Iniciando aplicação Nokia");
Smartphone nokia = new Nokia(numero:"+55(11)11111-1111", modelo:"N-AZ1234", imei:"111111111111", memoria: 64);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Whatsapp");

System.Console.WriteLine("iniciando aplicação Iphone");
Smartphone iphone = new Iphone(numero: "+55()22222-2222", modelo: "A-IP1234", imei: "222222222222", memoria: 128);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Itune");