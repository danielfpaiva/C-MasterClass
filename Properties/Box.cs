using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Box
    {
        //member variables
        private int lenght;
        private int height;
        //public int width;
        private int volume;

        public int Width { get; set; }

        public int Volume
        {
            get
            {
                return this.lenght * this.Width * this.Height;
            }
        }

        public int Height 
        {
            get
            {
                return height;
            }
            set
            {
                if (value < 0)
                {
                    height = -value;
                }else
                {
                    height = value;
                }
            }
        }

        public int FrontSurface 
        {
            get
            {
                return height * lenght;
            }        
        }


        public Box (int lenght, int width, int height)
        {
            this.lenght = lenght;
            this.height = height;
            Width = width;
        }

        public void SetLenght(int lenght)
        {
            if(lenght < 0)
            {
                throw new Exception(message: "Lenght should be higher than 0.");
            }else
            {
                this.lenght = lenght;
            }
            
        }

        public int GetLenght()
        {
            return this.lenght;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Lenght is {0} and height is {1} and width is {2} and volume is {3}"
                , lenght, height, Width, volume = lenght * height * Width);
            Console.Read();
        }
    }
}
