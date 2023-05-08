using System.IO;

namespace WarehouseClient.PacketsApi.Packets {
    public abstract class PacketBase : IPacket {

        public int ID {
            get; private set;
        }

        protected PacketBase(int id) {
            ID = id;
        }

        public virtual void WriteBody(BinaryWriter writer) {
        }

        public void Write(BinaryWriter writer) {
            writer.Write(ID);
            WriteBody(writer);
        }
    }
}
