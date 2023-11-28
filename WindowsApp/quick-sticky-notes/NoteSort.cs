using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sticky_notes
{
    public class NodeSort : IComparer<Note>
    {
        public static List<int> StateSortList = new List<int> {1,0,3,2,4,5 };
        public int Compare(Note x, Note y)
        {
            if (x.state == y.state)
            {
                return x.dateCreated < y.dateCreated ? -1 : 1;
            }
            else
            {
                return (StateSortList.IndexOf(x.state)< StateSortList.IndexOf(y.state))?-1:1;
            }
        }
        public static NodeSort GetNodeSort()
        {
            return new NodeSort();
        }
    }
}
