# Book Club Database (C# ASP .NET Application)

## By _**Krista Rutz**_

#### A web-based application where the user can track information about books, hosted on [GitHub](https://github.com/KristaRutz/Week-12-Advanced-Databases-and-Authentication-Project). _Last Updated 03.28.2020._

## Description

This application lets the user create an account and login to organize their personal library or virtual reading shelves, letting them add books and authors. Ability to add multiple authors to a book or multiple books to an author is included, in addition to edit and delete functionality.

This project was developed in C# on the .NET Core platform with ASP.NET Core web processing, using MVC pattern libraries, Razor dynamic templating, and a SQL database. Specifically, the app was built using Entity Framework and MySQL to create the schema, and it's hosted on [GitHub](https://github.com/KristaRutz/Week-12-Advanced-Databases-and-Authentication-Project).

#### Epicodus skills:

- C#, HTML, CSS
- Razor view on pages
- MVC pattern (with ASP .NET Core 2.2)
- RESTful routing and CRUD
- many-to-many database relationships
- Entity framework migrations
- Identity and authorization
- Asynchronous code
- MySQL Workbench and server
- Bootstrap library
- Behavior driven development (BDD)
- Git version control and GitHub

## Installation / Set-up

Download or clone the repository to run this program locally! _This program requires .NET Core SDK to run. [Here is a free tutorial](https://www.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-c-and-net) for installing .NET on Mac or Windows 10._

- Download or clone this repo.
  - **To Download ZIP:**
    - Select "Download" on the [GitHub Repository](https://github.com/KristaRutz/Week-12-Advanced-Databases-and-Authentication-Project) site
    - Once downloaded, open the ZIP and extract files. The new folder will be created as 'Week-12-Advanced-Databases-and-Authentication-Project'.
  - **To Clone:**
    - Clone from command line into your Desktop: \$ `git clone https://github.com/KristaRutz/Week-12-Advanced-Databases-and-Authentication-Project`
    - The new directory will be created as 'Desktop/Week-12-Advanced-Databases-and-Authentication-Project'.
- Once you have stored the files locally, execute the following commands.
  - Navigate to the application directory: \$ `cd Desktop/Week-12-Advanced-Databases-and-Authentication-Project/BookClub`
  - \$ `dotnet restore`
  - \$ `dotnet ef migrations add Initial`
  - \$ `dotnet ef database update`
  - \$ `dotnet build`
  - \$ `dotnet run`
- Upon success, the program will begin running in your console.

## Technologies Used

- .NET Core 2.2
  - Server-side in C#
    - C# Back-end
    - HTML, CSS, and C# front-end
- ASP .NET Core and Razor templating
  - client-side in JavaScript
- SQL database

## Specs

Build an application with user authentication and a many-to-many relationship. Here are the features to include:

- The application should have user authentication. A user should be able to log in and log out. Only logged in users should have create, update and delete functionality. All users should be able to have read functionality.
- There should be a many-to-many relationship.
- A user should be able to navigate to a splash page that lists all instances of each class. Users should be able to click on an individual instance to see all the instances that belong to it.

Your code will be reviewed for the following objectives:

- [x] Does at least one of your classes have all CRUD methods implemented in your app?
- [x] Are you able to view both sides of the many-many relationship? For a particular instance of a class, are you able to view all of the instances of the other class that are related to it?
- [x] Are users able to register, log in and log out with Identity?
- [x] Is Create, Update and Delete functionality limited to authenticated users?
- [x] Is the project in a polished, portfolio-quality state?
- [o] Was required functionality in place by the 5:00pm Friday deadline?
- [x] Does the project demonstrate all of this week's concepts? If prompted, are you able to discuss your code with an instructor using correct terminology?

<details>
  <summary>Expand specs for this project</summary>

| Spec | Example Input | Expected Output |
| :--- | :------------ | :-------------- |


</details>

<details>
  <summary>Expand user stories for this project</summary>

| As a _User-Type_, | I want... | so that... |
| :---------------- | :-------- | :--------- |


</details>

## Known Bugs

- No known bugs

## Support and contact details

Please contact me if you run into any issues or have questions, ideas or concerns. I can be contacted at <krista.rutz@pomona.edu>. Feel free to create a pull request for updates - _contributions to the code are encouraged!_

### License

Copyright (c) 2020 **_Krista Rutz_**

_This software is licensed under the MIT license._

<details>
  <summary>View license details</summary>

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

</details>
