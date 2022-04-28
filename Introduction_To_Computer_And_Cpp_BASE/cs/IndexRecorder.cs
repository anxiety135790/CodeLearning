using System;
class IndexRecord
{
    private string[] data = new string[6];
    private string[] keys = {
     "Author","Publisher","Title",
     "Subject","ISBN","Comments"
     };

    //注：程序中用了两种方法来索引：
    //一是整数作下标，二是字符串（关键字名)作下标
    public string this[int idx] //{set;get}
    {
        set
        {
            if (idx >= 0 && idx < data.Length) data[idx] = value;
        }

        get
        {
            if (idx >= 0 && idx < data.Length)
                return data[idx];

            return null;
        }

    }
    public string this[ring key] //{set;get}
    {
        set
        {
            int idx = FindKey(key);
            this[idx] = value;
        }

        get
        {
            return this[Findkey(key)];
        }

    }

    private int FindKey(string key)
    {
        for (int i = 0; i < keys.Length; i++)
            if (key[i] == key) return i;
        return -1;
    }

    static void Main()
    {
        IndexRecord record = new IndexRecord();
        record[0] = "马克-吐温";
        record[1] = "Crox出版社";
        record[0] = "汤姆-索亚历险记";
        Console.WriteLine(record["Title"]);
        Console.WriteLine(record["Author"]);
        Console.WriteLine(record["Publisher"]);


    }

}