using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public Mem m = new Mem();

        private void Form1_Load(object sender, EventArgs e)
        {
            int PID = m.GetProcIdFromName("rpcs3");
            if (PID > 0)
            {
                m.OpenProcess(PID);
                connectionLabel.Text = "Connected";
                connectionLabel.ForeColor = Color.Green;
                pidLabel.Text = PID.ToString();
                string name = m.ReadString("0x30098EBBC");
                username.Text = name + "!";
            }
            else
            {
                connectionLabel.Text = "N/A";
                connectionLabel.ForeColor = Color.Red;
                pidLabel.Text = "N/A";
                pidLabel.ForeColor = Color.Red;
            }
        }
        public void CustomizationEucadian()
        {
            if (!m.OpenProcess("rpcs3"))
            {
                MessageBox.Show("Process Is Not Found or Open!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //
            // Head Eucadian
            //
            if (headE.Value == 1)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x0", "", null, false);

            }
            else if (headE.Value == 2)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x1", "", null, false);

            }
            else if (headE.Value == 3)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x2", "", null, false);

            }
            else if (headE.Value == 4)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x3", "", null, false);

            }
            else if (headE.Value == 5)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x4", "", null, false);

            }
            else if (headE.Value == 6)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x5", "", null, false);

            }
            else if (headE.Value == 7)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x6", "", null, false);

            }
            else if (headE.Value == 8)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x7", "", null, false);

            }
            else if (headE.Value == 9)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x8", "", null, false);

            }
            else if (headE.Value == 10)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x9", "", null, false);

            }
            else if (headE.Value == 11)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x0A", "", null, false);

            }
            else if (headE.Value == 12)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x0B", "", null, false);

            }
            else if (headE.Value == 13)
            {

                m.WriteMemory("0x342CCE603", "byte", "0x0C", "", null, false);

            }
            //
            // Upper Eucadian
            //
            if (upperE.Value == 1)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x0", "", null, false);

            }
            else if (upperE.Value == 2)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x1", "", null, false);

            }
            else if (upperE.Value == 3)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x2", "", null, false);

            }
            else if (upperE.Value == 4)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x3", "", null, false);

            }
            else if (upperE.Value == 5)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x4", "", null, false);

            }
            else if (upperE.Value == 6)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x5", "", null, false);

            }
            else if (upperE.Value == 7)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x6", "", null, false);

            }
            else if (upperE.Value == 8)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x7", "", null, false);

            }
            else if (upperE.Value == 9)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x8", "", null, false);

            }
            else if (upperE.Value == 10)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x9", "", null, false);

            }
            else if (upperE.Value == 11)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x0A", "", null, false);

            }
            else if (upperE.Value == 12)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x0B", "", null, false);

            }
            else if (upperE.Value == 13)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x0C", "", null, false);

            }
            else if (upperE.Value == 14)
            {

                m.WriteMemory("0x342CCE605", "byte", "0x0D", "", null, false);

            }
            //
            // Lower Eucadian
            //
            if (lowerE.Value == 1)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x0", "", null, false);

            }
            else if (lowerE.Value == 2)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x1", "", null, false);

            }
            else if (lowerE.Value == 3)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x2", "", null, false);

            }
            else if (lowerE.Value == 4)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x3", "", null, false);

            }
            else if (lowerE.Value == 5)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x4", "", null, false);

            }
            else if (lowerE.Value == 6)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x5", "", null, false);

            }
            else if (lowerE.Value == 7)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x6", "", null, false);

            }
            else if (lowerE.Value == 8)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x7", "", null, false);

            }
            else if (lowerE.Value == 9)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x8", "", null, false);

            }
            else if (lowerE.Value == 10)
            {

                m.WriteMemory("0x342CCE607", "byte", "0x9", "", null, false);

            }
            //
            // Plane Eucadian
            //
            if (planeE.Value == 1)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x0", "", null, false);

            }
            else if (planeE.Value == 2)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x1", "", null, false);

            }
            else if (planeE.Value == 3)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x2", "", null, false);

            }
            else if (planeE.Value == 4)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x3", "", null, false);

            }
            else if (planeE.Value == 5)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x4", "", null, false);

            }
            else if (planeE.Value == 6)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x5", "", null, false);

            }
            else if (planeE.Value == 7)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x6", "", null, false);

            }
            else if (planeE.Value == 8)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x7", "", null, false);

            }
            else if (planeE.Value == 9)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x8", "", null, false);

            }
            else if (planeE.Value == 10)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x9", "", null, false);

            }
            else if (planeE.Value == 11)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x0A", "", null, false);

            }
            else if (planeE.Value == 12)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x0B", "", null, false);

            }
            else if (planeE.Value == 13)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x0C", "", null, false);

            }
            else if (planeE.Value == 14)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x0D", "", null, false);

            }
            else if (planeE.Value == 15)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x0E", "", null, false);

            }
            else if (planeE.Value == 16)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x0F", "", null, false);

            }
            else if (planeE.Value == 17)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x10", "", null, false);

            }
            else if (planeE.Value == 18)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x11", "", null, false);

            }
            else if (planeE.Value == 19)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x12", "", null, false);

            }
            else if (planeE.Value == 20)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x13", "", null, false);

            }
            else if (planeE.Value == 21)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x14", "", null, false);

            }
            else if (planeE.Value == 22)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x15", "", null, false);

            }
            else if (planeE.Value == 23)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x16", "", null, false);

            }
            else if (planeE.Value == 24)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x17", "", null, false);

            }
            else if (planeE.Value == 25)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x18", "", null, false);

            }
            else if (planeE.Value == 26)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x19", "", null, false);

            }
            else if (planeE.Value == 27)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x1A", "", null, false);

            }
            else if (planeE.Value == 28)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x1B", "", null, false);

            }
            else if (planeE.Value == 29)
            {

                m.WriteMemory("0x342CCE60B", "byte", "0x1C", "", null, false);

            }
        }

        public void CustomizationChernovan()
        {
            if (!m.OpenProcess("rpcs3"))
            {
                MessageBox.Show("Process Is Not Found or Open!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //
            // Head Chernovan
            //
            if (headC.Value == 1)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x0", "", null, false);

            }
            else if (headC.Value == 2)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x1", "", null, false);

            }
            else if (headC.Value == 3)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x2", "", null, false);

            }
            else if (headC.Value == 4)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x3", "", null, false);

            }
            else if (headC.Value == 5)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x4", "", null, false);

            }
            else if (headC.Value == 6)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x5", "", null, false);

            }
            else if (headC.Value == 7)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x6", "", null, false);

            }
            else if (headC.Value == 8)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x7", "", null, false);

            }
            else if (headC.Value == 9)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x8", "", null, false);

            }
            else if (headC.Value == 10)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x9", "", null, false);

            }
            else if (headC.Value == 11)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x0A", "", null, false);

            }
            else if (headC.Value == 12)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x0B", "", null, false);

            }
            else if (headC.Value == 13)
            {

                m.WriteMemory("0x342CCE604", "byte", "0x0C", "", null, false);

            }
            //
            // Upper Chernovan
            //
            if (upperC.Value == 1)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x0", "", null, false);

            }
            else if (upperC.Value == 2)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x1", "", null, false);

            }
            else if (upperC.Value == 3)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x2", "", null, false);

            }
            else if (upperC.Value == 4)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x3", "", null, false);

            }
            else if (upperC.Value == 5)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x4", "", null, false);

            }
            else if (upperC.Value == 6)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x5", "", null, false);

            }
            else if (upperC.Value == 7)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x6", "", null, false);

            }
            else if (upperC.Value == 8)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x7", "", null, false);

            }
            else if (upperC.Value == 9)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x8", "", null, false);

            }
            else if (upperC.Value == 10)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x9", "", null, false);

            }
            else if (upperC.Value == 11)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x0A", "", null, false);

            }
            else if (upperC.Value == 12)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x0B", "", null, false);

            }
            else if (upperC.Value == 13)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x0C", "", null, false);

            }
            else if (upperC.Value == 14)
            {

                m.WriteMemory("0x342CCE606", "byte", "0x0D", "", null, false);

            }
            //
            // Lower Chernovan
            //
            if (lowerC.Value == 1)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x0", "", null, false);

            }
            else if (lowerC.Value == 2)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x1", "", null, false);

            }
            else if (lowerC.Value == 3)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x2", "", null, false);

            }
            else if (lowerC.Value == 4)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x3", "", null, false);

            }
            else if (lowerC.Value == 5)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x4", "", null, false);

            }
            else if (lowerC.Value == 6)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x5", "", null, false);

            }
            else if (lowerC.Value == 7)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x6", "", null, false);

            }
            else if (lowerC.Value == 8)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x7", "", null, false);

            }
            else if (lowerC.Value == 9)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x8", "", null, false);

            }
            else if (lowerC.Value == 10)
            {

                m.WriteMemory("0x342CCE608", "byte", "0x9", "", null, false);

            }
            //
            // Plane Chernovan
            //
            if (planeC.Value == 1)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x0", "", null, false);

            }
            else if (planeC.Value == 2)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x1", "", null, false);

            }
            else if (planeC.Value == 3)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x2", "", null, false);

            }
            else if (planeC.Value == 4)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x3", "", null, false);

            }
            else if (planeC.Value == 5)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x4", "", null, false);

            }
            else if (planeC.Value == 6)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x5", "", null, false);

            }
            else if (planeC.Value == 7)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x6", "", null, false);

            }
            else if (planeC.Value == 8)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x7", "", null, false);

            }
            else if (planeC.Value == 9)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x8", "", null, false);

            }
            else if (planeC.Value == 10)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x9", "", null, false);

            }
            else if (planeC.Value == 11)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x0A", "", null, false);

            }
            else if (planeC.Value == 12)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x0B", "", null, false);

            }
            else if (planeC.Value == 13)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x0C", "", null, false);

            }
            else if (planeC.Value == 14)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x0D", "", null, false);

            }
            else if (planeC.Value == 15)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x0E", "", null, false);

            }
            else if (planeC.Value == 16)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x0F", "", null, false);

            }
            else if (planeC.Value == 17)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x10", "", null, false);

            }
            else if (planeC.Value == 18)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x11", "", null, false);

            }
            else if (planeC.Value == 19)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x12", "", null, false);

            }
            else if (planeC.Value == 20)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x13", "", null, false);

            }
            else if (planeC.Value == 21)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x14", "", null, false);

            }
            else if (planeC.Value == 22)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x15", "", null, false);

            }
            else if (planeC.Value == 23)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x16", "", null, false);

            }
            else if (planeC.Value == 24)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x17", "", null, false);

            }
            else if (planeC.Value == 25)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x18", "", null, false);

            }
            else if (planeC.Value == 26)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x19", "", null, false);

            }
            else if (planeC.Value == 27)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x1A", "", null, false);

            }
            else if (planeC.Value == 28)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x1B", "", null, false);

            }
            else if (planeC.Value == 29)
            {

                m.WriteMemory("0x342CCE60C", "byte", "0x1C", "", null, false);

            }

        }

        private void ChernovanSet_Click(object sender, EventArgs e)
        {
            CustomizationChernovan();
        }

        private void EucadianSet_Click(object sender, EventArgs e)
        {
            CustomizationEucadian();
        }
    }
}
