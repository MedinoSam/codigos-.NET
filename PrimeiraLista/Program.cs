using PrimeiraLista;

Piramide piramide = new Piramide(4);
try
{
    piramide.Desenha(4);
}
catch (NotFiniteNumberException)
{
    Console.WriteLine("O numero precisa ser maior ou igual a 1");
}