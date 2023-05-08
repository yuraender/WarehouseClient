using System.IO;
using WarehouseClient.PacketsApi.Contexts;

namespace WarehouseClient.PacketsApi.Handlers {
    public abstract class PacketHandlerBase : IPacketHandler {

        public Connection Connection {
            get; set;
        }

        public virtual void Read(BinaryReader reader) {
        }

        public virtual void Handle() {
        }

        public abstract object Clone();
    }
}
