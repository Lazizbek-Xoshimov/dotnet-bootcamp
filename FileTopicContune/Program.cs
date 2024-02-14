using System.Text;

//string fileName = "C:\\Users\\Public\\Texts\\dunyo.txt";
//using FileStream fileStream = File.Create(fileName);
//byte[] bytes = Encoding.UTF8.GetBytes("Salom, dunyo!");
//fileStream.Write(bytes, 0, bytes.Length);
//fileStream.Close();
//Console.WriteLine("Faylga ma'lumot yozildi.");

//var newFileName = "C:\\Users\\Public\\NewTexts\\world.txt";
//File.Copy(fileName, newFileName);
//Console.WriteLine("Fayl nusxalandi.");

//var newFileLocation = "C:\\Users\\Public\\NewTexts\\mir.txt";
//File.Move(newFileName, newFileLocation);
//Console.WriteLine("Fayl boshqa joyga ko'chirildi.");

var path = "C:\\Users\\Public\\Texts\\dunyo.txt";
using FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read);
byte[] buffer = new byte[1024];
int c;
while((c = fileStream.Read(buffer, 0, buffer.Length)) > 0)
{
    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, c));
}
fileStream.Close();