using PrimeiraLista;

Piramide piramide = new Piramide(3);
try
{
    piramide.Desenha();
}
catch (NotFiniteNumberException)
{
    Console.WriteLine("O numero precisa ser maior ou igual a 1");
}