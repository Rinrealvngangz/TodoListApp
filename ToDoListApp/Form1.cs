using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ToDoListApp.Properties;

namespace ToDoListApp 
{
    public partial class Form1 : Form
    {
        int yTodo, yWork,yMovie,yFamily;
        int yFirst = 133;
        Panel pn = new Panel();
       List<UserControl1> Listitem = new List<UserControl1>();
        List<UserControl1> ListitemTodo = new List<UserControl1>();
        List<UserControl1> ListitemWork = new List<UserControl1>();
        List<UserControl1> ListitemMovie = new List<UserControl1>();
        List<UserControl1> ListitemFamily = new List<UserControl1>();
        string strimgBefore = "C://Users//Tuan//Downloads//icons8-delete-64.png";
        Image imgBefore;
        string dataMyday = Application.StartupPath + "//dulieuMyday.txt";
        string dataTodo = Application.StartupPath + "//dulieuTodo.txt";
        string dataWork = Application.StartupPath + "//dulieuWork.txt";
        string dataMovie = Application.StartupPath + "//dulieuMovie.txt";
        string dataFamily = Application.StartupPath + "//dulieuFamily.txt";
        public Form1()
        {
            InitializeComponent();
             yTodo = pnTodo.Location.Y - pnMyday.Location.Y;
            yWork = pnWork.Location.Y - pnTodo.Location.Y;
            yMovie = pnMovie.Location.Y - pnWork.Location.Y;
            yFamily = pnFamily.Location.Y - pnMovie.Location.Y;
            pn.Width = 5;
            pn.Height = pnTodo.Height;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            imgBefore = Image.FromFile(strimgBefore);
            picClear.Image = imgBefore;
            timer1.Enabled = true;
        }
      
        //Xử lý giao diện load Data
        private void pnMyday_Click(object sender, EventArgs e)
        {
                 
            flowLayoutPanel2.Controls.Clear();
            lbstatus.Text = pnMyday.Text;
            pn.BackColor = Color.Yellow;
            pn.Location = new Point(3, yFirst);
            pncustom.Controls.Add(pn);
          
            if (lbstatus.Text == pnMyday.Text)
           {
                Listitem = FileFactory.ReadFile(dataMyday);
                DisplayInfo(Listitem);
            }

        }     
        private void pnTodo_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();          
            lbstatus.Text = pnTodo.Text;
            pn.BackColor = Color.Yellow;     
            pn.Location = new Point(3,yFirst+yTodo);
            pncustom.Controls.Add(pn);
           if (lbstatus.Text == pnTodo.Text)
            {

                ListitemTodo = FileFactory.ReadFile(dataTodo);
                DisplayInfo(ListitemTodo);
            }
        }
        private void pnWork_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            lbstatus.Text = pnWork.Text;
            pn.BackColor = Color.Yellow;
            pn.Location = new Point(3, yFirst + yTodo + yWork);
            pncustom.Controls.Add(pn);
            if (lbstatus.Text == pnWork.Text)
            {
                ListitemWork = FileFactory.ReadFile(dataWork);
                DisplayInfo(ListitemWork);
            }
        }
        private void pnMovie_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            lbstatus.Text = pnMovie.Text;
            pn.BackColor = Color.Yellow;
            pn.Location = new Point(3, yFirst + yTodo + yWork + yMovie);
            pncustom.Controls.Add(pn);
            if (lbstatus.Text == pnMovie.Text)
            {

                ListitemMovie = FileFactory.ReadFile(dataMovie);
                DisplayInfo(ListitemMovie);
            }
        }
        private void pnFamily_Click(object sender, EventArgs e)
        {

            flowLayoutPanel2.Controls.Clear();
            lbstatus.Text = pnFamily.Text;
            pn.BackColor = Color.Yellow;
            pn.Location = new Point(3, yFirst + yTodo + yWork + yMovie + yFamily);
            pncustom.Controls.Add(pn);
            if (lbstatus.Text == pnFamily.Text)
            {
                ListitemFamily = FileFactory.ReadFile(dataFamily);
                DisplayInfo(ListitemFamily);
            }

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            if(lbName.Text != "")
            lbName.PlaceholderText = "";
            if(lbName.Text =="")
            lbName.PlaceholderText = "Name";
            
        }


       //View GUI
        private void btnadd_Click(object sender, EventArgs e)
        {
            if (pnMyday.Text == lbstatus.Text)
            {

                XulyDulieu(Listitem, dataMyday);

            }
            else if (pnTodo.Text == lbstatus.Text)
            {

                XulyDulieu(ListitemTodo, dataTodo);
            }
            else if (pnWork.Text == lbstatus.Text)
            {
                XulyDulieu(ListitemWork, dataWork);

            }
            else if (pnMovie.Text == lbstatus.Text)
            {
                XulyDulieu(ListitemMovie, dataMovie);
            }
            else if (pnFamily.Text == lbstatus.Text)
            {
                XulyDulieu(ListitemFamily, dataFamily);
            }
            else
                return;
        }

        private void guna2CirclePictureBox2_Click(object sender, EventArgs e)
        {
            if (pnMyday.Text == lbstatus.Text)
            {

                DeleteNote(Listitem, dataMyday);

            }
            else if (pnTodo.Text == lbstatus.Text)
            {

                DeleteNote(ListitemTodo, dataTodo);
            }
            else if (pnWork.Text == lbstatus.Text)
            {
                DeleteNote(ListitemWork, dataWork);

            }
            else if (pnMovie.Text == lbstatus.Text)
            {
                DeleteNote(ListitemMovie, dataMovie);
            }
            else
                DeleteNote(ListitemFamily, dataFamily);

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (tbUpdate.Visible == false)
                tbUpdate.Visible = true;
            else tbUpdate.Visible = false;

            if (pnMyday.Text == lbstatus.Text)
            {

                UpdateNote(Listitem, dataMyday);

            }
            else if (pnTodo.Text == lbstatus.Text)
            {

                UpdateNote(ListitemTodo, dataTodo);
            }
            else if (pnWork.Text == lbstatus.Text)
            {
                UpdateNote(ListitemWork, dataWork);

            }
            else if (pnMovie.Text == lbstatus.Text)
            {
                UpdateNote(ListitemMovie, dataMovie);
            }
            else
                UpdateNote(ListitemFamily, dataFamily);

        }
        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            string strimgAfter = "C://Users//Tuan//Downloads//icons8-delete-64 (1).png";
            Image imgAfter = Image.FromFile(strimgAfter);
            if (picClear.Image == imgBefore)
                picClear.Image = imgAfter;
            else
                picClear.Image = imgBefore;

            if (pnMyday.Text == lbstatus.Text)
            {

                DeleteAll(Listitem, dataMyday);

            }
            else if (pnTodo.Text == lbstatus.Text)
            {

                DeleteAll(ListitemTodo, dataTodo);
            }
            else if (pnWork.Text == lbstatus.Text)
            {
                DeleteAll(ListitemWork, dataWork);

            }
            else if (pnMovie.Text == lbstatus.Text)
            {
                DeleteAll(ListitemMovie, dataMovie);
            }
            else
                DeleteAll(ListitemFamily, dataFamily);

        }
        private void picdel_MouseHover(object sender, EventArgs e)
        {
            string strimg = "C://Users//Tuan//Downloads//icons8-trash-64 (1).png";
            Image img = Image.FromFile(strimg);
            picdel.Image = img;
        }

        private void picdel_MouseLeave(object sender, EventArgs e)
        {
            string strimg = "C://Users//Tuan//Downloads//icons8-trash-64.png";
            Image img = Image.FromFile(strimg);
            picdel.Image = img;
        }
        public void DisplayInfo(List<UserControl1> List)
        {
            for (int i = 0; i < List.Count; i++)
            {
                flowLayoutPanel2.Controls.Add(List[i]);
            }
        }
        //Controller
        public void XulyDulieu(List<UserControl1> List,string data)
        {

            AddNote(List);
            DisplayInfo(List);
            Savedata(List, data);

        }
        public void AddNote(List<UserControl1> List)
        {
            if (tbadd.Text == "") return;

            flowLayoutPanel2.AutoScroll = true;
            UserControl1 note = new UserControl1();
            note.text = tbadd.Text;
            tbadd.Text = "";
            List.Add(note);      
        }
            
        public void DeleteNote(List<UserControl1> List,string data)
        {
           
            for (int i = 0; i < List.Count; i++)
            {
                if (List[i].checkbox.Checked == true)
                {
                    flowLayoutPanel2.Controls.Remove(List[i]);
                    List.RemoveAt(i);
                    i--;
                }
            }
            Savedata(List, data);
        }
          
      public void UpdateNote(List<UserControl1> List, string path)
        {
            for (int i = 0; i < List.Count; i++)
            {

                if (List[i].checkbox.Checked == true)
                {
                    if (tbUpdate.Text != "")
                    {
                        List[i].text = tbUpdate.Text;
                        List[i].checkbox.Checked = false;
                    }
                }
            }
            tbUpdate.Text = "";
            Savedata(List, path);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
        }

        private void gunaPictureBox1_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("Bạn muốn Thoát Chương trình", "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        public void DeleteAll(List<UserControl1> item, string path)
        {
            for (int i = 0; i < item.Count; i++)
            {
                flowLayoutPanel2.Controls.Remove(item[i]);
                item.Remove(item[i]);
                i--;
            }
            Savedata(item, path);
        }
        public void loadDuLieuMyDay(string data)
        {
            try
            {
                if (System.IO.File.Exists(data))
                {
                    Listitem = FileFactory.ReadFile(data);
                    DisplayInfo(Listitem);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
        public void Savedata(List <UserControl1> item, string path)
        {
            try
            {
                FileFactory.SaveFile(item, path);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    
    }

}
