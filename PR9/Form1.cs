using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Linq.Mapping;
using System.Data.Linq;




namespace PR9
{
    public partial class Form1 : Form
    {
        static string conStr = "Data Source=10.10.1.24;Initial Catalog=Makc27;Persist Security Info=True;User ID=pro-41;Password=IsPro-41";
        DataContext context = new DataContext(conStr);

        public Form1()
        {
            InitializeComponent();
                 Table<orders> orders = context.GetTable<orders>();
            dataGridView1.DataSource = orders.ToList();
            Table<users> users = context.GetTable<users>();
            dataGridView2.DataSource = users.ToList();
            Table<statuses> statuses = context.GetTable<statuses>();
            dataGridView3.DataSource = statuses.ToList();
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
