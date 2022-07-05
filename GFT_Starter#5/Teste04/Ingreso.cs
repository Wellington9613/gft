namespace gft
{
    public class Ingreso
    {
        public int Valor { get; set; }
        public virtual void ImprimeValor()
        {

            Console.WriteLine($"O valor do Ingresso é {Valor}");

        }

    }

}