using Newtonsoft.Json;
using System.IO;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet7RepairEdit : PacketBase {

        private readonly Repair _repair;
        private readonly Part _part;
        private readonly CuAction _action;

        public Packet7RepairEdit(Repair repair, Part part, CuAction action) : base(7) {
            _repair = repair;
            _part = part;
            _action = action;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_repair));
            writer.Write(JsonConvert.SerializeObject(_part));
            writer.Write((byte) _action);
        }
    }

    public class Packet7RepairEditHandler : PacketHandlerBase {
        public override object Clone() {
            return new Packet7RepairEditHandler();
        }
    }
}
