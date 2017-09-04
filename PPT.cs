using System;

namespace PPT
{
    public class PPT
    {
        private string[] opciones;
		private string[,] resultado;
		private int jugador=0;
		private int cpu=0;
		
		public PPT()
		{
			opciones = new string[] {"Piedra","Papel","Tijera"};
			resultado = new string[,] {{"Empate","Papel envuelve piedra. Pierdes","Piedra aplasta tijeras. Ganas"},
				{"Papel envuelve piedra. Ganas","Empate","Tijeras corta papel. Pierdes"},
				{"Piedra aplasta tijeras. Pierdes","Tijeras corta papel. Ganas","Empate"}};
		}
		
		public void datosJ()
		{
			bool correcto=false;
			while(!correcto)
			{
				Console.WriteLine("ELIGE TU OPCION:");
				Console.WriteLine("1: PIEDRA");
				Console.WriteLine("2: PAPEL");
				Console.WriteLine("3: TIJERA");
				Console.WriteLine("4: SALIR");
				if(Int32.TryParse(Console.ReadLine(),out jugador))
				{
					if(jugador>=1 && jugador<=4)
					{
						correcto=true;
						jugador--;
					}
					else
					{
						Console.WriteLine("El dato debe ser un numero entre 1 y 4");
					}
				}
				else
				{
					Console.WriteLine("El dato debe ser un numero");
				}
			}
			
		}
		
		public void datosC()
		{
			Random r= new Random();
			cpu=r.Next(0,3);
		}
		
		public void juego()
		{
			datosJ();
			if(jugador !=3)
			{
				datosC();
				Console.WriteLine("Opcion jugador: "+opciones[jugador]);
				Console.WriteLine("Opcion CPU: "+opciones[cpu]);
				Console.WriteLine(resultado[jugador,cpu]);
				juego();
			}
		}
		
		public static void Main(string[] args)
        {
            PPT partida=new PPT();
			partida.juego();
			
        }
    }
}
