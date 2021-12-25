using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();
            Test4();
            Test5();            
        }


        //File - Directory 클래스 간단 사용
        static void Test1()
        {
            //E:\test 폴더를 만들 예정입니다.

            string dir = "e:\\test";
            if (false == Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            string[] files = Directory.GetFiles(dir);
            if (files != null && files.Length > 0)
            {
                foreach (var f in files)
                {
                    Console.WriteLine(f);
                }
            }

            string file = dir + "\\test.txt";
            if (false == File.Exists(file))
            {
                File.Create(file);
            }
            else
            {
                File.Delete(file);
            }
        }


        //long 타입의 데이터를 특정 파일에 바이트 배열과 FileStream을 통해 저장
        static void Test2()
        {
            long someValue = 0x123456789ABCDEF0;
            string dir = "e:\\test";
            string file = "filestreamex.dat";

            //string fullfile = dir + "\\" + file;
            string fullfile = Path.Combine(dir, file);

            if (false == Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
            }

            //if( true == File.Exists(fullfile))
            //{
            //
            //}

            FileStream outStream = new FileStream(fullfile, FileMode.Create);

            byte[] wBytes = BitConverter.GetBytes(someValue);

            outStream.Write(wBytes, 0, wBytes.Length);            

            outStream.Close();
        }


        //파일에 저장되어있는 8바이트의 데이터를 읽어와 long 타입의 숫자로 복구
        static void Test3()
        {
            string dir = "e:\\test";
            string file = "filestreamex.dat";
            string fullfile = Path.Combine(dir, file);

            if (File.Exists(fullfile))
            {

                FileStream fs = new FileStream(fullfile, FileMode.Open);//열고,연결하고

                byte[] rBytes = new byte[8];

                fs.Read(rBytes, 0, rBytes.Length);
                long readdata = BitConverter.ToInt64(rBytes, 0);
                Console.WriteLine("0x" + Convert.ToString(readdata, 16));

                fs.Close();//닫고, 해제한다.
            }
            else
            {
                Console.WriteLine("파일이 존재하지 않습니다.");
            }
        }

        //파일에 문자열 쓰기
        static void Test4()
        {
            string dir = @"e:\test";
            string file = "aaaaaa.txt";
            string fullfile = Path.Combine(dir, file);

            var fs = new FileStream(fullfile, FileMode.Create);
            var sw = new StreamWriter(fs);

            sw.WriteLine("gOOD mORNING!");
            sw.WriteLine("jang eun mee");
            sw.WriteLine("안녕~");


            sw.Close();
            fs.Close();
        }

        //파일에서 문자열 읽어오기
        static void Test5()
        {
            string dir = @"e:\test";
            string file = "aaaaaa.txt";
            string fullfile = Path.Combine(dir, file);

            if (File.Exists(fullfile))
            {
                var fs = new FileStream(fullfile, FileMode.Open);
                var sr = new StreamReader(fs);

                StringBuilder builder = new StringBuilder();
                while (sr.EndOfStream == false)
                {
                    builder.Append(sr.ReadLine());
                    builder.Append(Environment.NewLine);
                }

                sr.Close();
                fs.Close();

                Console.WriteLine(builder.ToString());
            }
        }
    }
}
