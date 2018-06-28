using System;
using System.Runtime.Versioning;
using System.Windows.Forms;

namespace HomeGenie_BE_InterfaceWizard
{
    public class UserInputForm : Form
    {
        private Label label1;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private TextBox textBox4;
        private Button button1;

        //private TextBox textBox1;
        //private Button button1;

        public UserInputForm()
        {
            //    this.Size = new System.Drawing.Size(155, 265);

            //    button1 = new Button();
            //    button1.Location = new System.Drawing.Point(90, 25);
            //    button1.Size = new System.Drawing.Size(50, 25);
            //    button1.Click += button1_Click;
            //    this.Controls.Add(button1);

            //    textBox1 = new TextBox();
            //    textBox1.Location = new System.Drawing.Point(10, 25);
            //    textBox1.Size = new System.Drawing.Size(70, 20);
            //    this.Controls.Add(textBox1);
            InitializeComponent();
        }
        public static string Domain { get; set; }
        public static string Author { get; set; }
        public static string ProjectHomePage { get; set; }
        public static string Description { get; set; }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInputForm));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // textBox2
            // 
            resources.ApplyResources(this.textBox2, "textBox2");
            this.textBox2.Name = "textBox2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox3
            // 
            resources.ApplyResources(this.textBox3, "textBox3");
            this.textBox3.Name = "textBox3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            // 
            // UserInputForm
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "UserInputForm";
            this.Load += new System.EventHandler(this.UserInputForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void UserInputForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Domain = textBox1.Text;
            Author = textBox2.Text;
            ProjectHomePage = textBox3.Text;
            AccessibleDefaultActionDescription = textBox4.Text;

            this.Close();
        }
    }
}