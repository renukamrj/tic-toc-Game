using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int turn = 0;
        private Button btn;

        private void btn1_Click(object sender, EventArgs e)
        {
            btn = btn1;
            markxo();
        }
        private void btn2_Click(object sender, EventArgs e)
        {
            btn = btn2;
            markxo();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            btn = btn3;
            markxo();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            btn = btn4;
            markxo();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            btn = btn5;
            markxo();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            btn = btn6;
            markxo();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            btn = btn7;
            markxo();
        }
        
        private void btn8_Click(object sender, EventArgs e)
        {
            btn = btn8;
            markxo();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            btn = btn9;
            markxo();
        }


        void markxo()
        {

            if (turn == 0 && btn.Text == "")
            {
               
                this.btn.ForeColor = Color.Green;
                this.btn.Text = "X";
                turn = 1;
                lblX.Text = "";
                lblO.Text = "O Player Turn";
                winners();

            }
            else if (turn == 1 && btn.Text == "")
            {
             
                this.btn.ForeColor=Color.Blue;
                this.btn.Text = "O";
                turn = 0;
                lblO.Text = "";
                lblX.Text = "X Player Turn";
                winners();
               
            }
        }
        
        void winners()
        {
            if ((btn1.Text == "X" && btn2.Text == "X" && btn3.Text == "X")
                || (btn4.Text == "X" && btn5.Text == "X" && btn6.Text == "X")
                || (btn7.Text == "X" && btn8.Text == "X" && btn9.Text == "X")
                || (btn1.Text == "X" && btn4.Text == "X" && btn7.Text == "X")
                || (btn2.Text == "X" && btn5.Text == "X" && btn8.Text == "X")
                || (btn3.Text == "X" && btn6.Text == "X" && btn9.Text == "X")
                || (btn1.Text == "X" && btn5.Text == "X" && btn9.Text == "X")
                || (btn3.Text == "X" && btn5.Text == "X" && btn7.Text == "X"))
               
            {
                turn = 3;
                lblX.Text = "Winner is X";
                MessageBox.Show("Winner X");
                
            }
            else if ((btn1.Text == "O" && btn2.Text == "O" && btn3.Text == "O")
               || (btn4.Text == "O" && btn5.Text == "O" && btn6.Text == "O")
               || (btn7.Text == "O" && btn8.Text == "O" && btn9.Text == "O")
               || (btn1.Text == "O" && btn4.Text == "O" && btn7.Text == "O")
               || (btn2.Text == "O" && btn5.Text == "O" && btn8.Text == "O")
               || (btn3.Text == "O" && btn6.Text == "O" && btn9.Text == "O")
               || (btn1.Text == "O" && btn5.Text == "O" && btn9.Text == "O")
               || (btn3.Text == "O" && btn5.Text == "O" && btn7.Text == "O"))
                
            {
                turn = 3;
               lblO.Text = "Winner is O";
                MessageBox.Show("Winner O");
                
            }
            else if (btn1.Text != "" && btn2.Text != "" && btn3.Text != "" 
               && btn4.Text != "" && btn5.Text != "" && btn6.Text != ""
               && btn7.Text != "" && btn8.Text != "" && btn9.Text != "") 

            {
                turn = 3;
                MessageBox.Show("No One is Winner");
            
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
            turn = 0;
            lblX.Text = "X Player Turn";
            lblO.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblO.Text = "";
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
