# Trees

## Binary Trees

A binary search tree has one of the **most efficient search algorithms** because it always searches for the middle number until it finds what you're looking for.

## Terminology

- `root`: First element of a tree.
- `leaf`: Non-root element with no children.
- `ancestor`: The parent of some element, located at left/right.
- `child`: The node below an ancestor.
- `depth` (level): It's the distance of some node (number of edges) to the root.

### Binary Search Trees (BST)

- A binary search tree (BST) is an efficient data structure where each node has at most two child nodes.
- The left child of a node is smaller, and the right child is greater than the parent node.

### Height of a BST

The height of a BST is the **longest path from the root to a leaf node**.

Consider a binary search tree (BST) shown in the image below:

![binary-search-tree-example](/images/binary-search-tree-bst-example.png)

We can calculate the height using a recursive function that traverses left and right subtrees.

Now, let’s implement the function as shown below:

```csharp
public static int GetHeight(Node root){
    if (root == null)
        return -1;
    
    return 1 + int.Max(getHeight(root.left),getHeight(root.right));
}
```

Explanation:

![binary-search-tree-bst-height-explanation](/images/binary-search-tree-bst-concept.png)