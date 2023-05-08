namespace WarehouseClient.Client.Entities {
    public class User {

        public int ID {
            get; set;
        }

        public string Name {
            get; set;
        }

        public string Login {
            get; set;
        }

        public string Password {
            get; set;
        }

        public bool IsPasswordChanged {
            get; set;
        }

        public bool IsAdmin {
            get; set;
        }

        public bool IsUnitAdmin {
            get; set;
        }

        public Unit Unit {
            get; set;
        }

        public override bool Equals(object obj) {
            if (!(obj is User)) {
                return false;
            }
            return ((User) obj).ID == ID;
        }

        public override string ToString() {
            return $"{Name} (#{ID})";
        }
    }
}
