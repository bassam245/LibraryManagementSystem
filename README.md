Library Management System

This is a simple C# console application that manages a library system.
The project is implemented using Object-Oriented Programming concepts and custom data structures without using built-in collections like List<T>.

Project Features

- Add books and members
- Sort books by ID using Insertion Sort (manual implementation)
- Search for a book using Binary Search (manual implementation)
- Borrow and return books
- Custom generic list structure (Listt<T>)

Technologies Used

- C#
- .NET Console Application

Project Structure

The project is organized as follows:

- Models/: Contains the basic classes like Book, Member, and Person
- DataStructures/: Contains the manually implemented Listt<T>
- Algorithms/: Contains InsertionSort and BinarySearch
- Services/: Contains the logic of the library system in LibraryManager.cs
- Program.cs: Entry point where the system is tested

Sample Functionality

- Books can be added manually
- A member can borrow or return a book by ID
- The system displays all books before and after sorting
- When searching, it returns whether the book exists or not and its position if found

Output Example

Below is a sample screenshot from the console output of the system:

![Console Output](Assets/OutputExample.png)

Notes

- The list and algorithms are implemented manually for learning purposes
- The system does not use any advanced libraries or UI — it's focused on practicing C# logic

Author

This project was implemented as part of learning and practice in Object-Oriented Programming and Algorithms in C#.
