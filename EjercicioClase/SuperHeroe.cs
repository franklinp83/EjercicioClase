namespace EjercicioClase
{
    public class SuperHeroe
    {
        public string Nombre { get; set; }
        public string IdentidadSecreta { get; set; }
        public string Ciudad { get; set; }
        public bool PuedeVolar { get; set; }
        public SuperPoder SuperPoder { get; set; }

        public SuperHeroe()
        {
            SuperPoder = new SuperPoder();
        }

        public void Imprimir()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"Identidad Secreta: {IdentidadSecreta}");
            Console.WriteLine($"Ciudad: {Ciudad}");
            Console.WriteLine($"Puede volar: {PuedeVolar.ToString().ToLower()}");
            Console.WriteLine($"Super Poder: {SuperPoder.Nombre}");
            Console.WriteLine($"Descripción: {SuperPoder.Descripcion}");
            Console.WriteLine($"Nivel: {SuperPoder.Nivel}");
            Console.WriteLine();
        }
    }
}
