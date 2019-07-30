using System;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Kursovaya_0._1
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }
        OleDbConnection rec = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + Application.StartupPath + @"\resource\Recommendation.mdb");
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label5_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
            
        }

        private void Label7_Click(object sender, EventArgs e)
        {
            //Patch patch = new Patch();
            //patch.ShowDialog();
            Change_patch patch = new Change_patch();
            this.Hide();
            patch.Show();

        }

        private void Label4_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.dota2.com/heroes/");
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            Process.Start("https://ru.dotabuff.com/players/leaderboard");
        }

        private void Label3_Click(object sender, EventArgs e)
        {
            learn learn = new learn();
            this.Close();
            learn.Show(); 
            

        }

        private void Label6_Click(object sender, EventArgs e)
        {
            Process.Start("steam://rungameid/570");
        }

        private void Exit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void Label8_Click(object sender, EventArgs e)
        {
            Prevue prevue = new Prevue();
            prevue.Show();
        }

        private void Label2_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Gray;
        }

        private void Label2_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        int i = 0;
        int j = 0;
        private void MainMenu_Load(object sender, EventArgs e)
        {
            label9.Hide();
            panel4.Width = 596;
            rec.Open();
            OleDbCommand cmd = rec.CreateCommand();
            OleDbCommand rec1 = rec.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select max([Код]) from Pic";
            Random random = new Random();
            if (cmd.ExecuteScalar() != null)
            {
                label9.Hide();
                i = random.Next(1, int.Parse(cmd.ExecuteScalar().ToString()));
                cmd.CommandText = "select [Путь] from Pic where(Код=" + i + ")";
                panel2.BackgroundImage = Image.FromFile(Application.StartupPath + cmd.ExecuteScalar().ToString());
            }
            else
            {
                panel4.Hide();
                label9.Show();
            }

            rec1.CommandType = CommandType.Text;
            rec1.CommandText = "select max([Код]) from Rec";
            Random Rrec = new Random();

            if (rec1.ExecuteScalar() != null)
            {
                label9.Hide();
                j = random.Next(1, int.Parse(rec1.ExecuteScalar().ToString()));
            }
            else
            {
                panel4.Hide();
                label9.Show();
            }
            rec1.CommandText = "select [Текст] from Rec where(Код=" + i + ")";
            if (rec1.ExecuteScalar() != null)
            {

                label8.Text = rec1.ExecuteScalar().ToString();
            }
            else
            {
                panel4.Hide();
                label9.Show();
            }
            //label8.Left = pictureBox3.Left + pictureBox3.Width + 10;
            //label8.Width = panel2.Width - (pictureBox3.Left + pictureBox3.Width) - (panel2.Width - pictureBox1.Left + pictureBox1.Width);
            //pictureBox1.Top = label8.Top - pictureBox1.Height / 2;
            //pictureBox3.Top = label8.Top - pictureBox3.Height / 2;
            label8.Left = pictureBox3.Left + pictureBox3.Width;
            label8.Width = panel4.Width - (pictureBox3.Left + pictureBox3.Width) - (panel4.Width - pictureBox1.Left + pictureBox1.Width);
            pictureBox1.Top = panel4.Height / 2 - pictureBox1.Height / 2;
            pictureBox3.Top = panel4.Height / 2 - pictureBox3.Height / 2;
            rec1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            rec.Close();
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Start();
            rec.Open();
            OleDbCommand cmd = rec.CreateCommand();
            OleDbCommand rec1 = rec.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select max([Код]) from Pic";

            Random random = new Random();
            int ibuff = i;
            int jbuff = j;
            if (cmd.ExecuteScalar() != null)
            {
                i = random.Next(1, int.Parse(cmd.ExecuteScalar().ToString()));

                if (ibuff != i)
                {


                    cmd.CommandText = "select [Путь] from Pic where(Код=" + i + ")";
                    panel2.BackgroundImage = Image.FromFile(Application.StartupPath + cmd.ExecuteScalar().ToString());


                }
                else
                {
                    cmd.CommandText = "select max([Код]) from Pic";
                    i = random.Next(1, int.Parse(cmd.ExecuteScalar().ToString()));

                }
            }
            else
            {
                panel4.Hide();
                label9.Show();
            }
            Random Rrec = new Random();
            rec1.CommandType = CommandType.Text;


            rec1.CommandText = "select max([Код]) from Rec";

            if (cmd.ExecuteScalar() != null)
            {
                j = random.Next(1, int.Parse(rec1.ExecuteScalar().ToString()));
            }
            else
            {
                panel4.Hide();
                label9.Show();
            }
            rec1.CommandText = "select [Текст] from Rec where(Код=" + i + ")";
            if (cmd.ExecuteScalar() != null)
            {
                label8.Text = rec1.ExecuteScalar().ToString();
            }
            else
            {
                panel4.Hide();
                label9.Show();
            }
            label8.Left = pictureBox3.Left + pictureBox3.Width;
            label8.Width = panel4.Width - (pictureBox3.Left + pictureBox3.Width) - (panel4.Width - pictureBox1.Left + pictureBox1.Width);
            pictureBox1.Top = panel4.Height / 2 - pictureBox1.Height / 2;
            pictureBox3.Top = panel4.Height / 2 - pictureBox3.Height / 2;


            if (ibuff != i)
            {
                ibuff = i;
            }
            rec1.ExecuteNonQuery();
            cmd.ExecuteNonQuery();
            rec.Close();


        }

        private void PictureBox5_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\resource\minimize_down.png");
        }

        private void PictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Image.FromFile(Application.StartupPath + @"\resource\minimize.png");
        }

        private void PictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\resource\off_down.png");
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Image.FromFile(Application.StartupPath + @"\resource\off.png");
        }
    }
}
