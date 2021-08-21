using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day12_13电脑_优盘_移动硬盘_MP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //用多态来实现 将移动硬盘或者优盘或者mp3插到电脑上读取数据的情形
            //MobileDisk md = new MobileDisk();
            //UDisk u = new UDisk();
            //MP3 mp = new MP3();
            //Computer com = new Computer();
            //com.CPURead(u);
            //com.CPUWrite(u);
            //Console.ReadKey();

            //MobileStorage ms = new UDisk();
            //Computer com = new Computer();
            //com.CPUWrite(ms);
            //com.CPURead(ms);
            //Console.ReadKey();



            MobileStorage ms = new MP3();//new UDisk();
            Computer com = new Computer();
            com.Ms = ms;
            com.CPURead();
            com.CPUWrite();
            Console.ReadKey();
        }
    }

    public abstract class MobileStorage
    {
        public abstract void Read();
        public abstract void Write();
    }

    public class MobileDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("移动硬盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("移动硬盘在写入数据");
        }
    }

    public class UDisk : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("U盘在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("U盘在写入数据");
        }
    }

    public class MP3 : MobileStorage
    {
        public override void Read()
        {
            Console.WriteLine("MP3在读取数据");
        }
        public override void Write()
        {
            Console.WriteLine("MP3在写入数据");
        }
        public void PlayMusic()
        {
            Console.WriteLine("MP3在播放音乐");
        }
    }

    public class Computer
    {
        private MobileStorage _ms;

        public MobileStorage Ms
        {
            get
            {
                return _ms;
            }

            set
            {
                _ms = value;
            }
        }

        public void CPURead()
        {
            Ms.Read();
        }
        public void CPUWrite()
        {
            Ms.Write();
        }
    }


}
