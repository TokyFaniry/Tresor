using System;
using System.Security.Cryptography.X509Certificates;

namespace Chasse_au_tresor
{
    public class Program {
        
        public static void SeDeplacer(int initialX ,int initialY ,string chemin) 
        {
            int maxX = 5;
            int maxY = 5;
            foreach (char c in chemin)
            {
                if (c == 'N') 
                {
                    initialY += 1;
                    if (initialY < 0 )
                    {
                        initialY=0;
                    }
                }
                if (c == 'S') 
                { 
                    initialY -= 1;
                    if (initialY > maxY) 
                    { 
                        initialY=maxY;
                    }
                }
                if (c == 'E') 
                { 
                    initialX -= 1; 
                    if (initialX > maxX)
                    {
                        initialX=maxX;
                    }
                }
                if (c == 'O')
                {
                    initialX -= 1;
                    if(initialX < 0)
                    {
                        initialX = 0;
                    }
                }
            }
            Console.WriteLine("x={0} et y={1}", initialX, initialY);
        }
        public string TrouverTresor(int initialX, int initialY, int tresorX, int tresorY)
        {
            string resultat = "";
            if (initialX < tresorX)
            {
                initialX += 1;
                resultat += "E";

            }
            if (initialX > tresorX)
            {
                initialX -= 1;
                resultat += "O";
            }

            if (initialY < tresorY)
            {
                initialY += 1;
                resultat += "S";

            }
            if (initialY > tresorY)
            {
                initialY -= 1;
                resultat += "N";

            }
          
            return (resultat);
        }
      public static void Main(string[] args)
     {
            int[,] terrain= new int[5,5];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    terrain[i,j] = 0;

                   if (i == 2 & j==2)
                    {
                        terrain[i,j] = 1;
                    }
                }
            }                   

            for (int i=0;i<5;i++)
            {
                for(int j=0;j<5;j++)
                {
                    Console.Write(terrain[i,j]);
                }
                Console.WriteLine(" ");
            }
            SeDeplacer(1, 2, "0");

        }
    }
}
