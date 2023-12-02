using System.Net;
using Microsoft.VisualBasic;

namespace AlgorithmsDataStructuresLearning.LinkedList;

public class LinkedList
{
    public Node? First { get; set; }

    public void InsertFirst(int data)
    {
        //create node
        Node newNode = new Node();
        
        //put data in node
        newNode.Data = data;
        
        //put old node in next
        newNode.Next = First;
        
        //Make First the new node
        First = newNode;
    }

    public Node DeleteFirst()
    {
        //Assign the temp variable
        Node temp = First;
        
        //assign next First
        First = First.Next;

        return temp;
    }  

    public void DisplayList()
    {
        Console.WriteLine("Iterating...");
        Node current = First;

        while (current != null)
        {
            current.DisplayNode();
            current = current.Next;
        }
    }

    public void InsertLast(int data)
    {
        Node current = First;

        while (current.Next != null)
        {
            current = current.Next;
        }

        Node newNode = new Node
        {
            Data = data
        };

        current.Next = newNode;

    }
}