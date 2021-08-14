﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;


namespace day16_06Server
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //当点击开始监听的时候 在服务器端创建一个负责监听IP地址跟端口号的Socket
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;//IPAddress.Parse(txtServer.Text);
                                         //创建端口号对象
            IPEndPoint point = new IPEndPoint(ip, Convert.ToInt32(txtPort.Text));
            //监听
            socketWatch.Bind(point);
            ShowMsg("监听成功");
            socketWatch.Listen(10);

            Thread th = new Thread(Listen);
            th.IsBackground = true;
            th.Start(socketWatch);
        }


        Socket socketSend;
        void Listen(object o)
        {
            Socket socketWatch = o as Socket;
            //等待客户端的连接 并且创建一个负责通信的Socket
            while (true)
            {
                //负责跟客户端通信的Socket
                socketSend = socketWatch.Accept();
                //将远程端口的客户端的IP地址和Socket存入集合中
                dicSocket.Add(socketSend.RemoteEndPoint.ToString(), socketSend);
                //将远程连接的客户端的IP地址和端口号存储在下拉框中
                cboUsers.Items.Add(socketSend.RemoteEndPoint.ToString());
                ShowMsg(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功");
                
                Thread th = new Thread(Recive);
                th.IsBackground = true;
                th.Start(socketSend);
            }
        }

        //将远程连接的客户端的IP地址和Socket存入集合中
        Dictionary<string, Socket> dicSocket = new Dictionary<string, Socket>();

        /// <summary>
        /// 服务器端不停的接受客户端发送过来的消息
        /// </summary>
        /// <param name="o"></param>
        void Recive(object o)
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                try
                {
                    //客户端连接成功后，服务器应该接受客户端发来的消息
                    byte[] buffer = new byte[1024 * 1024 * 2];
                    //实际接受到的有效字节数
                    int r = socketSend.Receive(buffer);
                    if (r == 0)
                    {
                        break;
                    }
                    string str = Encoding.UTF8.GetString(buffer, 0, r);
                    ShowMsg(socketSend.RemoteEndPoint + ":" + str);
                }
                catch
                { }
            }
        }
        void ShowMsg(string str)
        {
            txtLog.AppendText(str + "\r\n");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        /// <summary>
        /// 服务器给客户端发消息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSend_Click(object sender, EventArgs e)
        {
            string str = txtMsg.Text;
            byte[] buffer = System.Text.Encoding.UTF8.GetBytes(str);
            List<byte> list = new List<byte>();
            list.Add(0);
            list.AddRange(buffer);
            byte[] newBuffer = list.ToArray();

            //socketSend.Send(buffer);
            //获得用户在下拉框中选中的IP地址
            string ip = cboUsers.SelectedItem.ToString();
            //dicSocket[ip].Send(buffer);
            dicSocket[ip].Send(newBuffer);


        }

        private void cboUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择要发送的文件";
            ofd.Filter = "所有文件|*.*";
            ofd.ShowDialog();
            txtPath.Text = ofd.FileName;
        }

        private void btnSendFile_Click(object sender, EventArgs e)
        {
            //获得要发送文件的路径
            string path = txtPath.Text;
            using (FileStream fsRead = new FileStream(path, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024 * 1024 * 5];
                int r = fsRead.Read(buffer, 0, buffer.Length);
                List<byte> list = new List<byte>();
                list.Add(1);
                list.AddRange(buffer);
                byte[] newbuffer = list.ToArray();
              
                dicSocket[cboUsers.SelectedItem.ToString()].Send(newbuffer, 0, r+1, SocketFlags.None);
            }
        }
        /// <summary>
        /// 发送震动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnZD_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1];
            buffer[0] = 2;
            dicSocket[cboUsers.SelectedItem.ToString()].Send(buffer);
        }
    }
}
