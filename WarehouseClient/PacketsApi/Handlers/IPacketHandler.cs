using System;
using System.IO;

namespace WarehouseClient.PacketsApi.Handlers {
    public interface IPacketHandler : ICloneable {
        void Read(BinaryReader reader);

        void Handle();
    }
}
