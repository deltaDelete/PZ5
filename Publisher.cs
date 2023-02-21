using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ5 {
    public class Publisher {
        private List<Subscriber> subscribers;
        private object mainState;

        public void Subscribe(Subscriber s) {
            subscribers.Add(s);
        }

        public void Unsubscribe(Subscriber s) {
            subscribers.Remove(s);
        }

        public void NotifySubscribers() {
            subscribers.ForEach(s => s.Update("notify"));
        }

        public void MainBusinessLogic() {
            for (int i = 0; i <= 100; i += 10) {
                Console.WriteLine($"Некая бизнес логика {i}%");
            }
        }
    }
}
