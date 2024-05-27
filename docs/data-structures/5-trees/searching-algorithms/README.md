# Searching Algorithms

## Level-Order Traversal (Breadth-first search)

Breadth-first search (BFS) is an algorithm used for graph traversal, **searching trees**, or traversing other data structures.

The key idea behind BFS is to visit nodes in a graph in a breadthwise fashion, **exploring all nodes at the same level before moving deeper into the graph**.

### Main points:

#### Visiting Nodes

1. The algorithm starts by selecting a single node (usually the initial or source node) in the graph.
2. It then visits all the nodes adjacent to the selected node one by one.
3. Once a node is visited, it is marked as such.

#### Queue-Based Approach

- BFS uses a queue data structure to keep track of nodes to be visited. The queue follows the First-In-First-Out (FIFO) model.
- Nodes are added to the queue as they are visited, and they are processed in the order they were added.

#### Level-by-Level Exploration

BFS explores the graph **level by level**, by visiting all nodes at the current level before moving to the next level, this ensures that nodes at the same depth are processed together.

#### Termination

The iterations continue until all nodes in the graph have been successfully visited and marked.

### Algorithm

```csharp
static void BreadthFirstSearch(Node root)
{
    if (root == null)
        return;

    Queue<Node> queue = new();

    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        Node currentTree = queue.Dequeue();

        if (currentTree.left != null)
        {
            queue.Enqueue(currentTree.left);
        }

        if (currentTree.right != null)
        {
            queue.Enqueue(currentTree.right);
        }
    }
}
```

Explanation:

![bfs-explanation](/images/search-algorithms-breadth-first-search.png)

### Implementations

- [On a Binary Search Tree](../binary-search-trees/README.md#breadth-first-search-bfs-implementation)