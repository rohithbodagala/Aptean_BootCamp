using System;
using System.Collections.Generic;
namespace ColorConfiger
{

    class Color
    {
        
        public static string HexCode="", RgbCode="";
        static int R=0, G=0, B=0;
        static Dictionary<string, string> CommonColorName = new Dictionary<string, string>();


        public Color()
        {
            CommonColorName.Add("#DC143C", "Crimson");
            CommonColorName.Add("#FF0000", "Red");
            CommonColorName.Add("#FFD700", "Gold");
            CommonColorName.Add("#FFA500", "Orange");
            CommonColorName.Add("#FFFF00", "Yellow");
            CommonColorName.Add("#556B2F", "Dark Olive Green");
            CommonColorName.Add("#00FF00", "Green");
            CommonColorName.Add("#008080", "Teal");
            CommonColorName.Add("#ADD8E6", "Light Blue");
            CommonColorName.Add("#0000FF", "Blue");
            CommonColorName.Add("#4169E1", "Royal Blue");
            CommonColorName.Add("#000000", "Black");
            CommonColorName.Add("#FFFFFF", "White");

        }
    
        public void GetRedComponent(string hex_code)
        {

            Color.R=Convert.ToInt32(hex_code.Substring(1, 2), 16);
        }

        public void GetGreenComponent(string hex_code)
        {
            Color.G=Convert.ToInt32(hex_code.Substring(3, 2), 16);
        }
        public void GetBlueComponent(string hex_code)
        {
            Color.B=Convert.ToInt32(hex_code.Substring(5, 2), 16);
        }

        
        public string HexToRgb(string hex_code)
        {
            GetRedComponent(hex_code);
            GetGreenComponent(hex_code);
            GetBlueComponent(hex_code);
            return "("+R.ToString() +","+ G.ToString() + "," + B.ToString()+")";
        }
        public string RgbToHex(int R, int G,int B)
        {
            HexCode = "#" + Convert.ToInt32(R).ToString("X") + Convert.ToInt32(G).ToString("X") + Convert.ToInt32(B).ToString("X");
            while(HexCode.Length != 7)
            {
                HexCode += '0';
            }
            return HexCode;
        }



        static void Main(string[] args)
        {
            Color obj = new Color();

            int ModeInput=1,choice=0;
            do
            {
                if(ModeInput==1)
                {
                    Console.WriteLine("Select any one of them");
                    Console.WriteLine("1. HEX Code");
                    Console.WriteLine("2. RGB Code");
                    int Input = int.Parse(Console.ReadLine());
                    if(Input==1)
                    {
                        Console.WriteLine("Enter HEX Code: ");
                        Color.HexCode = Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Enter Red component: ");
                        Color.R = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Green component: ");
                        Color.G = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Blue component: ");
                        Color.B = int.Parse(Console.ReadLine());
                        obj.RgbToHex(R, G, B);
                    }
                    ModeInput = 0;

                }

                Console.WriteLine("Select any one from the following");
                Console.WriteLine("1.	Get HEX code");
                Console.WriteLine("2.	Get RGB code ");
                Console.WriteLine("3.	Get Red component ");
                Console.WriteLine("4.	Get Green component ");
                Console.WriteLine("5.	Get Blue component ");
                Console.WriteLine("6.	Get color's common name");
                Console.WriteLine("7.	Try another color");
                Console.WriteLine("8.	Exit");

                int Select = int.Parse(Console.ReadLine());
                switch (Select)
                {
                    case 1:
                        if (Color.HexCode.Equals(""))
                            Color.HexCode = obj.RgbToHex(Color.R, Color.G, Color.B);
                        Console.WriteLine($"HEX code is {Color.HexCode}");
                        break;
                    case 2:
                        if (Color.RgbCode.Equals(""))
                            Color.RgbCode = obj.HexToRgb(Color.HexCode);
                        Console.WriteLine($"RGB code is {Color.RgbCode}");
                        break;
                    case 3:
                        if (Color.R == 0)
                            obj.GetRedComponent(Color.HexCode);
                        Console.WriteLine($"Red Component is {Color.R}");
                            break;
                    case 4:
                        if (Color.G == 0)
                            obj.GetGreenComponent(Color.HexCode);
                        Console.WriteLine($"Green Component is {Color.G}");
                        break;
                    case 5:
                        if(Color.B == 0)
                            obj.GetBlueComponent(Color.HexCode);
                        Console.WriteLine($"Blue Component is {Color.B}");
                        break;
                    case 6:
                        string colorname = "";
                        if (Color.CommonColorName.TryGetValue(Color.HexCode.Trim(), out colorname))
                            Console.WriteLine($"The color name is {colorname}");
                        else
                            Console.WriteLine("Color name doesn't exist!");
                        break;
                    case 7: ModeInput = 1;
                            break;
                    case 8: choice = 1;
                            break;
                    default: Console.WriteLine("Invalid choice!");
                             break;

                }

            } while (choice != 1);

        }
    }
}
