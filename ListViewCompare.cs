using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reapEAT
{
    /// <summary>
    /// It's better to have 4 classes. Having one is slover couse each compare has to do 2 "if" commands.
    /// </summary>

    class ListViewStringComparerAsc : IComparer
    {
        private readonly int column;
        public ListViewStringComparerAsc()
        {
            column = 0;
        }
        public ListViewStringComparerAsc(int column)
        {
            this.column = column;
        }
        public int Compare(object x, object y)
        {
            return string.Compare(((ListViewItem)x).SubItems[column].Text, ((ListViewItem)y).SubItems[column].Text);
        }
    }

    class ListViewStringComparerDsc : IComparer
    {
        private readonly int column;
        public ListViewStringComparerDsc()
        {
            column = 0;
        }
        public ListViewStringComparerDsc(int column)
        {
            this.column = column;
        }
        public int Compare(object x, object y)
        {
            return string.Compare(((ListViewItem)y).SubItems[column].Text, ((ListViewItem)x).SubItems[column].Text);
        }
    }

    class ListViewIntComparerAsc : IComparer
    {
        private readonly int column;
        public ListViewIntComparerAsc()
        {
            column = 0;
        }
        public ListViewIntComparerAsc(int column)
        {
            this.column = column;
        }
        public int Compare(object x, object y)
        {

            return (int.Parse(((ListViewItem)x).SubItems[column].Text)).CompareTo((int.Parse(((ListViewItem)y).SubItems[column].Text)));
        }
    }

    class ListViewIntComparerDsc : IComparer
    {
        private readonly int column;
        public ListViewIntComparerDsc()
        {
            column = 0;
        }
        public ListViewIntComparerDsc(int column)
        {
            this.column = column;
        }
        public int Compare(object x, object y)
        {
            return (int.Parse(((ListViewItem)y).SubItems[column].Text)).CompareTo((int.Parse(((ListViewItem)x).SubItems[column].Text)));
        }
    }

}
