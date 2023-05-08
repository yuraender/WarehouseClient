namespace WarehouseClient.Client.Entities {
    public class Group {

        public int ID {
            get; set;
        }

        public string Name {
            get; set;
        }

        public Unit Unit {
            get; set;
        }

        public override bool Equals(object obj) {
            if (!(obj is Group)) {
                return false;
            }
            return ((Group) obj).ID == ID;
        }

        public override string ToString() {
            return Name;
        }
    }
}
