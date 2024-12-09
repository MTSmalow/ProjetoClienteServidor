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
using System.Windows.Forms.VisualStyles;

namespace ProjetoClienteServidor
{
    public partial class Form1 : Form
    {
        Thread tarefaServico;
        Thread tarefaAtendeCliente;
        TcpListener ServidorGlobal;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            int porta = Convert.ToInt32(txtPorta.Text);
            TcpListener Servidor = new TcpListener(porta);
            Servidor.Start();
            ServidorGlobal = Servidor;

            ParameterizedThreadStart thread = new ParameterizedThreadStart(Servico);

            Thread tarefa = new Thread(thread);
            tarefa.Start(Servidor);
            tarefaServico = tarefa;

            btnStart.Enabled = false;
            btnParar.Enabled = true;

        }

        private void Servico(Object Servidor)
        {
            while (true)
            {
                if ( ((TcpListener) Servidor).Pending())
                {
                    Socket conexao = ((TcpListener)Servidor).AcceptSocket();
                    ParameterizedThreadStart thread = new ParameterizedThreadStart(AtendeCliente);
                    Thread tarefa = new Thread(thread);
                    tarefa.Start(conexao);
                    
                }
                Thread.Sleep(100);
            }
        }

        private void AtendeCliente(object conexaoObj)
        {
            Socket conexao = (Socket)conexaoObj;
            if (conexao != null)
            {
                string mensagem = txtMensagem.Text;
                byte[] bmensagem = Encoding.UTF8.GetBytes(mensagem);
                conexao.Send(bmensagem);
                conexao.Close();
                conexao.Dispose();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tarefaServico.Abort();
            ServidorGlobal.Stop();


            btnStart.Enabled = true;
            btnParar.Enabled = false;
        }
    }
}
