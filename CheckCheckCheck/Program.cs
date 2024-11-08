using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace checkcheck
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string checkfor(string[,] x, string b, string[] c, int d, bool e)
            {
                int count1 = 0;
                string xcord = b.Substring(0, 1);
                string ycord = b.Substring(1, 1);
                int y = Convert.ToInt32(ycord);
                int correlates = Array.IndexOf(c, xcord);
                correlates++;
                bool foundcheck = false;
                for (int i = 0; i < d; i++)

                {

                    if (x[0, i] == "bishop")

                    {

                        string xc = x[1, i].Substring(0, 1);
                        string yc = x[1, i].Substring(1, 1);
                        int tempx = Array.IndexOf(c, xc);
                        int storagex = tempx;
                        bool checkedposright = false;
                        bool checknegright = false;
                        bool checkedposleft = false;
                        bool checkednegleft = false;
                        int counter = 0;

                        int tempy = Convert.ToInt32(yc);
                        int storagey = tempy;
                        string[] coords = new string[d];
                        for (int j = 0; j < d; j++)
                        {
                            coords[j] = x[1, j];


                        }



                        //Now checking begins: remember to add while loop.
                        while (e == false)
                        {


                            while (checkedposright == false)
                            {
                                tempx++;
                                tempy++;
                                Console.WriteLine(tempx);
                                if (tempx == 8)
                                {
                                    checkedposright = true;
                                    tempx = tempx - 1;
                                
                                
                                }
                                
                                counter++;
                                string ccordletter = c[tempx];

                                string ycordnum = tempy.ToString();

                                string total = ccordletter + ycordnum;
                                bool notcheck = true;

                                Console.WriteLine(total);
                                if (Array.IndexOf(coords, total) > 0)
                                {
                                    Console.WriteLine("the bishop is not causing a check since there is another peice in the way.");
                                    notcheck = true;
                                    e = true;
                                    checkedposright = true;




                                }
                                else if (total == b && notcheck == true)
                                {
                                    Console.WriteLine("the bishop at " + x[1, i] + " is causing check on your king");
                                    e = true;
                                    checkedposright = true;
                                    foundcheck = true;



                                }
                                else if (tempy == 8 || tempx == 8)
                                {
                                    checkedposright = true;
                                    Console.WriteLine("checked right hand side up");

                                }
                                else if (total.Substring(0,1) == "h")
                                {

                                    checkedposright = true;
                                
                                }



                            }
                            Console.WriteLine("first loop broken");
                            tempx = storagex;
                            tempy = storagey;

                            while (checknegright == false)
                            {


                                tempx++;
                                tempy = tempy - 1;
                                if (tempx == 8)
                                {
                                    checknegright = true;
                                    tempx = tempx - 1;
                                
                                
                                }

                                string ccordletter = c[tempx];

                                string ycordnum = tempy.ToString();

                                string total = ccordletter + ycordnum;
                                bool notcheck = true;

                                Console.WriteLine(total);
                                if (Array.IndexOf(coords, total) > 0)
                                {
                                    Console.WriteLine("the bishop is not causing a check since there is another peice in the way.");
                                    notcheck = true;
                                    e = true;
                                    checknegright = true;




                                }
                                else if (total == b && notcheck == true)
                                {
                                    Console.WriteLine("the bishop at " + x[1, i] + " is causing check on your king");
                                    e = true;
                                    notcheck = false;

                                    checknegright = true;



                                }
                                else
                                {

                                    if (tempy == 8 || tempy < 0 || tempx == 8)
                                    {
                                        checknegright = true;


                                    }

                                }












                            }
                            Console.WriteLine("second loop broken");
                            tempx = storagex;
                            tempy = storagey;
                            while (checkedposleft == false)
                            {
                                tempx = tempx - 1;
                                tempy++;

                                string ccordletter = c[tempx];
                                if (tempx == 0)
                                {
                                    checkedposleft = true;
                                    tempx++;
                                
                                
                                }
                                string ycordnum = tempy.ToString();

                                string total = ccordletter + ycordnum;
                                bool notcheck = true;

                                Console.WriteLine(total);
                                if (Array.IndexOf(coords, total) > 0)
                                {
                                    Console.WriteLine("the bishop is not causing a check since there is another peice in the way.");
                                    notcheck = true;
                                    e = true;
                                    checkedposleft = true;




                                }
                                else if (total == b && notcheck == true)
                                {
                                    Console.WriteLine("the bishop at " + x[1, i] + " is causing check on your king");
                                    e = true;
                                    notcheck = false;

                                    checkedposleft = true;



                                }
                                else
                                {

                                    if (tempy == 8 && tempx == 8)
                                    {
                                        checkedposleft = true;


                                    }

                                }
                             
                                



            



                            }
                            Console.WriteLine("third loop broken");
                            tempx = storagex;
                            tempy = storagey;


                            while (checkednegleft == false) 
                            {
                                tempx = tempx - 1;
                                tempy= tempy-1;

                                string ccordletter = c[tempx];

                                string ycordnum = tempy.ToString();

                                string total = ccordletter + ycordnum;
                                bool notcheck = true;

                                Console.WriteLine(total);
                                if (Array.IndexOf(coords, total) > 0)
                                {
                                    Console.WriteLine("the bishop is not causing a check since there is another peice in the way.");
                                    notcheck = true;
                                    e = true;
                                    checkednegleft = true;




                                }
                                else if (total == b && notcheck == true)
                                {
                                    Console.WriteLine("the bishop at " + x[1, i] + " is causing check on your king");
                                    e = true;
                                    notcheck = false;

                                    checkednegleft = true;



                                }
                                else
                                {

                                    if (tempy == 8 && tempx == 8)
                                    {
                                        checkednegleft = true;


                                    }

                                }

                            }










                        }




                    }
                    if (x[0, i] == "rook")
                    {
                        bool ee = false;
                        bool checkup = false;
                        bool checkdown = false;
                        bool checkleft = false;
                        bool checkright = false;
                        string xc = x[1, i].Substring(0, 1);
                        string yc = x[1, i].Substring(1, 1);
                        int tempx = Array.IndexOf(c, xc);
                        int storagex = tempx;


                        int tempy = Convert.ToInt32(yc);
                        int storagey = tempy;
                        string[] coords = new string[d];
                        for (int j = 0; j < d; j++)
                        {
                            coords[j] = x[1, j];


                        }
                        while (ee == false)
                        {
                            while (checkup == false)
                            {
                                tempy = tempy + 1;
                                string newcord = xc + tempy.ToString();

                                if (Array.IndexOf(coords, newcord) >= 0)
                                {
                                    Console.WriteLine("there is something between the rook and the king");


                                }
                                else if (newcord == b)
                                {
                                    string output = $"the rook at{x[1, i]} is causing check on your king";
                                    Console.WriteLine(output);
                                    checkup = true;
                                    ee = true;



                                }
                                else if (tempy > 8)
                                {
                                    checkup = true;
                                
                                
                                }



                            }
                            
                            tempx = storagex;
                            tempy = storagey;
                            while (checkdown == false)
                            {
                                tempy = tempy -1;
                                
                                string newcord = xc + tempy.ToString();
                                if (Array.IndexOf(coords, newcord) >= 0)
                                {
                                    Console.WriteLine("there is something between the rook and the king");
                                    checkdown = true;




                                }
                                else if (newcord == b)
                                {
                                    string output = $"the rook at{x[1, i]} is causing check on your king";
                                    Console.WriteLine(output);
                                    checkdown = true;
                                    ee = true;



                                }
                                else if (tempy < 0)
                                { 
                                    checkdown = true;
                                
                                
                                
                                }


                            }
                            Console.WriteLine("leaves loop 2");
                            tempx = storagex;
                            tempy = storagey;

                            while (checkright == false)
                            {
                                tempx++;
                                
                                
                                if (tempx == 8)
                                {
                                    checkright = true;
                                    tempx = tempx - 1;
                                
                                
                                }
                                string letter = c[tempx];
                                string newcord = letter + yc;
                                
                                if (Array.IndexOf(coords, newcord) >= 0)
                                {
                                    Console.WriteLine("there is something between the rook and the king");




                                }
                                else if (newcord == b)
                                {
                                    string output = $"the rook at{x[1, i]} is causing check on your king";
                                    Console.WriteLine(output);
                                    checkright = true;
                                    ee = true;



                                }
                                else if (tempx > 8)
                                {
                                    checkright = true;
                                
                                
                                
                                }




                            }
                            while (checkleft == false)
                            {
                                tempx = tempx -1;

                                string letter = c[tempx];
                                if (tempx == 0)
                                {
                                    checkleft = true;
                                    tempx = tempx + 1;


                                }
                                string newcord = letter + yc;

                                if (Array.IndexOf(coords, newcord) >= 0)
                                {
                                    Console.WriteLine("there is something between the rook and the king");
                                    Console.WriteLine("left");




                                }
                                else if (newcord == b)
                                {
                                    string output = $"the rook at {x[1, i]} is causing check on your king";
                                    
                                    Console.WriteLine(output);
                                    checkleft = true;
                                    ee = true;



                                }
                                else if (tempx > 8)
                                {
                                    checkleft = true;



                                }


                            }




                        }
                    
                    
                    }
                    if (x[0, i] == "knight")
                    {
                        string xc = x[1, i].Substring(0, 1);
                        string yc = x[1, i].Substring(1, 1);
                        int tempx = Array.IndexOf(c, xc);
                        int storagex = tempx;
                        bool checkleft = false;



                        int tempy = Convert.ToInt32(yc);
                        int storagey = tempy;
                        string[] coords = new string[d];
                        for (int j = 0; j < d; j++)
                        {
                            coords[j] = x[1, j];


                        }
                        while (checkleft == false)
                        {
                            tempx = tempx + 2;
                            tempy++;
                            string newcord = c[tempx] + tempy.ToString();
                            if (newcord == b)
                            {
                                string output = $"the knight at{x[1, i]} is causing check on your king";
                                Console.WriteLine(output);
                                checkleft = true;




                            }
                            else
                            {
                                tempx = tempx - 1;
                                tempy++;
                                 newcord = c[tempx] + tempy.ToString();
                                if (newcord == b)
                                {
                                    string output = $"the knight at{x[1, i]} is causing check on your king";
                                    Console.WriteLine(output);
                                    checkleft = true;




                                }
                                




                            }
                           
                        
                        
                        }
                        



                    }



                }
                



                return null;


            }









            bool check = false;
            string[] letters = { "a", "b", "c", "d", "e", "f", "g", "h" };
            Console.WriteLine("What is the coordinate of your king?");
            string king = Console.ReadLine();
            string[,] peices = new string[8, 8];
            int count = 0;
            int amt = 0;
            string cont = "true";
            while (cont == "true")
            {
                Console.WriteLine("enter a peice");
                string inp = Console.ReadLine();
                peices[0, count] = inp;
                count++;
                amt++;
                Console.WriteLine("more peices?");
                cont = Console.ReadLine();





            }
            cont = "true";
            count = 0;
            for (int x = 0; x < amt; x++)
            {
                Console.WriteLine("enter the coordinate for the peice: " + peices[0, x]);
                string inp = Console.ReadLine();
                peices[1, x] = inp;








            }

            checkfor(peices, king, letters, amt, check);









            Console.ReadKey();

        }
    }
}
