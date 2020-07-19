using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CW_01_19_07
{
    public partial class Form1 : Form
    {
        private enum Action
        {
            Plus = 0,
            Minus,
            Divide,
            Multiply
        }

        private List<int> numbers = new List<int>();
        private List<Action> action = new List<Action>();

        public Form1()
        {
            InitializeComponent();
        }

        private void seven_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 7;
        }

        private void eight_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 8;
        }

        private void nine_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 9;
        }

        private void four_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 4;
        }

        private void five_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 5;
        }

        private void six_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 6;
        }

        private void one_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 1;
        }

        private void two_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 2;
        }

        private void three_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 3;
        }

        private void zero_btn_Click(object sender, EventArgs e)
        {
            result_tb.Text += 0;
        }

        private void result_tb_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (result_tb.Text.Length == 0) return;
            result_tb.Text = result_tb.Text.Remove(result_tb.Text.Length-1);
        }

        private void div_btn_Click(object sender, EventArgs e)
        {
            action.Add(Action.Divide);
            int res = int.Parse(result_tb.Text);
            numbers.Add(res);
            result_tb.Text = null;
        }

        private void multi_btn_Click(object sender, EventArgs e)
        {
            action.Add(Action.Multiply);
            int res = int.Parse(result_tb.Text);
            numbers.Add(res);
            result_tb.Text = null;
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            action.Add(Action.Minus);
            int res = int.Parse(result_tb.Text);
            numbers.Add(res);
            result_tb.Text = null;
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            action.Add(Action.Plus);
            int res = int.Parse(result_tb.Text);
            numbers.Add(res);
            result_tb.Text = null;
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            int res = int.Parse(result_tb.Text);
            numbers.Add(res);
            double buffer = 0;
            for (int i = 0; i < action.Count; i++)
            {
                if (i == 0) buffer += numbers[i];
                
                switch(action[i])
                {
                    case Action.Divide:
                        buffer /= numbers[i+1];
                        break;
                    case Action.Plus:
                        buffer += numbers[i + 1];
                        break;
                    case Action.Minus:
                        buffer -= numbers[i + 1];
                        break;
                    case Action.Multiply:
                        buffer *= numbers[i + 1];
                        break;
                }
            }

            result_tb.Text = buffer.ToString();
            numbers.Clear();
            action.Clear();
        }
    }
}
