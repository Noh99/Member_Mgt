using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Member_Mgt
{
    public partial class Form1 : Form
    {
        const string ip = "3.35.235.128";
        const string db = "member_mgt";
        const string id = "noh99";
        const string pw = "1111";
        public string info = $"server={ip};database={db};user={id};password={pw};";
        public string sql;
        public List<Control> controls = new List<Control>();
        public MySqlConnection conn = null;
        public MySqlCommand cmd = null;
        public MySqlDataReader rdr = null;

        public Form1()
        {
            InitializeComponent();
            DataToList();
        }
        private void btn_add_Click(object sender, EventArgs e)
        {
            if (list_mem.FocusedItem != null)
            {
                list_mem.SelectedItems.Clear();
                list_mem.FocusedItem = null;
            }
            ControlDispose();
            ControlAdd();
        }
        private void btn_del_Click(object sender, EventArgs e)
        {
            if(list_mem.SelectedItems.Count > 0)
            {
                string id = list_mem.SelectedItems[0].SubItems[1].Text;
                DialogResult check = MessageBox.Show("정말로 삭제하시겠습니까?", id,MessageBoxButtons.YesNo);

                if(check == DialogResult.Yes)
                {
                    try
                    {
                        using (conn = new MySqlConnection(info))
                        {
                            conn.Open();
                            sql = $"DELETE FROM tbl_mem WHERE id = '{id}'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                        }
                        ControlDispose();
                        DataToList();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, sql);
                    }
                }
            }      
        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            if(controls.Count > 0)
            {
                try
                {
                    string id = controls[0].Text;
                    if (id == "") throw new Exception("아이디를 입력해주세요.");
                    string nm = controls[1].Text;
                    if (nm == "") throw new Exception("이름을 입력해주세요.");
                    string gen;
                    if (((RadioButton)controls[2]).Checked) gen = controls[2].Text;
                    else gen = controls[3].Text;
                    string bd = controls[4].Text;

                    using (conn = new MySqlConnection(info))
                    {
                        conn.Open();

                        if(list_mem.SelectedItems.Count == 0)
                        {
                            sql = $"SELECT * FROM tbl_mem WHERE id = '{id}'";
                            cmd = new MySqlCommand(sql, conn);
                            rdr = cmd.ExecuteReader();

                            if (rdr.HasRows) throw new Exception("이미 존재하는 아이디입니다.");
                            rdr.Close();

                            sql = $"INSERT INTO tbl_mem(id, nm, gen, bd) VALUES('{id}', '{nm}', '{gen}', '{bd}')";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            sql = $"UPDATE tbl_mem SET nm = '{nm}', gen = '{gen}', bd = '{bd}' WHERE id = '{id}'";
                            cmd = new MySqlCommand(sql, conn);
                            cmd.ExecuteNonQuery();
                        }        
                    }
                    ControlDispose();
                    DataToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "오류");
                }
            }
        }
        private void btn_reset_Click(object sender, EventArgs e)
        {
            ControlDispose();
            DataToList();
        }
        private void list_mem_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (list_mem.SelectedItems.Count > 0)
            {
                ControlDispose();
                ControlAdd();

                controls[0].Text = list_mem.SelectedItems[0].SubItems[1].Text;
                ((TextBox)controls[0]).ReadOnly = true;
                ((TextBox)controls[0]).BackColor = Color.White;
                ((TextBox)controls[0]).ForeColor = Color.DarkGray;
                controls[1].Text = list_mem.SelectedItems[0].SubItems[2].Text;
                if (controls[2].Text == list_mem.SelectedItems[0].SubItems[3].Text) 
                    ((RadioButton)controls[2]).Checked = true;
                else 
                    ((RadioButton)controls[3]).Checked = true;
                controls[4].Text = list_mem.SelectedItems[0].SubItems[4].Text;
            }
        }
        private void list_mem_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            e.NewWidth = list_mem.Columns[e.ColumnIndex].Width;
            e.Cancel = true;
        }
        public void DataToList()
        {
            list_mem.Groups.Clear();
            list_mem.Items.Clear();

            list_mem.BeginUpdate();

            using (conn = new MySqlConnection(info))
            {
                conn.Open();

                sql = "SELECT * FROM tbl_mem";
                cmd = new MySqlCommand(sql, conn);
                rdr = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(rdr);

                for (int i = 1; i <= dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(i.ToString());
                    item.SubItems.Add(dt.Rows[i - 1][1].ToString());
                    item.SubItems.Add(dt.Rows[i - 1][2].ToString());
                    item.SubItems.Add(dt.Rows[i - 1][3].ToString());
                    item.SubItems.Add(dt.Rows[i - 1][4].ToString().Split(' ')[0]);
                    list_mem.Items.Add(item);
                }
            }
            list_mem.EndUpdate();
        }
        public void ControlAdd()
        {
            int last = list_mem.Items.Count - 1;

            if (last < 0 || list_mem.Items[last].Text != "")
            {
                ListViewItem item = new ListViewItem();
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
                item.SubItems.Add("");
                list_mem.Items.Add(item);

                last++;

                TextBox tb1 = new TextBox();
                TextBox tb2 = new TextBox();
                RadioButton rb1 = new RadioButton();
                RadioButton rb2 = new RadioButton();
                DateTimePicker dtp = new DateTimePicker();

                rb1.Text = "남";
                rb2.Text = "여";
                rb1.Checked = true;

                dtp.CustomFormat = "yyyy-MM-dd";
                dtp.Format = DateTimePickerFormat.Custom;

                tb1.Parent = list_mem;
                tb2.Parent = list_mem;
                rb1.Parent = list_mem;
                rb2.Parent = list_mem;
                dtp.Parent = list_mem;

                Rectangle rt;

                rt = list_mem.Items[last].SubItems[1].Bounds;
                tb1.SetBounds(rt.X, rt.Y, rt.Width, rt.Height);
                controls.Add(tb1);

                rt = list_mem.Items[last].SubItems[2].Bounds;
                tb2.SetBounds(rt.X, rt.Y, rt.Width, rt.Height);
                controls.Add(tb2);

                rt = list_mem.Items[last].SubItems[3].Bounds;
                rb1.SetBounds(rt.X + 5, rt.Y + 2, rt.Width / 2 - 5, rt.Height);
                controls.Add(rb1);
                rb2.SetBounds(rt.X + 5 + rt.Width / 2, rt.Y + 2, rt.Width / 2 - 5, rt.Height);
                controls.Add(rb2);

                rt = list_mem.Items[last].SubItems[4].Bounds;
                dtp.SetBounds(rt.X, rt.Y, rt.Width, rt.Height);
                controls.Add(dtp);

                list_mem.Items.RemoveAt(last);
            }
        }
        public void ControlDispose()
        {
            foreach (Control control in controls)
            {
                control.Dispose();
            }
            controls.Clear();
        }
    }
}