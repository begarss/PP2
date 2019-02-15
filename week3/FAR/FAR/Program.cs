using System;
using System.IO;
using System.Text;

namespace Ex1
{
    class FarManager
    {
        public int cursor;
        public string path;
        public int sz;
        public bool ok;
        DirectoryInfo directory = null;
        FileSystemInfo currentFs = null;

        public FarManager()
        {
            cursor = 0;
        }

        public FarManager(string path)
        {
            this.path = path;
            cursor = 0;
            directory = new DirectoryInfo(path);
            sz = directory.GetFileSystemInfos().Length;
            ok = true;
        }

        public void Color(FileSystemInfo fs, int index)
        {
            if (cursor == index)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                currentFs = fs;
            }
            else if (fs.GetType() == typeof(DirectoryInfo))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.Yellow;
            }
        }

        public void Show()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            Console.SetCursorPosition(10, 0);
            Console.WriteLine("Delete: Del | Open: Spacebar | Rename: N | Back: Backspace | Exit: Esc");
            for (int i = 0, k = 0; i < fs.Length; i++)
            {
                if (ok == false && fs[i].Name[0] == '.')
                {
                    continue;
                }
                Color(fs[i], k);
                Console.WriteLine(i+1+". " +fs[i].Name);
                k++;
            }
        }
        public void Up()
        {
            cursor--;
            if (cursor < 0)
                cursor = sz - 1;
        }
        public void Down()
        {   
            cursor++;
            if (cursor == sz)
                cursor = 0;
        }

        public void CalcSz()
        {
            directory = new DirectoryInfo(path);
            FileSystemInfo[] fs = directory.GetFileSystemInfos();
            sz = fs.Length;
            if (ok == false)
                for (int i = 0; i < fs.Length; i++)
                    if (fs[i].Name[0] == '.')
                        sz--;
        }

        public void Start()
        {
            ConsoleKeyInfo consoleKey = Console.ReadKey();
            while (consoleKey.Key != ConsoleKey.Escape)
            {
                CalcSz();
                Show();
                consoleKey = Console.ReadKey();
                if (consoleKey.Key == ConsoleKey.UpArrow)
                    Up();
                if (consoleKey.Key == ConsoleKey.DownArrow)
                    Down();
                if (consoleKey.Key == ConsoleKey.RightArrow)
                {
                    ok = false;
                    cursor = 0;
                }
                if (consoleKey.Key == ConsoleKey.LeftArrow)
                {
                    cursor = 0;
                    ok = true;
                }
                if (consoleKey.Key == ConsoleKey.Enter)
                {
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        cursor = 0;
                        path = currentFs.FullName;
                    }
                }
                if (consoleKey.Key == ConsoleKey.Backspace)
                {
                    cursor = 0;
                    path = directory.Parent.FullName;
                }
                if (consoleKey.Key == ConsoleKey.Delete)
                {
                    cursor = 0;
                    
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        Directory.Delete(currentFs.FullName, true); // Delete folder(true means delete folder with things inside of him too)
                    }
                    else
                    {
                        FileInfo file = new FileInfo(currentFs.FullName);
                        currentFs.Delete();
                    }


                }
                if (consoleKey.Key == ConsoleKey.Spacebar)
                {
                    cursor = 0;
                    System.Diagnostics.Process.Start(currentFs.FullName);


                }
                if (consoleKey.Key == ConsoleKey.N)
                {
                        
                    if (currentFs.GetType() == typeof(DirectoryInfo))
                    {
                        Console.SetCursorPosition(50, cursor);
                        Console.Write("Введите новое имя:");
                        string newname = Console.ReadLine();
                        newname = Path.Combine(directory.FullName, newname);
                        System.IO.Directory.Move(currentFs.FullName, newname);
                    }else
                    
                    {
                        Console.SetCursorPosition(40,cursor );
                        Console.Write("Введите новое имя:");
                        string newname = Console.ReadLine();
                        newname = Path.Combine(directory.FullName, newname);
                        System.IO.File.Move(currentFs.FullName, newname);
                        
                        
                    }

                    


                }
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string path = "G:/";
            FarManager farManager = new FarManager(path);
            farManager.Start();
        }
    }
}