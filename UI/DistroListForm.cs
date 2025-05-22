using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DistroListTool.Models;

namespace DistroListTool
{
    public partial class DistroListForm : Form
    {
        private readonly List<DistroList> _distroLists;
        public DistroListItem SelectedTemplate { get; private set; }
        public DistroListForm(DistroConfig distroConfig)
        {
            InitializeComponent();

            this.Text = $"{this.Text} - Version: {distroConfig.Version}";

            _distroLists = distroConfig.DistroList;
            distroListComboBox.DataSource = _distroLists;
            distroListComboBox.ValueMember = "Name";
            distroListComboBox.SelectedIndex = 0;
        }

        private void distroListComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = distroListComboBox.SelectedIndex;

            templatesComboBox.DataSource = _distroLists[index].Distros;
            templatesComboBox.ValueMember = "Name";
            templatesComboBox.SelectedIndex = 0;
            templatesComboBox.Enabled = true;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var distroIndex = distroListComboBox.SelectedIndex;
            var templateIndex = templatesComboBox.SelectedIndex;
            SelectedTemplate = _distroLists[distroIndex].Distros[templateIndex];
            this.Close();
        }

        private void On_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                openButton_Click(sender, e);
            }
        }
    }
}
