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

        private void button1_Click(object sender, EventArgs e)
        {
            orders NewOrders = new orders { created = Convert.ToDateTime(textBox1.Text), user_ids = Convert.ToInt32(textBox2.Text), point_ids = Convert.ToInt32(textBox3.Text), sum = Convert.ToInt32(textBox4.Text), status_ids = Convert.ToInt32(textBox5.Text), delivery_sevice_ids = Convert.ToInt32(textBox6.Text) };
            context.GetTable<orders>().InsertOnSubmit(NewOrders);
            context.SubmitChanges();
            Table<orders> orders = context.GetTable<orders>();
            dataGridView1.DataSource = orders.ToList();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            users NewUser = new users { first_name = textBox7.Text, last_name = textBox8.Text, created = Convert.ToDateTime(textBox9.Text), phone = textBox10.Text, email = textBox11.Text};
            context.GetTable<users>().InsertOnSubmit(NewUser);
            context.SubmitChanges();
            Table<users> users = context.GetTable<users>();
            dataGridView2.DataSource = users.ToList();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            orders currentOrder = context.GetTable<orders>().FirstOrDefault(
x => x.order_id == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            textBox1.Text = currentOrder.created.ToString();
            textBox2.Text = currentOrder.user_ids.ToString();
            textBox3.Text = currentOrder.point_ids.ToString();
            textBox4.Text = currentOrder.sum.ToString();
            textBox5.Text = currentOrder.status_ids.ToString();
            textBox6.Text = currentOrder.delivery_sevice_ids.ToString();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            users currentUser = context.GetTable<users>().FirstOrDefault(
y => y.user_id == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
            textBox7.Text = currentUser.first_name.ToString();
            textBox8.Text = currentUser.last_name.ToString();
            textBox9.Text = currentUser.created.ToString();
            textBox10.Text = currentUser.phone.ToString();
            textBox11.Text = currentUser.email.ToString();           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                users currentUser = context.GetTable<users>().FirstOrDefault(
    y => y.user_id == Convert.ToInt32(dataGridView2.CurrentRow.Cells[0].Value));
                currentUser.first_name = textBox7.Text;
                currentUser.last_name = textBox8.Text;
                currentUser.created = Convert.ToDateTime(textBox9.Text);
                currentUser.phone = textBox10.Text;
                currentUser.email = textBox11.Text;
                context.SubmitChanges();
                Table<users> users = context.GetTable<users>();
                dataGridView2.DataSource = users.ToList();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
          

            var query = from u in context.GetTable<users>()
                        where u.first_name == "" + textBox7.Text + ""
                        select u;
            dataGridView2.DataSource = query.ToList();


            
        }
    }
}
