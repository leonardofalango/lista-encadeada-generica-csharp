// See https://aka.ms/new-console-template for more information


Lista<int> lista = new Lista<int>();
lista.Add(1);
lista.Add(2);
lista.Add(3);
for (int i = 0; i<20; i++)
{
    lista.Add(1);
}
for (int i = 0; i<lista.Length; i++)
{
    Console.WriteLine(lista[i]);
}
