namespace JsonApp
{
    partial class JsonApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new System.Windows.Forms.GroupBox();
            inputJson = new System.Windows.Forms.TextBox();
            validateButton = new System.Windows.Forms.Button();
            resetButton = new System.Windows.Forms.Button();
            groupBox2 = new System.Windows.Forms.GroupBox();
            label1 = new System.Windows.Forms.Label();
            this.jsonTreeView = new System.Windows.Forms.TreeView();
            output = new System.Windows.Forms.TextBox();
            openFileButton = new System.Windows.Forms.Button();
            validateAgentsCheckBox = new System.Windows.Forms.CheckBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(inputJson);
            groupBox1.Location = new System.Drawing.Point(15, 10);
            groupBox1.Margin = new System.Windows.Forms.Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new System.Windows.Forms.Padding(2);
            groupBox1.Size = new System.Drawing.Size(850, 290);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Input";
            // 
            // inputJson
            // 
            inputJson.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            inputJson.Location = new System.Drawing.Point(17, 24);
            inputJson.Margin = new System.Windows.Forms.Padding(2);
            inputJson.Multiline = true;
            inputJson.Name = "inputJson";
            inputJson.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            inputJson.Size = new System.Drawing.Size(808, 230);
            inputJson.TabIndex = 0;
            // 
            // validateButton
            // 
            validateButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            validateButton.Location = new System.Drawing.Point(696, 305);
            validateButton.Margin = new System.Windows.Forms.Padding(2);
            validateButton.Name = "validateButton";
            validateButton.Size = new System.Drawing.Size(83, 56);
            validateButton.TabIndex = 1;
            validateButton.Text = "Validate";
            validateButton.UseVisualStyleBackColor = true;
            validateButton.Click += ValidateButton_Click;
            // 
            // resetButton
            // 
            resetButton.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            resetButton.Location = new System.Drawing.Point(783, 305);
            resetButton.Margin = new System.Windows.Forms.Padding(2);
            resetButton.Name = "resetButton";
            resetButton.Size = new System.Drawing.Size(82, 56);
            resetButton.TabIndex = 2;
            resetButton.Text = "Reset";
            resetButton.UseVisualStyleBackColor = true;
            resetButton.Click += ResetButton_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(this.jsonTreeView);
            groupBox2.Controls.Add(output);
            groupBox2.Location = new System.Drawing.Point(15, 426);
            groupBox2.Margin = new System.Windows.Forms.Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(2);
            groupBox2.Size = new System.Drawing.Size(850, 371);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Output";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(17, 112);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(108, 20);
            label1.TabIndex = 2;
            label1.Text = "JSON hierarchy";
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Location = new System.Drawing.Point(17, 135);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.Size = new System.Drawing.Size(808, 182);
            this.jsonTreeView.TabIndex = 1;
            // 
            // output
            // 
            output.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            output.Location = new System.Drawing.Point(17, 41);
            output.Margin = new System.Windows.Forms.Padding(2);
            output.Multiline = true;
            output.Name = "output";
            output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            output.Size = new System.Drawing.Size(808, 52);
            output.TabIndex = 0;
            // 
            // openFileButton
            // 
            openFileButton.Location = new System.Drawing.Point(15, 305);
            openFileButton.Margin = new System.Windows.Forms.Padding(2);
            openFileButton.Name = "openFileButton";
            openFileButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            openFileButton.Size = new System.Drawing.Size(92, 54);
            openFileButton.TabIndex = 4;
            openFileButton.Text = "Open file";
            openFileButton.UseVisualStyleBackColor = true;
            openFileButton.Click += OpenFileButton_Click;
            // 
            // validateAgentsCheckBox
            // 
            validateAgentsCheckBox.AutoSize = true;
            validateAgentsCheckBox.Location = new System.Drawing.Point(494, 335);
            validateAgentsCheckBox.Name = "validateAgentsCheckBox";
            validateAgentsCheckBox.Size = new System.Drawing.Size(187, 24);
            validateAgentsCheckBox.TabIndex = 2;
            validateAgentsCheckBox.Text = "Validate agents schema";
            validateAgentsCheckBox.UseVisualStyleBackColor = true;
            // 
            // JsonApp
            // 
            AllowDrop = true;
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(897, 808);
            Controls.Add(validateAgentsCheckBox);
            Controls.Add(openFileButton);
            Controls.Add(groupBox2);
            Controls.Add(resetButton);
            Controls.Add(validateButton);
            Controls.Add(groupBox1);
            Margin = new System.Windows.Forms.Padding(2);
            Name = "JsonApp";
            Text = "JsonApp";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox inputJson;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.TreeView jsonTreeView;
        private System.Windows.Forms.CheckBox validateAgentsCheckBox;
        private System.Windows.Forms.Label label1;
    }
}

