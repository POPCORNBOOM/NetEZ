using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Net.Security;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using Meting4Net.Core;
using static NetEZ.apibcaksongdir;
using static NetEZ.Apibacksearch;

namespace NetEZ
{
    public partial class MusicNetEZ : Form
    {
        public bool togglefloat = false;
        public MusicNetEZ()
        {

            InitializeComponent();
            string Downpath = Properties.Settings.Default.defaultpath;
            t_downpath.Text = Downpath;
            if (Directory.Exists(Downpath + "\\NetEZmusic") == false)
                Directory.CreateDirectory(Downpath + "\\NetEZmusic");
        }

        //public bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        //{   // 总是接受  
        //    return true;
        //}

        private void btn_download_Click(object sender, EventArgs e)
        {   
            pb_down.Value = 10;
            pb_down.Visible = true;
            
            
            string SongsId = t_songid.Text;

            Meting api = new Meting(ServerProvider.Netease);
            string jsonStr = api.FormatMethod(false).Url(SongsId);
            Rootd rb = JsonConvert.DeserializeObject<Rootd>(jsonStr);
            int overtimes = 0;
            while (rb.code != 200 && overtimes < 5)
            {
                jsonStr = api.FormatMethod(false).Url(SongsId);
                rb = JsonConvert.DeserializeObject<Rootd>(jsonStr);
                overtimes++;
            }
            
            if(rb.code == 200)
            {
                string downlink = rb.data[0].url;
                HttpWebRequest dldSong = WebRequest.CreateHttp(downlink);
                HttpWebResponse dldres = dldSong.GetResponse() as HttpWebResponse;
                Stream dldstream = dldres.GetResponseStream();
                double totsize = dldres.ContentLength;
                double nowsize = totsize;
                pb_down.Value = 20;
                string inpath;
                if (t_path.Text == null)
                {
                    inpath = "newNetEZsong";
                }
                else
                {
                    inpath = t_path.Text;
                }
                Stream stream = new FileStream(Properties.Settings.Default.defaultpath + "\\NetEZmusic\\" + inpath + ".mp3", FileMode.Create);
                byte[] bArr = new byte[1024];
                int size = dldstream.Read(bArr, 0, (int)bArr.Length);

                while (size > 0)
                {
                    stream.Write(bArr, 0, size);
                    size = dldstream.Read(bArr, 0, (int)bArr.Length);
                    pb_down.Value = (int)(20 + 80 * (totsize - nowsize) / totsize);
                    if (nowsize >= 1024)
                        nowsize -= 1024;
                    else
                        nowsize = 0;
                    
                }

                
                pb_down.Visible = false;
                stream.Close();
                dldstream.Close();

            }
            else
            {
                MessageBox.Show("下载时发生错误，错误码：" + rb.code);
            }


        }
        //置顶开关
        private void btn_up_Click(object sender, EventArgs e)
        {

            if (togglefloat == false)
            {
                togglefloat = true;
                this.TopMost = togglefloat;
                btn_up.Text = "取消置顶";
                btn_up.BackColor = Color.Gray;
                btn_up.ForeColor = Color.White;
            }
            else
            {
                togglefloat = false;
                this.TopMost = togglefloat;
                btn_up.Text = "窗口置顶"; 
                btn_up.BackColor = Color.White;
                btn_up.ForeColor = Color.DarkGray;

            }
        }

        //打开qq邮箱
        private void ll_email_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://mail.qq.com/");
        }

        //显示疑问帮助
        private void btn_quest_Click(object sender, EventArgs e)
        {
            new quest().ShowDialog();
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            string C_selectedcell = dgv_search.CurrentCell.Value.ToString();
            if (C_selectedcell != "")
                Clipboard.SetDataObject(C_selectedcell);
        }

        private void 搜索ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string C_selectedcell = dgv_search.CurrentRow.Cells[2].Value.ToString();
            string C_selectedname = dgv_search.CurrentRow.Cells[0].Value.ToString() + "-" + dgv_search.CurrentRow.Cells[1].Value.ToString();

            if (C_selectedcell != "")
            {
                t_songid.Text = C_selectedcell;
                t_path.Text = C_selectedname;
            }
        }


        //搜索函数
        private void btn_searchfor(object sender, EventArgs e)
        {
            Meting api = new Meting(ServerProvider.Netease);
            string jsonStr = api.FormatMethod(false).Search(t_search.Text);
            Roota rb = JsonConvert.DeserializeObject<Roota>(jsonStr);
            int overtimes = 0;
            while (rb.code != 200 && overtimes < 5)
            {
                jsonStr = api.FormatMethod(false).Search(t_search.Text);
                rb = JsonConvert.DeserializeObject<Roota>(jsonStr);
                overtimes++;
            }
            if (rb.code == 200)
            {
                for (int i = 0; i < 30; i++)
                {
                    dgv_search.Rows.Add();
                    dgv_search.Rows[i].Cells[0].Value = rb.result.songs[i].name;
                    dgv_search.Rows[i].Cells[1].Value = rb.result.songs[i].ar[0].name;
                    dgv_search.Rows[i].Cells[2].Value = rb.result.songs[i].id;
                    if (rb.result.songs[i].privilege.chargeInfoList[0].chargeType == 1)
                    {
                        dgv_search.Rows[i].DefaultCellStyle.BackColor = Color.DarkGray;
                        dgv_search.Rows[i].Cells[2].Value = "";
                    }

                }
            }
            else
            {
                MessageBox.Show("搜索发生错误，错误码：" + rb.code);
            }

        }



        private void dgv_search_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string C_selectedcell = dgv_search.CurrentRow.Cells[2].Value.ToString();
            string C_selectedname = dgv_search.CurrentRow.Cells[0].Value.ToString() + "-" + dgv_search.CurrentRow.Cells[1].Value.ToString();
            
            if (C_selectedcell != "")
            {
                t_songid.Text = C_selectedcell;
                t_path.Text = C_selectedname;
            }
            

        }



        private void btn_pathset_Click(object sender, EventArgs e)
        {

            FBD.ShowDialog();
            t_downpath.Text = FBD.SelectedPath;
            Properties.Settings.Default.defaultpath = t_downpath.Text;
            Properties.Settings.Default.Save();
            string Downpath = Properties.Settings.Default.defaultpath;
            if (Directory.Exists(Downpath + "\\NetEZmusic") == false)
                Directory.CreateDirectory(Downpath + "\\NetEZmusic");
        }
    }
}
