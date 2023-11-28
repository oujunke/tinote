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
            if (screen.WorkingArea.Width - point.X< image.Width&&point.X < screen.WorkingArea.Left+screen.WorkingArea.Width / 2)
            {
                point.X = screen.WorkingArea.Left;
            }
            showImgForm.Size = new Size(Math.Min(image.Width,screen.WorkingArea.Width-point.X),
                Math.Min(image.Height, screen.WorkingArea.Height - point.Y));
            point.X = point.X - showImgForm.Size.Width;
            showImgForm.Location = point;
            showImgForm.Show();
        }
        public static void HideForm()
        {
            showImgForm?.Hide();
        }
    }
}
