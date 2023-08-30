class Numero
{
    public double Valor { get; }

    public Numero(double valor)
    {
        Valor = valor;
    }
}

class Ordenador
{
    public static void BubbleSort(Numero[] numeros)
    {
        int n = numeros.Length;
        bool trocou;

        do
        {
            trocou = false;

            for (int i = 0; i < n - 1; i++)
            {
                if (numeros[i].Valor > numeros[i + 1].Valor)
                {
                    Numero temp = numeros[i];
                    numeros[i] = numeros[i + 1];
                    numeros[i + 1] = temp;
                    trocou = true;
                }
            }
        } while (trocou);
    }
}