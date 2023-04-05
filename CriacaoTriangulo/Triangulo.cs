namespace CriacaoTriangulo
{
    public class Triangulo
    {
        double[] lados;
        public Triangulo(double[] lados)
        {
            this.lados = lados;
        }

        public string VerificarTipo()
        {
            if (!VerificarLados())
            {
                return "Não forma triângulo";
            }

            if (lados[0] == lados[1])
            {
                if (lados[1] == lados[2])
                {
                    return "Forma triângulo equilátero";
                }

                return "Forma triângulo isósceles";
            }

            if (lados[0] == lados[2])
            {
                return "Forma triângulo isósceles";
            }

            if (lados[1] == lados[2])
            {
                return "Forma triângulo isósceles";
            }

            return "Forma triângulo escaleno";
        }

        private bool VerificarLados()
        {
            return lados[0] < lados[1] + lados[2] && lados[1] < lados[0] + lados[2] && lados[2] < lados[0] + lados[1];
        }
    }
}
