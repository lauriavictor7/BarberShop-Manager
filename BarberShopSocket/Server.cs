using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarberShopSocket
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
        }

        private Socket socket;
        private Thread thread;


        private NetworkStream networkStream;
        private BinaryWriter binaryWriter;
        private BinaryReader binaryReader;

        TcpListener tcpListener;

        public void RunServer()
        {

            try
            {
                IPEndPoint ipEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 2001);
                tcpListener = new TcpListener(ipEndPoint);
                tcpListener.Start();

                // AddToListBox("Servidor habilitado e escutando porta..." + "Server App");

                socket = tcpListener.AcceptSocket();
                networkStream = new NetworkStream(socket);
                binaryWriter = new BinaryWriter(networkStream);
                binaryReader = new BinaryReader(networkStream);

              //  AddToListBox("conexão recebida!" + "Server App");
                binaryWriter.Write("\nconexão efetuada!");

                string messageReceived = "";
                do
                {
                    messageReceived = binaryReader.ReadString();

                //    AddToListBox("Filtro da pesquisa:" + messageReceived);

                } while (socket.Connected);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (binaryReader != null)
                {
                    binaryReader.Close();
                }
                if (binaryWriter != null)
                {
                    binaryWriter.Close();
                }
                if (networkStream != null)
                {
                    networkStream.Close();
                }
                if (socket != null)
                {
                    socket.Close();
                }
                MessageBox.Show("conexão finalizada", "Server App");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                ConexaoSocket cs = new ConexaoSocket();
                cs.FilaAgendamentos();
            }
            catch (SocketException socketEx)
            {
                MessageBox.Show(socketEx.Message, "Erro");
            }
            catch (Exception socketEx)
            {
                MessageBox.Show(socketEx.Message, "Erro");
            }
        }
    }
}
