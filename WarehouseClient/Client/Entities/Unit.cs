namespace WarehouseClient.Client.Entities {
    public class Unit {

        public int ID {
            get; set;
        }

        public string Name {
            get; set;
        }

        public override bool Equals(object obj) {
            if (obj == null || !(obj is Unit)) {
                return false;
            }
            return ((Unit) obj).ID == ID;
        }

        public override string ToString() {
            return Name;
        }
    }
}
