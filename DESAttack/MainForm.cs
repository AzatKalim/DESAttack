using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections;

namespace DESAttack
{
    public partial class MainForm : Form
    {
        Encryptor worker;

        public MainForm()
        {
            InitializeComponent();
            worker = new Encryptor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = worker.EncodeString(codeTextBox.Text);
            encryptedTextBox.Text = result;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var result = worker.DecodeString(encryptedTextBox.Text);
            decodeTextBox.Text = result;
        }

        private void prepButton_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            worker.PrepairData();
            timer.Stop();
            timerTextBox.Text = timer.Elapsed.ToString();
            keyTextBox.Text = DES.LastKey.ToView();
            for (int j = 0; j < 8; j++)
            {
                var temp = new BitArray(DES.LastRoundKeys[j]);
                raundKeysTextBox.Text += temp.ToView() + Environment.NewLine;
            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            var timer = new Stopwatch();
            timer.Start();
            LinearCryptanalysis.Attack();
            timer.Stop();
            timerTextBox.Text = timer.Elapsed.ToString();
            equalsCountTextBox.Text = LinearCryptanalysis.EqualsCount.ToString();
            keyBitsTextBox.Text = LinearCryptanalysis.KeyBitsString;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
