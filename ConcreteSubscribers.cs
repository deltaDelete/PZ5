using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5 {
    internal class ConcreteSubscribers : Subscriber {
        public int RandomInteger { get; set; } = Random.Shared.Next();
        public void Update(string context) {
            Console.WriteLine($"{nameof(ConcreteSubscribers)}{RandomInteger}{context}");
        }
    }
}
