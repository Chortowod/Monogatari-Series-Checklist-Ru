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
        List<DataCheck> checkers = new List<DataCheck>();
        
        public Form1()
        {
            InitializeComponent();
        }

        //Save on closing
        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            using (FileStream fStream = new FileStream("Save.xml", FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer xmlFormat = new XmlSerializer(typeof(List<DataCheck>));
                xmlFormat.Serialize(fStream, checkers);
            }
        }

        #region(Load Restore)
        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer xmlFormatP = new XmlSerializer(typeof(List<DataCheck>));
            try
            {
                using (FileStream fStream = new FileStream("Save.xml", FileMode.OpenOrCreate, FileAccess.Read, FileShare.None))
                {
                    checkers.AddRange((List<DataCheck>)xmlFormatP.Deserialize(fStream));
                }
            }
            catch
            {
                MessageBox.Show("Привет! Скорее всего, это твой первый запуск приложения.\nЛКМ на арке - опенинг.\nПКМ на арке - эндинг.\nДанные сохраняются автоматически при выходе из приложения.", "Начало работы", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (checkers.Count == 0)
            {
                checkers.Add(new DataCheck() { Name = "KVamp", Chk = false });
                checkers.Add(new DataCheck() { Name = "KStone", Chk = false });
                checkers.Add(new DataCheck() { Name = "TFamily", Chk = false });
                checkers.Add(new DataCheck() { Name = "HCrab", Chk = false });
                checkers.Add(new DataCheck() { Name = "KFlower", Chk = false });
                checkers.Add(new DataCheck() { Name = "MSnail", Chk = false });
                checkers.Add(new DataCheck() { Name = "SMonkey", Chk = false });
                checkers.Add(new DataCheck() { Name = "NSnake", Chk = false });
                checkers.Add(new DataCheck() { Name = "TCat", Chk = false });
                checkers.Add(new DataCheck() { Name = "KSand", Chk = false });
                checkers.Add(new DataCheck() { Name = "KWater", Chk = false });
                checkers.Add(new DataCheck() { Name = "KBee", Chk = false });
                checkers.Add(new DataCheck() { Name = "KWind", Chk = false });
                checkers.Add(new DataCheck() { Name = "TPhoenix", Chk = false });
                checkers.Add(new DataCheck() { Name = "MJiangshi", Chk = false });
                checkers.Add(new DataCheck() { Name = "STime", Chk = false });
                checkers.Add(new DataCheck() { Name = "SMail", Chk = false });
                checkers.Add(new DataCheck() { Name = "TTiger", Chk = false });
                checkers.Add(new DataCheck() { Name = "KTree", Chk = false });
                checkers.Add(new DataCheck() { Name = "KTea", Chk = false });
                checkers.Add(new DataCheck() { Name = "OFormula", Chk = false });
                checkers.Add(new DataCheck() { Name = "SRiddle", Chk = false });
                checkers.Add(new DataCheck() { Name = "SLost", Chk = false });
                checkers.Add(new DataCheck() { Name = "NMedusa", Chk = false });
                checkers.Add(new DataCheck() { Name = "KMountain", Chk = false });
                checkers.Add(new DataCheck() { Name = "NMedusaa", Chk = false });
                checkers.Add(new DataCheck() { Name = "KTorus", Chk = false });
                checkers.Add(new DataCheck() { Name = "HEnd", Chk = false });
                checkers.Add(new DataCheck() { Name = "KSeed", Chk = false });
                checkers.Add(new DataCheck() { Name = "HEndd", Chk = false });
                checkers.Add(new DataCheck() { Name = "YDoll", Chk = false });
                checkers.Add(new DataCheck() { Name = "KSeedd", Chk = false });
                checkers.Add(new DataCheck() { Name = "KNothing", Chk = false });
                checkers.Add(new DataCheck() { Name = "KDead", Chk = false });
                checkers.Add(new DataCheck() { Name = "MHell", Chk = false });
                checkers.Add(new DataCheck() { Name = "HRendezvous", Chk = false });
                checkers.Add(new DataCheck() { Name = "ODark", Chk = false });
                checkers.Add(new DataCheck() { Name = "KReverse", Chk = false });
                checkers.Add(new DataCheck() { Name = "SDevil", Chk = false });


            }
            if (checkers[checkers.FindIndex(a => a.Name == "KVamp")].Chk == true) KVamp3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KStone")].Chk == true) KStone3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "TFamily")].Chk == true) TFamily3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "HCrab")].Chk == true) HCrab3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KFlower")].Chk == true) KFlower3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "MSnail")].Chk == true) MSnail3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "SMonkey")].Chk == true) SMonkey3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "NSnake")].Chk == true) NSnake3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "TCat")].Chk == true) TCat3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KSand")].Chk == true) KSand3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KWater")].Chk == true) KWater3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KBee")].Chk == true) KBee3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KWind")].Chk == true) KWind3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "TPhoenix")].Chk == true) TPhoenix3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "MJiangshi")].Chk == true) MJiangshi3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "STime")].Chk == true) STime3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "SMail")].Chk == true) SMail3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "TTiger")].Chk == true) TTiger3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KTree")].Chk == true) KTree3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KTea")].Chk == true) KTea3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "OFormula")].Chk == true) OFormula3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "SRiddle")].Chk == true) SRiddle3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "SLost")].Chk == true) SLost3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "NMedusa")].Chk == true) NMedusa3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KMountain")].Chk == true) KMountain3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "NMedusaa")].Chk == true) NMedusaa3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KTorus")].Chk == true) KTorus3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "HEnd")].Chk == true) HEnd3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KSeed")].Chk == true) KSeed3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "HEndd")].Chk == true) HEndd3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "YDoll")].Chk == true) YDoll3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KSeedd")].Chk == true) KSeedd3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KNothing")].Chk == true) KNothing3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KDead")].Chk == true) KDead3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "MHell")].Chk == true) MHell3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "HRendezvous")].Chk == true) HRendezvous3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "ODark")].Chk == true) ODark3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "KReverse")].Chk == true) KReverse3.Checked = true;
            if (checkers[checkers.FindIndex(a => a.Name == "SDevil")].Chk == true) SDevil3.Checked = true;
        }
        #endregion

        #region(Check Restore)
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (KVamp3.Checked == true)
            {
                KVamp.LinkColor = Color.Green;
                KVamp1.ForeColor = Color.Green;
                KVamp2.ForeColor = Color.Green;
                KVamp3.ForeColor = Color.Green;
                KVamp3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KVamp")].Chk = true;
            }
            else
            {
                KVamp.LinkColor = Color.Black;
                KVamp1.ForeColor = Color.Black;
                KVamp2.ForeColor = Color.Black;
                KVamp3.ForeColor = Color.Black;
                KVamp3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KVamp")].Chk = false;
            }
        }

        private void KStone3_CheckedChanged(object sender, EventArgs e)
        {
            if (KStone3.Checked == true)
            {
                KStone.LinkColor = Color.Green;
                KStone1.ForeColor = Color.Green;
                KStone2.ForeColor = Color.Green;
                KStone3.ForeColor = Color.Green;
                KStone3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KStone")].Chk = true;
            }
            else
            {
                KStone.LinkColor = Color.Black;
                KStone1.ForeColor = Color.Black;
                KStone2.ForeColor = Color.Black;
                KStone3.ForeColor = Color.Black;
                KStone3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KStone")].Chk = false;
            }
        }

        private void TFamily3_CheckedChanged(object sender, EventArgs e)
        {
            if (TFamily3.Checked == true)
            {
                TFamily.LinkColor = Color.Green;
                TFamily1.ForeColor = Color.Green;
                TFamily2.ForeColor = Color.Green;
                TFamily3.ForeColor = Color.Green;
                TFamily3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "TFamily")].Chk = true;
            }
            else
            {
                TFamily.LinkColor = Color.Black;
                TFamily1.ForeColor = Color.Black;
                TFamily2.ForeColor = Color.Black;
                TFamily3.ForeColor = Color.Black;
                TFamily3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "TFamily")].Chk = false;
            }
        }

        private void HCrab3_CheckedChanged(object sender, EventArgs e)
        {
            if (HCrab3.Checked == true)
            {
                HCrab.LinkColor = Color.Green;
                HCrab1.ForeColor = Color.Green;
                HCrab2.ForeColor = Color.Green;
                HCrab3.ForeColor = Color.Green;
                HCrab3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "HCrab")].Chk = true;
            }
            else
            {
                HCrab.LinkColor = Color.Black;
                HCrab1.ForeColor = Color.Black;
                HCrab2.ForeColor = Color.Black;
                HCrab3.ForeColor = Color.Black;
                HCrab3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "HCrab")].Chk = false;
            }
        }

        private void KFlower3_CheckedChanged(object sender, EventArgs e)
        {
            if (KFlower3.Checked == true)
            {
                KFlower.LinkColor = Color.Green;
                KFlower1.ForeColor = Color.Green;
                KFlower2.ForeColor = Color.Green;
                KFlower3.ForeColor = Color.Green;
                KFlower3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KFlower")].Chk = true;
            }
            else
            {
                KFlower.LinkColor = Color.Black;
                KFlower1.ForeColor = Color.Black;
                KFlower2.ForeColor = Color.Black;
                KFlower3.ForeColor = Color.Black;
                KFlower3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KFlower")].Chk = false;
            }
        }

        private void MSnail3_CheckedChanged(object sender, EventArgs e)
        {
            if (MSnail3.Checked == true)
            {
                MSnail.LinkColor = Color.Green;
                MSnail1.ForeColor = Color.Green;
                MSnail2.ForeColor = Color.Green;
                MSnail3.ForeColor = Color.Green;
                MSnail3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "MSnail")].Chk = true;
            }
            else
            {
                MSnail.LinkColor = Color.Black;
                MSnail1.ForeColor = Color.Black;
                MSnail2.ForeColor = Color.Black;
                MSnail3.ForeColor = Color.Black;
                MSnail3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "MSnail")].Chk = false;
            }
        }

        private void SMonkey3_CheckedChanged(object sender, EventArgs e)
        {
            if (SMonkey3.Checked == true)
            {
                SMonkey.LinkColor = Color.Green;
                SMonkey1.ForeColor = Color.Green;
                SMonkey2.ForeColor = Color.Green;
                SMonkey3.ForeColor = Color.Green;
                SMonkey3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SMonkey")].Chk = true;
            }
            else
            {
                SMonkey.LinkColor = Color.Black;
                SMonkey1.ForeColor = Color.Black;
                SMonkey2.ForeColor = Color.Black;
                SMonkey3.ForeColor = Color.Black;
                SMonkey3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SMonkey")].Chk = false;
            }
        }

        private void NSnake3_CheckedChanged(object sender, EventArgs e)
        {
            if (NSnake3.Checked == true)
            {
                NSnake.LinkColor = Color.Green;
                NSnake1.ForeColor = Color.Green;
                NSnake2.ForeColor = Color.Green;
                NSnake3.ForeColor = Color.Green;
                NSnake3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "NSnake")].Chk = true;
            }
            else
            {
                NSnake.LinkColor = Color.Black;
                NSnake1.ForeColor = Color.Black;
                NSnake2.ForeColor = Color.Black;
                NSnake3.ForeColor = Color.Black;
                NSnake3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "NSnake")].Chk = false;
            }
        }

        private void TCat3_CheckedChanged(object sender, EventArgs e)
        {
            if (TCat3.Checked == true)
            {
                TCat.LinkColor = Color.Green;
                TCat1.ForeColor = Color.Green;
                TCat2.ForeColor = Color.Green;
                TCat3.ForeColor = Color.Green;
                TCat3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "TCat")].Chk = true;
            }
            else
            {
                TCat.LinkColor = Color.Black;
                TCat1.ForeColor = Color.Black;
                TCat2.ForeColor = Color.Black;
                TCat3.ForeColor = Color.Black;
                TCat3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "TCat")].Chk = false;
            }
        }

        private void KSand3_CheckedChanged(object sender, EventArgs e)
        {
            if (SMonkey3.Checked == true)
            {
                KSand.LinkColor = Color.Green;
                KSand1.ForeColor = Color.Green;
                KSand2.ForeColor = Color.Green;
                KSand3.ForeColor = Color.Green;
                KSand3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KSand")].Chk = true;
            }
            else
            {
                KSand.LinkColor = Color.Black;
                KSand1.ForeColor = Color.Black;
                KSand2.ForeColor = Color.Black;
                KSand3.ForeColor = Color.Black;
                KSand3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KSand")].Chk = false;
            }
        }

        private void KWater3_CheckedChanged(object sender, EventArgs e)
        {
            if (KWater3.Checked == true)
            {
                KWater.LinkColor = Color.Green;
                KWater1.ForeColor = Color.Green;
                KWater2.ForeColor = Color.Green;
                KWater3.ForeColor = Color.Green;
                KWater3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KWater")].Chk = true;
            }
            else
            {
                KWater.LinkColor = Color.Black;
                KWater1.ForeColor = Color.Black;
                KWater2.ForeColor = Color.Black;
                KWater3.ForeColor = Color.Black;
                KWater3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KWater")].Chk = false;
            }
        }

        private void KBee3_CheckedChanged(object sender, EventArgs e)
        {
            if (KBee3.Checked == true)
            {
                KBee.LinkColor = Color.Green;
                KBee1.ForeColor = Color.Green;
                KBee2.ForeColor = Color.Green;
                KBee3.ForeColor = Color.Green;
                KBee3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KBee")].Chk = true;
            }
            else
            {
                KBee.LinkColor = Color.Black;
                KBee1.ForeColor = Color.Black;
                KBee2.ForeColor = Color.Black;
                KBee3.ForeColor = Color.Black;
                KBee3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KBee")].Chk = false;
            }
        }

        private void KWind3_CheckedChanged(object sender, EventArgs e)
        {
            if (KWind3.Checked == true)
            {
                KWind.LinkColor = Color.Green;
                KWind1.ForeColor = Color.Green;
                KWind2.ForeColor = Color.Green;
                KWind3.ForeColor = Color.Green;
                KWind3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KWind")].Chk = true;
            }
            else
            {
                KWind.LinkColor = Color.Black;
                KWind1.ForeColor = Color.Black;
                KWind2.ForeColor = Color.Black;
                KWind3.ForeColor = Color.Black;
                KWind3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KWind")].Chk = false;
            }
        }

        private void TPhoenix3_CheckedChanged(object sender, EventArgs e)
        {
            if (TPhoenix3.Checked == true)
            {
                TPhoenix.LinkColor = Color.Green;
                TPhoenix1.ForeColor = Color.Green;
                TPhoenix2.ForeColor = Color.Green;
                TPhoenix3.ForeColor = Color.Green;
                TPhoenix3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "TPhoenix")].Chk = true;
            }
            else
            {
                TPhoenix.LinkColor = Color.Black;
                TPhoenix1.ForeColor = Color.Black;
                TPhoenix2.ForeColor = Color.Black;
                TPhoenix3.ForeColor = Color.Black;
                TPhoenix3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "TPhoenix")].Chk = false;
            }
        }

        private void MJiangshi3_CheckedChanged(object sender, EventArgs e)
        {
            if (MJiangshi3.Checked == true)
            {
                MJiangshi.LinkColor = Color.Green;
                MJiangshi1.ForeColor = Color.Green;
                MJiangshi2.ForeColor = Color.Green;
                MJiangshi3.ForeColor = Color.Green;
                MJiangshi3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "MJiangshi")].Chk = true;
            }
            else
            {
                MJiangshi.LinkColor = Color.Black;
                MJiangshi1.ForeColor = Color.Black;
                MJiangshi2.ForeColor = Color.Black;
                MJiangshi3.ForeColor = Color.Black;
                MJiangshi3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "MJiangshi")].Chk = false;
            }
        }

        private void STime3_CheckedChanged(object sender, EventArgs e)
        {
            if (STime3.Checked == true)
            {
                STime.LinkColor = Color.Green;
                STime1.ForeColor = Color.Green;
                STime2.ForeColor = Color.Green;
                STime3.ForeColor = Color.Green;
                STime3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "STime")].Chk = true;
            }
            else
            {
                STime.LinkColor = Color.Black;
                STime1.ForeColor = Color.Black;
                STime2.ForeColor = Color.Black;
                STime3.ForeColor = Color.Black;
                STime3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "STime")].Chk = false;
            }
        }

        private void SMail3_CheckedChanged(object sender, EventArgs e)
        {
            if (SMail3.Checked == true)
            {
                SMail.LinkColor = Color.Green;
                SMail1.ForeColor = Color.Green;
                SMail2.ForeColor = Color.Green;
                SMail3.ForeColor = Color.Green;
                SMail3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SMail")].Chk = true;
            }
            else
            {
                SMail.LinkColor = Color.Black;
                SMail1.ForeColor = Color.Black;
                SMail1.ForeColor = Color.Black;
                SMail3.ForeColor = Color.Black;
                SMail3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SMail")].Chk = false;
            }
        }

        private void TTiger3_CheckedChanged(object sender, EventArgs e)
        {
            if (TTiger3.Checked == true)
            {
                TTiger.LinkColor = Color.Green;
                TTiger1.ForeColor = Color.Green;
                TTiger2.ForeColor = Color.Green;
                TTiger3.ForeColor = Color.Green;
                TTiger3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "TTiger")].Chk = true;
            }
            else
            {
                TTiger.LinkColor = Color.Black;
                TTiger1.ForeColor = Color.Black;
                TTiger1.ForeColor = Color.Black;
                TTiger3.ForeColor = Color.Black;
                TTiger3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "TTiger")].Chk = false;
            }
        }

        private void KTree3_CheckedChanged(object sender, EventArgs e)
        {
            if (KTree3.Checked == true)
            {
                KTree.LinkColor = Color.Green;
                KTree1.ForeColor = Color.Green;
                KTree2.ForeColor = Color.Green;
                KTree3.ForeColor = Color.Green;
                KTree3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KTree")].Chk = true;
            }
            else
            {
                KTree.LinkColor = Color.Black;
                KTree1.ForeColor = Color.Black;
                KTree1.ForeColor = Color.Black;
                KTree3.ForeColor = Color.Black;
                KTree3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KTree")].Chk = false;
            }
        }

        private void KTea3_CheckedChanged(object sender, EventArgs e)
        {
            if (KTea3.Checked == true)
            {
                KTea.LinkColor = Color.Green;
                KTea1.ForeColor = Color.Green;
                KTea2.ForeColor = Color.Green;
                KTea3.ForeColor = Color.Green;
                KTea3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KTea")].Chk = true;
            }
            else
            {
                KTea.LinkColor = Color.Black;
                KTea1.ForeColor = Color.Black;
                KTea1.ForeColor = Color.Black;
                KTea3.ForeColor = Color.Black;
                KTea3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KTea")].Chk = false;
            }
        }

        private void OFormula3_CheckedChanged(object sender, EventArgs e)
        {
            if (OFormula3.Checked == true)
            {
                OFormula.LinkColor = Color.Green;
                OFormula1.ForeColor = Color.Green;
                OFormula2.ForeColor = Color.Green;
                OFormula3.ForeColor = Color.Green;
                OFormula3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "OFormula")].Chk = true;
            }
            else
            {
                OFormula.LinkColor = Color.Black;
                OFormula1.ForeColor = Color.Black;
                OFormula1.ForeColor = Color.Black;
                OFormula3.ForeColor = Color.Black;
                OFormula3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "OFormula")].Chk = false;
            }
        }

        private void SRiddle3_CheckedChanged(object sender, EventArgs e)
        {
            if (SRiddle3.Checked == true)
            {
                SRiddle.LinkColor = Color.Green;
                SRiddle1.ForeColor = Color.Green;
                SRiddle2.ForeColor = Color.Green;
                SRiddle3.ForeColor = Color.Green;
                SRiddle3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SRiddle")].Chk = true;
            }
            else
            {
                SRiddle.LinkColor = Color.Black;
                SRiddle1.ForeColor = Color.Black;
                SRiddle1.ForeColor = Color.Black;
                SRiddle3.ForeColor = Color.Black;
                SRiddle3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SRiddle")].Chk = false;
            }
        }

        private void SLost3_CheckedChanged(object sender, EventArgs e)
        {
            if (SLost3.Checked == true)
            {
                SLost.LinkColor = Color.Green;
                SLost1.ForeColor = Color.Green;
                SLost2.ForeColor = Color.Green;
                SLost3.ForeColor = Color.Green;
                SLost3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SLost")].Chk = true;
            }
            else
            {
                SLost.LinkColor = Color.Black;
                SLost1.ForeColor = Color.Black;
                SLost1.ForeColor = Color.Black;
                SLost3.ForeColor = Color.Black;
                SLost3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SLost")].Chk = false;
            }
        }

        private void NMedusa3_CheckedChanged(object sender, EventArgs e)
        {
            if (NMedusa3.Checked == true)
            {
                NMedusa.LinkColor = Color.Green;
                NMedusa1.ForeColor = Color.Green;
                NMedusa2.ForeColor = Color.Green;
                NMedusa3.ForeColor = Color.Green;
                NMedusa3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "NMedusa")].Chk = true;
            }
            else
            {
                NMedusa.LinkColor = Color.Black;
                NMedusa1.ForeColor = Color.Black;
                NMedusa1.ForeColor = Color.Black;
                NMedusa3.ForeColor = Color.Black;
                NMedusa3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "NMedusa")].Chk = false;
            }
        }

        private void KMountain3_CheckedChanged(object sender, EventArgs e)
        {
            if (KMountain3.Checked == true)
            {
                KMountain.LinkColor = Color.Green;
                KMountain1.ForeColor = Color.Green;
                KMountain2.ForeColor = Color.Green;
                KMountain3.ForeColor = Color.Green;
                KMountain3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KMountain")].Chk = true;
            }
            else
            {
                KMountain.LinkColor = Color.Black;
                KMountain1.ForeColor = Color.Black;
                KMountain1.ForeColor = Color.Black;
                KMountain3.ForeColor = Color.Black;
                KMountain3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KMountain")].Chk = false;
            }
        }

        private void NMedusaa3_CheckedChanged(object sender, EventArgs e)
        {
            if (NMedusaa3.Checked == true)
            {
                NMedusaa.LinkColor = Color.Green;
                NMedusaa1.ForeColor = Color.Green;
                NMedusaa2.ForeColor = Color.Green;
                NMedusaa3.ForeColor = Color.Green;
                NMedusaa3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "NMedusaa")].Chk = true;
            }
            else
            {
                NMedusaa.LinkColor = Color.Black;
                NMedusaa1.ForeColor = Color.Black;
                NMedusaa1.ForeColor = Color.Black;
                NMedusaa3.ForeColor = Color.Black;
                NMedusaa3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "NMedusaa")].Chk = false;
            }
        }

        private void KTorus3_CheckedChanged(object sender, EventArgs e)
        {
            if (KTorus3.Checked == true)
            {
                KTorus.LinkColor = Color.Green;
                KTorus1.ForeColor = Color.Green;
                KTorus2.ForeColor = Color.Green;
                KTorus3.ForeColor = Color.Green;
                KTorus3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KTorus")].Chk = true;
            }
            else
            {
                KTorus.LinkColor = Color.Black;
                KTorus1.ForeColor = Color.Black;
                KTorus1.ForeColor = Color.Black;
                KTorus3.ForeColor = Color.Black;
                KTorus3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KTorus")].Chk = false;
            }
        }

        private void HEnd3_CheckedChanged(object sender, EventArgs e)
        {
            if (HEnd3.Checked == true)
            {
                HEnd.LinkColor = Color.Green;
                HEnd1.ForeColor = Color.Green;
                HEnd2.ForeColor = Color.Green;
                HEnd3.ForeColor = Color.Green;
                HEnd3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "HEnd")].Chk = true;
            }
            else
            {
                HEnd.LinkColor = Color.Black;
                HEnd1.ForeColor = Color.Black;
                HEnd1.ForeColor = Color.Black;
                HEnd3.ForeColor = Color.Black;
                HEnd3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "HEnd")].Chk = false;
            }
        }

        private void KSeed3_CheckedChanged(object sender, EventArgs e)
        {
            if (KSeed3.Checked == true)
            {
                KSeed.LinkColor = Color.Green;
                KSeed1.ForeColor = Color.Green;
                KSeed2.ForeColor = Color.Green;
                KSeed3.ForeColor = Color.Green;
                KSeed3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KSeed")].Chk = true;
            }
            else
            {
                KSeed.LinkColor = Color.Black;
                KSeed1.ForeColor = Color.Black;
                KSeed1.ForeColor = Color.Black;
                KSeed3.ForeColor = Color.Black;
                KSeed3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KSeed")].Chk = false;
            }
        }

        private void HEndd3_CheckedChanged(object sender, EventArgs e)
        {
            if (HEndd3.Checked == true)
            {
                HEndd.LinkColor = Color.Green;
                HEndd1.ForeColor = Color.Green;
                HEndd2.ForeColor = Color.Green;
                HEndd3.ForeColor = Color.Green;
                HEndd3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "HEndd")].Chk = true;
            }
            else
            {
                HEndd.LinkColor = Color.Black;
                HEndd1.ForeColor = Color.Black;
                HEndd1.ForeColor = Color.Black;
                HEndd3.ForeColor = Color.Black;
                HEndd3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "HEndd")].Chk = false;
            }
        }

        private void YDoll3_CheckedChanged(object sender, EventArgs e)
        {
            if (YDoll3.Checked == true)
            {
                YDoll.LinkColor = Color.Green;
                YDoll1.ForeColor = Color.Green;
                YDoll2.ForeColor = Color.Green;
                YDoll3.ForeColor = Color.Green;
                YDoll3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "YDoll")].Chk = true;
            }
            else
            {
                YDoll.LinkColor = Color.Black;
                YDoll1.ForeColor = Color.Black;
                YDoll1.ForeColor = Color.Black;
                YDoll3.ForeColor = Color.Black;
                YDoll3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "YDoll")].Chk = false;
            }
        }

        private void KSeedd3_CheckedChanged(object sender, EventArgs e)
        {
            if (KSeedd3.Checked == true)
            {
                KSeedd.LinkColor = Color.Green;
                KSeedd1.ForeColor = Color.Green;
                KSeedd2.ForeColor = Color.Green;
                KSeedd3.ForeColor = Color.Green;
                KSeedd3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KSeedd")].Chk = true;
            }
            else
            {
                KSeedd.LinkColor = Color.Black;
                KSeedd1.ForeColor = Color.Black;
                KSeedd1.ForeColor = Color.Black;
                KSeedd3.ForeColor = Color.Black;
                KSeedd3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KSeedd")].Chk = false;
            }
        }

        private void KNothing3_CheckedChanged(object sender, EventArgs e)
        {
            if (KNothing3.Checked == true)
            {
                KNothing.LinkColor = Color.Green;
                KNothing1.ForeColor = Color.Green;
                KNothing2.ForeColor = Color.Green;
                KNothing3.ForeColor = Color.Green;
                KNothing3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KNothing")].Chk = true;
            }
            else
            {
                KNothing.LinkColor = Color.Black;
                KNothing1.ForeColor = Color.Black;
                KNothing1.ForeColor = Color.Black;
                KNothing3.ForeColor = Color.Black;
                KNothing3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KNothing")].Chk = false;
            }
        }

        private void KDead3_CheckedChanged(object sender, EventArgs e)
        {
            if (KDead3.Checked == true)
            {
                KDead.LinkColor = Color.Green;
                KDead1.ForeColor = Color.Green;
                KDead2.ForeColor = Color.Green;
                KDead3.ForeColor = Color.Green;
                KDead3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KDead")].Chk = true;
            }
            else
            {
                KDead.LinkColor = Color.Black;
                KDead1.ForeColor = Color.Black;
                KDead1.ForeColor = Color.Black;
                KDead3.ForeColor = Color.Black;
                KDead3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KDead")].Chk = false;
            }
        }

        private void MHell3_CheckedChanged(object sender, EventArgs e)
        {
            if (MHell3.Checked == true)
            {
                MHell.LinkColor = Color.Green;
                MHell1.ForeColor = Color.Green;
                MHell2.ForeColor = Color.Green;
                MHell3.ForeColor = Color.Green;
                MHell3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "MHell")].Chk = true;
            }
            else
            {
                MHell.LinkColor = Color.Black;
                MHell1.ForeColor = Color.Black;
                MHell1.ForeColor = Color.Black;
                MHell3.ForeColor = Color.Black;
                MHell3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "MHell")].Chk = false;
            }
        }

        private void HRendezvous3_CheckedChanged(object sender, EventArgs e)
        {
            if (HRendezvous3.Checked == true)
            {
                HRendezvous.LinkColor = Color.Green;
                HRendezvous1.ForeColor = Color.Green;
                HRendezvous2.ForeColor = Color.Green;
                HRendezvous3.ForeColor = Color.Green;
                HRendezvous3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "HRendezvous")].Chk = true;
            }
            else
            {
                HRendezvous.LinkColor = Color.Black;
                HRendezvous1.ForeColor = Color.Black;
                HRendezvous1.ForeColor = Color.Black;
                HRendezvous3.ForeColor = Color.Black;
                HRendezvous3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "HRendezvous")].Chk = false;
            }
        }

        private void ODark3_CheckedChanged(object sender, EventArgs e)
        {
            if (ODark3.Checked == true)
            {
                ODark.LinkColor = Color.Green;
                ODark1.ForeColor = Color.Green;
                ODark2.ForeColor = Color.Green;
                ODark3.ForeColor = Color.Green;
                ODark3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "ODark")].Chk = true;
            }
            else
            {
                ODark.LinkColor = Color.Black;
                ODark1.ForeColor = Color.Black;
                ODark1.ForeColor = Color.Black;
                ODark3.ForeColor = Color.Black;
                ODark3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "ODark")].Chk = false;
            }
        }

        private void KReverse3_CheckedChanged(object sender, EventArgs e)
        {
            if (KReverse3.Checked == true)
            {
                KReverse.LinkColor = Color.Green;
                KReverse1.ForeColor = Color.Green;
                KReverse2.ForeColor = Color.Green;
                KReverse3.ForeColor = Color.Green;
                KReverse3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KReverse")].Chk = true;
            }
            else
            {
                KReverse.LinkColor = Color.Black;
                KReverse1.ForeColor = Color.Black;
                KReverse1.ForeColor = Color.Black;
                KReverse3.ForeColor = Color.Black;
                KReverse3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "KReverse")].Chk = false;
            }
        }

        private void SDevil3_CheckedChanged(object sender, EventArgs e)
        {
            if (SDevil3.Checked == true)
            {
                SDevil.LinkColor = Color.Green;
                SDevil1.ForeColor = Color.Green;
                SDevil2.ForeColor = Color.Green;
                SDevil3.ForeColor = Color.Green;
                SDevil3.Text = "Просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SDevil")].Chk = true;
            }
            else
            {
                SDevil.LinkColor = Color.Black;
                SDevil1.ForeColor = Color.Black;
                SDevil1.ForeColor = Color.Black;
                SDevil3.ForeColor = Color.Black;
                SDevil3.Text = "Не просмотрено";
                checkers[checkers.FindIndex(a => a.Name == "SDevil")].Chk = false;
            }
        }
        #endregion

        #region(OPs Click)
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

        //August arc ling
        private void label49_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://i.imgur.com/6yMK6uS.png"); 
        }

        //Help link
        private void горячиеКлавишиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ЛКМ на арке - опенинг.\nПКМ на арке - эндинг.\nДанные сохраняются автоматически при выходе из приложения.\nХронологию событий 20-25 августа можно посмотреть подробнее, щелкнув на августе ЛКМ.", "Помощь", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
