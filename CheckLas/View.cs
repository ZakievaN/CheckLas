using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using GIS.Core;

namespace CheckLas
{
    public partial class View : Form
    {
        private readonly Controller _controller = new Controller();

        private List<Dictionary<LasReader.Errors, object>> _list = new List<Dictionary<LasReader.Errors, object>>();

        public View()
        {
            InitializeComponent();
            listView.Clear();
            listView.Groups.Clear();
        }

        private void SelectFiles_Click(object sender, EventArgs e)
        {
            VisibleControls(false);
            if (openFiles.ShowDialog() != DialogResult.OK) return;
            if (openFiles.FileNames != null)
            {
                LoadResult(openFiles.FileNames);
            }
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            VisibleControls(false);
            if (openFolder.ShowDialog() != DialogResult.OK) return;
            if (string.IsNullOrWhiteSpace(openFolder.SelectedPath)) return;
            var files = Directory.GetFiles(openFolder.SelectedPath).Where(s => s.Contains("las")).ToArray();
            LoadResult(files);
        }

        private void LoadResult(string [] listFile)
        {
            _list = _controller.GetResults(listFile);
            if (_list == null)
            {
                MessageBox.Show(Localize.Lang.FilesNotFound, Localize.Lang.Warning);
                return;
            }
            if (_list.Count == 0)
            {
                MessageBox.Show(Localize.Lang.FilesNotFound, Localize.Lang.Warning);
                return;
            }
            listView.Clear();
            listView.Groups.Clear();
            var flag = false;           
            for (var i = 0; i < _list.Count; i++)
            {
                var item = _list[i];
                if (item.Count <= 0) continue;
                flag = true;
                var viewGroup = new ListViewGroup
                {
                    Header = listFile[i],
                    HeaderAlignment = HorizontalAlignment.Center
                };
                listView.Groups.Add(viewGroup);
                var i1 = i;
                foreach (var elem in item)
                {
                    var str = elem.Key.ToString();
                    var localizeString = Localize.Lang.ResourceManager.GetString(str, CultureInfo.InvariantCulture);
                    string val = Convert.ToString(elem.Value);
                    val = val.Contains("Object") ? string.Empty : " (" + val + ")";
                    var viewItem = new ListViewItem()
                    {
                        Text = localizeString + val,
                        Group = listView.Groups[i1]
                    };
                    listView.Items.Add(viewItem);
                }
            }
            listView.Refresh();
            if (!flag)
            {
                MessageBox.Show(Localize.Lang.ErrorNotFound, Localize.Lang.Warning);
            }
            else
            {
                VisibleControls(true);
            }
        }

        private void VisibleControls(bool flag)
        {
            label1.Visible = flag;
            listView.Visible = flag;
        }
    }
}