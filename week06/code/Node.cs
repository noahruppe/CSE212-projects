public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

public void Insert(int value)
{
    if (value < Data)
    {
        // Insert to the left
        if (Left is null)
            Left = new Node(value);
        else
            Left.Insert(value);
    }
    else if (value > Data) // Prevent duplicate values
    {
        // Insert to the right
        if (Right is null)
            Right = new Node(value);
        else
            Right.Insert(value);
    }
}

public bool Contains(int value)
{
    if (value == Data)
    {
        return true;  // Found the value in the current node
    }

    if (value < Data)
    {
        if (Left is null)
        {
            return false;  // Left node is null, value not found
        }
        return Left.Contains(value);  // Recurse to the left node
    }

    if (value > Data)
    {
        if (Right is null)
        {
            return false;  // Right node is null, value not found
        }
        return Right.Contains(value);  // Recurse to the right node
    }

    return false;  // If not found
}


    public int GetHeight()
{
        
        if (Left == null && Right == null)
            return 1;

        
        int leftHeight = 0;
        if (Left != null)
        {
            leftHeight = Left.GetHeight();
        }

        
        int rightHeight = 0;
        if (Right != null)
        {
            rightHeight = Right.GetHeight();
        }

        
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}
