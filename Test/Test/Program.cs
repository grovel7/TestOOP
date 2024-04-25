using System;
namespace Test;

class Program
{
    public static void Main()
    {
        Sales allthesales = new Sales();

        Batch firstbatch = new Batch("#2024x00001", "CompSci Books");
    
        Transaction t1 = new Transaction("1", "Deep Learning in Python", 67.90m);
        Transaction t2 = new Transaction("2", "C# in Action", 54.10m);
        Transaction t3 = new Transaction("3", "Design Patterns", 129.75m);

        Batch secondbatch = new Batch("#2024x00001", "Fantasy Books");

        
        firstbatch.Add(t1);
        firstbatch.Add(t2);
        firstbatch.Add(t3);

        Transaction t4 = new Transaction("00-0001", "Compilers", 134.60m);
        Transaction t5 = new Transaction("10-0003", "Hunger Games 1-3", 45.00m);
        Transaction t6 = new Transaction("15-0020", "Learning Blender", 56.90m);

        allthesales.AddTransaction(t4);
        allthesales.AddTransaction(t5);
        allthesales.AddTransaction(t6);


        allthesales.AddBatch(firstbatch);
        allthesales.AddBatch(secondbatch);

        

        allthesales.PrintOrders();

        


        
        

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

