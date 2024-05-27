# Binary Search Trees

A binary search tree (BST) is an efficient data structure where each node has at most two child nodes.

And the left child of a node is always smaller, and the right child is always greater than the parent node.

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

### Breadth-First Search (BFS) Implementation

Let's suppose we have the following BST, below:

```
    10
   /  \
  5    15
 / \   /
3   7 12
```

Using a BFS approach, we will have the following result: `10, 5, 15, 3, 7, 12`.