using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Threading;

namespace ProjetoCliente
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnet_Click(object sender, EventArgs e)
        {
            TcpClient cliente = new TcpClient();
            string ip = txtIP.Text;
            int porta = Convert.ToInt32(txtPorta.Text);

            
           
            cliente.Connect(ip, porta);
            while(!cliente.Connected)
            {
                Thread.Sleep(100);
            }
            while(cliente.Available == 0)
            {
               Thread.Sleep(100);

            }    

            while (cliente.Available > 0 ) {
                NetworkStream tunel = cliente.GetStream();
                byte[] data = new byte[255];
                tunel.Read(data, 0, 255);
                string mensagem = Encoding.UTF8.GetString(data);
                MessageBox.Show(mensagem);

                
            }

        }
    }
}
