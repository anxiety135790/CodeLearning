using System;

enmu LightColor

    {

        Red,
        Yellow,
        Green

    }


class TrafficLight

    {
        public static void WhatInfo(LightColor color){

            switch(color){

                case LightColor.Red:
                    Console.WriteLine("Stop!");
                    break;

                case LightColor.Yellow:
                    Console.WriteLine("Waiting!");
                    break;

                case LightColor.Green:
                    Console.WriteLine("GO!");
                    break;

                default:
                    break;
            }
        }
    }

class Test
    {
        static void Main()

            {
                LightColor c = LightColor.Red;

                Console.WriteLine(c.ToString());
                Conso


            }

    }
