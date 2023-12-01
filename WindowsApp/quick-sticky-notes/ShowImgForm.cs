using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_sticky_notes
{
    public partial class ShowImgForm : Form
    {
        public Image Image { private set; get; }
        private static ShowImgForm showImgForm;
        public ShowImgForm()
        {
            InitializeComponent();
        }
        public void SetImage(Image image)
        {
            Image = image;
            pictureBox1.Image = Image;
        }
        public static void ShowForm(Image image,Point point)
        {
            if (showImgForm == null)
            {
                showImgForm=new ShowImgForm();
            }
            showImgForm.SetImage(image);
            var screen=Screen.FromPoint(point);
            var newPonit = new Point(point.X,point.Y);
            if (screen.WorkingArea.Width - point.X< image.Width&&point.X > screen.WorkingArea.Left+screen.WorkingArea.Width / 2)
            {
                newPonit.X = screen.WorkingArea.Left;
            }
            if(screen.WorkingArea.Height-newPonit.Y< image.Height)
            {
                newPonit.Y = Math.Max(screen.WorkingArea.Y, screen.WorkingArea.Y + (screen.WorkingArea.Height - image.Height));
            }
            showImgForm.Size = new Size(Math.Min(image.Width,screen.WorkingArea.Width- newPonit.X),
                Math.Min(image.Height, screen.WorkingArea.Height - newPonit.Y));
            newPonit.X = point.X - showImgForm.Size.Width;
            showImgForm.Location = newPonit;
            showImgForm.Show();
        }
        public static void HideForm()
        {
            showImgForm?.Hide();
        }
    }
}
