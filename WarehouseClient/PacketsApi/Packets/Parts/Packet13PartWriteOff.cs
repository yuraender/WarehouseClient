using Newtonsoft.Json;
using System.IO;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet13PartWriteOff : PacketBase {

        private readonly Part _part;
        private readonly int _amount;
        private readonly string _reason;

        public Packet13PartWriteOff(Part part, int amount, string reason) : base(13) {
            _part = part;
            _amount = amount;
            _reason = reason;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_part));
            writer.Write(_amount);
            writer.Write(_reason);
        }
    }

    public class Packet13PartWriteOffHandler : PacketHandlerBase {
        public override object Clone() {
            return new Packet13PartWriteOffHandler();
        }
    }
}
