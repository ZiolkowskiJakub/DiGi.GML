using DiGi.GML.Interfaces;

namespace DiGi.GML.Test
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Button_Open_Click(object sender, EventArgs e)
        {
            string? path = null;

            using(OpenFileDialog openFileDialog = new())
            {
                openFileDialog.Title = "Select GML File";
                openFileDialog.Filter = "GML File (*.gml)|*.gml|All files (*.*)|*.*";
                if(openFileDialog.ShowDialog() != DialogResult.OK)
                {
                    return;
                }

                path = openFileDialog.FileName;
            }

            if(string.IsNullOrWhiteSpace(path) || !Path.Exists(path))
            {
                return;
            }

#pragma warning disable IDE0059 // Unnecessary assignment of a value
            List<IAbstractGML>? abstractGMLs = Convert.ToGML<IAbstractGML>(path);
#pragma warning restore IDE0059 // Unnecessary assignment of a value
        }
    }
}
