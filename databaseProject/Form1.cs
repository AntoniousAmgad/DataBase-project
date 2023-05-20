using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace databaseProject
{
    public partial class nameTextBox : Form
    {
        public nameTextBox()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(nameTextBox));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_insert = new System.Windows.Forms.Button();
            this.btn_read = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // textBox4
            // 
            resources.ApplyResources(this.textBox4, "textBox4");
            this.textBox4.Name = "textBox4";
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            resources.ApplyResources(this.textBox5, "textBox5");
            this.textBox5.Name = "textBox5";
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            resources.ApplyResources(this.textBox6, "textBox6");
            this.textBox6.Name = "textBox6";
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button_insert
            // 
            resources.ApplyResources(this.button_insert, "button_insert");
            this.button_insert.Name = "button_insert";
            this.button_insert.UseVisualStyleBackColor = true;
            this.button_insert.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_read
            // 
            resources.ApplyResources(this.btn_read, "btn_read");
            this.btn_read.Name = "btn_read";
            this.btn_read.UseVisualStyleBackColor = true;
            this.btn_read.Click += new System.EventHandler(this.btn_read_Click);
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // nameTextBox
            // 
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btn_read);
            this.Controls.Add(this.button_insert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Name = "nameTextBox";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void nameTextBox_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string query = "insert into person (username, phone_number, password) VALUES ('" + textBox6.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            DBhelper.createCon();
            DBhelper.insertData(query);
            DBhelper.closeCon();
            clearTextBoxes();
        }
        
        private void clearTextBoxes()
        {
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string query = "insert into person (username, phone_number, password) VALUES ('" + textBox6.Text + "', '" + textBox4.Text + "', '" + textBox5.Text + "')";
            DBhelper.createCon();
            DBhelper.insertData(query);
            DBhelper.closeCon();
            clearTextBoxes();
        }

        private void btn_read_Click(object sender, EventArgs e)
        {
            populateDgv();
        }
        private void populateDgv()
        {
            string query = "select * from person";
            DBhelper.createCon();
            DataTable dt = DBhelper.readData(query);
            DBhelper.closeCon();
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
            DataGridViewRow selectedRow = dataGridView1.Rows[selectedrowindex];
            int user_ID = Convert.ToInt32(selectedRow.Cells["user_ID"].Value);
            textBox6.Text = Convert.ToString(selectedRow.Cells["username"].Value);
            string password = Convert.ToString(selectedRow.Cells["password"].Value);
            string phone_number = Convert.ToString(selectedRow.Cells["phone_number"]);
        }
    }
}
