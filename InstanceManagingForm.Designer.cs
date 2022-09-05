
namespace InstancesManagingApp
{
    partial class InstanceManagingForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InstanceManagingForm));
            this.controllerLabel = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.terminateAppButton = new System.Windows.Forms.Button();
            this.hideGUIButton = new System.Windows.Forms.Button();
            this.killAllInstancesButton = new System.Windows.Forms.Button();
            this.createInstanceButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // controllerLabel
            // 
            this.controllerLabel.AutoSize = true;
            this.controllerLabel.Font = new System.Drawing.Font("Segoe UI", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.controllerLabel.Location = new System.Drawing.Point(254, 49);
            this.controllerLabel.Name = "controllerLabel";
            this.controllerLabel.Size = new System.Drawing.Size(311, 47);
            this.controllerLabel.TabIndex = 1;
            this.controllerLabel.Text = "Instances Manager";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.terminateAppButton);
            this.groupBox2.Controls.Add(this.hideGUIButton);
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(101, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(252, 180);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manage GUI";
            // 
            // terminateAppButton
            // 
            this.terminateAppButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.terminateAppButton.ForeColor = System.Drawing.Color.Black;
            this.terminateAppButton.Location = new System.Drawing.Point(30, 96);
            this.terminateAppButton.Name = "terminateAppButton";
            this.terminateAppButton.Size = new System.Drawing.Size(194, 50);
            this.terminateAppButton.TabIndex = 6;
            this.terminateAppButton.Text = "Terminate App";
            this.terminateAppButton.UseVisualStyleBackColor = true;
            this.terminateAppButton.Click += new System.EventHandler(this.terminateAppButton_Click);
            // 
            // hideGUIButton
            // 
            this.hideGUIButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.hideGUIButton.ForeColor = System.Drawing.Color.Black;
            this.hideGUIButton.Location = new System.Drawing.Point(30, 22);
            this.hideGUIButton.Name = "hideGUIButton";
            this.hideGUIButton.Size = new System.Drawing.Size(194, 50);
            this.hideGUIButton.TabIndex = 5;
            this.hideGUIButton.Text = "Hide GUI";
            this.hideGUIButton.UseVisualStyleBackColor = true;
            this.hideGUIButton.Click += new System.EventHandler(this.hideGUIButton_Click);
            // 
            // killAllInstancesButton
            // 
            this.killAllInstancesButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.killAllInstancesButton.ForeColor = System.Drawing.Color.Red;
            this.killAllInstancesButton.Location = new System.Drawing.Point(481, 241);
            this.killAllInstancesButton.Name = "killAllInstancesButton";
            this.killAllInstancesButton.Size = new System.Drawing.Size(194, 50);
            this.killAllInstancesButton.TabIndex = 6;
            this.killAllInstancesButton.Text = "Kill All Instances";
            this.killAllInstancesButton.UseVisualStyleBackColor = true;
            this.killAllInstancesButton.Click += new System.EventHandler(this.killAllInstancesButton_Click);
            // 
            // createInstanceButton
            // 
            this.createInstanceButton.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createInstanceButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.createInstanceButton.Location = new System.Drawing.Point(481, 156);
            this.createInstanceButton.Name = "createInstanceButton";
            this.createInstanceButton.Size = new System.Drawing.Size(194, 50);
            this.createInstanceButton.TabIndex = 5;
            this.createInstanceButton.Text = "Create Instance";
            this.createInstanceButton.UseVisualStyleBackColor = true;
            this.createInstanceButton.Click += new System.EventHandler(this.createInstanceButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(453, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 180);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage Instances";
            // 
            // InstanceManagingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.killAllInstancesButton);
            this.Controls.Add(this.createInstanceButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.controllerLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InstanceManagingForm";
            this.Text = "Instances Manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MittalGUI_FormClosing);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label controllerLabel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button terminateAppButton;
        private System.Windows.Forms.Button hideGUIButton;
        private System.Windows.Forms.Button killAllInstancesButton;
        private System.Windows.Forms.Button createInstanceButton;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
