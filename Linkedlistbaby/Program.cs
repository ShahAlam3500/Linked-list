using System;

namespace Linkedlistbaby
{
    class Program
    {

        class Node
        {
            public int data;
            public Node next;
        };

        class LinkedList
        {
            public Node head;
            //constructor to create an empty LinkedList
            public LinkedList()
            {
                head = null;
            }


            public void pop_at(int position)
            {
                if (position < 1)
                {
                    Console.Write("\nposition should be >= 1.");
                }
                else if (position == 1 && head != null)
                {
                    Node nodeToDelete = head;
                    head = head.next;
                    nodeToDelete = null;
                }
                else
                {
                    Node temp = new Node();
                    temp = head;
                    for (int i = 1; i < position - 1; i++)
                    {
                        if (temp != null)
                        {
                            temp = temp.next;
                        }
                    }
                    if (temp != null && temp.next != null)
                    {
                        Node nodeToDelete = temp.next;
                        temp.next = temp.next.next;
                        nodeToDelete = null;
                    }
                    else
                    {
                        Console.Write("\nThe node is already null.");
                    }


                }
            }





            public void SearchElement(int searchValue)
            {

                //1. create a temp node pointing to head
                Node temp = new Node();
                temp = this.head;

                //2. create two variables: found - to track
                //   search, idx - to track current index
                int found = 0;
                int i = 0;

                //3. if the temp node is not null check the
                //   node value with searchValue, if found 
                //   update variables and break the loop, else
                //   continue searching till temp node is not null 
                if (temp != null)
                {
                    while (temp != null)
                    {
                        i++;
                        if (temp.data == searchValue)
                        {
                            found++;
                            break;
                        }
                        temp = temp.next;
                    }
                    if (found == 1)
                    {
                        Console.WriteLine(searchValue + " is found at index = " + i + ".");
                    }
                    else
                    {
                        Console.WriteLine(searchValue + " is not found in the list.");
                    }
                }
                else
                {

                    //4. If the temp node is null at the start, 
                    //   the list is empty
                    Console.WriteLine("The list is empty.");
                }
            }



            //display the content of the list
            public void PrintList()
            {
                Node temp = new Node();
                temp = this.head;
              if (temp != null)
                {
                    Console.Write("The list contains: ");
                    while (temp != null)
                    {
                        Console.Write(temp.data + " ");
                        temp = temp.next;
                    }
                  // Console.WriteLine();
               }
               else
                {
                   Console.WriteLine("The list is empty.");
                }
            }



            public void reverseList()
            {
                //1. If head is not null create three nodes
                //   prevNode - pointing to head,
                //   tempNode - pointing to head,
                //   curNode - pointing to next of head
                if (this.head != null)
                {
                    Node prevNode = this.head;
                    Node tempNode = this.head;
                    Node curNode = this.head.next;

                    //2. assign next of prevNode as null to make the
                    //   first node as last node of the reversed list
                    prevNode.next = null;

                    while (curNode != null)
                    {
                        //3. While the curNode is not null adjust links 
                        //   (unlink curNode and link it to the reversed list 
                        //   from front and modify curNode and prevNode) 
                        tempNode = curNode.next;
                        curNode.next = prevNode;
                        prevNode = curNode;
                        curNode = tempNode;
                    }

                    //4. Make prevNode (last node) as head
                    this.head = prevNode;
                }
            }


        };

        // test the code 
      
        static void Main(string[] args)
        {
            //create an empty LinkedList
            LinkedList MyList = new LinkedList();

            //Add first node.
            Node first = new Node();
            first.data = 10;
            first.next = null;
            //linking with head node
            MyList.head = first;

            //Add second node.
            Node second = new Node();
            second.data = 20;
            second.next = null;
            //linking with first node
            first.next = second;

            //Add third node.
            Node third = new Node();
            third.data = 30;
            third.next = null;
            //linking with second node
            second.next = third;

            MyList.PrintList();
        }
    }
    
}
