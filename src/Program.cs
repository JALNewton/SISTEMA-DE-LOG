using System;

namespace Repo
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.SetDefaultColor();//Alterando para cor de texto atual

            Log.Write("Hello World!");
            Log.Write("Hello World!",0);
            Log.Write("Hello World!",1);
            Log.Write("Hello World!",2);
            Log.Write("Hello World!",4);

            Log.Close();//Encerramento do LOG.            
        }
    }
}
