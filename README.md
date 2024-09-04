# Inventory Management System

## Overview
The Inventory Management System is a Windows Forms application developed using C# and Entity Framework Core. The system is designed to help small retail stores efficiently manage their products, track inventory, and record transactions such as sales and purchases. The application connects to a Microsoft SQL Server database to store and retrieve data.

## Features
- **Product Management:** Add, edit, delete, and search products in the inventory.
- **Category Management:** Categorize products for better organization and management.
- **Inventory Tracking:** Track stock levels of products and update them automatically based on transactions.
- **Transaction Recording:** Record sales and purchase transactions, adjusting inventory levels accordingly.
- **Reporting:** Generate and view detailed reports on transactions and inventory status.
- **Search Functionality:** Search products based on various criteria such as name, description, and category.
- **Data Validation:** Ensure accurate data entry with validation checks.

## Project Structure

### Entities
- **Product:** Represents a product in the inventory. Includes details such as name, description, selling price, and category.
- **Category:** Represents a product category. Each category can have multiple products.
- **Inventory:** Tracks the quantity of each product in stock.
- **Transactions:** Records sales and purchase transactions, including product, quantity, date, and notes.

### Forms
- **Main Form:** Serves as the entry point of the application, providing navigation to various management forms.
- **Product Management Form:** Allows users to add, edit, delete, and search for products.
- **Category Management Form:** Manages product categories.
- **Inventory Management Form:** Displays and manages inventory levels, including low stock alerts.
- **Transaction Management Form:** Handles sales and purchase transactions, updating inventory accordingly.

### Database Context
- **AppDbContext:** The Entity Framework Core database context that manages data access to the Product, Category, Inventory, and Transactions tables in the SQL Server database.

## Installation

### Prerequisites
- Visual Studio 2022 or later (as it supports .NET 8.0)
- .NET SDK 8.0 or later
- SQL Server 2017 or later

### Setup

1. **Clone the repository:**

   - git clone https://github.com/your-username/InventoryManagementSystem.git

2. **Open the project:**

    - Open the InventoryManagementSystem.sln file in Visual Studio.

3. **Configure the database:**

    Update the connection string in AppDbContext.cs to point to your SQL Server instance:

    - optionsBuilder.UseSqlServer("Server=your-server;Database=InventoryManagmentSystem;Trusted_Connection=True;Encrypt=false;TrustServerCertificate=True");

4. **Install dependencies:**
    - The project uses Entity Framework Core, which is included in the project file. Ensure you restore the necessary NuGet packages:

5. **Apply migrations and create the database:**

    - In Visual Studio, open the Package Manager Console and run: Update-Database

6. **Build and run the application:**
    
## Usage

### Main Menu
- Use the main menu to navigate between different forms (Product Management, Category Management, Inventory Management, and Transaction Management).

### Product Management
- Add, edit, or delete products, and assign them to categories.
Search for products by name, description, or category.

### Category Management
- Manage product categories and view associated products.

### Inventory Management
- Monitor inventory levels and view low stock alerts.
- Update inventory manually or through transactions.

### Transaction Management
- Record sales or purchase transactions, automatically adjusting inventory levels.
