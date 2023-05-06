using System;
using System.IO;
using System.Drawing;

namespace imgresizer {

    class Program {

        static void Main(string[] args) {
            AddToPath();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            if(args.Length != 3 || args[0] == "-h"){
                Console.WriteLine("\n\n\n\n\nDescription: \n    This is a simple image resizing program that works based on your arguments.\n   Its made with c# by Erdajt Sopjani.\n   I wanted to make this program to test my skills in c# since i just started learning it.\n   This is a really useful tool that is going to save my time and help me everyday.\n  This tool also gets added to your path so you can call it anywhere with just your terminal.\n   Use cases are above and call it anywhere in any directory by using your terminal with: resizeimage.exe arg1 arg2 arg3.\n    Thanks for using my program and i hope it's useful to you.\n");
                Console.WriteLine("\nUsage: ");
                Console.WriteLine("\n   Help: \n        resizeimage.exe -h");
                Console.WriteLine("\n   Info: \n        resizeimage.exe C:/path/to/image.png -i null");
                Console.WriteLine("\n   Resize: \n        resizeimage.exe C:/path/to/image.png {width} {height}\n\n\n");
                return;
            }

            string imgPath = args[0];
            Image img = Image.FromFile(imgPath);
            
            string widthStr = args[1];
            string heightStr = args[2];  

            if (widthStr == "-i" && heightStr == "null") {
                int width = img.Width;
                int height = img.Height;

                Console.WriteLine("\n\n\n{0} width: {1}, height: {2}\n use: .\\resizeimage.exe C:/path/to/image.png (width) (height)   to resize it.\n\n\n", Path.GetFileName(imgPath), width, height, width, height);
                return;
            }else if(widthStr != "-i" && heightStr != "null"){
                int newWidth = Convert.ToInt32(widthStr);
                int newHeight = Convert.ToInt32(heightStr);

                Bitmap bitmap = new Bitmap(img, newWidth, newHeight);
                string newImagePath = Path.Combine(Path.GetDirectoryName(imgPath), "resized_" + Path.GetFileName(imgPath));
                bitmap.Save(newImagePath);

                Console.WriteLine("\n\n\nImage resized and saved to: {0}\n\n\n", newImagePath);
            }
        }
        public static void AddToPath(){
            var path = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);

            var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var newPath = string.Join(";", new[] { path, directory });

            Environment.SetEnvironmentVariable("PATH", newPath, EnvironmentVariableTarget.User);
        }
    }
}