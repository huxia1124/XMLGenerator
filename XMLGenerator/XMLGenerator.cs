using LinqToExcel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace XMLGenerator
{
    public partial class XMLGenerator : Form
    {
        public XMLGenerator()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            try
            {

                var excel = new ExcelQueryFactory(txData.Text);
                var data = from c in excel.WorksheetRange(txStart.Text, txEnd.Text, 0) //Selects data within the B3 to G10 cell range
                           select c;


                var sheetNames = excel.GetWorksheetNames();
                var colNames = excel.GetColumnNames(sheetNames.First());

                int i = 0;
                Dictionary<String, int> d = new Dictionary<string, int>();
                foreach (string name in colNames)
                {
                    d.Add(name, i++);
                }

                Directory.CreateDirectory(txOutDir.Text);

                i = 0;
                foreach (var val in data.ToList())
                {
                    lbStatus.Text = i.ToString();

                    XmlDocument doc = new XmlDocument();
                    doc.Load(txTemplate.Text);
                    XmlNode root = doc.DocumentElement;

                    foreach (var entry in d)
                    {
                        String queryXPath = String.Format("//*[text()=\"{0}\"]", entry.Key);
                        var nodes = root.SelectNodes(queryXPath);
                        if (nodes != null)
                        {
                            foreach (XmlNode node in nodes)
                            {
                                node.InnerText = val[entry.Value].ToString().Trim();
                            }        
                        }
                    }

                    doc.Save(txOutDir.Text.TrimEnd("\\".ToCharArray()) + "\\" + val[0].ToString().Trim() + ".xml");

                    i++;
                }

                lbStatus.Text = i + " Done!";
            }
            catch(Exception ex)
            {
                lbStatus.Text = ex.Message;
            }
        }
    }
}
