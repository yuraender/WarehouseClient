using System.Net.Sockets;
using WarehouseClient.PacketsApi.Contexts;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.Client {
    public class WarehouseClient {

        private TcpClient _tcpClient;

        public PacketHandlerStorage Handlers {
            get; set;
        }
        public Connection Connection {
            get; private set;
        }

        public WarehouseClient(string ip, int port, PacketHandlerStorage handlers) {
            Handlers = handlers;
            _tcpClient = new TcpClient(ip, port);
            Connection = new Connection(_tcpClient, handlers);
            Connection.Run();
        }
    }
}
