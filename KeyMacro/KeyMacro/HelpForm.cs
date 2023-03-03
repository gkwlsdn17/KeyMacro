using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyMacro
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            listView1.Items.Add(new ListViewItem(new string[] { "Shift", "+" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Ctrl", "^" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Alt", "%" }));
            listView1.Items.Add(new ListViewItem(new string[] { "↑", "{UP}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "↓", "{DOWN}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "←", "{LEFT}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "→", "{RIGHT}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "엔터", "{ENTER}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "스페이스", "{SPACE}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "TAB", "{TAB}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "ESC", "{ESC}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "백스페이스", "{BACKSPACE}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "CapsLock", "{CAPSLOCK}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Insert", "{INSERT}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Del", "{DEL}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Home", "{HOME}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "End", "{END}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "PageUp", "{PGUP}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "PageDown", "{PGDN}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "PrintScreen", "{PRTSC}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "ScrollLock", "{SCROLLLOCK}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "Break", "{BREAK}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "+", "{ADD}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "-", "{SUBTRACT}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "*", "{MULTIPLY}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "/", "{DIVIDE}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F1", "{F1}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F2", "{F2}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F3", "{F3}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F4", "{F4}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F5", "{F5}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F6", "{F6}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F7", "{F7}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F8", "{F8}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F9", "{F9}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F10", "{F10}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F11", "{F11}" }));
            listView1.Items.Add(new ListViewItem(new string[] { "F12", "{F12}" }));
            listView1.Refresh();
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode == Keys.C)
            {
                CopyListBox((System.Windows.Forms.ListView)sender);
            }
        }

        public void CopyListBox(ListView list)
        {
            Clipboard.SetDataObject(list.SelectedItems[0].SubItems[1].Text);
        }
    }
}
