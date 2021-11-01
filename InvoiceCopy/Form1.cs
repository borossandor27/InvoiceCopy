using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Specialized;
using System.IO;
using System.Xml;
using System.Xml.Schema;
using System.Timers;

namespace InvoiceCopy
{
    //-- https://onlineszamla.nav.gov.hu/dokumentaciok ---
    public partial class Form1 : Form
    {
        string path_FromSAP;
        string path_SAP_backup;
        string path_notValid;
        string path_pwc_upload;
        string prefix;
        int slice;
        string cPath = Directory.GetCurrentDirectory();
        XmlReaderSettings invoicesSettings = new XmlReaderSettings();

        int down = 0;
        int up = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ReadSettings();
            openFileDialog1.Filter = "xml fájlok|*.xml";
            string semaPath = "OSA Schemas_v3";
            invoicesSettings.Schemas.Add("http://schemas.nav.gov.hu/NTCA/1.0/common", Path.Combine(semaPath, "common.xsd"));
            invoicesSettings.Schemas.Add("http://schemas.nav.gov.hu/OSA/3.0/base", Path.Combine(semaPath, "invoiceBase.xsd"));
            invoicesSettings.Schemas.Add("http://schemas.nav.gov.hu/OSA/3.0/annul", Path.Combine(semaPath, "invoiceAnnulment.xsd"));
            invoicesSettings.Schemas.Add("http://schemas.nav.gov.hu/OSA/3.0/api", Path.Combine(semaPath, "invoiceApi.xsd"));
            invoicesSettings.Schemas.Add("http://schemas.nav.gov.hu/OSA/3.0/data", Path.Combine(semaPath, "invoiceData.xsd"));
            invoicesSettings.Schemas.Add("http://schemas.nav.gov.hu/OSA/3.0/metrics", Path.Combine(semaPath, "serviceMetrics.xsd"));
            invoicesSettings.ValidationType = ValidationType.Schema; invoicesSettings.ValidationType = ValidationType.Schema;
            invoicesSettings.ValidationEventHandler += new ValidationEventHandler(invoicesSettingsValidationEventHandler);
            SetTimer();
            dolgozik();
        }
        private void SetTimer()
        {
            // Create a timer with a interval.
            timer1.Interval = slice;
            // Hook up the Elapsed event for the timer. 
            timer1.Enabled = true;
        }
        private void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine("The Elapsed event was raised at {0:HH:mm:ss.fff}",
                              e.SignalTime);
        }
        private void invoicesSettingsValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                Console.Write("WARNING: ");
                Console.WriteLine(e.Message);
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                Console.Write("ERROR: ");
                Console.WriteLine(e.Message);
            }
        }
        private void ReadSettings()
        {
            try
            {
                path_FromSAP = ConfigurationManager.AppSettings.Get("input");
                string path = path_FromSAP;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                label_view_forras.Text = path;
                path_SAP_backup = ConfigurationManager.AppSettings.Get("input_mentes");
                path = path_SAP_backup;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                label_view_copyTo.Text = path;
                path_notValid = ConfigurationManager.AppSettings.Get("notvalid");
                path = path_notValid;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                label_view_err.Text = path;
                path_pwc_upload = ConfigurationManager.AppSettings.Get("output");
                path = path_pwc_upload;
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                label_view_upload.Text = path;
                prefix = ConfigurationManager.AppSettings.Get("prefix");
                slice = int.Parse(ConfigurationManager.AppSettings.Get("slice")) * 60 * 1000;
                label_view_log.Text = cPath;
            }
            catch (Exception)
            {

                MessageBox.Show("Helytelen paraméterek!", "Súlyos hiba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(0);
            }

        }
 
        private void button_Change_forras_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = cPath + "\\" + path_FromSAP;
            openFileDialog1.ShowDialog();
        }

        private void button_Change_Masolatok_helye_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = cPath + "\\" + path_SAP_backup;
            openFileDialog1.ShowDialog();

        }

        private void button_Change_upload_path_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = cPath + "\\" + path_pwc_upload;
            openFileDialog1.ShowDialog();

        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            dolgozik();
        }

        private void dolgozik()
        {
            fromDigitalStand();
            toPWC();
         }

        private void toPWC()
        {
            //-- Feltöltés a PWC-be
            foreach (string item in Directory.GetFiles(path_SAP_backup, prefix + "*.xml"))
            {
                FileInfo fajl = new FileInfo(item);
                //-- xml ellenőrzés
                XmlReader invoice = XmlReader.Create(item, invoicesSettings);
                try
                {
                    while (invoice.Read()) { }
                }
                catch (XmlException e)
                {
                    string err = $"{fajl.Name}: \t{e.Message}";
                    try
                    {
                        using (StreamWriter sw = new StreamWriter("NAV_validalas_err.log", true))
                        {
                            sw.WriteLine(err);
                        }
                    }
                    catch (IOException exc)
                    {
                        MessageBox.Show(exc.Message);
                    }
                    //-- bemásolom a hiba mappába
                    using (StreamReader reader = new StreamReader(item))
                    using (StreamWriter writer = new StreamWriter(Path.Combine(path_notValid, fajl.Name)))
                    {
                        writer.Write(reader.ReadToEnd());
                    }

                    //-- nem ment át a validáláson, a további műveleteket nem kell elvégezni!
                    continue;
                }
                //-- validálás sikeres, kezdődik a feltöltés
                using (StreamReader reader = new StreamReader(item))
                using (StreamWriter writer = new StreamWriter(Path.Combine(path_pwc_upload, fajl.Name)))
                {
                    writer.Write(reader.ReadToEnd());
                }
                label_counter_upload.Text = (++up).ToString("#,##0");
                //string logLine = $"{fajl.Name} - {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")} --- Forrás: {path_FromSAP}; Tárolva: {path_SAP_backup} ; Feltöltve: {path_pwc_upload}";
                string logLine = String.Join(";", fajl.Name, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"), path_FromSAP, path_SAP_backup, path_pwc_upload);
                using (StreamWriter sw = new StreamWriter("InvoicesCopy.log", true))
                {
                    sw.WriteLine(logLine);
                }
                File.Delete(Path.Combine(path_FromSAP, fajl.Name));
            }
        }

        private void fromDigitalStand()
        {
            //-- letöltés a DigitalStand SAP-ből
            foreach (string item in Directory.GetFiles(path_FromSAP, prefix + "*"))
            {
                FileInfo fajl = new FileInfo(item);
                using (StreamReader reader = new StreamReader(item))
                using (StreamWriter writer = new StreamWriter(Path.Combine(path_SAP_backup, fajl.Name)))
                {
                    writer.Write(reader.ReadToEnd());
                }
                label_counter_copy.Text = (++down).ToString("#,##0");
            }
        } //-- fromDigitalStand() vége

        void booksSettingsValidationEventHandler(object sender, ValidationEventArgs e)
        {
            if (e.Severity == XmlSeverityType.Warning)
            {
                Console.Write("WARNING: ");
                Console.WriteLine(e.Message);
            }
            else if (e.Severity == XmlSeverityType.Error)
            {
                Console.Write("ERROR: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
      

