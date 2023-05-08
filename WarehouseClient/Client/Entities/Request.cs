using System;
using System.Collections.Generic;

namespace WarehouseClient.Client.Entities {
    public class Request {

        public int ID {
            get; set;
        }

        public int Number {
            get; set;
        }

        public DateTime Date {
            get; set;
        }

        public List<RequestPart> Parts {
            get; set;
        }

        public User User {
            get; set;
        }
    }

    public class RequestPart {

        public Part Part {
            get; set;
        }

        public DateTime Date {
            get; set;
        }

        public DateTime DateCompleted {
            get; set;
        }

        public string Reason {
            get; set;
        }

        public bool Status {
            get; set;
        }

        public override string ToString() {
            string request =
                $"{Part.Name} {Part.Type} {Part.Description} {Part.Amount} {Part.Measure}"
                + $" до {Date.ToShortDateString()}";
            if (Status) {
                request += " — выполнено";
            } else {
                request += " — не выполнено";
            }
            return request;
        }
    }
}
