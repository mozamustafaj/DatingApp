# DatingApp
BookStore API is a RESTful API to manage books inventory and orders for a book store.

# Introduction
This project serves as a backend for managing a book store's inventory and orders. It provides endpoints for adding, retrieving, updating, and deleting books, as well as placing and tracking orders.

# Technologies Used
.NET 6
Entity Framework Core 6
SQL Server
AutoMapper
Swagger/OpenAPI
# Setup
Prerequisites
.NET 6.0 SDK
SQL Server (any recent version)
**Installation**
Clone the repository and navigate to the project directory:

sh
Copy code
git clone https://github.com/yourusername/BookStoreAPI.git
cd BookStoreAPI
Restore the .NET packages and run the application:

sh
Copy code
dotnet restore
dotnet run
The API can be accessed at http://localhost:5000/.

**Features**
CRUD operations for books
Place and track orders
Search for books
To-do list for future development:

Implement user authentication and authorization
Support for bulk orders
Enhance search functionality
**How to Use**
API documentation is available at http://localhost:5000/swagger.

**Testing**
To run the unit tests:

sh
Copy code
dotnet test
**Contributing**
Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

**License**
This project is licensed under the MIT License.
