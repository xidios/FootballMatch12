using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FootballMatch12
{
    public partial class Form1 : Form
    {
        public Random rand = new Random();
        public const int team_count = 8;
        public List<Label> labels = new List<Label>();
        public List<Label> team_labels = new List<Label>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            labels.Clear();
            team_labels.Clear();


            var l = new Label[] { label9, label10, label11, label12, label13, label14, label15 };
            var teams = new Label[] { label1, label2, label3, label4, label5, label6, label7, label8 };
            List<Label> winers = new List<Label>();
            labels.AddRange(l);
            team_labels.AddRange(teams);

            for (int i = 0; i < team_count/2; i++)
            {
                var r = rand.NextDouble();
                if (r > 0.5)
                {
                    labels[i].Text = team_labels[i * 2 + 1].Text;
                    winers.Add(team_labels[i * 2 + 1]);
                }
                else
                {
                    labels[i].Text = team_labels[i * 2].Text;
                    winers.Add(team_labels[i * 2]);
                }
            }

            List<Label> final = new List<Label>();
            for (int i = 0; i < team_count / 4; i++)
            {
                var r = rand.NextDouble();
                if (r > 0.5)
                {
                    labels[i+4].Text = winers[i * 2 + 1].Text;
                    final.Add(team_labels[i * 2 + 1]);
                }
                else
                {
                    labels[i+4].Text = winers[i * 2].Text;
                    final.Add(team_labels[i * 2]);
                }
            }

            int bo3_team1 = 0;
            int bo3_team2 = 0;
            for (int i = 0; i < 3; i++)
            {
                var r = rand.NextDouble();
                if (r > 0.5)
                {
                    bo3_team1++;
                }
                else
                {
                    bo3_team2++;
                }
            }
            label15.Text = $"{bo3_team1} : {bo3_team2}";
        }
    }
}
