using Newtonsoft.Json;
using System.IO;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet11UnitEdit : PacketBase {

        private readonly Unit _unit;
        private readonly CuAction _action;

        public Packet11UnitEdit(Unit unit, CuAction action) : base(11) {
            _unit = unit;
            _action = action;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_unit));
            writer.Write((byte) _action);
        }
    }

    public class Packet11UnitEditHandler : PacketHandlerBase {
        public override object Clone() {
            return new Packet11UnitEditHandler();
        }
    }
}
