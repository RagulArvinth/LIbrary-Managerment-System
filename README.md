Library Management System
=========================

Overview
--------
This project is a simple console-based library management system that helps users manage books and eBooks. 
It applies core Object-Oriented Programming (OOP) concepts and adheres to SOLID principles to ensure maintainability, scalability, and clean code. 
It also demonstrates the usage of design patterns like Singleton and Factory.

Features
--------
- Add new books or eBooks to the library.
- Remove books by ISBN.
- Search for books by title.
- List all available books in the library.
- Display additional details for eBooks, including file size.

Setup and Running the Project
-----------------------------
1. Prerequisites:
   - Install .NET SDK from https://dotnet.microsoft.com/download
   - Use a code editor like Visual Studio Code or Visual Studio.

2. Clone the Repository: git clone https://github.com/RagulArvinth/LIbrary-Managerment-System.git cd ./LIbrary-Managerment-System

3. Run the Project:
- Open the project folder in your IDE.
- Build the project by pressing `Ctrl+Shift+B` (or the equivalent in your IDE).
- Run the project:
  - For Visual Studio, press `F5`.
  - For the terminal, run:
    ```
    dotnet run
    ```

4. Using the System:
- Follow the menu displayed in the console.
- You can perform actions like adding, searching, removing, and listing books.

Key Concepts and Principles Applied
-----------------------------------
1. Object-Oriented Programming (OOP):
- Encapsulation:
  - The `Book` and `EBook` classes encapsulate their properties (e.g., Title, Author) and behavior (e.g., `ToString`).
- Inheritance:
  - `EBook` extends the `Book` class, reusing properties and behaviors of the base class.
- Polymorphism:
  - The `ToString` method is overridden in both `Book` and `EBook` to provide class-specific behavior.
- Abstraction:
  - Common functionality is abstracted in the `Book` class, while specialized behavior is implemented in `EBook`.

2. SOLID Principles:
- Single Responsibility Principle (SRP):
  - Each class has a single responsibility:
    - `Book`: Represents a generic book.
    - `EBook`: Represents an electronic version of a book.
    - `Library`: Manages the collection of books.
    - `LibraryManager`: Provides the user interface and coordinates the library's operations.
- Open/Closed Principle (OCP):
  - New types of books (like `EBook`) can be added by extending the `Book` class without modifying the existing code.
- Liskov Substitution Principle (LSP):
  - Wherever a `Book` is used, an `EBook` can be substituted without breaking functionality.
- Interface Segregation Principle (ISP):
  - Though interfaces aren't explicitly used in this simple project, responsibilities are divided into distinct classes, avoiding monolithic design.
- Dependency Inversion Principle (DIP):
  - The `LibraryManager` depends on abstractions (via the `Library` class) rather than directly managing books.

3. Design Patterns:
- Singleton Pattern:
  - The `LibraryManager` class ensures only one instance is created throughout the application, managing operations consistently.
- Factory Pattern:
  - The `BookFactory` class creates instances of `Book` or `EBook` based on user input, making the object creation process more modular.

Screenshots
-----------
- Add screenshots of the console application demonstrating features like adding, listing, searching, and removing books.
