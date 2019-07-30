using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Kursovaya_0._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source = " + Application.StartupPath + @"\resource\Dota2.mdb");
        private void Form1_Load(object sender, EventArgs e)
        {


            // TODO: данная строка кода позволяет загрузить данные в таблицу "dota2DataSet.common_items". При необходимости она может быть перемещена или удалена.
            this.common_itemsTableAdapter.Fill(this.dota2DataSet.common_items);
            label3.Hide();
            label3.Top = this.Height / 2;
            label3.Left = this.Width / 2 - label3.Width / 2;
            con.Open();
            OleDbCommand max = con.CreateCommand();
            max.CommandType = CommandType.Text;
            max.CommandText = "select max([Код]) from common_items ";
            int j = 0;

            
            if (max.ExecuteScalar() != null)
            {
                j = Convert.ToInt16(max.ExecuteScalar().ToString());
            }
            else
            {
                label3.Text += "data upload faild";
                label3.Show();
                MessageBox.Show(label3.Text);
                this.Close();
            }
            max.ExecuteNonQuery();
            con.Close();

            PicGenerateCommon(j);


            con.Open();
            OleDbCommand maxup = con.CreateCommand();
            maxup.CommandType = CommandType.Text;
            maxup.CommandText = "select max([Код]) from upgrade_items ";

            int i = 0;
            if (max.ExecuteScalar() != null)
            {
                i = Convert.ToInt16(maxup.ExecuteScalar().ToString());
            }
            else
            {
                label3.Text += "data upload faild";
                label3.Show();
                MessageBox.Show(label3.Text);
                this.Close();
            }
            maxup.ExecuteNonQuery();
            con.Close();

            PicGenerateUpgrade(i);

            upadate();
            GetInfo("Town_Portal_Scroll");
            GetInfo("Town_Portal_Scroll");

            Upgrade.Width = this.Width - (Basic.Left + Basic.Width + info.Width) - 40;
            Upgrade.Left = Basic.Left + Basic.Width + 10;
            Upgrade.Top = Basic.Top;
            Upgrade.Height = Basic.Height;

            Upgradelab.Left = (Upgrade.Width / 2) - (Upgradelab.Width / 2);
            Upgradelab.Top = 10;

            label1.Hide();
            label2.Hide();
            info.Hide();
            ItemName.Hide();
            infoPic.Hide();

            {
                //DataTable dt = new DataTable();
                //OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                //da.Fill(dt);
                //dataGridView1.DataSource = dt;
            }

        }//Загрузка формы

        private void upadate()//Обновление DataGrid
        {
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from common_items";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void PicGenerateCommon(int max)//Генерация картинок на форме
        {
            
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int x = 20;
            int y = 35;


            for (int i = 1; i < max; i++)
            {

                cmd.CommandText = "select [Название] from common_items where ([Код]=" + i + ")";
                PictureBox pictureBox = new PictureBox();

                Basic.Height = this.Height-30;
                Basic.Width = 35 + (49 * 5);
                Basic.Top = 10;
                Basic.Left = 20;

                Basiclab.Left = (Basic.Width / 2) - (Basiclab.Width / 2);
                Basiclab.Top = 10;

                info.Top = Basic.Top;
                info.Height = Basic.Height;
                label2.Width = 280;
                Uselab.Width = 280;
                Uselab.Height = 240;
                info.Width = 320;
                info.Left = this.Width - info.Width - 20;

                //ItemSection.Top =  -1*(ItemSection.Height- info.Height+10);


                pictureBox.Width = 44;
                pictureBox.Height = 32;
                pictureBox.Location = new Point(x, y);
                if ((i >= 1) & (i < 13))
                {
                    y = ((i + 1) * 35);
                }
                else
                {
                    if ((i > 12) & (i < 25))
                    {
                        x = 69;
                        y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 13) * 35);
                    }
                    else
                    {

                        if ((i >= 24) & (i < 39))
                        {
                            x = 118;
                            y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 25) * 35);
                        }
                        else
                        {
                            if ((i > 38) & (i < 54))
                            {
                                x = 167;
                                y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 39) * 35);
                            }
                            else
                            {
                                if ((i > 53) & (i < 67))
                                {
                                    x = 216;
                                    y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 54) * 35);
                                }
                                else
                                {
                                    y = (i * 35) - 30;
                                }
                            }
                        }
                    }
                }
                if (cmd.ExecuteScalar() != null)
                {
                    pictureBox.Name = cmd.ExecuteScalar().ToString();
                }
                else
                {
                    label3.Text += "data upload faild";
                    label3.Show();
                    MessageBox.Show(label3.Text);
                    this.Close();
                }
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.Click += pictureBox_Click;
                string name = pictureBox.Name;
                this.Basic.Controls.Add(pictureBox);
                cmd.CommandText = "select [Иконка] from common_items where ([Название]='" + name + "')";
                (Basic.Controls[name] as PictureBox).Image = Image.FromFile( Application.StartupPath + cmd.ExecuteScalar().ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
            upadate();
           
        }

        private void pictureBox_Click(object sender, EventArgs e)//Ивент для иконок
        {
            
            label1.Show();
            label2.Show();
            info.Show();
            ItemName.Show();
            infoPic.Show();
            PictureBox pic = (PictureBox)sender;
            infoPic.Image = pic.Image;
            PropertyMet(pic.Name);
            GetInfo(pic.Name);

            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Код] from common_items where ([Название]='" + pic.Name + "')";
            if (cmd.ExecuteScalar() != null)
            {
                UseSpell(Convert.ToInt32(cmd.ExecuteScalar().ToString()));
                passiveSpel(Convert.ToInt32(cmd.ExecuteScalar().ToString()));
                activatedspell(Convert.ToInt32(cmd.ExecuteScalar().ToString()));
            }
            else
            {
                label3.Text += "data upload faild";
                label3.Show();
                MessageBox.Show(label3.Text);
                this.Close();
            }
            cmd.ExecuteNonQuery();
            con.Close();
            Update();

        }

        private void pictureBoxUpgrade_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            infoPic.Image = pic.Image;
            PropertyMetUpgrade(pic.Name);
            GetInfoUpgrade(pic.Name);
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Код] from upgrade_items where ([Название]='" + pic.Name + "')";
            if (cmd.ExecuteScalar() != null)
            {
                UseSpellUpgrade(Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 67);
                passiveSpel(Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 67);
                activatedspell(Convert.ToInt32(cmd.ExecuteScalar().ToString()) + 67);
            }
            else
            {
                label3.Text += "data upload faild";
                label3.Show();
                MessageBox.Show(label3.Text);
                this.Close();
            }
            
            cmd.ExecuteNonQuery();
            con.Close();
            label1.Show();
            label2.Show();
            info.Show();
            ItemName.Show();
            infoPic.Show();
        }

        private void GetInfo(string name)//Вывод основной информации о предмете
        {
           
            con.Open();
            Infolab.Top = 10;
            Infolab.Left = (info.Width / 2) - (Infolab.Width / 2);
            Uselab.Top = label2.Top + label2.Height + 10;
            Uselab.Left = label2.Left;

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Описание] from common_items where ([Название]='" + name + "')";
            if ((name == "Crown") | (name == "Ring_of_Tarrasque"))
            {
                label1.Text = "Цена:";
                label2.Hide();
            }
            else
            {
                label2.Show();
                label2.Text = "Описание:";
                label1.Text = "Цена:";
                label2.Text += cmd.ExecuteScalar().ToString();
            }


            cmd.CommandText = "select [Цена] from common_items where ([Название]='" + name + "')";
            label1.Text += cmd.ExecuteScalar().ToString();
            infoPic.Top = 50;
            ItemName.Top = infoPic.Top;
            ItemName.Left = infoPic.Left + infoPic.Width + 5;
            property.Top = label1.Top + label1.Height + 5;
            property.Left = infoPic.Left;
            label2.Top = label1.Top + label1.Height + property.Height + 5;
            label2.Left = infoPic.Left;
            label1.Left = ItemName.Left;
            label1.Top = ItemName.Top + ItemName.Height + 3;
            cmd.ExecuteNonQuery();
            con.Close();
            StringBuilder str = new StringBuilder(name);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '_')
                {
                    str[i] = ' ';
                }
            }
            ItemName.Text = str.ToString();
            info.Show();
        }

        private void GetInfoUpgrade(string name)//Вывод основной информации о предмете
        {
            
            con.Open();
            Infolab.Top = 10;
            Infolab.Left = (info.Width / 2) - (Infolab.Width / 2);
            Uselab.Top = label2.Top + label2.Height + 10;
            Uselab.Left = label2.Left;

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Описание] from upgrade_items where ([Название]='" + name + "')";

            {
                label2.Show();
                label2.Text = "Описание:";
                label1.Text = "Цена:";
                if (cmd.ExecuteScalar() != null)
                {
                    label2.Text += cmd.ExecuteScalar().ToString();
                    label3.Text = "Error:"; 
                }
                else
                {
                    label3.Text += "data upload faild";
                    label3.Show();
                    MessageBox.Show(label3.Text);
                    this.Close();
                }
            }

            cmd.CommandText = "select [Цена] from upgrade_items where ([Название]='" + name + "')";
            if (cmd.ExecuteScalar() != null)
            {
                label1.Text += cmd.ExecuteScalar().ToString();
            }
            else
            {
                label3.Text += "data upload faild";
                label3.Show();
                MessageBox.Show(label3.Text);
                this.Close();
            }
            infoPic.Top = 50;
            ItemName.Top = infoPic.Top;
            ItemName.Left = infoPic.Left + infoPic.Width + 5;
            property.Top = label1.Top + label1.Height + 5;
            property.Left = infoPic.Left;
            label2.Top = label1.Top + label1.Height + property.Height + 5;
            label2.Left = infoPic.Left;
            label1.Left = ItemName.Left;
            label1.Top = ItemName.Top + ItemName.Height + 3;
            cmd.ExecuteNonQuery();
            con.Close();
            StringBuilder str = new StringBuilder(name);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == '_')
                {
                    str[i] = ' ';
                }
            }
            ItemName.Text = str.ToString();
            info.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            //info.Hide();
            //label2.Text = "Описание:";
            //label1.Text = "Цена:";
        }

        private void Button1_Click_1(object sender, EventArgs e)//Обновление картинок(Debag)
        {
            con.Open();
            OleDbCommand max = con.CreateCommand();
            max.CommandType = CommandType.Text;
            max.CommandText = "select max([Код]) from common_items ";
            int j = 0;
            if (max.ExecuteScalar() != null)
            {
               j  = Convert.ToInt16(max.ExecuteScalar().ToString());
            }
            else
            {
                label3.Text += "data upload faild";
                label3.Show();
                MessageBox.Show(label3.Text);
                this.Close();
            }
            max.ExecuteNonQuery();
            con.Close();
            PicGenerateCommon(j);
            upadate();
        }

        private void PicGenerateUpgrade(int max)//Улучшеные предметы создание обьектов
        {
            
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            int x = 20;
            int y = 35;


            for (int i = 1; i < max; i++)
            {

                cmd.CommandText = "select [Название] from upgrade_items where ([Код]=" + i + ")";
                PictureBox pictureBox = new PictureBox();


                pictureBox.Width = 44;
                pictureBox.Height = 32;
                pictureBox.Location = new Point(x, y);
                if ((i >= 1) & (i < 13))
                {
                    y = ((i + 1) * 35);
                }
                else
                {
                    if ((i > 12) & (i < 28))
                    {
                        x = 69;
                        y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 13) * 35);
                    }
                    else
                    {

                        if ((i >= 27) & (i < 42))
                        {
                            x = 118;
                            y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 28) * 35);
                        }
                        else
                        {
                            if ((i >= 42) & (i < 55))
                            {
                                x = 167;
                                y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 42) * 35);
                            }
                            else
                            {
                                if ((i >= 55) & (i < 72))
                                {
                                    x = 216;
                                    y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 55) * 35);
                                }
                                else
                                {
                                    if ((i >= 72) & (i < 90))
                                    {
                                        x = 265;
                                        y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 72) * 35);
                                    }
                                    else
                                    {
                                        //if ((i >= 86) & (i < 90))
                                        //{
                                        //    x = 314;
                                        //    y = (Basic.Controls["Town_Portal_Scroll"] as PictureBox).Top + ((i - 86) * 35);
                                        //}
                                        //else
                                        {
                                            y = (i * 35) - 30;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                pictureBox.Name = cmd.ExecuteScalar().ToString();
                pictureBox.Cursor = Cursors.Hand;
                pictureBox.Click += pictureBoxUpgrade_Click;
                string name = pictureBox.Name;
                this.Upgrade.Controls.Add(pictureBox);
                cmd.CommandText = "select [Иконка] from upgrade_items where ([Название]='" + name + "')";
                (Upgrade.Controls[name] as PictureBox).Image = Image.FromFile(Application.StartupPath + cmd.ExecuteScalar().ToString());
            }
            cmd.ExecuteNonQuery();
            con.Close();
            upadate();
           
        }

        private void PropertyMet(string name)//Характеристики-вывод
        {
            property.Text = null;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Сила] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Сила: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Ловкость] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Ловкость: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Интелект] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Интелект: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Атака] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Урон: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Скорость атаки] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Скорость атаки: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Скорость передвижения] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Скорость предвижения: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Восстановление маны] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Восстановление маны: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Восстановление здоровья] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Восстановление здоровья: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Сопротивление магии] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Сопротивление магии: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + '%' + "\n";
            }
            cmd.CommandText = "select [Броня] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Броня: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Здоровье] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Здоровье: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Мана] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Мана: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Уклонение] from common_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Уклонение: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + '%' + "\n";
            }
            property.Text += "\n";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void PropertyMetUpgrade(string name)//Характеристики-вывод
        {
            property.Text = null;
            con.Open();
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select [Сила] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Сила: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Ловкость] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Ловкость: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Интелект] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Интелект: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Атака] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Урон: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Скорость атаки] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Скорость атаки: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Скорость передвижения] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Скорость предвижения: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "%" + "\n";
            }
            cmd.CommandText = "select [Восстановление маны] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Восстановление маны: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "%" + "\n";
            }
            cmd.CommandText = "select [Восстановление здоровья] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Восстановление здоровья: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Сопротивление магии] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Сопротивление магии: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + '%' + "\n";
            }
            cmd.CommandText = "select [Броня] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Броня: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Здоровье] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Здоровье: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Мана] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
            {
                property.Text += "Мана: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + "\n";
            }
            cmd.CommandText = "select [Уклонение] from upgrade_items where ([Название]='" + name + "')";
            if ((cmd.ExecuteScalar().ToString() != "0")&(cmd.ExecuteScalar() != null))
            {
                property.Text += "Уклонение: +";
                property.Text += (cmd.ExecuteScalar().ToString()) + '%' + "\n";
            }
            property.Text += "\n";
            cmd.ExecuteNonQuery();
            con.Close();

        }

        private void UseSpell(int id)//Активная способность-вывод
        {

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from use_spell where ([Код]=" + id + ")";
            if (cmd.ExecuteScalar() != null)
            {
                Uselab.Top = label2.Top + label2.Height + 10;

                Uselab.Text = null;
                Uselab.Show();
                cmd.CommandText = "select [Название способности] from use_spell where ([Код]=" + id + ")";
                if (cmd.ExecuteScalar() != null)
                {
                    Uselab.Text += "Активная:";
                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n\n";
                }
                cmd.CommandText = "select [Описание способности] from use_spell where ([Код]=" + id + ")";
                if (cmd.ExecuteScalar() != null)
                {
                    Uselab.Text += "Описание:";
                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n\n";
                }
                cmd.CommandText = "select [Время перезарядки] from use_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
                {
                    Uselab.Text += "Время перезарядки:";
                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                }
                cmd.CommandText = "select [Манакост] from use_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0" & (cmd.ExecuteScalar() != null)))
                {
                    Uselab.Text += "Манакост:";
                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                }
                cmd.CommandText = "select [Радиус применения] from use_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0" & (cmd.ExecuteScalar() != null)))
                {
                    Uselab.Text += "Радиус применения:";

                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                }
            }
            else Uselab.Hide();
            cmd.ExecuteNonQuery();

        }

        private void UseSpellUpgrade(int id)//Активная способность-вывод
        {

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from use_spell where ([Код]=" + id + ")";
            if (cmd.ExecuteScalar() != null)
            {
                Uselab.Top = label2.Top + label2.Height + 10;

                Uselab.Text = null;
                Uselab.Show();
                cmd.CommandText = "select [Название способности] from use_spell where ([Код]=" + id + ")";
                if (cmd.ExecuteScalar() != null)
                {
                    Uselab.Text += "Название:";
                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n\n";
                }
                cmd.CommandText = "select [Описание способности] from use_spell where ([Код]=" + id + ")";
                if (cmd.ExecuteScalar() != null)
                {
                    Uselab.Text += "Описание:";
                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n\n";
                }
                cmd.CommandText = "select [Время перезарядки] from use_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
                {
                    Uselab.Text += "Время перезарядки:";
                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                }
                cmd.CommandText = "select [Манакост] from use_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0" & (cmd.ExecuteScalar() != null)))
                {
                    Uselab.Text += "Манакост:";
                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                }
                cmd.CommandText = "select [Радиус применения] from use_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0" & (cmd.ExecuteScalar() != null)))
                {
                    Uselab.Text += "Радиус применения:";

                    Uselab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                }
            }
            else Uselab.Hide();
            cmd.ExecuteNonQuery();

        }

        private void passiveSpel(int id)//Пассивная способность-вывод
        {
            if (Uselab.Visible == true)
            {
                Passivelab.Top = Uselab.Top + Uselab.Height + 10;
                Passivelab.Left = Uselab.Left;
            }
            else
            {
                Passivelab.Top = Uselab.Top;
                Passivelab.Left = Uselab.Left;
            }
            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "select * from passive_spell where ([Код]=" + id + ")";
            if (cmd.ExecuteScalar() != null)
            {
                Passivelab.Text = null;
                Passivelab.Show();
                cmd.CommandText = "select [Название способности] from passive_spell where ([Код]=" + id + ")";
                if (cmd.ExecuteScalar() != null)
                {
                    Passivelab.Text += "Пасивная: ";
                    Passivelab.Text += (cmd.ExecuteScalar().ToString()) + "\n\n";
                }
                cmd.CommandText = "select [Описание способности] from passive_spell where ([Код]=" + id + ")";
                if (cmd.ExecuteScalar() != null)
                {
                    Passivelab.Text += "Описание:";
                    Passivelab.Text += (cmd.ExecuteScalar().ToString()) + "\n\n";
                }

            }
            else Passivelab.Hide();
            cmd.ExecuteNonQuery();

        }

        private void activatedspell(int id)//Пассивная способность-вывод
        {
            Activelab.Show();
            Activelab.Left = Passivelab.Left;
            if (Passivelab.Visible == true)
            {
                Activelab.Top = Passivelab.Top + Passivelab.Height + 10;
            }
            else
            {
                Activelab.Top = Passivelab.Top+35;
            }

            OleDbCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from activated_spell where ([Код]=" + id + ")";
            if (cmd.ExecuteScalar() != null)
            {
                

                Activelab.Text = null;
                Activelab.Show();
                cmd.CommandText = "select [Название способности] from activated_spell where ([Код]=" + id + ")";
                if (cmd.ExecuteScalar() != null)
                {
                    Activelab.Text += "Активная:";
                    Activelab.Text += (cmd.ExecuteScalar().ToString()) + "\n\n";
                }
                cmd.CommandText = "select [Описание способности] from activated_spell where ([Код]=" + id + ")";
                if (cmd.ExecuteScalar() != null)
                {
                    Activelab.Text += "Описание:";
                    Activelab.Text += (cmd.ExecuteScalar().ToString()) + "\n\n";
                }
                cmd.CommandText = "select [Время перезарядки] from activated_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0") & (cmd.ExecuteScalar() != null))
                {
                    Activelab.Text += "Время перезарядки:";
                    Activelab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                }
                cmd.CommandText = "select [Манакост] from activated_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0" & (cmd.ExecuteScalar() != null)))
                {
                    Activelab.Text += "Манакост:";
                    Activelab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                    
                }
                cmd.CommandText = "select [Радиус применения] from activated_spell where ([Код]=" + id + ")";
                if ((cmd.ExecuteScalar().ToString() != "0" & (cmd.ExecuteScalar() != null)))
                {
                    Activelab.Text += "Радиус применения:";

                    Activelab.Text += (cmd.ExecuteScalar().ToString()) + "\n";
                }
            }
            else Activelab.Hide();
            cmd.ExecuteNonQuery();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Close();
            mainMenu.Show();
        }//В главное меню

        private void Back_MouseLeave(object sender, EventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.White;
        }

        private void Back_MouseMove(object sender, MouseEventArgs e)
        {
            Label label = (Label)sender;
            label.ForeColor = Color.Gray;
        }
    }
}

