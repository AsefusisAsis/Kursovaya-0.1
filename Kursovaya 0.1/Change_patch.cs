using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Kursovaya_0._1
{
    public partial class Change_patch : Form
    {
        public Change_patch()
        {
            InitializeComponent();
        }
        
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = "+ Application.StartupPath + @"\resource\Patch.mdb");
        private void Change_patch_Load(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Hide();
            comboBox1.Text = "7.22";
            label4.Hide();
                con.Open();
                OleDbCommand max = con.CreateCommand();
                max.CommandType = CommandType.Text;
                max.CommandText = "select max([Код]) from last_patch";
            int count = int.Parse(max.ExecuteScalar().ToString());
            for (int i = 1; i < count; i++)
            {
                max.CommandText = "select [Код патча] from last_patch where (Код="+i+")";
                comboBox1.Items.Add(max.ExecuteScalar().ToString());
            }
                max.ExecuteNonQuery();
                con.Close();
            
        }

        private void Label3_Click(object sender, EventArgs e)
        {

            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();

        }

        private void Label2_Click(object sender, EventArgs e)
        {
            MainMenu main = new MainMenu();
            main.Hide();

            con.Open();
            OleDbCommand max = con.CreateCommand();
            max.CommandType = CommandType.Text;
            
                max.CommandText = "select [Путь к странице] from last_patch where ([Код патча]='" + comboBox1.Text + "')";
            if (max.ExecuteScalar() != null)
            {
                PatchVal.patch = max.ExecuteScalar().ToString();
                //MessageBox.Show(patch.patch);
            }
            else
            {
                label4.Show();
                comboBox1.Text = null;
            }

            max.ExecuteNonQuery();
            con.Close();
            Patch patch = new Patch();
            this.Hide();
            patch.ShowDialog();
            
        }
    }
}
