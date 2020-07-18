﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Windows.Forms;

namespace Design_Dashboard_Modern
{
    public partial class GuiMail : Form
    {
        public GuiMail()
        {
            InitializeComponent();
        }
        #region Mở nhiều file;
        private void btnOpenfile_Click(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog1 = new OpenFileDialog();
            //Cho phép chọn nhiều dòng trong OpenFileDialog
            openFileDialog1.Multiselect = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    //Thêm các file đã chọn vào listBox1
                    listBox1.Items.Add(filename.ToString());
                }
            }
        }
        #endregion;
        #region Gửi mail;
        private void btnsend_Click(object sender, EventArgs e)
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential(txtFrom.Text, txtPass.Text);

                MailMessage message = new MailMessage(txtFrom.Text, txtTo.Text);
                message.Subject = txtSubject.Text;
                message.Body = txtBody.Text;
                //Kiểm tra nếu có file trong listBox1
                if (listBox1.Items.Count > 0)
                {
                    foreach (var filename in listBox1.Items)
                    {
                        //Kiểm tra file có tồn tại trong ổ đĩa không
                        if (File.Exists(filename.ToString()))
                        {
                            //Thêm file đính kèm vào tin nhắn
                            message.Attachments.Add(new Attachment(filename.ToString()));
                        }
                    }
                }

                mailclient.Send(message);
                MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception )
            {
                MessageBox.Show("Lỗi không gửi được , Lưu ý : bạn hãy tắt các File đó trước khi gửi .");
            }
            #endregion;
        }

        private void GuiMail_Load(object sender, EventArgs e)
        {

        }
    }
}
