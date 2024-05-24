# Linked Lists

In a few words, Linked Lists are a data structure that consists of a **group of nodes** which **represent a sequence** together.

## Characteristics

- Order matters.
- Space is dynamic (We don't need to say the total of elements is needed in the beginning like it happens in arrays).

## Terminology

### Node

It's where the data is stored and each node has a reference to the next node.

## When should you use it?

They should be used when it's needed a **fasting insertion/deletion operations**.

It is not a good call to use it for searching operations, because you have to access each one of the nodes to know where is the next one.

So, it's not so performatic as arrays for searching operations.

## Terminology/Naming

- C# => LinkedList<Type>

## Pros & Cons

### Advantages

Fast for inserting/deleting elements.

### Disadvantages

Slow for reading elements.

The biggest disadvantage for linked lists is the fact it does not have indexes.

If we want to find the third element, we will need to iterate it from the beginning.