using Newtonsoft.Json;
using System.IO;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet15RequestEdit : PacketBase {

        private readonly object _request;
        private readonly CuAction _action;

        public Packet15RequestEdit(object request, CuAction action) : base(15) {
            _request = request;
            _action = action;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_request));
            writer.Write((byte) _action);
        }
    }

    public class Packet15RequestEditHandler : PacketHandlerBase {
        public override object Clone() {
            return new Packet15RequestEditHandler();
        }
    }
}
