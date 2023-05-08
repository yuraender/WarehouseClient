using System;

namespace WarehouseClient.Client.Entities {
    public class Repair {

        public int ID {
            get; set;
        }

        public string Organization {
            get; set;
        }

        public DateTime DispatchDate {
            get; set;
        }

        public DateTime? ReturnDate {
            get; set;
        }

        public override string ToString() {
            return $"{Organization} ({DispatchDate} - {ReturnDate}) (#{ID})";
        }
    }
}
