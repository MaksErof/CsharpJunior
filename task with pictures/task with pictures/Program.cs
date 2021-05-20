using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_with_pictures
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPictures = 52;
            int picturesInRow = 3;
            int rowOfPictures = numberOfPictures / picturesInRow;
            int remainingPictures = numberOfPictures - rowOfPictures * picturesInRow;
            Console.WriteLine("Из 52 картинок создастся " + rowOfPictures + " рядов");
            Console.WriteLine(remainingPictures + " картинка останется");
            Console.ReadKey();
        }
    }
}
