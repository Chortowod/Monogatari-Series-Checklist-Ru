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
using System.Xml.Serialization;

namespace Gatari_v1
{
    public partial class Form1 : Form
    {
        //SaveData, CheckBoxes list and PathSaveData creation
        List<DataCheck> checkers = new List<DataCheck>();
        List<CheckBox> checkBoxes;
        string help = "ЛКМ на арке - опенинг.\nПКМ на арке - эндинг.\nДанные сохраняются автоматически при выходе из приложения.\n" +
                      "Хронологию событий 20-25 августа можно посмотреть подробнее, щелкнув на августе ЛКМ.";
        string saveDirectory = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Gatari\");
        string saveFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), @"Gatari\Save.xml");

        //SaveDirectory & ListOfCheckBoxes creation
        public Form1()
        {
            InitializeComponent();
            if (!Directory.Exists(saveDirectory))
                Directory.CreateDirectory(saveDirectory);
            checkBoxes = panel1.Controls.OfType<CheckBox>().Where(a => a.ForeColor != Color.DarkRed).ToList();
        }

        //Change the state of the title
        private void changeToWatched(LinkLabel linkLabel, Label label, Label label2, CheckBox box)
        {
            linkLabel.LinkColor = Color.Green;
            label.ForeColor = Color.Green;
            label2.ForeColor = Color.Green;
            box.ForeColor = Color.Green;
            box.Text = "Просмотрено";
            checkers[checkers.FindIndex(a => a.Name == box.Name)].Chk = true;
        }

        //Change the state of the title
        private void changeToUnwatched(LinkLabel linkLabel, Label label, Label label2, CheckBox box)
        {
            linkLabel.LinkColor = Color.Black;
            label.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            box.ForeColor = Color.Black;
            box.Text = "Не просмотрено";
            checkers[checkers.FindIndex(a => a.Name == box.Name)].Chk = false;
        }

        //Save on closing
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            using (FileStream fStream = new FileStream(saveFile, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<DataCheck>));
                xmlFormat.Serialize(fStream, checkers);
            }
        }

        //Load Restore
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer xmlFormatP = new XmlSerializer(typeof(List<DataCheck>));
            try
            {
                using (FileStream fStream = new FileStream(saveFile, FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    checkers.AddRange((List<DataCheck>)xmlFormatP.Deserialize(fStream));
                }
            }
            catch
            {
                foreach (CheckBox value in checkBoxes)
                    checkers.Add(new DataCheck() { Name = value.Name, Chk = false });
                MessageBox.Show("Привет! Скорее всего, это твой первый запуск приложения.\n" + help, "Начало работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (CheckBox value in checkBoxes)
            {
                if (checkers.First(a => a.Name == value.Name).Chk == true)
                    value.Checked = true;
            }
        }

        #region(OPs/EDs Click)
        private void KVamp_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=1roUrSIHSmc");
        }
        private void KStone_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=QcI1QoOseGo");
        }
        private void TFamily_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=tNWSdPCNSPg");
        }
        private void TFamily_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=vfltbkdSBUM");
        }
        private void HCrab_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=uVuJiunPo4E");
        }
        private void MSnail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=2OC6ARG6fZA"); 
        }
        private void SMonkey_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=_NiUoFOtiqE");
        }
        private void NSnake_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=PiauQ7P7mtQ");
        }
        private void TCat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=9HwdeZ6SqcI");
        }
        private void TCat_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=HBT7o-o8zjA");
        }
        private void KBee_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=-HTGOn7KVJ8");
        }
        private void KBee_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ZPn_i1xHsAQ");
        }
        private void TPhoenix_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Y8SwZJAUiW4");
        }
        private void MJiangshi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=EVnFzopxBKc");
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=_OgmOXFRWS0");
        }
        private void STime_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=4nm5498BYTI");
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xluEix54H4I"); 
        }
        private void SMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=NpoKXPEAEIs");
        }
        private void SMail_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Ho33AGH1lEE");
        }
        private void TTiger_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=PdxeBzNLQe0");
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=EstxiXkXGik"); 
        }
        private void OFormula_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=PWXNvCg3uT0");
        }
        private void OFormula_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=ExWNledkLj0");
        }
        private void SRiddle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=jePBN9qPPf0");
        }
        private void SLost_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Nha-DeZEV0o");
        }
        private void NMedusa_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=VT5gSCjz-yI");
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=4sLKiV2DU6A");
        }
        private void HEnd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=T78cA9r1P50");
        }
        private void HEnd_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=6UU2LFYK83M");
        }
        private void HEndd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=nvIEztK_gwQ");
        }
        private void YDoll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=vRVEZq8plc0");
        }
        private void YDoll_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=VE-bLR5UKGc");
        }
        private void MHell_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=6slgHkcpRoU");
            else
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=uUaXfxKmVe4");
        }
        private void HRendezvous_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=IUv14HK_EUk");
            else
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=YXVG4iMGTmg");
        }
        private void ODark_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=hhxmwHErUhU");
            else
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=b5llyR2PKMA");
        }
        private void KReverse_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=B-p86RaRP2o");
            else
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=rAqiXw7J3O0");
        }
        private void SDevil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=i27cViremYM");
            else
                System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=Od-ZKV8clCY");
        }
        #endregion

        //August arc link
        private void label49_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://i.imgur.com/6yMK6uS.png"); 
        }

        //Help link
        private void HotKeys_Click(object sender, EventArgs e)
        {
            MessageBox.Show(help, "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //CheckBox actions
        private void checkBox24_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = sender as CheckBox;
            string name = chk.Name.Substring(0, chk.Name.Length - 1);
            LinkLabel linkLabel = panel1.Controls.OfType<LinkLabel>().FirstOrDefault(a => a.Name == name);
            Label label = panel1.Controls.OfType<Label>().FirstOrDefault(a => a.Name == name + "1");
            Label label2 = panel1.Controls.OfType<Label>().FirstOrDefault(a => a.Name == name + "2");
            if (chk.Checked == true)
                changeToWatched(linkLabel, label, label2, chk);
            else
                changeToUnwatched(linkLabel, label, label2, chk);
        }

        //BackColor change within August link
        private void label49_MouseMove(object sender, MouseEventArgs e)
        {
            label49.BackColor = Color.OrangeRed;
        }
        private void label49_MouseLeave(object sender, EventArgs e)
        {
            label49.BackColor = Color.PaleGreen;
        }
    }
}
