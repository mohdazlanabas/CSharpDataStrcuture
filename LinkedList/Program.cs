// Linked List
// HEAD > INESERT > DELETE > ITERATE > NULL

using LinkedList;

/*
Node nodeA = new Node();
nodeA.Data = 865;
Node nodeB = new Node();
nodeB.Data = 344;
Node nodeC = new Node();
nodeC.Data = 888;
Node nodeD = new Node();
nodeD.Data = 222;

nodeA.Next = nodeB;
nodeB.Next = nodeC;
nodeC.Next = nodeD;
*/

Links links = new Links();
links.InsertFirst(1);
links.InsertFirst(2);
links.InsertFirst(3);
links.InsertFirst(4);

links.DeleteFirst();
links.DeleteFirst();

links.InsertLast(546);
links.InsertLast(3434);

links.DisplayList();