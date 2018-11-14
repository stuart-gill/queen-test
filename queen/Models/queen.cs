using System;
using System.Collections.Generic;
using System.Linq;

namespace QueenWorld
{
     public class Program
     {
        public class Queen
            {
                public bool canQueenAttack(int queenX, int queenY, int targetX, int targetY)
                {
                
                    if (queenX == targetX ) 
                    {
                        return true;
                    }
                    else if (queenY == targetY)
                    {
                        return true;
                    }
                    else if (Math.Abs(queenX-targetX)==Math.Abs(queenY-targetY))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
            }
        
            
                public static void Main()
                {
                    Console.WriteLine("Please enter your queen x position");
                    int queenX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your queen y position");
                    int queenY = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your target x position");
                    int targetX = int.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter your target y position");
                    int targetY = int.Parse(Console.ReadLine());
                    Queen MyQueen = new Queen();
                    if (MyQueen.canQueenAttack(queenX, queenY, targetX, targetY)==true)
                    {
                        Console.WriteLine("Your queen can attack your target");
                    }
                    else
                    {
                        Console.WriteLine("Your queen cannot attack your target");
                    }
                }
     }
    

}