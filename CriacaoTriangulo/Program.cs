namespace CriacaoTriangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] lados = new double[3];
            for (int i = 0; i < lados.Length; i++)
            {
                Console.Write("Digite o {0} lado: ", i + 1);
                lados[i] = Convert.ToDouble(Console.ReadLine());
            }

            Triangulo triangulo = new Triangulo(lados);
            Console.WriteLine(triangulo.VerificarTipo());
            Console.ReadLine();
        }
    }
}