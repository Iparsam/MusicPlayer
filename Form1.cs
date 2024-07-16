using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        Queue<string> q = new Queue<string>();
        string[] Musics = new string[1000];
        int cont;
        string a;


        public Form1()
        {
            InitializeComponent();
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3 files (*.mp3)|*.mp3";
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                for (int i = 0; i < open.FileNames.LongLength; i++)
                {
                    if (Ltb_Musics.Items.Contains(open.FileNames.GetValue(i)) == false)
                    {
                        var r = open.SafeFileNames.GetValue(i);
                        a = Convert.ToString(r);
                        q.Enqueue(a);
                        Musics[cont] = open.FileNames.GetValue(i).ToString();
                        cont += 1;

                    }
                }
                Ltb_Musics.Items.Clear();
                foreach (string id in q)
                {
                    Ltb_Musics.Items.Add(id);
                }
                if (Ltb_Musics.SelectedIndex < 0)
                {
                    Ltb_Musics.SetSelected(0, true);
                }
            }
            Player.URL = Musics[0];

        }
        private void previousbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ltb_Musics.SelectedIndex != 0)
                {

                    Ltb_Musics.SetSelected(Ltb_Musics.SelectedIndex - 1, true);
                    Player.URL = Musics[Ltb_Musics.SelectedIndex];
                }
                else
                {
                    Ltb_Musics.SelectedIndex = Ltb_Musics.Items.Count - 1;
                    Player.URL = Musics[Ltb_Musics.SelectedIndex];

                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("آهنگی یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (Ltb_Musics.SelectedIndex != Ltb_Musics.Items.Count - 1)
                {
                    Ltb_Musics.SetSelected(Ltb_Musics.SelectedIndex + 1, true);
                    Player.URL = Musics[Ltb_Musics.SelectedIndex];
                }
                else
                {
                    Ltb_Musics.SelectedIndex = 0;
                    Player.URL = Musics[Ltb_Musics.SelectedIndex];
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show("آهنگی یافت نشد", "توجه", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            String[] arr = q.ToArray();
            String search = searchtxt.Text="";

            var items = (from a in arr
                         where a.ToLower().Contains(search)
                         select a).ToArray<String>();

            Ltb_Musics.Items.Clear();
            Ltb_Musics.Items.AddRange(items);
        }

        private void Ltb_Musics_SelectedIndexChanged(object sender, EventArgs e)
        {
            Player.URL = Musics[Ltb_Musics.SelectedIndex];
        }
    }
}
