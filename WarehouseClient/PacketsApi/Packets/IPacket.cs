using System.IO;

namespace WarehouseClient.PacketsApi.Packets {
    public interface IPacket {
        void Write(BinaryWriter writer);
    }
}
