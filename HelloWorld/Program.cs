using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        //Unity Ex
        struct Vector3
        {
            public float x, y, z;
        }
        struct Vector4
        {
            public float x, y, z,w;
        }
        struct Point2D
        {
            public float x, y;
        }
        static void Main(string[] args)
        {
            //Unity Ex
            Vector3 position;
            position.x = 0.0f;
            position.y = 0.0f;
            position.z = 0.0f;
            Console.WriteLine("Structs");
            Console.WriteLine();
            //pre-structs
            //pre-classes(Objects)

            //Ex:
            //----Player----
            //int health = 100;
            //int Playerx = 10;
            //int Playery = 10;
            Point2D playerPOS;
            playerPOS.x = 10;
            playerPOS.y = 10;

            //----Enemy----
            //int EnemyX = 20;
            //int EnemyY = 20;

            //----1000 enemies----
            int numEnemies = 100;
            //int[] enemyX = new int[numEnemies];
            //int[] enemyY = new int[numEnemies];
            Point2D[] enemyPOS = new Point2D[numEnemies];
            //loop to initialize them...
            for (int i = 0; i < numEnemies; i++)
            {
                enemyPOS[i].x = 10;
                enemyPOS[i].y = 10;
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to quit");
            Console.ReadKey(true);
        }
    }
}
