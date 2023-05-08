using Newtonsoft.Json;
using System.IO;
using WarehouseClient.Client.Entities;
using WarehouseClient.PacketsApi.Handlers;

namespace WarehouseClient.PacketsApi.Packets {
    public class Packet3UserEdit : PacketBase {

        private readonly User _user;
        private readonly CuAction _action;

        public Packet3UserEdit(User user, CuAction action) : base(3) {
            _user = user;
            _action = action;
        }

        public override void WriteBody(BinaryWriter writer) {
            writer.Write(JsonConvert.SerializeObject(_user));
            writer.Write((byte) _action);
        }
    }

    public class Packet3UserEditHandler : PacketHandlerBase {
        public override object Clone() {
            return new Packet3UserEditHandler();
        }
    }
}
