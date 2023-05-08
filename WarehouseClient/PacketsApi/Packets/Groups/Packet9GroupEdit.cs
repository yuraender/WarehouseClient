using Newtonsoft.Json;
using System.IO;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet9GroupEdit : PacketBase {

        private readonly Group _group;
        private readonly CuAction _action;

        public Packet9GroupEdit(Group group, CuAction action) : base(9) {
            _group = group;
            _action = action;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_group));
            writer.Write((byte) _action);
        }
    }

    public class Packet9GroupEditHandler : PacketHandlerBase {
        public override object Clone() {
            return new Packet9GroupEditHandler();
        }
    }
}
