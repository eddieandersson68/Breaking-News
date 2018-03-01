using System.Linq;
using System.Windows.Forms;

namespace Breaking_News
{
    public static class Extension
    {
        public static RadioButton SelectedRadioButton(this GroupBox b)
        {
            if (b == null)
            {
                throw new System.ArgumentNullException(nameof(b));
            }

            return b.Controls.OfType<RadioButton>().Where(rb => rb.Checked).SingleOrDefault();
        }
    }
}