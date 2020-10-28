using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveMore
{
    public partial class SaveMore : Form
    {
        List<Panel> listPages = new List<Panel>();
        int index = 0;

        decimal income_total;
        decimal expense_total;
        decimal dif_total;

        public SaveMore()
        {
            InitializeComponent();
        } 

        private void SaveMore_Load(object sender, EventArgs e)
        {
            listPages.Add(page1);
            listPages.Add(page2);
            listPages.Add(page3);
            listPages.Add(page4);

            listPages[index].BringToFront();
        }

        private void Next_btn_Click(object sender, EventArgs e)
        {
            if (index < listPages.Count - 1)
                listPages[++index].BringToFront();
        /*
            if(listPages[3].Visible = true)
            {
                Next_btn.Visible = false;
            } */
        }

        private void Back_btn_Click(object sender, EventArgs e)
        {
            if (index > 0)
                listPages[--index].BringToFront();

           /* if(listPages[3].Visisble)
            {
                Back_btn.Visible = false;
            } */
        }

        private void calculate_btn_Click(object sender, EventArgs e)
        {
            income_total = income_num.Value + income_num2.Value + income_num3.Value + income_num4.Value
                            + income_num5.Value + income_num6.Value;

            expense_total = expense_num.Value + expense_num2.Value + expense_num3.Value + expense_num4.Value 
                            + expense_num5.Value + expense_num6.Value + expense_num7.Value + expense_num8.Value
                            + expense_num9.Value + expense_num10.Value + expense_num11.Value + expense_num12.Value;

            dif_total = income_total - expense_total;

            income_tl_txt.Text = '$' + Convert.ToString(income_total);

            expense_tl_txt.Text = '$' + Convert.ToString(expense_total);

            dif_txt.Text = '$' + Convert.ToString(dif_total);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void retry_btn_Click(object sender, EventArgs e)
        {

            /*  for (index = 0; index < 3; index++)
              {
                  listPages[index].BringToFront();
              } */
            listPages[3].BringToFront();
            listPages[2].BringToFront();
            listPages[1].BringToFront();
            listPages[0].BringToFront();  

            

            Back_btn.BringToFront();
            Next_btn.BringToFront();
        }
    }
}
