using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IADAL;
using System.IO;
using SubSonic.Repository;

namespace IACollector
{
    public static class Common
    {
        public static Form1 MainForm { get; set; }
        public static List<AllPages> LocalPages { get; set; }
        public static List<WebPage> WebQueue { get; set; }
        private static CollectionWorker currSearch;

        public static bool debugOutToFile = true;
        public static int tabs = 0;
        public static bool debugOut { get; set; }



        public static List<LinkWithoutHeading> AllLinkWithoutHeading;
        public static List<LinkWithHeading> AllLinkWithHeading;
        public static List<Heading> AllHeading;
        public static List<AnImage> AllImage;
        public static List<AnImageWithoutHeading> AllImageWithoutHeading;
        public static List<WebPage> AllWebPages;
        public static List<Paragraph> AllParas;
        public static List<TemplateOfLink> AllTemplateOfLink;
        
        
        
        public static void StartSearching(string url, List<WebPage> InWebQueue)
        {
            AllPages allp1 = new AllPages();
         //  AllPages allp2 = new AllPages();
        //   	AllPages allp3 = new AllPages();
       //  	AllPages allp4 = new AllPages();
       //  	AllPages allp5 = new AllPages();
            //  AllPages allp6 = new AllPages();
            //  AllPages allp7 = new AllPages();
            //  AllPages allp8 = new AllPages();
            //  AllPages allp9 = new AllPages();


            Common.LocalPages = new List<AllPages>();
            Common.WebQueue = InWebQueue;
            Common.LocalPages.Add(allp1);
      //     Common.LocalPages.Add(allp2);
    //      Common.LocalPages.Add(allp3);
    //    		Common.LocalPages.Add(allp4);
    //     		Common.LocalPages.Add(allp5);
            //  Common.LocalPages.Add(allp6);
            //  Common.LocalPages.Add(allp7);
            //  Common.LocalPages.Add(allp8);
            //  Common.LocalPages.Add(allp9);



            allp1.Show();
       //    allp2.Show();
         ///	allp3.Show();
       //		allp4.Show();
       //			allp5.Show();
            // allp6.Show();
            //  allp7.Show();
            //  allp8.Show();
            //  allp9.Show();


            if (url == "")
            {
                url = WebQueue[0].Url;
            }

        }

        public static void DoNextSearch()
        {


            for (int i = 0; i < Common.LocalPages.Count; i++)
            {
                if (Common.LocalPages[i].Finished)
                {

                    Common.LocalPages[i].setLinkValue(Common.WebQueue[0].Url, Common.WebQueue[0].WebPageId, "C://AliTeesInternetWebpages/" + Common.WebQueue[0].WebPageId + ".html");
                    Common.WebQueue.RemoveAt(0);




                }
            }
        }


        public static bool DebugOutToFile
        {

            get { return Common.debugOutToFile; }

            set
            {

                tabs = -1;

                debugOutToFile = value && !debugOut;

            }

        }



        public static bool DebugOut
        {

            get { return debugOut; }

            set
            {

                tabs = -1;

                debugOut = value;

            }

        }

        private static DateTime lastnow = DateTime.Now;

        private static DateTime startnow = DateTime.Now;

        public static void Status(string sin)
        {

            if ((!debugOut) && (!debugOutToFile)) return;

            string sout = "";

            if (sin == "start")
            {

                lastnow = DateTime.Now;

                startnow = lastnow;

                return;

            }

            else if (sin == "end")
            {

                sout = "Finished at " + DateTime.Now + " " + DateTime.Now.Subtract(startnow);

            }

            else
            {

                if (sin.IndexOf("in") == 0)
                {

                    tabs++;

                }

                DateTime now = DateTime.Now;

                int mm = now.Millisecond;

                string smm = mm.ToString();

                if (smm.Length <= 2)
                {

                    smm = "0" + smm;

                }

                if (smm.Length <= 2)
                {

                    smm = "0" + smm;

                }

                if (now.Subtract(lastnow).Seconds > 0)
                {

                    sout += "**** ";

                }

                sout += now.ToLongTimeString() + ":" + smm;

                mm = now.Subtract(lastnow).Milliseconds;

                smm = mm.ToString();

                if (smm.Length <= 2)
                {

                    smm = "0" + smm;

                }

                if (smm.Length <= 2)
                {

                    smm = "0" + smm;

                }

                sout += " (" + now.Subtract(lastnow).Seconds + ":" + smm + ")";

                for (int n = 0; n < tabs; n++)
                {

                    sout += "  ";

                }

                sout += "  " + sin;

                if (sin.IndexOf("out") == 0)
                {

                    tabs--;

                }

                lastnow = now;

            }

            if (debugOutToFile)
            {

                StreamWriter SW;

                SW = File.AppendText("C:\\log.txt");

                SW.WriteLine(sout);

                SW.Close();

            }

            else
            {

                Console.WriteLine(sout);

            }

        }


        public static void CacheData()
        {
            AllWebPages = WebPage.All().ToList();
            AllParas = Paragraph.All().ToList();
            AllHeading = Heading.All().ToList();
            AllImage = AnImage.All().ToList();
            AllLinkWithoutHeading = LinkWithoutHeading.All().ToList();
            AllLinkWithHeading = LinkWithHeading.All().ToList();
          //  AllTemplateOfLink = TemplateOfLink.All().ToList();
            AllImageWithoutHeading = AnImageWithoutHeading.All().ToList();
        }
        
        public static void SaveCache()
        {
            return; // not needed any more as always saving
            Common.Status("In Cache");
            Common.Status("start");
            //WebPage.Delete(x => x.WebPageId > 0);
            //Paragraph.Delete(x => x.ParaId > 0);
            //Heading.Delete(x => x.HeadingId > 0);
            //AnImage.Delete(x => x.ImgId > 0);
            //LinkWithoutHeading.Delete(x => x.LinkId > 0);
            //LinkWithHeading.Delete(x => x.LinkId > 0);
            SubSonicRepository<WebPage> rep = new SubSonicRepository<WebPage>(new InfoArchDB());
            var wps = AllWebPages.FindAll(x => x.IsNew()).ToList();
            if (wps.Count > 0)
            {
                rep.Add(wps);
            }
            SubSonicRepository<Paragraph> repo = new SubSonicRepository<Paragraph>(new InfoArchDB());
            var pas = AllParas.FindAll(x => x.IsNew()).ToList();
            if (pas.Count > 2100)
            {
                var pas2 = pas.Take(2000);
                var pas3 = pas.Skip(2000);
                repo.Add(pas2);
                repo.Add(pas3);
            }
            else if (pas.Count > 0)
            {
                repo.Add(pas);
            }
            SubSonicRepository<LinkWithoutHeading> repo2 = new SubSonicRepository<LinkWithoutHeading>(new InfoArchDB());
            var l1s = AllLinkWithoutHeading.FindAll(x => x.IsNew()).ToList();
            if (l1s.Count > 2100)
            {
                repo2.Add(l1s.Take(2100));
                repo2.Add(l1s.Skip(2100));
            }
            else if (l1s.Count > 0)
            {
                repo2.Add(l1s);
            }
            SubSonicRepository<LinkWithHeading> repo3 = new SubSonicRepository<LinkWithHeading>(new InfoArchDB());
            var l2s = AllLinkWithHeading.FindAll(x => x.IsNew()).ToList();
            if (l2s.Count > 0)
            {
                repo3.Add(l2s);
            }
            SubSonicRepository<Heading> repo4 = new SubSonicRepository<Heading>(new InfoArchDB());
            var hs = AllHeading.FindAll(x => x.IsNew()).ToList();
            if (hs.Count > 0)
            {
                repo4.Add(hs);
            }
            SubSonicRepository<AnImage> repo5 = new SubSonicRepository<AnImage>(new InfoArchDB());
            var iss = AllImage.FindAll(x => x.IsNew()).ToList();
            if (iss.Count > 0)
            {
                repo5.Add(iss);
            }
            Common.Status("end");
        }




    }
}

