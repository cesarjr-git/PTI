using System;

public class Program
{
    static void Main(string[] args)
    {
        Locadora locadora = new Locadora();
        Menu menu = new Menu(locadora);
        menu.exMenu(); // Chama exMenu sem parâmetros
    }
}
