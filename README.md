# Book Store - ASP.NET Core (MVC)

*   Noah Hicks

## Summary

This web application is an online bookstore built using ASP.NET Core MVC framework. It allows users to browse through a collection of books, view book details, and navigate through the book catalog using pagination. The application follows a clean architecture, separating concerns into models, repositories, interfaces, and controllers. It utilizes a SQLite database to store book information and Entity Framework Core for data access.

## Features

*   Book Catalog: The application displays a list of books with their details, including title, author, publisher, ISBN, classification, category, page count, and price.
*   Pagination: The book catalog is paginated, allowing users to navigate through the list of books easily. The number of books per page can be customized.
*   Repository Pattern: The application uses the repository pattern to abstract the data access layer, providing a clean and maintainable architecture.
*   Dependency Injection: The application leverages dependency injection to manage dependencies between classes, promoting loose coupling and testability.
*   Bootstrap Styling: The user interface is styled using Bootstrap, providing a responsive and modern design that adapts to different screen sizes.

## Technical Details

*   Framework: ASP.NET Core MVC
*   Database: SQLite
*   ORM: Entity Framework Core
*   Front-end: HTML, CSS, Bootstrap
*   Programming Language: C#

## Implementation

The application follows a structured architecture, utilizing the following components:

*   Models: The `Book` model represents the structure of a book entity in the database, with properties such as `Title`, `Author`, `Publisher`, `ISBN`, `Classification`, `Category`, `PageCount`, and `Price`.
*   Repository: The `IBookRepository` interface defines the contract for retrieving book data, while the `BookRepository` class implements this interface, interacting with the database using Entity Framework Core.
*   Controller: The `BookController` handles HTTP requests related to books, interacts with the repository to retrieve book data, and returns the appropriate views to the user.
*   Views: The `Index` view displays the list of books in a tabular format, with pagination links at the bottom. The `_Layout` view provides a consistent layout for all pages, including the navigation bar and footer.

## Challenges and Learning Outcomes

During the development of this application, I encountered several challenges and learning opportunities:

*   Implementing pagination: I learned how to efficiently retrieve a subset of data from the database based on the current page number and page size, and how to generate pagination links dynamically.
*   Applying Bootstrap styles: I gained experience in utilizing Bootstrap classes and components to create a responsive and visually appealing user interface.
*   Working with Entity Framework Core: I deepened my understanding of using Entity Framework Core to interact with a database, including configuring the database context, defining entity relationships, and performing database queries.

## Future Enhancements

While the current version of the application provides basic functionality for browsing books, there are several potential enhancements that could be implemented in the future:

*   Search functionality: Allow users to search for books based on title, author, or other criteria.
*   User authentication and authorization: Implement user registration, login, and role-based access control to personalize the user experience and restrict certain actions to authorized users.
*   Shopping cart and checkout: Enable users to add books to a shopping cart and complete the purchase process.
*   Book details page: Create a dedicated page for each book, displaying more detailed information and user reviews.

## Conclusion

The Book Store web application demonstrates my skills in developing a functional and visually appealing ASP.NET Core MVC application. It showcases my understanding of core concepts such as data modeling, repository pattern, dependency injection, and Bootstrap styling. Through this project, I have gained valuable experience in building web applications using the ASP.NET Core framework and working with databases using Entity Framework Core.
