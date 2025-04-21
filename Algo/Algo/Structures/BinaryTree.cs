namespace Algo.Structures;

public static class BinaryTree
{
    public static void BreathFirstSearch(Node root)
    {
        if(root == null) return;
        System.Collections.Generic.Queue<Node> queue = new Queue<Node>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            Node node = queue.Dequeue();
            Console.WriteLine($"Node value: {node.GetValue()}");
            if(node.LeftNode() != null) queue.Enqueue(node.LeftNode());
            if(node.RightNode() != null) queue.Enqueue(node.RightNode());
        }
    }
}

public class Node
{
    private Node? _leftNode;
    private Node? _rightNode;
    private int _value;

    public Node(int value)
    {
        _value = value;
        _leftNode = null;
        _rightNode = null;
    }

    public int GetValue()
    {
        return _value;
    }

    public Node? LeftNode()
    {
        return _leftNode;
    }

    public Node? RightNode()
    {
        return _rightNode;
    }

    public void SetLeftNode(Node newNode)
    {
        _leftNode = newNode;
    }

    public void SetRightNode(Node newNode)
    {
        _rightNode = newNode;
    }
}