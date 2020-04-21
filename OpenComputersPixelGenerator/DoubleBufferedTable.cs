using System.ComponentModel;
using System.Windows.Forms;
namespace OpenComputersPixelGenerator
{

        /// <summary>
        /// Double Buffered layout panel - removes flicker during resize operations.
        /// </summary>
        public partial class DoubleBufferedTable : TableLayoutPanel
        {
            public DoubleBufferedTable()
            {
                InitializeComponent();
                SetStyle(ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.OptimizedDoubleBuffer |
                  ControlStyles.UserPaint, true);
            }

            public DoubleBufferedTable(IContainer container)
            {
                container.Add(this);
                InitializeComponent();
                SetStyle(ControlStyles.AllPaintingInWmPaint |
                  ControlStyles.OptimizedDoubleBuffer |
                  ControlStyles.UserPaint, true);
            }
        }

}
