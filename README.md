# StudentDB

## Overview
StudentDB is a simple C# web application designed to manage student information. It offers functionalities like adding, updating, and retrieving student records from a database.

## Features
- Add new students with personal details.
- Update existing student information.
- Delete student records.
- View a list of all students.

## Technologies Used
- **ASP.NET Core** - For building the web application.
- **Entity Framework Core** - For database interactions.
- **SQL Server** - As the database.

## Setup Instructions

### Prerequisites
- .NET SDK installed
- SQL Server or any other relational database

### Steps
1. Clone the repository:
    ```bash
    git clone https://github.com/jsison2021/StudentDB.git
    cd StudentDB
    ```

2. Set up the database:
    - Update the connection string in `appsettings.json`.
    - Run database migrations:
      ```bash
      dotnet ef database update
      ```

3. Run the application:
    ```bash
    dotnet run
    ```

4. Access the app at `http://localhost:5000`.

## Contributing
Feel free to fork this repository and contribute via pull requests. Make sure to write tests and update documentation for any new features.
