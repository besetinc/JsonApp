using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Newtonsoft.Json.Schema.Generation;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace JsonApp
{
    public partial class JsonApp : Form
    {
        public JsonApp()
        {
            InitializeComponent();
        }
        private void OpenFileButton_Click(object sender, EventArgs e)
        {
            OpenJsonFile();
        }
        private void OpenJsonFile()
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "JSON Source File|*.json"
            };
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                var sr = new StreamReader(ofd.FileName);
                var myJson = sr.ReadToEnd();
                inputJson.Text = myJson;
            }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
            inputJson.Text = string.Empty;
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            if (inputJson.Text != "")
            {
                ValidateJson(inputJson.Text);
            }
            else
            {
                PrintOutput("There is no .json file to validate. Please provide the file.");
            }
        }
        private void PrintOutput(string outputStr)
        {
            try
            {
                System.Diagnostics.Debug.WriteLine(outputStr);
                output.Text = output.Text + outputStr + Environment.NewLine;
                output.SelectionStart = output.TextLength;
            }
            catch (Exception e)
            {
                System.Diagnostics.Debug.WriteLine(e.Message.ToString());
            }
        }
        private void ValidateJson(string inputJson)
        {
            try
            {
                JObject jsonObject = JObject.Parse(inputJson);
                PrintOutput(jsonObject.ToString());
                JSchemaGenerator generator = new JSchemaGenerator();
                JSchema schema = generator.Generate(typeof(Agents));
                IList<string> validationMessages = new List<string>();
                if (jsonObject.IsValid(schema, out validationMessages))
                {
                    PrintOutput("Json is valid.");
                }
                else
                {
                    foreach (string message in validationMessages)
                    {
                        PrintOutput(message);
                    }
                    PrintOutput("JSON is NOT valid.");
                }
            }
            catch (Exception e)
            {
                PrintOutput("Found a problem: " + e.Message.ToString());
            }
        }
        public class Agents
        {
            [JsonProperty("machineName")]
            public string Name { get; set; }
            [JsonProperty("machineNumber")]
            public int Number { get; set; }
            [JsonProperty("isOnline")]
            public bool Online { get; set; }
            [JsonProperty("isReserved")]
            public bool Reserved { get; set; }
            [JsonProperty("isReservedBy")]
            public string ReservedBy { get; set; }
        }
    }
}

