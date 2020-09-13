﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Examination_2
{
    /// <summary>
    /// Options the user chooses between.
    /// </summary>
    enum Options { Indefinite, TwoD, ThreeD };

    /// <summary>
    /// The appliccation gives the user the opportunity to choose between 2D and 3D shapes
    /// and presents the chosen shape in a table with randomly chosen shapes and numbers.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Starts the application.
        /// </summary>
        static void Main(string[] args)
        {
            try
            {
                StartApp();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        /// <summary>
        /// Checks what shapes the user wants to see.
        /// </summary>
        public static void StartApp()
        {
            bool exit = false;
            Options type = Options.Indefinite;
            List<string> shapes;
            bool is3D;

           do
           {
               switch (MenuChoices())
                {
                    case 0:
                        exit = true;
                        break;

                    case 1:
                        type = Options.TwoD;
                        break;

                    case 2:
                        type = Options.ThreeD;
                        break;
                }
                Console.Clear();
              
                if (type == Options.ThreeD)
                {
                    is3D = true;
                    shapes = ShapeLists(is3D);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("| Shape     | Length | Width | Height | Mantel area | Total surface area | Volume  |");
                    Console.ResetColor();
                    foreach (var i in shapes)
                    {
                        Console.WriteLine(i);
                    } 
                }
                else if (type == Options.TwoD)
                {
                    is3D = false;
                    shapes = ShapeLists(is3D);
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine("| Shape     | Length | Width | Perimeter | Area   |");
                    Console.ResetColor();
                    foreach (var i in shapes)
                    {
                        Console.WriteLine(i);
                    }
                }

                ContinueOnKeyPressed();
            } while (!exit);
        }

        /// <summary>
        /// Displays a menu with options.
        /// </summary>
        private static int MenuChoices()
        {
            int index;

            do
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine("\n ═══════════════════════════════════════════\n");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("\n ----- Choose shape to view -----\n");
                Console.WriteLine(" 1. 2D");
                Console.WriteLine(" 2. 3D");
                Console.WriteLine("\n ═══════════════════════════════════════════\n");
                Console.Write("Menu choise [0-2]: ");
                Console.ResetColor();

                if (int.TryParse(Console.ReadLine(), out index) && index >= 0 && index <= 2)
                {
                    return index;
                }
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Not a valid menu option");
                Console.ResetColor();
                ContinueOnKeyPressed();
            } while (true);
        }

        /// <summary>
        /// Reads user key press.
        /// </summary>
        private static void ContinueOnKeyPressed()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("\n   Press any key to continue   ");
            Console.ResetColor();
            Console.CursorVisible = false;
            Console.ReadKey(true);
            Console.Clear();
            Console.CursorVisible = true;
        }

        /// <summary>
        /// Returns a list with shapes.
        /// </summary>
         private static List<string> ShapeLists(bool is3D)
        {
            RandomClass random = new RandomClass();

            List<Shape2D> shapes2d = new List<Shape2D>();
            List<Shape3D> shapes3d = new List<Shape3D>();
            List<string> shapes = new List<string>();
            Shape2D shape2d;
            Shape3D shape3d;
            ShapeType shapeType;

            int min = 1;
            int max = 50;

            Random r = new Random();
            int randomNumber = r.Next(5, 16);

            for (int i = 0; i < randomNumber; i++)
            {
                shapeType = (ShapeType)random.RandomShape(is3D);

                 if (shapeType == ShapeType.Cuboid)
                {
                    shape3d = new Cuboid(random.RandomNumberShapes(min, max), random.RandomNumberShapes(min, max), random.RandomNumberShapes(min, max));
                    shapes3d.Add(shape3d);
                }
                else if (shapeType == ShapeType.Cylinder)
                {
                    shape3d = new Cylinder(random.RandomNumberShapes(min, max), random.RandomNumberShapes(min, max), random.RandomNumberShapes(min, max));
                    shapes3d.Add(shape3d); 
                }
                else if (shapeType == ShapeType.Sphere)
                {
                    shape3d = new Sphere(random.RandomNumberShapes(min, max));
                    shapes3d.Add(shape3d);  
                }
                else if (shapeType == ShapeType.Ellipse)
                {
                    shape2d = new Ellipse(random.RandomNumberShapes(min, max), random.RandomNumberShapes(min, max));
                    shapes2d.Add(shape2d);
                }
                else if (shapeType == ShapeType.Rectangle)
                {
                    shape2d = new Rectangle(random.RandomNumberShapes(min, max), random.RandomNumberShapes(min, max));
                    shapes2d.Add(shape2d); 
                }
            }

            if (is3D)
            {
                shapes3d = shapes3d.OrderBy(x => x.ShapeType)
                                    .ThenBy(x => x.Volume)
                                    .ToList();
                foreach (var i in shapes3d)
                {
                    shapes.Add(i.ToString("R"));
                }
            }
            else
            {
                shapes2d = shapes2d.OrderBy(x => x.ShapeType)
                                    .ThenBy(x => x.Area)
                                    .ToList();
                foreach (var i in shapes2d)
                {
                    shapes.Add(i.ToString("R"));
                }
            }

            return shapes;
        }
    }
}
