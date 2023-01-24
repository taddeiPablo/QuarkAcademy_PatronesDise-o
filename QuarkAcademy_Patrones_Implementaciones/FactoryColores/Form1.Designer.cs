
namespace FactoryColores
{
    partial class Form1
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
            this.panelAzul = new System.Windows.Forms.Panel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.panelRojo = new System.Windows.Forms.Panel();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.panelAmarillo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // panelAzul
            // 
            this.panelAzul.Location = new System.Drawing.Point(23, 51);
            this.panelAzul.Name = "panelAzul";
            this.panelAzul.Size = new System.Drawing.Size(86, 16);
            this.panelAzul.TabIndex = 0;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(145, 73);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(86, 290);
            this.listBox2.TabIndex = 3;
            // 
            // panelRojo
            // 
            this.panelRojo.Location = new System.Drawing.Point(145, 51);
            this.panelRojo.Name = "panelRojo";
            this.panelRojo.Size = new System.Drawing.Size(86, 16);
            this.panelRojo.TabIndex = 2;
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(269, 73);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(86, 290);
            this.listBox3.TabIndex = 5;
            // 
            // panelAmarillo
            // 
            this.panelAmarillo.Location = new System.Drawing.Point(269, 51);
            this.panelAmarillo.Name = "panelAmarillo";
            this.panelAmarillo.Size = new System.Drawing.Size(86, 16);
            this.panelAmarillo.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(145, 375);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "agregar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(269, 375);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "agregar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "GAMA DE COLORES";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 73);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(86, 290);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 410);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.panelAmarillo);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.panelRojo);
            this.Controls.Add(this.panelAzul);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelAzul;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Panel panelRojo;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.Panel panelAmarillo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}

