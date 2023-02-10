using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TowerUnite_Rom_Downloader {
    public partial class Form1 : Form {
        private readonly List<CheckBox> _Consoles;
        private readonly List<CheckBox> _Handhelds;
        private string _UserDir = null;

        public Form1() {
            InitializeComponent();
            
        }

        private void OpenSelctedItemsBTN_Click(object sender, EventArgs e) {
            if (DownloadAllRomsCD.Checked != true) {

            } else {

            }
        }

        private void TowerUniteSteamdirectoryBTN_CLICK(object sender, EventArgs e) {
            FolderBrowserDialog d = new FolderBrowserDialog();
            d.ShowDialog();
            TowerUniteSteamdirectoryPAHT.Text = d.SelectedPath;
        }
    }
}
