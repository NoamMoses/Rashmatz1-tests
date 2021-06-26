using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*

TODO

- To check "formBorderStyle"
    it is used to make the main form not resizable. Need to check more deeply what each option means

*/

namespace Rashmatz1 {
    public partial class mainWin : Form {
        public const string credits = "" +
            "פותח " +
            "ע\"י " +
            "נמו";
        public mainWin() {
            InitializeComponent();
            // this.credit.Text = "this is some text";
            this.credit.Text = credits;
        }

        private void Form1_Load(object sender, EventArgs e) {
            Console.WriteLine("Programme started");
            const string path = "db.txt";
            string[] content = File.ReadAllLines(path);
            string line;
            using (StreamReader sw = new StreamReader(path)) {
                while ((line = sw.ReadLine()) != null) {
                    string[] lineSplitted = line.Split(';');
                    string itemID = lineSplitted[0],
                        itemName = lineSplitted[1],
                        itemData = lineSplitted[2],
                        itemCount = lineSplitted[3],
                        itemMakat = lineSplitted[4],
                        itemMakatFactory = lineSplitted[5],
                        itemLocation = lineSplitted[6],
                        itemComments = lineSplitted[7],
                        itemSign = lineSplitted[8];
                    ListViewItem item = new ListViewItem(itemID);
                    item.SubItems.Add(itemName);
                    item.SubItems.Add(itemData);
                    item.SubItems.Add(itemCount);
                    item.SubItems.Add(itemMakat);
                    item.SubItems.Add(itemMakatFactory);
                    item.SubItems.Add(itemLocation);
                    item.SubItems.Add(itemComments);
                    item.SubItems.Add(itemSign);

                    mainList.Items.Add(item);
                }
            }
        }

        private void mainList_SelectedIndexChanged(object sender, EventArgs e) {

        }

        private void mainList_DoubleClick(object sender, EventArgs e) {
            Console.WriteLine("double clic: ");
            if (mainList.SelectedIndices.Count > 0) {
                int itemIndex = mainList.SelectedIndices[0];
                // labelDebug.Text = mainList.Items[itemIndex].SubItems[2].ToString();
                string[] data = {
                    mainList.Items[itemIndex].SubItems[0].Text,
                    mainList.Items[itemIndex].SubItems[1].Text,
                    mainList.Items[itemIndex].SubItems[2].Text,
                    mainList.Items[itemIndex].SubItems[3].Text,
                    mainList.Items[itemIndex].SubItems[4].Text,
                    mainList.Items[itemIndex].SubItems[5].Text,
                    mainList.Items[itemIndex].SubItems[6].Text,
                    mainList.Items[itemIndex].SubItems[7].Text,
                    mainList.Items[itemIndex].SubItems[8].Text
                };
                Form viewItem = new viewItem(data);
                viewItem.ShowDialog();
            }
        }

        private void debugButton_Click(object sender, EventArgs e) {
            Form viewItem = new viewItem();
            viewItem.ShowDialog();
        }
    }
}
