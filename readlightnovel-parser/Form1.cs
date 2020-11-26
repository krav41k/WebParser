using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AngleSharp.Text;
using readlightnovel_parser.core;
using readlightnovel_parser.habra;

namespace readlightnovel_parser
{
    public partial class Form1 : Form
    {
        private ParserWorker<string[]> parser;
        
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                    new HabraParser()
            );

            parser.OnNewData += Parser_OnNewData;
            parser.OnCompleted += Parser_OnCompleted;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }
        
        private void Parser_OnCompleted(object arg1)
        {
            MessageBox.Show("All works done!");
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            parser.Settings = new HabraSettings(int.Parse(textBoxStartPoint.Text), int.Parse(textBoxStopPoint.Text));
            parser.Start();
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}