using Newtonsoft.Json;
using System.IO;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet16RequestPart : PacketBase {

        private readonly Part _part;

        public Packet16RequestPart(Part part) : base(16) {
            _part = part;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_part));
        }
    }

    public class Packet16RequestPartHandler : PacketHandlerBase {
        public override object Clone() {
            return new Packet16RequestPartHandler();
        }
    }
}
