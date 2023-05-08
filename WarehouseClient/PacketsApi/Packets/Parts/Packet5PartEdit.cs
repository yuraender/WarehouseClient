using Newtonsoft.Json;
using System.IO;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet5PartEdit : PacketBase {

        private readonly Part _part;
        private readonly CuAction _action;

        public Packet5PartEdit(Part part, CuAction action) : base(5) {
            _part = part;
            _action = action;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_part));
            writer.Write((byte) _action);
        }
    }

    public class Packet5PartEditHandler : PacketHandlerBase {
        public override object Clone() {
            return new Packet5PartEditHandler();
        }
    }
}
