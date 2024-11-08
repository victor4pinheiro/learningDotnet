# Learning MVC with .NET

Welcome to repository for learning the Model-View-Controller (MVC) architecture using .NET!

## Table of Contents
1. [What is MVC?](#what-is-mvc)
2. [Prerequisites](#prerequisites)
3. [Getting Started](#getting-started)

---

## What is MVC?

MVC is a design pattern that separates an application into three main components:

1. **Model**: Represents the data or business logic of the application. It interacts with the database and performs operations on data.
2. **View**: The user interface that displays data to the user. It only handles data presentation.
3. **Controller**: Manages the communication between the Model and the View. It handles user input, updates the Model, and decides which View to display.

.NET provides a powerful MVC framework with built-in support for building dynamic web applications.

## Prerequisites

To follow along, you should have:

- **.NET SDK** (version 6 or higher): [Install .NET SDK](https://dotnet.microsoft.com/download)
- **Visual Studio** (recommended) or **Visual Studio Code** for code editing and debugging

Basic knowledge of **C#** is helpful but not required.

## Getting Started

### Step 1: Create a New Project

1. Open your IDE (Visual Studio or VS Code).
2. Open the terminal or use the Command Palette in Visual Studio Code.
3. Create a new MVC project by running the following command:

   ```bash
   dotnet new mvc -o MyMvcApp
    ```

This will create a new MVC project in a folder named MyMvcApp.

### Step 2: Understand the Project Structure

After creating the project, you’ll notice several key folders:

    Controllers: Contains C# files that handle incoming HTTP requests, process them, and select the Views to render.
    Models: Contains classes that represent the data structure of your application.
    Views: Contains .cshtml files (Razor templates) that represent the HTML structure and display data.

### Step 3: Build and Run the Application

1. Navigate to your project folder:

   ```bash
   cd MyMvcApp
     ```

Build and run the application:

   ```bash
   dotnet run
   ```

Open your browser and go to http://localhost:5000 to view your app running!


    Navigate to your project folder:
