namespace AlgorithmsDataStructuresLearning;

public class Hashtable
{
    public string[] _hashTable { get; set; }

    public Hashtable()
    {
        _hashTable = new string[10];
    }

    private int Hash(string key)
    {
        return key.Length % _hashTable.Length;
    }

    public string Get(string key)
    {
        int hashedKey = Hash(key);
        return _hashTable[hashedKey];
    }
    
    public void Set(string key, string value)
    {
        int hashedKey = Hash(key);

        if (_hashTable[hashedKey] != null)
        {
            Console.WriteLine("Sorry collision hash has occured");
        }

        else
        {
            _hashTable[hashedKey] = value;
        }
    }
}