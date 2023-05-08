using System.Collections.Generic;
using System.Linq;

namespace WarehouseClient.PacketsApi.Handlers {
    public class PacketHandlerStorage {

        private readonly Dictionary<int, PacketHandlerBase> _storage;

        public PacketHandlerStorage() {
            _storage = new Dictionary<int, PacketHandlerBase>();
        }

        public List<PacketHandlerBase> GetHandlers() {
            return _storage.Values.ToList();
        }

        public PacketHandlerBase GetHandlerById(int id) {
            return (PacketHandlerBase) _storage[id].Clone();
        }

        public void AddHandler(int id, PacketHandlerBase handler) {
            _storage.Add(id, handler);
        }
    }
}
