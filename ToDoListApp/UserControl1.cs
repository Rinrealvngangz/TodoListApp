using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace ToDoListApp
{
    
    public partial class UserControl1 : UserControl
    {
      
        public UserControl1()
        {
            InitializeComponent();
            string hex = "#dfe4ea";
            Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
   
        }
      
        #region proper   
        private string _text;
        private List<UserControl1> _item;

        public string text { get { return _text; } set { _text = value; label1.Text = value; } }
        public CheckBox checkbox { get { return checkbox1; } set { checkbox1.Checked = false; } }
        public List<UserControl1> item { get { return _item; } set { _item = value; } }

        #endregion

        private void PanelContro_MouseHover(object sender, EventArgs e)
        {
            changeBackPanel();
        }

        private void PanelContro_MouseLeave(object sender, EventArgs e)
        {
            changeBackPanelOrigin();
        }

        private void lbtext_MouseHover(object sender, EventArgs e)
        {
            changeBackPanel();
        }

        private void lbtext_MouseLeave(object sender, EventArgs e)
        {
            changeBackPanelOrigin();
        }
        public void changeBackPanel()
        {
            string hex = "#dfe4ea";
            Color _color = System.Drawing.ColorTranslator.FromHtml(hex);
            if (PanelContro.BackColor == Color.White)
                PanelContro.BackColor = _color;
        }
        public void changeBackPanelOrigin()
        {
            PanelContro.BackColor = Color.White;
        }
        
        //private void ScaleFont(Label lab)
        //{
        //    SizeF extent = TextRenderer.MeasureText(lab.Text, lab.Font);

        //    float hRatio = lab.Height / extent.Height;
        //    float wRatio = lab.Width / extent.Width;
        //    float ratio = (hRatio < wRatio) ? hRatio : wRatio;

        //    float newSize = lab.Font.Size * ratio;

        //    lab.Font = new Font(lab.Font.FontFamily, newSize, lab.Font.Style);
        //}
        
    }

}

