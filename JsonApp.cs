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

                output.Clear();
                jsonTreeView.Nodes.Clear();
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
        private void ResetButton_Click(object sender, EventArgs e)
        {
            output.Text = string.Empty;
            inputJson.Text = string.Empty;
            jsonTreeView.Nodes.Clear();
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
        private void ValidateJson(string inputJson)
        {
            output.Clear();
            jsonTreeView.Nodes.Clear();

            try
            {
                // Check JSON syntax
                JToken jsonToken = JToken.Parse(inputJson);

                PrintOutput("JSON syntax is valid.");

                // Build JSON hierarchy
                TreeNode rootNode = jsonTreeView.Nodes.Add("JSON");

                PopulateTreeView(jsonToken, rootNode);

                rootNode.ExpandAll();

                // Validate against Agents schema if checkbox is checked
                if (validateAgentsCheckBox.Checked)
                {
                    JSchemaGenerator generator = new JSchemaGenerator();
                    JSchema schema = generator.Generate(typeof(Agents));

                    IList<string> validationMessages = new List<string>();

                    if (jsonToken.IsValid(schema, out validationMessages))
                    {
                        PrintOutput("JSON matches Agents schema.");
                    }
                    else
                    {
                        foreach (string message in validationMessages)
                        {
                            PrintOutput(message);
                        }

                        PrintOutput("JSON does NOT match Agents schema.");
                    }
                }
            }
            catch (JsonReaderException e)
            {
                jsonTreeView.Nodes.Clear();

                PrintOutput("JSON syntax is NOT valid.");
                PrintOutput("Found a problem: " + e.Message);
            }
            catch (Exception e)
            {
                PrintOutput("Found a problem: " + e.Message);
            }
        }
        private void PopulateTreeView(JToken token, TreeNode parentNode)
        {
            if (token is JObject jsonObject)
            {
                parentNode.Text += " {}";
                foreach (JProperty property in jsonObject.Properties())
                {
                    TreeNode propertyNode = parentNode.Nodes.Add(property.Name);
                    PopulateTreeView(property.Value, propertyNode);
                }
            }
            else if (token is JArray jsonArray)
            {
                parentNode.Text += $" [{jsonArray.Count}]";
                for (int i = 0; i < jsonArray.Count; i++)
                {
                    TreeNode arrayNode = parentNode.Nodes.Add($"[{i}]");
                    PopulateTreeView(jsonArray[i], arrayNode);
                }
            }
            else
            {
                parentNode.Text += ": " + token.ToString(Formatting.None);
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

