using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RandomDivide
{
    public partial class Form1 : Form
    {
        private int ClassNumber=1;
        
        public Form1()
        {
            InitializeComponent();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Style", "IDE1006:命名样式", Justification = "<挂起>")]
        private void button1_Click(object sender, EventArgs e)
        {
            GroupList.Items.Add("班级" + ClassNumber);
            
            ClassNumber += 1;
        }

        private void GroupList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Delete && GroupList.SelectedItems.Count!=0)
            {
                GroupList.Items.Remove(GroupList.SelectedItems[0]);
            }
        }

        private void Create_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem g in GroupList.Items)
            {
                if (g.SubItems.Count >1) g.SubItems.RemoveAt(1);
            }
            Random random = new Random();
            int count = GroupList.Items.Count;
            List<string> gname = new List<string>();
            for(int i = 0; i < count/4; i++)
            {
                for(int j = 0;j<4; j++)
                    gname.Add(((char)(i+65)).ToString());
            }
            foreach (ListViewItem g in GroupList.Items)
            {
                int name = random.Next(gname.Count);
                int availablecount = gname.FindAll((string gn) => {
                    return gn == gname[name].ToString();
                }).Count;
                
                g.SubItems.Add(gname[name].ToString());
                g.SubItems.Add((4-availablecount+1).ToString());
                gname.RemoveAt(name);              
            }
        }

        private void Senior1_Click(object sender, EventArgs e)
        {
            ClassNumber = 1;
            GroupList.Items.Clear();
            for (int i = 0; i < 20; i++)
            {
                GroupList.Items.Add(ClassNumber + "班");

                ClassNumber += 1;
            }

        }

        private void Senior2_Click(object sender, EventArgs e)
        {
            ClassNumber = 1;
            GroupList.Items.Clear();
            for (int i = 0; i < 16; i++)
            {
                GroupList.Items.Add(ClassNumber + "班");

                ClassNumber += 1;
            }
        }
    }
}
