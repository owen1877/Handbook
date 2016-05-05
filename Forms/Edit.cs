﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Handbook.Models;

namespace Handbook.Forms
{
    public partial class Edit : Form
    {
        private int el;
        public Edit(int a)
        {
            InitializeComponent();
            el = a;
        }

        private void Edit_Load(object sender, EventArgs e)
        {
            List l = new List();
            foreach (Material m in l.lm)
            {
                if (cd.Items.IndexOf(m.cd) == -1)
                {
                    cd.Items.Add(m.cd);
                }
            }
            author.Text = l.lm[el].author;
            song.Text = l.lm[el].song;
            cd.Text = l.lm[el].cd;            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            List l = new List();
            l.Delete(el);
            Material m = new Material(author.Text, song.Text, cd.Text);
            m.Add();
        }
    }
}
