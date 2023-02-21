namespace PZ5;

class Program {
    static void Main(string[] args) {
        var publisher = new Publisher();

        var s = new ConcreteSubscribers();
        publisher.Subscribe(s);
    }

}
