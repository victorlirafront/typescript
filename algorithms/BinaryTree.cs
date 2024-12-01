using System;

class Node {
    public int Value;
    public Node Left, Right;

    public Node(int value) {
        Value = value;
        Left = Right = null;
    }
}

class BinaryTree {
    public Node Root;

    public void Insert(int value) {
        Root = InsertRec(Root, value);
    }

    private Node InsertRec(Node root, int value) {
        if (root == null) return new Node(value);

        if (value < root.Value) root.Left = InsertRec(root.Left, value);
        else if (value > root.Value) root.Right = InsertRec(root.Right, value);

        return root;
    }

    public bool Search(int value) {
        return SearchRec(Root, value);
    }

    private bool SearchRec(Node root, int value) {
        if (root == null) return false;
        if (root.Value == value) return true;

        return value < root.Value
            ? SearchRec(root.Left, value)
            : SearchRec(root.Right, value);
    }
}

class Program {
    static void Main() {
        BinaryTree tree = new BinaryTree();
        tree.Insert(50);
        tree.Insert(30);
        tree.Insert(70);
        tree.Insert(20);
        tree.Insert(40);
        tree.Insert(60);
        tree.Insert(80);

        Console.WriteLine(tree.Search(40) ? "Encontrado" : "Não encontrado");
    }
}
