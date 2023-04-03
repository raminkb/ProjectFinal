using System.Numerics;
using ProjectFinal.Class;

namespace ProjectFinal
{
    public partial class Form1 : Form
    {
        private All all;
        List<All> allstudent = new List<All>();
        public Form1()
        {
            InitializeComponent();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (All item in allstudent)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4}",
                            item.studentname,
                            item.studentlastname,
                            item.studentid,
                            item.floor,
                            item.room));
                    }
                }
            }
        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string fileName = openFileDialog1.FileName;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                all = new All()
                {
                    studentname = textBoxName.Text,
                    studentlastname = textBoxLastname.Text,
                    floor = textBoxFloor.Text,
                    room = textBoxRoom.Text,
                };
     
            }
            catch 
            {
                MessageBox.Show("กรอกข้อมูลไม่ครบถ้วน");
            }
            this.DialogResult= DialogResult.OK;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
    
}