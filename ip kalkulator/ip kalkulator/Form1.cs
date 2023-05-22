using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ip_kalkulator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bit1, bit2, bit3, bit4, mask;

            try
            {
                if (tb_1bit.Text != null)
                {
                    bit1 = (int)Convert.ToInt32(tb_1bit.Text);
                }
                else bit1 = 1;
                if (tb_2bit.Text != null)
                {
                    bit2 = (int)Convert.ToInt32(tb_2bit.Text);
                }
                else bit2 = 1;
                if (tb_3bit.Text != null)
                {
                    bit3 = (int)Convert.ToInt32(tb_3bit.Text);
                }
                else bit3 = 0;
                if (tb_4bit.Text != null)
                {
                    bit4 = (int)Convert.ToInt32(tb_4bit.Text);
                }
                else bit4 = 0;
                if (tb_mask.Text != null)
                {
                    mask = (int)Convert.ToInt32(tb_mask.Text);
                }
                else mask = 25;


                if (bit1 > 255 || bit2 > 255 || bit3 > 255 || bit4 > 255 || mask > 32 || bit1 < 0 || bit2 < 0 || bit3 < 0 || bit4 < 0 || mask < 0)
                {
                    MessageBox.Show("Ошибка ввода данных");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода данных");
                return;
            }



            if (mask < 17)//Вычисления в 1 или 2 бите
            {
                if (mask > 8)//вычисления в 2 бите
                {
                    int step;
                    step = (int)Math.Pow(2, 16 - mask);
                    int lowg;//минимальное кол-во шагов
                    lowg = bit2 / step;
                    //адрес сети 
                    network.Text = bit1 + "." + (lowg * step) + ".0.0";
                    //адрес широковещательный
                    broadcast.Text = bit1 + "." + (lowg * step + step - 1) + ".255.255";
                    //Полная маска
                    int kalcbit = 256 - (int)Math.Pow(2, 16 - mask);
                    fullmask.Text = "255." + kalcbit + ".0.0";
                }
                else//вычисления в 1 бите
                {
                    int step;
                    step = (int)Math.Pow(2, 8 - mask);
                    int lowg;//минимальное кол-во шагов
                    lowg = bit1 / step;
                    //адрес сети
                    network.Text = (lowg * step) + ".0.0.0";
                    //адрес широковещательный
                    broadcast.Text = (lowg * step + step - 1) + ".255.255.255";
                    //Полная маска
                    int kalcbit = 256 - (int)Math.Pow(2, 8 - mask);
                    fullmask.Text = kalcbit + ".0.0.0";
                }
            }
            else//Вычисления в 3 или 4 бите
            {
                if (mask > 23)//вычисления в 4 бите
                {
                    int step;
                    step = (int)Math.Pow(2, 32 - mask);
                    int lowg;//минимальное кол-во шагов
                    lowg = bit4 / step;
                    //адрес сети 
                    network.Text = bit1 + "." + bit2 + "." + bit3 + "." + (lowg * step);
                    //адрес широковещательный
                    broadcast.Text = bit1 + "." + bit2 + "." + bit3 + "." + (lowg * step + step - 1);
                    //Полная маска
                    int kalcbit = 256 - (int)Math.Pow(2, 32 - mask);
                    fullmask.Text = "255.255.255." + kalcbit;
                }
                else//вычисления в 3 бите
                {
                    int step;
                    step = (int)Math.Pow(2, 24 - mask);
                    int lowg;//минимальное кол-во шагов
                    lowg = bit3 / step;
                    //адрес сети
                    network.Text = bit1 + "." + bit2 + "." + (lowg * step) + ".0";
                    //адрес широковещательный
                    broadcast.Text = bit1 + "." + bit2 + "." + (lowg * step + step - 1) + ".255";
                    //Полная маска
                    int kalcbit = 256 - (int)Math.Pow(2, 24 - mask);
                    fullmask.Text = "255.255." + kalcbit + ".0";
                }
            }

            long kolvo = (long)Math.Pow(2, (32 - mask));
            Hosts.Text = Convert.ToString( kolvo);
            

        }

        
    }
}
