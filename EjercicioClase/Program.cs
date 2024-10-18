using System;
using EjercicioClase;

class Program
{
    static void Main(string[] args)
    {
        SuperHeroe superman = new SuperHeroe();
        superman.Nombre = "Superman";
        superman.IdentidadSecreta = "Clark Kent";
        superman.Ciudad = "Metropolis";
        superman.PuedeVolar = true;
        superman.SuperPoder.Nombre = "Super Fuerza";
        superman.SuperPoder.Descripcion = "Capacidad de levantar objetos muy pesados";
        superman.SuperPoder.Nivel = 9;
        superman.Imprimir();

        SuperHeroe invisibleWoman = new SuperHeroe();
        invisibleWoman.Nombre = "Invisible Woman";
        invisibleWoman.IdentidadSecreta = "Sue Storm";
        invisibleWoman.Ciudad = "New York";
        invisibleWoman.PuedeVolar = false;
        invisibleWoman.SuperPoder.Nombre = "Invisibilidad";
        invisibleWoman.SuperPoder.Descripcion = "Habilidad para volverse invisible";
        invisibleWoman.SuperPoder.Nivel = 8;
        invisibleWoman.Imprimir();

        SuperHeroe nightcrawler = new SuperHeroe();
        nightcrawler.Nombre = "Batman";
        nightcrawler.IdentidadSecreta = "Bruno Diaz";
        nightcrawler.Ciudad = "Ciudad Gotica";
        nightcrawler.PuedeVolar = false;
        nightcrawler.SuperPoder.Nombre = "Millonario";
        nightcrawler.SuperPoder.Descripcion = "Usa tecnologia";
        nightcrawler.SuperPoder.Nivel = 1;
        nightcrawler.Imprimir();
    }
}