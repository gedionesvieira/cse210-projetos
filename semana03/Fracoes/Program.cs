using System;

class Program
{
    static void Main(string[] args)
    {
       fracao fracao1 = new fracao();
       Console.WriteLine(fracao1.ObterFracaoEmTexto());
       Console.WriteLine(fracao1.ObterFracaoEmDecimal());

       fracao fracao2 = new fracao(5);
       Console.WriteLine(fracao2.ObterFracaoEmTexto());
       Console.WriteLine(fracao2.ObterFracaoEmDecimal());

       fracao fracao3 = new fracao(3, 4);
       Console.WriteLine(fracao3.ObterFracaoEmTexto());
       Console.WriteLine(fracao3.ObterFracaoEmDecimal());

       fracao fracao4 = new fracao(1, 3);
         Console.WriteLine(fracao4.ObterFracaoEmTexto());
         Console.WriteLine(fracao4.ObterFracaoEmDecimal());
    }
}