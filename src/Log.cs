//Gerando arquivo de LOG.
using System;
using System.IO;

public static class Log
    {
        private static StreamWriter streamFile = new StreamWriter("Log.txt");
        private static ConsoleColor DefaultColor;
        public static void Write(string textToWrite_)
        {
            Console.WriteLine(textToWrite_);
            streamFile.WriteLine(textToWrite_);
        }

        public static void Write(object textToWrite_)
        {
            Console.WriteLine(textToWrite_);
            streamFile.WriteLine(textToWrite_);
        }
        public static void Write(string textToWrite_, ConsoleColor colorText)
        {
            Console.ForegroundColor = colorText;
            Console.WriteLine(textToWrite_);
            Console.ForegroundColor = DefaultColor;
            streamFile.WriteLine(textToWrite_);
        }

        public static void Write(string textToWrite_, int idColorText)
        {
            /*
                0: red
                1: blue
                2: green
                3: gray
                4: yellow
                5: white
                default: black // none
            */

            switch(idColorText)
            {
                case 0: 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                }
                case 1: 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                }
                case 2: 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                }
                case 3: 
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                case 4: 
                {
                   Console.ForegroundColor = ConsoleColor.Yellow;                    
                    break;
                }
                default:
                    Console.ForegroundColor = DefaultColor;
                    break;
            }
            Console.WriteLine(textToWrite_);
            Console.ForegroundColor = DefaultColor;
            streamFile.WriteLine(textToWrite_);
        }

        public static void Write(string textToWrite_, string idColorText)
        {
            switch(idColorText)
            {
                case "Red": 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                }
                case "Blue": 
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                }
                case "Green": 
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                }
                case "Gray": 
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
                }
                case "Yellow": 
                {
                   Console.ForegroundColor = ConsoleColor.Yellow;                    
                    break;
                }
                case "Black": 
                {
                   Console.ForegroundColor = ConsoleColor.Yellow;                    
                    break;
                }
                default:
                    Console.ForegroundColor = DefaultColor;
                    break;
            }
            Console.WriteLine(textToWrite_);
            Console.ForegroundColor = DefaultColor;
            streamFile.WriteLine(textToWrite_);
        }

        public static void SetDefaultColor()
        {
             DefaultColor = Console.ForegroundColor;
        }

        public static void Close()
        {
            streamFile.Close();
        }
    }