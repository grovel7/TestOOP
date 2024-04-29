using System;
using static System.Reflection.Metadata.BlobBuilder;

namespace Test;

class Program
{
    public static void Main()
    {

        //sale object

        Sales newSales = new Sales();

        Batch FirstBatch = new Batch("#2024x00001" , "CompSci Books");
        FirstBatch.Add(new Transaction("1", "Deep Learning in Python", 1.00m));
        FirstBatch.Add(new Transaction("2", "C# in action", 2.00m));
        newSales.Add(FirstBatch);

        //empty batch
        Batch secondBatch = new Batch("#2024x00002", "Fantasy Books");
        newSales.Add(secondBatch);

        //single transaction

        Transaction single = new Transaction("00-0001", "Compilers", 3.00m);
        newSales.Add(single);
        

        //nested batch

        Batch outerBatch = new Batch("outer" , "movies");
        outerBatch.Add(new Transaction("2024", "bb" , 1.00m));

        Batch innerBatch = new Batch("inner", "series");
        innerBatch.Add(new Transaction("1", "one piece", 1.00m));
        innerBatch.Add(new Transaction("2", " Friends", 2.00m));
        innerBatch.Add(new Transaction("3", "HIMYM", 3.00m));

        outerBatch.Add(innerBatch);
        newSales.Add(outerBatch);


        //print
        newSales.PrintOrders();
















    }
}

//Sales:
//Batch sale: #2024x00001, CompSci Books
//#1, Deep Learning in Python, $67.90
//#2, C# in Action, $54.10
//#3, Design Patterns, $129.75
//Total: $251.75
//Batch sale: #2024x00002, Fantasy Books
//Empty order.
//#00-0001, Compilers, $134.60
//#10-0003, Hunger Games 1-3, $45.00
//#15-0020, Learning Blender, $56.90
//Sales total: $488.25

