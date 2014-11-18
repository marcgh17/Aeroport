using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    public class MyListViewItem : ListViewItem
    {
        string key;

        public MyListViewItem (string text, ListViewGroup group, string k) : base(text,group)
        {
            
            key = k;

        }

        public MyListViewItem(string k, string text)
            : base(text)
        {

            Text = text;
            key = k;

        }
        public void setKey(string k)
        {
            key = k;

        }

        public string getKey()
        {

            return key;
        }
    }

