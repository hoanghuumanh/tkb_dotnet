﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lapTKB
{
    public partial class add_gv : Form
    {
        datahelper dh;
        string mssv;
        public add_gv()
        {
            InitializeComponent();
            dh = new datahelper("Data Source=desktop-2j8o873;Initial Catalog=thoi_khoa_bieu;Integrated Security=True");
        }

        private void f2_show_bt_Click(object sender, EventArgs e)
        {
            string cmd = "select * from teacher";
            dataGridView1.DataSource = dh.getTable(cmd);
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            f2_name_tb.Text = dataGridView1.SelectedRows[0].Cells["Teachername"].Value.ToString();
            f2_hocvi_tb.Text= dataGridView1.SelectedRows[0].Cells["TeacherHocvi"].Value.ToString();
            f2_sdt_tb.Text =  dataGridView1.SelectedRows[0].Cells["TeacherSdt"].Value.ToString();
            f2_chuyennghanh_tb.Text= dataGridView1.SelectedRows[0].Cells["TeacherChuyenNganh"].Value.ToString();
            mssv = dataGridView1.SelectedRows[0].Cells["TeacherID"].Value.ToString();
        }
        public void show()
        {
            string cmd = "select * from teacher";
            dataGridView1.DataSource = dh.getTable(cmd);
        }
        private void f2_update_bt_Click(object sender, EventArgs e)
        {
            //string mssv = dataGridView1.SelectedRows[0].Cells["TeacherID"].Value.ToString();
            string cmd = "update teacher set TeacherName='"+f2_name_tb.Text+"',TeacherSdt='"+f2_sdt_tb.Text+"',TeacherHocvi='"+f2_hocvi_tb.Text+"',TeacherChuyenNganh='"+f2_chuyennghanh_tb.Text+"' where TeacherID='"+mssv+"'";
            dh.exuteNonQuery(cmd);
            show();
        }

        private void f2_delete_bt_Click(object sender, EventArgs e)
        {
            string cmd2 = "DELETE FROM [dbo].[tkb]";
            dh.exuteNonQuery(cmd2);
            string cmd1 = "delete from phancong where TeacherID='" + mssv + "'";
            dh.exuteNonQuery(cmd1);
            string cmd = "delete from teacher where TeacherID ='"+mssv+"'";
            dh.exuteNonQuery(cmd);
            show();
        }

        private void f2_add_b_Click(object sender, EventArgs e)
        {
            add_gv_2 ad = new add_gv_2();
            ad.Show();
            ad.x = show; 
        }
    }
}
