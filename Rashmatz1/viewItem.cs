using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rashmatz1 {
    public partial class viewItem : Form {
        private string[] data;
        public viewItem() {
            InitializeComponent();
        }

        public viewItem(string[] data) {
            InitializeComponent();
            this.data = data;
        }

        private void viewItem_Load(object sender, EventArgs e) {
            /* Loading main listView */
            string ID = this.data[0],
                name = this.data[1],
                desc = this.data[2],
                count = this.data[3],
                makat = this.data[4],
                makatFactory = this.data[5],
                location = this.data[6],
                comments = this.data[7],
                sign = this.data[8];
            ListViewItem item = new ListViewItem(ID);
            item.SubItems.Add(name);
            item.SubItems.Add(desc);
            item.SubItems.Add(count);
            item.SubItems.Add(makat);
            item.SubItems.Add(makatFactory);
            item.SubItems.Add(location);
            item.SubItems.Add(comments);
            item.SubItems.Add(sign);
            mainList.Items.Add(item);

            /* Loading inputs */
            editFields_IDinput.Text = ID;
            editFields_nameInput.Text = name;
            editFields_descInput.Text = desc;
            editFields_countInput.Value = Int32.Parse(count);
            editFields_makatInput.Text = makat;
            editFields_makatFactoryInput.Text = makatFactory;
            editFields_locatiomInput.Text = location;
            editFields_commentsInput.Text = comments;
            editFields_signInput.Text = sign;
        }

        private void editFields_nameTitle_Click(object sender, EventArgs e) { editFields_nameInput.Focus(); }
        private void editFields_makatTitle_Click(object sender, EventArgs e) { editFields_makatInput.Focus(); }
        private void editFields_locationTitle_Click(object sender, EventArgs e) { editFields_locatiomInput.Focus(); }
        private void editFields_descTitle_Click(object sender, EventArgs e) { editFields_descInput.Focus(); }
        private void editFields_makatFactoryTitle_Click(object sender, EventArgs e) { editFields_makatFactoryInput.Focus(); }
        private void editFields_signTitle_Click(object sender, EventArgs e) { editFields_signInput.Focus(); }
        private void editFields_commentsTitle_Click(object sender, EventArgs e) { editFields_commentsInput.Focus(); }
        private void editFields_countTitle_Click(object sender, EventArgs e) { editFields_countInput.Focus(); }

        DialogResult showConfirmationDialog(string title, string msg, MessageBoxButtons buttons) {
            DialogResult confirm = MessageBox.Show(msg, title, buttons, MessageBoxIcon.None, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading);
            return confirm;
        }

        private void cancelEdit_Click(object sender, EventArgs e) {
            string msg = "" +
                "האם אתה בטוח שברצונך לבטל את עריכת הפריט? כול השינויים יימחקו",
                title = "" +
                "אישור פעולה | ביטול עריכת פריט";
            DialogResult confirm = showConfirmationDialog(title, msg, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes) {
                Console.WriteLine("Closing dialog");
                this.Close();
            } else if (confirm == DialogResult.No || confirm == DialogResult.Cancel) {
            }
        }

        private void deleteItem_Click(object sender, EventArgs e) {
            string msg = "" +
                "האם אתה בטוח שברצונך למחוק את פריט זה? אין אפשרות לביטול הפעולה!",
                title = "" +
                "אישור פעולה | מחיקת פריט";
            DialogResult confirm = showConfirmationDialog(title, msg, MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes) {
                // TODO delete item
            } else if (confirm == DialogResult.No || confirm == DialogResult.Cancel) {
            }
        }

        private void saveItem_Click(object sender, EventArgs e) {
            string msg = "" +
                "הפריט נשמר בהצלחה!",
                title = "" +
                "אישור פעולה | שמירת עריכת פריט";
            DialogResult confirm = MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.RtlReading);
            if (confirm == DialogResult.Yes) {
                // TODO save item
            } else if (confirm == DialogResult.No || confirm == DialogResult.Cancel) {
            }
        }
    }
}
