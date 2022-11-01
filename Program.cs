int n1, n2, resto;



Console.WriteLine("Vamos de inovação , escolha um numero ,que falarem ser é multiplo . SIM OU NÃO (;  "); 

Console.WriteLine(" FALE OS NUEMROS A SEGUIR ");

Console.WriteLine("");



Console.Write("primeiro numero: ");

n1 = Convert.ToInt32(Console.ReadLine());



Console.Write("segundo número: ");

n2 = Convert.ToInt32(Console.ReadLine());



resto = n1 % n2;

bool ehMultiplo = (resto == 0);



if (resto == 0)

{

    Console.WriteLine($"{n1} é multiplo de {n2}");

}

else

{

Console.WriteLine($"{n1} não é multiplo de {n2}");

}
