using System;
using System.Net.Sockets;
using System.Windows.Forms;
using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.PacketsApi.Packets;
using WarehouseClient.PacketsApi.Processors;

namespace WarehouseClient.PacketsApi.Contexts {
    public class Connection {

        private readonly InputProcessor _inputProccessor;
        private readonly OutputProccessor _outputProccessor;

        public TcpClient Client {
            get; private set;
        }

        public Connection(TcpClient client, PacketHandlerStorage handlers) {
            Client = client;
            NetworkStream stream = client.GetStream();
            _inputProccessor = new InputProcessor(this, stream, handlers);
            _outputProccessor = new OutputProccessor(stream);
        }

        public void Run() {
            _inputProccessor.Run();
            _outputProccessor.Run();
        }

        public void Stop() {
            _inputProccessor.Stop();
            _outputProccessor.Stop();
        }

        public void Send(PacketBase packet) {
            _outputProccessor.Send(packet);
        }

        public void Receive(PacketHandlerBase handler) {
            handler.Connection = this;
            try {
                handler.Handle();
            } catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
