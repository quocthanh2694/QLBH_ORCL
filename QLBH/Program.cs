using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.LookAndFeel;
using System.IO;

namespace QLBH
{
    static class Program //: DevExpress.XtraBars.Ribbon.RibbonForm
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            DevExpress.Skins.SkinManager.EnableFormSkins();
          
            DevExpress.UserSkins.BonusSkins.Register();
            //defaultLookAndFeel2.LookAndFeel.SkinName = "Office 2010 Blue";
            //DevExpress.UserSkins.OfficeSkins.
            // DevExpress.Skins.SkinManager.EnableFormSkins();

            //string fileName = Application.StartupPath + "\\Skins.txt";

            //if (File.Exists(fileName) == false)
            //    UserLookAndFeel.Default.SetSkinStyle("Office 2010 Blue");
            //else
            //{
            //    StreamReader sr = new StreamReader(fileName, false);
            //    UserLookAndFeel.Default.SetSkinStyle(sr.ReadLine());
            //    sr.Close();
            //}
           
            Formsss.Login lg = new Formsss.Login();
            Application.Run(lg);
           
           
            if (lg.ktra == true)
                Application.Run(new MainForm());



            
            
        }
    }
}
