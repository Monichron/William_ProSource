using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProSource
{
    
    public partial class Form1 : Form
    {
        public string CustomConnection { get; set; }
        public string CustomConnectionTable { get; set; }
        public List<string> TextBoxInputs = new List<string>();
        public List<string> Responces = new List<string>();
        public string SaveLocation;
        int CurrentPosition = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (TextBoxRdo.Checked)
            {
                SaveText(Tb.Text);
                string text = Tb.Text;
                var Info =TextBoxSearch(text);
                VerifyAddresses(Info);
            }

            SaveText(Tb.Text);
        }

        private void VerifyAddresses(List<string> info)
        {
            for (int i = 0; i < info.Count/5; i++)
            {
                var client = new RestClient("https://dgsapi.prosource.co.za/api/AddressEngine/ScanAddress");
                var request = new RestRequest(Method.POST);
                request.AddHeader("Content-Type", "application/json");
                var body = @"{
" + "\n" +
                @"  ""vt"": """",
" + "\n" +
                $@"  ""licenseKey"": ""{ConfigurationManager.AppSettings["License"].ToString()}"",
" + "\n" +
                @"  ""languageRules"": 0,
" + "\n" +
                @"  ""characterCasingRuleSet"": 0,
" + "\n" +
                @"  ""outputCountry"": false,
" + "\n" +
                @"  ""validateOnly"": true,
" + "\n" +
                @"  ""useAbbreviations"": true,
" + "\n" +
                @"  ""returnNearestPostOffice"": false,
" + "\n" +
                @"  ""countryRuleSet"": 0,
" + "\n" +
                @"  ""providedLanguage"": 0,
" + "\n" +
                $@"  ""add1"": ""{info[i*5]}"",
" + "\n" +
                $@"  ""add2"": ""{info[i*5+1]}"",
" + "\n" +
                $@"  ""add3"": ""{info[i*5+2]}"",
" + "\n" +
                $@"  ""add4"": """",
" + "\n" +
                $@"  ""pCode"": ""{info[i*5+3]}"",
" + "\n" +
                $@"  ""town"": ""{info[i*5+4]}"",
" + "\n" +
                @"  ""municipality"": """",
" + "\n" +
                @"  ""province"": """",
" + "\n" +
                @"  ""country"": ""ZA""
" + "\n" +
                @"}";
                request.AddParameter("application/json", body, ParameterType.RequestBody);
                IRestResponse response = client.Execute(request);
                Responces.Add(response.Content);
                Tb.Text += response.Content;
                Tb.Text += "//n";
            }
            
        }

        private List<string> TextBoxSearch(string text)
        {
            var ArrayOfAdresses = text.Split('|');
            var ListofAdresses = ArrayOfAdresses.ToList<string>();
            for (int i = 0; i < ListofAdresses.Count; i++)
            {
                if (ListofAdresses[i].Contains("NULL"))
                {
                    ListofAdresses[i] = string.Empty;
                }
            }
            return ListofAdresses;
        }

        private void SqlRdo_CheckedChanged(object sender, EventArgs e)
        {
            if (SqlRdo.Checked)
            {
                bool Default = true;
                using (SqlForm form2 = new SqlForm())
                {
                    if (form2.ShowDialog() == DialogResult.OK)
                    {
                        CustomConnection = form2.Con;
                        CustomConnectionTable = form2.Table;
                    }

                    if (form2.Con != null)
                    {
                        CustomConnection = form2.Con;

                    }
                    Default = form2.IsDefault;


                }
                if (Default)
                {
                    SqlConnection con = new SqlConnection(ConfigurationManager.AppSettings["Con"].ToString());
                    con.Open();
                    DataTable Dt = new DataTable();
                    string strCmd = $@"Select * From {ConfigurationManager.AppSettings["Table"].ToString()}";
                    SqlCommand cmd = new SqlCommand(strCmd, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(Dt);
                    foreach (DataRow item in Dt.Rows)
                    {
                        for (int i = 0; i < Dt.Columns.Count; i++)
                        {
                            Tb.Text += item[i] + "|";
                        }
                    }
                    con.Close();
                }
                else
                {
                    SqlConnection con = new SqlConnection(@CustomConnection);
                    con.Open();
                    DataTable Dt = new DataTable();
                    string strCmd = $@"Select * From {CustomConnectionTable}";
                    SqlCommand cmd = new SqlCommand(strCmd, con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(Dt);
                    foreach (DataRow item in Dt.Rows)
                    {
                        for (int i = 0; i < Dt.Rows.Count; i++)
                        {
                            Tb.Text += item[i] + "|";
                        }
                    }
                    con.Close();
                }
            }

            SaveText(Tb.Text);
            
        }

        private void SaveText(string text)
        {
            TextBoxInputs.Add(Text);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
                    }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (PathCbox.Checked)
            {
                FolderBrowserDialog diag = new FolderBrowserDialog();
                if (diag.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string folder = diag.SelectedPath;
                    SaveLocation = folder;
                }

            }
        }

        private void FromDocRdo_CheckedChanged(object sender, EventArgs e)
        {
            string textFile = "";
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    textFile = dialog.FileName;
                    string text = File.ReadAllText(textFile);
                    Tb.Text = text;
                    SaveText(Tb.Text);
                }
            }
        }

        private void Tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
