using System.Collections;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace KeyMacro
{
    public partial class Form1 : Form
    {
        string openFileName = "";
        Thread thread;
        List<int> timeList = new List<int>();
        List<Item> itemList = new List<Item>();
        EventHandler ev;
        bool run = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            try
            {
                string key = textBox_key.Text;
                int delay = int.Parse(textBox_delay.Text);
                int repeat = int.Parse(textBox_repeat.Text);
                if (key.Trim() != "")
                {
                    ListViewItem item = new ListViewItem(new string[] { (listView1.Items.Count + 1).ToString() , key, textBox_delay.Text, textBox_repeat.Text });
                    listView1.Items.Add(item);
                    textBox_key.Text = "";
                    textBox_key.Focus();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("입력값을 다시 확인해주세요");
            }
            
        }

        private void button_del_Click(object sender, EventArgs e)
        {
            try
            {
                if(listView1.SelectedItems.Count > 0)
                {
                    int index = listView1.FocusedItem.Index;
                    listView1.Items.RemoveAt(index);

                    int i = 1;
                    foreach(ListViewItem item in listView1.Items)
                    {
                        item.SubItems[0].Text = i.ToString();
                        i++;
                    }
                    listView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("삭제 할 수 없습니다.");
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            string fileName = openFileName;
            if(fileName == null || fileName == "")
            {
                button_saveAs_Click(sender, e);
            }
            else
            {
                using (StreamWriter sw = new StreamWriter(fileName, false))
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        sw.WriteLine(item.SubItems[0].Text);
                        sw.WriteLine(item.SubItems[1].Text);
                        sw.WriteLine(item.SubItems[2].Text);
                        sw.WriteLine(item.SubItems[3].Text);
                    }
                    sw.Close();
                }
            }
            

        }

        private void button_read_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.InitialDirectory = System.Environment.CurrentDirectory;
                ofd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    listView1.Items.Clear();
                    string[] item = new string[4];
                    int i = 0;
                    foreach (string line in File.ReadAllLines(ofd.FileName))
                    {
                        item[i] = line;
                        i++;
                        if (i == 4)
                        {
                            listView1.Items.Add(new ListViewItem(item));
                            i = 0;
                        }

                    }
                    listView1.Refresh();
                    openFileName = ofd.FileName;
                }
                

            }
            catch(Exception ex)
            {
                MessageBox.Show("파일을 불러 올 수 없습니다.");
            }
            
        }

        private void button_saveAs_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = System.Environment.CurrentDirectory;
            sfd.Title = "설정 파일 저장";
            sfd.FileName = "saveFile";
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName.ToString()))
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        sw.WriteLine(item.SubItems[0].Text);
                        sw.WriteLine(item.SubItems[1].Text);
                        sw.WriteLine(item.SubItems[2].Text);
                        sw.WriteLine(item.SubItems[3].Text);
                    }
                    sw.Close();
                }

            }
        }

        private void button_start_Click(object sender, EventArgs e)
        {
            try
            {
                if (button_start.Text == "시작")
                {
                    setting();
                    ev = new EventHandler(setTime);
                    timer1.Tick += setTime;
                    timer1.Start();
                    thread = new Thread(macro);
                    thread.Start();
                    button_start.Text = "중단";
                }
                else
                {
                    thread_exit();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("오류: " + ex.ToString());
            }
            
            
        }

        public void setting()
        {
            timeList.Clear();
            itemList.Clear();
            foreach (ListViewItem item in listView1.Items)
            {
                itemList.Add(new Item(int.Parse(item.SubItems[0].Text), item.SubItems[1].Text, int.Parse(item.SubItems[2].Text), int.Parse(item.SubItems[3].Text)));
                timeList.Add(0);
            }
            
        }

        public void setTime(object sender, EventArgs e)
        {
            for(int i=0; i<timeList.Count; i++)
            {
                if (timeList[i] == 0) continue;
                timeList[i]--;
            }
        }

        public void macro()
        {
            try
            {
                run = true;
                Thread.Sleep(1000);
                while (thread.IsAlive && run)
                {
                    for(int i = 0; i < itemList.Count; i++)
                    {
                        if (itemList[i].repeat > -1)
                        {
                            if(timeList[i] < 1)
                            {
                                if (itemList[i].key.Equals("{SPACE}"))
                                {
                                    SendKeys.SendWait(" ");
                                }
                                else
                                {
                                    SendKeys.SendWait(itemList[i].key);
                                }
                                Thread.Sleep(itemList[i].delay);
                                timeList[i] = itemList[i].repeat;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                thread_exit();
            }
        }

        public void thread_exit()
        {
            timer1.Stop();
            timer1.Tick -= ev;
            if(thread != null)
            {
                if (thread.IsAlive)
                {
                    run = false;
                    if (this.InvokeRequired)
                    {
                        this.Invoke(new Action(delegate ()
                        {
                            button_start.Text = "시작";
                        }));
                    }
                    thread.Interrupt();
                }
            }
            else
            {
                button_start.Text = "시작";
            }
            
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count > 0)
                {
                    int index = listView1.FocusedItem.Index;
                    listView1.Items[index].SubItems[1].Text = textBox_key.Text;
                    listView1.Items[index].SubItems[2].Text = int.Parse(textBox_delay.Text).ToString();
                    listView1.Items[index].SubItems[3].Text = int.Parse(textBox_repeat.Text).ToString();
                    listView1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"수정 할 수 없습니다.\n{ex.Message}");
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                textBox_key.Text = listView1.SelectedItems[0].SubItems[1].Text;
                textBox_delay.Text = listView1.SelectedItems[0].SubItems[2].Text;
                textBox_repeat.Text = listView1.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void button_help_Click(object sender, EventArgs e)
        {
            HelpForm form = new HelpForm();
            form.Show();

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }
    }
}