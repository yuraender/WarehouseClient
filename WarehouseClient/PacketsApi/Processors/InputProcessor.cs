using System;
using System.Diagnostics;
using System.IO;
using System.Net.Sockets;
using System.Threading;
using WarehouseClient.PacketsApi.Contexts;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Processors {
    public class InputProcessor {

        private Thread _thread;
        private readonly Connection _connection;
        private readonly BinaryReader _reader;
        private bool _started = false;

        public PacketHandlerStorage Handlers {
            get; private set;
        }

        public InputProcessor(Connection connection, NetworkStream stream, PacketHandlerStorage handlers) {
            Handlers = handlers;
            _connection = connection;
            _reader = new BinaryReader(stream);
        }

        private void _handlePacket() {
            try {
                int id = _reader.ReadInt32();
                PacketHandlerBase handler = Handlers.GetHandlerById(id);
                handler.Read(_reader);
                _connection.Receive(handler);
            } catch (Exception ex) {
                //MessageBox.Show(ex.ToString());
                Process.GetCurrentProcess().Kill();
            }
        }

        public void Run() {
            _thread = new Thread(() => {
                while (!_started) {
                    _handlePacket();
                }
            });
            _thread.Start();
        }

        public void Stop() {
            _reader.Close();
            _thread.Interrupt();
            _thread.Abort();
        }
    }
}
