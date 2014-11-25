using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

using System.IO;

using System.Net;

using System.Text.RegularExpressions;
using System.Threading;

using IADAL;
using mshtml;
using SubSonic.Query;
using System.Windows.Forms.DataVisualization;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;


namespace IACollector {
    public partial class Form2 : Form {

        public SortedDictionary<double, int> histogram;
        public Form f;
        public Form2() {
            InitializeComponent();
        }

       
        public void UpdateConrol( SortedDictionary<double, int> histogram,ArrayList key,ArrayList value,Form f,String graphLabel){
            this.histogram = histogram;
            this.f = f;
            label1.Text = graphLabel.ToUpper();
            //setting the width of columns

            chart1.ChartAreas["ChartArea1"].Area3DStyle.Enable3D = true;

            



            //this can be used to show the frequency values on top of the every bar
           // chart1.Series["Series1"].IsValueShownAsLabel = true;

            chart1.ChartAreas["ChartArea1"].BackColor = System.Drawing.Color.LightGray;
            
            //setting the colour of bars to red
            //chart1.Series["Series1"].Color = System.Drawing.Color.FromArgb(250, 0, 0);

             chart1.Series["Teesside University Analysis"].CustomProperties = "DrawingStyle = Cylinder,PixelPointWidth = 20";




            //setting the labell format
            chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0.00}";

            //setting the x-asis label interval
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;

            foreach (KeyValuePair<double, int> kvp in histogram) {
                this.chart1.Series["Teesside University Analysis"].Points.AddXY(kvp.Key, kvp.Value);
             }
            

            GenerateBarGraph("VisuaL Graphics @Raza Habib", key, value, 50, 25, 400);
             
        }


        public void GenerateBarGraph(string graphTitle, ArrayList xValues, ArrayList yValues, int barWidth, int barSpaceWidth, int graphHeight) {
            int graphTitleHeight = 20; // Height in pixels utilized by the title in the graph
            int itemsHeight = 35; // Height in pixels utilized by the items in the x-axis

            /*
            The Graph’s width is calculated by adding the width of a bar and the space between
            two bars multiplied by the total values in the x-axis plus the space between two bars
            */
            int graphWidth = (barWidth + barSpaceWidth) * xValues.Count + barSpaceWidth;

            /*
            The maximum height that a bar can attain needs to be found from the y-values passed
            as parameter
            */
            int maxBarHeight = 0;

            //Total height of the image is calculated
            int totalGraphHeight = graphHeight + graphTitleHeight + itemsHeight;

            //Create an instance of Bitmap class with the given width and height

            
            Bitmap barBitmap = new Bitmap(graphWidth, totalGraphHeight);

            /*
            Graphics class does not have a constructor and hence we call its static method
            FromImage and pass the Bitmap object to it
            */
            Graphics barGraphics = Graphics.FromImage(barBitmap);

            /*
            Using the Graphics object we fill the image of given dimensions with light gray color
            */

            barGraphics.FillRectangle(
            new SolidBrush(Color.WhiteSmoke),
            0,
            0,
            graphWidth,
            totalGraphHeight);

            /*
            create an instance of Font class available in System.Drawing. We will be using this
            to display the title of the graph.
            */
            Font titleFont = new Font("Verdana", 14, FontStyle.Bold);

            /*
            Graphics object’s DrawString method draws the title at the specified location
            */
            barGraphics.DrawString(
            graphTitle,
            titleFont,
            new SolidBrush(Color.Black),
            (graphWidth / 2) - graphTitle.Length * 5,
            totalGraphHeight - itemsHeight);

            //////////////Code to generate bars/////////////////

            /*
 Find the highest value in the yValues ArrayList and set it as the maximum height of the bar
 */
            foreach (int _value in yValues)
                if (_value > maxBarHeight) maxBarHeight = _value;

            //barXPos will store the x position of a bar
            int barXPos = barSpaceWidth;
            int barHeight;

            Font itemsFont = new Font("Verdana", 9, FontStyle.Bold);
            Font valuesFont = new Font("Verdana", 7, FontStyle.Italic);


            for (int i = 0;i<xValues.Count;i++){
                
                barHeight = ((((int)yValues[i] * 100 / maxBarHeight)) * graphHeight) / 100;

                //Draw the bar with the set brush, x and y positions, width and height
               
                barGraphics.FillRectangle( new SolidBrush(Color.Red), barXPos, graphHeight - barHeight,        barWidth,  barHeight);

                //Draw the x-value along the x-axis
               barGraphics.DrawString(  xValues[i].ToString(), itemsFont,new SolidBrush(Color.Red),barXPos,graphHeight);

                //Draw the respective y value on top of the bar
                barGraphics.DrawString(yValues[i].ToString(), valuesFont, new SolidBrush(Color.Red), barXPos,(graphHeight - barHeight) - itemsHeight);

                //Change the x position of the next bar
                barXPos += (barWidth + barSpaceWidth);
            }

            
            barBitmap.Save("D:\\bargraph.png", System.Drawing.Imaging.ImageFormat.Bmp);//, ImageFormat.Png);
            //Dispose off the Graphics and Bitmap objects
            barGraphics.Dispose();
            barBitmap.Dispose();


           
}

        private void button1_Click(object sender, EventArgs e) {
           
            f.TopMost = false;

            string path = "D:\\bargraph.png";
            Process p = new Process();
            p.StartInfo.FileName = "rundll32.exe";
            p.StartInfo.Arguments = @"C:\WINDOWS\System32\shimgvw.dll,ImageView_Fullscreen " + path;
            p.Start();   



        }

        private void button2_Click(object sender, EventArgs e) {

            f.TopMost = false;

            TextWriter tw = new StreamWriter(@"D:\Analysis.txt");
            foreach (KeyValuePair<double, int> pair in histogram) {
                tw.WriteLine("{0} occurred {1} times", pair.Key, pair.Value);
            }
            tw.Close();
            Process.Start(@"D:\Analysis.txt");

        }

        private void chart1_Click(object sender, EventArgs e) {

        }

     







    }
}
