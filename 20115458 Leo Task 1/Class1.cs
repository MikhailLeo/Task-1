using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20115458_Leo_Task_1
{
    abstract class Tile
    {
        protected  int X;
        public int x
        {
            get { return X; }
            set { X = value; }
        }
        protected  int Y;
        public int y
        {
            get { return Y; }
            set { Y = value; }
        }
    
        /// <summary>
        /// Q2.1
        /// </summary>
        public enum TileType
        {
            Hero = 0,
            Enemy = 1,
            Gold = 3,
            Weapon = 4,
        }
        public Tile()
        {
            X = 0;
            Y = 0;
            
            
        }
        class obstacle : Tile
        {
            public obstacle(int X, int Y, char symbol)
            {
                Console.WriteLine("X");
            }
        }
     
           
     


       
      
           

        
        
             
           
    } 

    
    
}
