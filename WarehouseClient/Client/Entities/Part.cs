using System.Collections.Generic;

namespace WarehouseClient.Client.Entities {
    public class Part {

        public int ID {
            get; set;
        }

        public string Name {
            get; set;
        }

        public string Type {
            get; set;
        }

        public int Amount {
            get; set;
        }

        public string Measure {
            get; set;
        }

        public string Description {
            get; set;
        }

        public Group Group {
            get; set;
        }

        public List<Repair> Repairs {
            get; set;
        }

        public override bool Equals(object obj) {
            if (!(obj is Part)) {
                return false;
            }
            return ((Part) obj).ID == ID;
        }

        public override string ToString() {
            return $"{Name} {Type} {Description} {Amount} {Measure}";
        }
    }
}
