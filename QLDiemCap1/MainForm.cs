using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDiemCap1
{
    public partial class MainForm : Form
    {
        private Panel currenPanelActive;
        private Button currentButtonActive;
        private bool mouseDown;
        private Point lastLocation;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            currenPanelActive = pnThongTin;
            currentButtonActive = btlThongTin;
            updateMenu(ref pnThongTin, ref btlThongTin, tpThongTin);
        }

        private void updateMenu(ref Panel selectedPanel, ref Button selectedButton, TabPage selectedTabPage)
        {
            currenPanelActive.BackColor = Color.FromArgb(42, 63, 84);
            currentButtonActive.BackColor = Color.FromArgb(42, 63, 84);
            currenPanelActive = selectedPanel;
            currentButtonActive = selectedButton;
            selectedPanel.BackColor = Color.FromArgb(26, 187, 156);
            selectedButton.BackColor = Color.FromArgb(53, 73, 93);
            tabControl1.SelectedTab = selectedTabPage;
        }

        private void btlThongTin_Click(object sender, EventArgs e)
        {
            updateMenu(ref pnThongTin, ref btlThongTin, tpThongTin);
        }

        private void btlNhapDiem_Click(object sender, EventArgs e)
        {
            updateMenu(ref pnNhapDiem, ref btlNhapDiem, tpNhapDiem);
        }

        private void btlNhapTuFile_Click(object sender, EventArgs e)
        {
            updateMenu(ref pnNhapTuFile, ref btlNhapTuFile, tpNhapTuFile);
        }

        private void btlTraCuu_Click(object sender, EventArgs e)
        {
            updateMenu(ref pnTraCuu, ref btlTraCuu, tpTraCuu);
        }

        private void btlGioiThieu_Click(object sender, EventArgs e)
        {
            updateMenu(ref pnGioiThieu, ref btlGioiThieu, tpGioiThieu);
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MainForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }

}



