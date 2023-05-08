using WarehouseClient.PacketsApi.Handlers;
using WarehouseClient.PacketsApi.Packets;

namespace WarehouseClient.Client {
    public class ClientHandler : PacketHandlerStorage {
        public ClientHandler() {
            AddHandler(1, new Packet1LoginHandler());
            AddHandler(2, new Packet2UserListHandler());
            AddHandler(3, new Packet3UserEditHandler());
            AddHandler(4, new Packet4PartListHandler());
            AddHandler(5, new Packet5PartEditHandler());
            AddHandler(6, new Packet6RepairListHandler());
            AddHandler(7, new Packet7RepairEditHandler());
            AddHandler(8, new Packet8GroupListHandler());
            AddHandler(9, new Packet9GroupEditHandler());
            AddHandler(10, new Packet10UnitListHandler());
            AddHandler(11, new Packet11UnitEditHandler());
            AddHandler(12, new Packet12LogHandler());
            AddHandler(13, new Packet13PartWriteOffHandler());
            AddHandler(14, new Packet14RequestListHandler());
            AddHandler(15, new Packet15RequestEditHandler());
            AddHandler(16, new Packet16RequestPartHandler());
        }
    }
}
