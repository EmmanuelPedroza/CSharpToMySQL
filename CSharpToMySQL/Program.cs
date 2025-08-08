using System;

namespace CSharpToMySQL
{
    class Program
    {
        static void Main()
        {
            // Create an instance of your DBConnect class
            DBConnect db = new DBConnect();

            // Insert a new record
            Console.WriteLine("Inserting a record...");
            db.Insert();

            // Update a record
            Console.WriteLine("Updating a record...");
            db.Update();

            // Select and display all records
            Console.WriteLine("Selecting records...");
            var records = db.Select();

            Console.WriteLine("ID\tName\tAge");
            for (int i = 0; i < records[0].Count; i++)
            {
                Console.WriteLine($"{records[0][i]}\t{records[1][i]}\t{records[2][i]}");
            }

            // Count records
            int count = db.Count();
            Console.WriteLine($"Total records: {count}");

            // Delete a record
            Console.WriteLine("Deleting a record...");
            db.Delete();

            Console.WriteLine("Done. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
