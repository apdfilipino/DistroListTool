using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DistroListTool.Models;

namespace DistroListTool
{
    public partial class ConfigureForm : Form
    {
        private DistroListService _service;
        public ConfigureForm(DistroListService service)
        {
            _service = service;
            InitializeComponent();
            if (_service.Config != null)
            {
                configureTextBox.Text = _service.Config.Path;
                isLocalCheckBox.Checked = service.Config.IsLocal;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var config = new Config()
            {
                Path = configureTextBox.Text,
                IsLocal = isLocalCheckBox.Checked
            };
            var task = _service.PersistIfExists(config);
            task.Wait();
            var result = task.Result;
            if (result == null)
            {
                MessageBox.Show("The file does not exist!", "DL Tool");
            }
            if (result != null)
            {
                MessageBox.Show($"Successfully configured. Version: {result.Version}", "DL Tool");
                this.Close();
            }
        }
    }
}
