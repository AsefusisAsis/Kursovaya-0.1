using System;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data;
using System.Net.NetworkInformation;

namespace Kursovaya_0._1
{
    public partial class Prevue : Form
    {
        public Prevue()
        {
            InitializeComponent();
        }
        OleDbConnection items = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + Application.StartupPath + @"\resource\Dota2.mdb");
        OleDbConnection learn = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + Application.StartupPath + @"\resource\Patch.mdb");
        OleDbConnection patch = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + Application.StartupPath + @"\resource\Learn.mdb");
        MainMenu mainMenu = new MainMenu();
        private void Timer1_Tick(object sender, EventArgs e)
        {

            this.Opacity += 0.01;
           
            if (this.Opacity == 1)
            {
                this.Hide();

                
                
                mainMenu.Opacity = 1;
                mainMenu.Show();
                timer1.Stop();

            }
        }

        private void Prevue_Load(object sender, EventArgs e)
        {
            string errortext = null;
            mainMenu.Opacity = 0;
            timer1.Start();

            learn.Open();
            OleDbCommand max1 = learn.CreateCommand();
            max1.CommandType = CommandType.Text;
            max1.CommandText = "select * from last_patch";
            if (max1.ExecuteScalar() == null)
            {
                errortext += "Невозможно загрузить фанные о последнем патче(БД Patch)";
            }
            max1.ExecuteNonQuery();
            

            patch.Open();
            OleDbCommand max2 = patch.CreateCommand();
            max2.CommandType = CommandType.Text;
            max2.CommandText = "select * from people";
            if (max2.ExecuteScalar() == null)
            {
                errortext += "Невозможно загрузить фанные о последнем каналах и сайтах(БД Learn)";
            }
            max2.ExecuteNonQuery();
            

            items.Open();
            OleDbCommand max = items.CreateCommand();
            
            
            max.CommandType = CommandType.Text;
            max.CommandText = "select * from common_items";
            
            
            
            if (max.ExecuteScalar() == null)
            {
                errortext += "Невозможно загрузить фанные о вещах(БД Dota2)";
            }
           
           
           

            max.ExecuteNonQuery();
            
            if ((max1.ExecuteScalar() == null) | (max2.ExecuteScalar() == null) | (max.ExecuteScalar() == null))
            {

                MessageBox.Show(errortext);
            }

            items.Close();
            patch.Close();
            learn.Close();

            IPStatus status = IPStatus.Unknown;
            try
            {
                status = new Ping().Send("ru.dota2.com").Status;
            }
            catch { }

            if (status != IPStatus.Success)
            {
                MessageBox.Show("Нет подключения к интернету!");
                this.Close();
            }
           
        }
    }
}
