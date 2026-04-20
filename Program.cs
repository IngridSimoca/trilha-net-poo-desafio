using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Nokia nokia1 = new Nokia("(11)1111111","AparelhoNokia","im329843845",128);
Iphone iphone1 = new Iphone("(24)99999999","AparelhoIphone","Im3849hifh34",240);

Console.WriteLine("Teste Nokia");
nokia1.Ligar();
nokia1.InstalarAplicativo("WhastApp");

Console.WriteLine("\n");
Console.WriteLine("Teste Iphone");

iphone1.Ligar();
iphone1.InstalarAplicativo("Jogo");


