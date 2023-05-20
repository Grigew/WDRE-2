using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace RFDW
{
    static class Map
    {
        // ☺ & ■ .
        public static string[,,] map1 = {

              { { "■", "■", "■", "■", "■" },
                { "■", " ", "■", "■", "■" },
                { "■", " ", "■", "■", "■" },
                { "■", " ", "■", "■", "■" },
                { "■", "■", "■", "■", "■" } },
                                 
              { { "■", "■", "■", "■", "■" },
                { "■", ".", "@", ".", "■" },
                { "■", " ", "☺", "■", "■" },
                { "■", "&", " ", ".", "■" },
                { "■", "■", "■", "■", "■" } },

              { { "■", "■", "■", "■", "■" },
                { "■", "■", ".", "■", "■" },
                { "■", ".", " ", "■", "■" },
                { "■", ".", ".", "■", "■" },
                { "■", "■", "■", "■", "■" } }
        };

        public static void Build()
        {
            for (int l = map1.GetLowerBound(0); l <= map1.GetUpperBound(0); l++) // z-levels
            {
                for (int i = map1.GetLowerBound(1); i <= map1.GetUpperBound(1); i++) // cols
                {
                    for (int j = map1.GetLowerBound(2); j <= map1.GetUpperBound(2); j++) // rows
                    {
                        if (Map.map1[l, i, j] == "☺")
                        {
                            Game.player_id = Game.sbj.Count;
                            Game.sbj.Add(new Player(j, i, l));
                            Game.sbj[^1].art = "☺";
                            Game.camera_z = Game.sbj[^1].Z;
                        }
                        else if (Map.map1[l, i, j] == "&")
                        {
                            Game.enemy_id = Game.sbj.Count;
                            Game.sbj.Add(new Enemy(j, i, l));
                            Game.sbj[^1].art = "&";
                            //Game.sbj.Add(new Floor(j, i, l));
                        }
                        else if (Map.map1[l, i, j] == "■")
                        {
                            Game.sbj.Add(new Wall(j, i, l));
                            Game.sbj[^1].art = "■";

                            Game.sbj.Add(new Floor(j, i, l + 1));
                            Game.sbj[^1].art = ".";
                        }
                        else if (Map.map1[l, i, j] == ".")
                        {
                            Game.sbj.Add(new Floor(j, i, l));
                            Game.sbj[^1].art = ".";
                        }
                    }
                }
            }          
        }
        public static (string, string) Render()
        {
            //var layer = ("", "", "", "", "");
            StringBuilder output = new StringBuilder("");
            StringBuilder output2 = new StringBuilder("");

            for (int l = map1.GetLowerBound(0); l <= map1.GetUpperBound(0); l++)
            {
                for (int i = map1.GetLowerBound(1); i <= map1.GetUpperBound(1); i++)
                {
                    for (int j = map1.GetLowerBound(2); j <= map1.GetUpperBound(2); j++)
                    {
                        
                    }
                    output2.Append($"{map1[l, i, 2]} ");
                }
                output2.Append(Environment.NewLine);
            }

            //int i = Game.obj_h;

            // i - cols(y), j - rows(x), l - depth(z)
            for (int i = map1.GetLowerBound(1); i <= map1.GetUpperBound(1); i++)
            {
                for (int j = map1.GetLowerBound(2); j <= map1.GetUpperBound(2); j++)
                {
                    //Map.map1[Game.camera_z, i, j] = " ";
                    Map.map1[Game.camera_z, i, j] = " ";

                    for (int r = 0; r < Game.sbj.Count; r++)
                    {

                        var subject = Game.sbj[r];
                        if (subject == null) continue;

                        if (j == subject.X && i == subject.Y && Game.camera_z == subject.Z)
                        {
                            Map.map1[Game.camera_z, i, j] = subject.art;

                            //if (subject is Wall)
                            //{
                            //    layer[3, i, j] += subject.art + " ";
                            //}

                            //if (subject is Enemy)
                            //{
                            //    layer[1, i, j] += subject.art + " ";
                            //}
                        }
                    }
                    output.Append($"{map1[Game.camera_z, i, j]} ");
                    
                    //layer.Item1 += " ";
                    //layer.Item2 += " ";

                    //layer.Item4 += " ";
                    //layer.Item5 += " ";
                }
                output.Append(Environment.NewLine);
                
                
            }
            return (output.ToString(), output2.ToString());
            //return ;
        }
    }
}
