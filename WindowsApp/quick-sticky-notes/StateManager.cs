using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace quick_sticky_notes
{
    public class StateManager
    {
        public static string GetStateText(int state)
        {
            switch (state)
            {
                case 0:
                    return "已创建";
                case 1:
                    return "进行中";
                case 2:
                    return "已完成";
                case 3:
                    return "已暂停";
                case 4:
                    return "已搁置";
                case 5:
                    return "已取消";
                default:
                    return "未知";
            }
        }
        public static int GetStateInt(string state)
        {
            switch (state)
            {
                case "已创建":
                    return 0;
                case "进行中":
                    return 1;
                case "已完成":
                    return 2;
                case "已暂停":
                    return 3;
                case "已搁置":
                    return 4;
                case "已取消":
                    return 5;
                default:
                    return -1;
            }
        }
        public static Color GetStateColor(int state)
        {
            switch (state)
            {
                case 0:
                    return Color.Black;
                case 1:
                    return Color.White;
                case 2:
                    return Color.Green;
                case 3:
                    return Color.Blue;
                case 4:
                    return Color.DarkRed;
                case 5:
                    return Color.Red;
                default:
                    return Color.Sienna;
            }
        }
        public static void InitToolStripMenuItem(ToolStripMenuItem toolStripMenuItem, Action<object, EventArgs> action)
        {
            for (int i = 0; i < 6; i++)
            {
                Image image = new Bitmap(40, 40);
                Graphics graphics = Graphics.FromImage(image);
                var color = GetStateColor(i);

                graphics.FillEllipse(new SolidBrush(color), new RectangleF(0, 0, image.Width, image.Width));
                graphics.Dispose();
                ToolStripMenuItem tempItem = new ToolStripMenuItem(GetStateText(i), image, new EventHandler(action));
                toolStripMenuItem.DropDownItems.Add(tempItem);
            }
        }
    }
}
