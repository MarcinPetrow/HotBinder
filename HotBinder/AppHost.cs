using BinderPlayground.App;
using System.Windows.Forms;
using View = BinderPlayground.Core.View;

namespace HotBinder
{
    public partial class AppHost : Form
    {
        public AppHost()
        {
            InitializeComponent();

            var controller = new SampleController();
            controller.MakeATest(this);
        }

        public void ApplyView(View view)
        {
            try
            {
                SuspendLayout();
                Controls.Clear();
                Controls.Add(view);
            }
            finally
            {
                ResumeLayout();
            }
        }
    }
}
