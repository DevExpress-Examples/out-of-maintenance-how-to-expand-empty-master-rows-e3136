using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid;

namespace WindowsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            gridControl1.DataSource = DataGenerator.GetData();
            gridControl1.ViewRegistered += gridControl1_ViewRegistered;
            gridView1.MasterRowEmpty += gridView1_MasterRowEmpty;
            gridView1.OptionsDetail.AllowExpandEmptyDetails = true;
        }

        void gridView1_MasterRowEmpty(object sender, MasterRowEmptyEventArgs e)
        {
            e.IsEmpty = false;
        }

        void gridControl1_ViewRegistered(object sender, ViewOperationEventArgs e)
        {
            (e.View as GridView).OptionsView.NewItemRowPosition = NewItemRowPosition.Bottom;
        }
    }
}