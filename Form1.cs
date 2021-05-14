using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void B_NewObject_Click(object sender, EventArgs e)
        {
            TV_ObjectBuffer.TV_BufferObject = new TV_Library.TV(new TV_Library.TV.s_TV_Desc());
            ObjectAddForm newWindow = new ObjectAddForm();
            newWindow.ShowDialog();
            if(TV_ObjectBuffer.TV_BufferObject!=null)
                this.LB_Objects.Items.Add(TV_ObjectBuffer.TV_BufferObject);
        }

        private void LB_Objects_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (LB_Objects.SelectedItem != null)
                    TB_ParamData.Text = LB_Objects.SelectedItem.ToString();
            }
            catch { }
        }

        private void B_Edit_Click(object sender, EventArgs e)
        {
            if (LB_Objects.SelectedItem != null)
                TV_ObjectBuffer.TV_BufferObject = (TV_Library.TV)LB_Objects.SelectedItem;
            ObjectAddForm newWindow = new ObjectAddForm();
            this.LB_Objects.Items.RemoveAt(this.LB_Objects.Items.IndexOf(TV_ObjectBuffer.TV_BufferObject));
            TB_ParamData.Text = string.Empty;
            newWindow.ShowDialog();
            this.LB_Objects.Items.Add(TV_ObjectBuffer.TV_BufferObject);
        }

        private void B_DeleteObject_Click(object sender, EventArgs e)
        {
            if (LB_Objects.SelectedItem != null)
            {
                this.LB_Objects.Items.RemoveAt(this.LB_Objects.Items.IndexOf(TV_ObjectBuffer.TV_BufferObject));
                TB_ParamData.Text = string.Empty;
            }
        }

        private void B_ClearList_Click(object sender, EventArgs e)
        {
            this.LB_Objects.Items.Clear();
            TB_ParamData.Text = string.Empty;
        }
    }
}
