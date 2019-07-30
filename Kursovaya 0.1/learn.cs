using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace Kursovaya_0._1
{
    public partial class learn : Form
    {
        public learn()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + Application.StartupPath + @"\resource\Learn.mdb");
        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Label12_Click(object sender, EventArgs e)
        {

            MainMenu main = new MainMenu();
            this.Hide();
            main.Show();

        }

   

        private void Label2_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            con.Close();
            con.Open();
            
            label.ForeColor = Color.Gray;
            
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Описание] from people where([Название]='" + label.Text + "')";
            Info.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "select [Картинки] from people where([Название]='" + label.Text + "')";
            pictureBox1.Image = Image.FromFile(Application.StartupPath+cmd.ExecuteScalar().ToString());

            cmd.ExecuteNonQuery();
            con.Close();
        }
        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
            
            
        }

        private void Learn_Load(object sender, EventArgs e)
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Описание] from people where([Код]=1)";
            Info.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "select [Картинки] from people where([Код]=1)";
            pictureBox1.Image = Image.FromFile(Application.StartupPath + cmd.ExecuteScalar().ToString());
            OleDbCommand txt = con.CreateCommand();
            txt.CommandType = CommandType.Text;
            cmd.CommandText = "select max([Код]) from people";
            
            for (int i=0;i< Convert.ToInt32(cmd.ExecuteScalar().ToString()+1); i++)
            {
                Label label = new Label();
                if (i == 0)
                {
                    label.Text = "Каналы на ютубе";
                    label.AutoSize = true;
                    label.Font = new Font("asinastra", 20);
                    label.Location = new Point(10, 10);
                    label.ForeColor = Color.White;
                    label.Name = "Chanel";
                    this.Controls.Add(label);
                }
                else
                    //Controls[name] as PictureBox).Image
                if (i< Convert.ToInt32(cmd.ExecuteScalar().ToString()))
                {
                    
                    label.AutoSize = true;
                    label.Font = new Font("asinastra", 16);
                    label.Cursor = Cursors.Hand;
                    label.Location = new Point(10, (i * (Controls["Chanel"] as Label).Height+ (Controls["Chanel"] as Label).Top + 15));
                    label.ForeColor = Color.White;
                    txt.CommandText = "select [Название] from people where(Код="+i+")";
                    label.Name = txt.ExecuteScalar().ToString();
                    label.Text = label.Name;
                    
                    label.Click += Labe_Click;
                    label.MouseMove += Label2_MouseMove;
                    label.MouseLeave += Label2_MouseLeave;
                    
                    this.Controls.Add(label);
                }
                else
                if(i== Convert.ToInt32(cmd.ExecuteScalar().ToString())+1)
                {
                    label.Text = "Обучающие сайты";
                    label.AutoSize = true;
                    label.Font = new Font("asinastra", 20);
                    
                    label.Location = new Point(10, (Controls["Dota Universe"] as Label).Top+ (Controls["Dota Universe"] as Label).Height+20);
                    label.ForeColor = Color.White;
                    label.Name = "Sites";
                    this.Controls.Add(label);
                }
            }

            cmd.ExecuteNonQuery();
            OleDbCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            OleDbCommand txt1 = con.CreateCommand();
            txt1.CommandType = CommandType.Text;
            cmd1.CommandText = "select MAX([Код]) from sites";
            for (int i = 1; i < Convert.ToInt32(cmd1.ExecuteScalar().ToString()); i++)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Font = new Font("asinastra", 16);
                label.Cursor = Cursors.Hand;
                label.Location = new Point(10, (i * (Controls["Sites"] as Label).Height + (Controls["Sites"] as Label).Top + 15));
                label.ForeColor = Color.White;
                txt.CommandText = "select [Название] from sites where(Код=" + i + ")";
                label.Name = txt.ExecuteScalar().ToString();
                label.Text = label.Name;

                label.Click += Labe_Site_Click;
                label.MouseMove += Labe_sites_MouseMove;
                label.MouseLeave += Label2_MouseLeave;

                this.Controls.Add(label);
            }

            con.Close();
            con.Open();
            





        }

        private void Labe_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            con.Close();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Адрес] from people where([Название]='" + label.Text + "')";
            Process.Start(cmd.ExecuteScalar().ToString());

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Labe_Site_Click(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            con.Close();
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Адрес] from sites where([Название]='" + label.Text + "')";
            Process.Start(cmd.ExecuteScalar().ToString());

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Labe_sites_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            con.Close();
            con.Open();
            
            label.ForeColor = Color.Gray;

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Описание] from sites where([Название]='" + label.Text + "')";
            Info.Text = cmd.ExecuteScalar().ToString();
            cmd.CommandText = "select [Картинки] from sites where([Название]='" + label.Text + "')";
            pictureBox1.Image = Image.FromFile(Application.StartupPath + cmd.ExecuteScalar().ToString());

            cmd.ExecuteNonQuery();
            con.Close();
        }

        private void Label12_MouseMove(object sender, MouseEventArgs e)
        {

            label12.ForeColor = Color.Gray;
        }

        private void L(object sender, EventArgs e)
        {
            
            label12.ForeColor = Color.White;
        }
    }
}
