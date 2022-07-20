using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSONBinding
{
    public partial class ItemList : Form
    {
        Item de = new Item();
        public ItemList()
        {
            InitializeComponent();

        }

        private void ItemList_Load(object sender, EventArgs e)
        {
            
                dataGridViewItems.DataSource = de.GetList();

            
        }
    }
}
