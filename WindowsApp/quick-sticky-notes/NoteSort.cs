using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_sticky_notes
{
    public class NoteSort : IComparer<Note>
    {
        public static List<int> StateSortList = new List<int> {1,0,3,2,4,5 };
        public static string StateText;
        public static string SortText;
        public static string DateText;
        public int Compare(Note x, Note y)
        {
            if (SortText == "时间升序")
            {
                return x.dateCreated < y.dateCreated ? -1 : 1;
            }
            else if (SortText == "时间逆序")
            {
                return x.dateCreated > y.dateCreated ? -1 : 1;
            }
            else
            {
                if (x.state == y.state)
                {
                    return x.dateCreated < y.dateCreated ? -1 : 1;
                }
                else
                {
                    return (StateSortList.IndexOf(x.state) < StateSortList.IndexOf(y.state)) ? -1 : 1;
                }
            }
        }
        public static List<Note> GetNodeList(List<Note> notes)
        {
            IEnumerable<Note> ie = notes;
            var state = StateManager.GetStateInt(StateText);
            if (state > -1)
            {
                ie = ie.Where(n=>n.state==state);
            }
            if (!string.IsNullOrEmpty(DateText)) {
                switch (DateText)
                {
                    case "今天":
                        ie = ie.Where(n => n.dateCreated.Date == DateTime.Now.Date);
                        break;
                    case "近两天":
                        ie = ie.Where(n => (DateTime.Now.Date-n.dateCreated.Date).TotalDays<=2);
                        break;
                    case "近三天":
                        ie = ie.Where(n => (DateTime.Now.Date - n.dateCreated.Date).TotalDays <= 3);
                        break;
                    case "近七天":
                        ie = ie.Where(n => (DateTime.Now.Date - n.dateCreated.Date).TotalDays <= 7);
                        break;
                    case "近半个月":
                        ie = ie.Where(n => (DateTime.Now.Date - n.dateCreated.Date).TotalDays <= 15);
                        break;
                    case "近一个月":
                        ie = ie.Where(n => (DateTime.Now.Date - n.dateCreated.Date).TotalDays <= 30);
                        break;
                    case "近三个月":
                        ie = ie.Where(n => (DateTime.Now.Date - n.dateCreated.Date).TotalDays <= 90);
                        break;
                    case "近半年":
                        ie = ie.Where(n => (DateTime.Now.Date - n.dateCreated.Date).TotalDays <= 180);
                        break;
                    case "近一年":
                        ie = ie.Where(n => (DateTime.Now.Date - n.dateCreated.Date).TotalDays <= 365);
                        break;
                } }
            var res = ie.ToList();
            res.Sort(new NoteSort());
            return res;
        }
    }
}
