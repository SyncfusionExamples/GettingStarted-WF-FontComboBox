using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fontcombobox_sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Initialize the FontComboBox control.
            FontComboBox fontComboBox = new FontComboBox();
            fontComboBox.Size = new Size(150, 40);
            fontComboBox.Location = new Point(100, 100);
            fontComboBox.VisualStyle = ThemedComboBoxStyles.Office2016Colorful;
            fontComboBox.UseAutoComplete = true;
            fontComboBox.SelectedItem = "Arial";
            this.Controls.Add(fontComboBox);
        }
    }
}
