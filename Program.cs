using System;
using System.IO;
using System.Drawing;

namespace ImageResizer {

    class Program {

        private static string Help = @"




Description: 
    This is a simple image resizing program that works based on your argumens.
    Its made with c# by Erdajt Sopjani
    I made this program when i first started learning c# to test my skills.
    
    This is a really useful tool for resizing images almost instantly and you can call it anywhere using your terminal.
    Since this gets automatically added to your path once you executed it once manually here are the use cases you can call from your terminal: 
    
Usage: 

    Help:
        `resizeimage.exe -h`
    Info:
        `resizeimage.exe C:\path\to\image.png -i null
    Resize:
        `resizeimage.exe C:\path\to\image.png width height
        
        
        
"; 

        static void Main(string[] args) {
            AddToPath();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            if(args.Length != 3 || args[0] == "-h") {
                Console.Write(Help);
                return;
            }

            string imgPath = args[0];
            Image img = Image.FromFile(imgPath);
            
            string widthStr = args[1];
            string heightStr = args[2];  

            if (widthStr == "-i" && heightStr == "null")
                Info(imgPath, img);
            else if(widthStr != "-i" && heightStr != "null")
                Resize(imgPath, img, widthStr, heightStr);
            else 
                Console.Write(Help);
            Console.Clear();
        }

        private static void AddToPath() {
            var path = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.User);

            var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var newPath = string.Join(";", new[] { path, directory });

            Environment.SetEnvironmentVariable("PATH", newPath, EnvironmentVariableTarget.User);
        }

        private static void Info(string imgPath, Image img) {
            int width = img.Width;
            int height = img.Height;

            Console.WriteLine("\n\n\n{0} width: {1}, height: {2}\n use: .\\resizeimage.exe C:/path/to/image.png (width) (height)   to resize it.\n\n\n", Path.GetFileName(imgPath), width, height, width, height);
            Console.ReadKey();
            Console.Clear();
        }

        private static void Resize(string imgPath, Image img, string widthStr, string heightStr) {
            int newWidth = Convert.ToInt32(widthStr);
            int newHeight = Convert.ToInt32(heightStr);

            Bitmap bitmap = new Bitmap(img, newWidth, newHeight);
            string newImagePath = Path.Combine(Path.GetDirectoryName(imgPath), "resized_" + Path.GetFileName(imgPath));
            bitmap.Save(newImagePath);

            Console.WriteLine("\n\n\n{0} has been resized to {1}px and is saved on: {2}\n\n\n",Path.GetFileName(imgPath),widthStr+"px & "+heightStr,  newImagePath);
            Console.ReadKey();
            Console.Clear();
        }
    }
}
