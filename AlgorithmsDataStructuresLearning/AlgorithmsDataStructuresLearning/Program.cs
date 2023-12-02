// See https://aka.ms/new-console-template for more information

using AlgorithmsDataStructuresLearning;
using AlgorithmsDataStructuresLearning.LinkedList;

int[] array = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

//Linear search
void LinearSearch(int[] array, int key)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == key)
        {
            Console.WriteLine("this number exists in array");
        }
    }
    
    Console.WriteLine(false);
}

//Linked List
LinkedList linkedList = new();

linkedList.InsertFirst(393);
linkedList.InsertFirst(693);
linkedList.InsertFirst(449);
linkedList.InsertFirst(30202);
linkedList.InsertFirst(202002);

linkedList.DeleteFirst();
linkedList.DeleteFirst();

linkedList.InsertLast(69);
linkedList.InsertLast(39303);

linkedList.DisplayList();


LinearSearch(array, 2);

Hashtable hashtable = new Hashtable();

hashtable.Set("Grapes", "01788569281");
hashtable.Set("Poop", "01983903039");
hashtable.Set("Scoob", "01788569282");
hashtable.Set("Raggy", "01788569283");
hashtable.Set("Velma", "01788569232");

Console.WriteLine(hashtable.Get("Grapes"));
Console.WriteLine(hashtable.Get("Poop"));
Console.WriteLine(hashtable.Get("Scoob"));
Console.WriteLine(hashtable.Get("Raggy"));
Console.WriteLine(hashtable.Get("Velma"));