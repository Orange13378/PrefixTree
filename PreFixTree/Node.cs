
namespace PreFixTree
{
    internal class Node<T>
    {
        public char Symbol { get; set; }
        public T Data { get; set; }
        public bool IsWord { get; set; }
        public string Prefix { get; set; }

        public Dictionary<char, Node<T>> SubNodes { get; set; }

        public Node(char symbol, T data, string prefix) 
        {
            Symbol = symbol;
            Data = data;
            SubNodes = new Dictionary<char, Node<T>>();
            Prefix = prefix;
        }

        public override string ToString() => $"{Data} [{SubNodes.Count}] ({Prefix})";

        public Node<T>? TryFind(char symbol) => SubNodes.TryGetValue(symbol, out var value) ? value : null;

        public override bool Equals(object? obj) => Data.Equals(obj is Node<T>); // Проверить

        public override int GetHashCode() => HashCode.Combine(Symbol, Data); // Проверить
    }
}
