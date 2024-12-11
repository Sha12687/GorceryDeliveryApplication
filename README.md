# Grocery Delivery Application

The **Grocery Delivery Application** is a robust system catering to two types of users: **customers** and **admins**.

## Customer Features:
- **Browse Products**: View available products by category.
- **Add to Cart**: Select products and add them to a shopping cart.
- **Order Tracking**: Track the status of placed orders.
- **Profile Management**: Update personal details for a customized experience.

## Admin Features:
- Manage product inventory, orders, and customer data.

This project implements a seamless user experience for efficient grocery shopping and delivery.

# ASP.NET Framework Project Setup

Follow these steps to clone the ASP.NET Framework repository and set up the project using a Code-First approach.

## Clone the Repository

1. Open a terminal or command prompt.

2. Navigate to the directory where you want to clone the repository:

3. https://github.com/Sha12687/GorceryDeliveryApplication
   
## Update Connection String

1. Open the `Web.config` file.

2. Locate the `<connectionStrings>` section.

3. Update the connection string with your database server details, database name, and credentials. Find the following XML snippet:

    ```xml
    <add name="YourDbContext" connectionString="Data Source=YourServer;Initial Catalog=YourDatabase;Integrated Security=True;" providerName="System.Data.SqlClient" />
    ```

   Replace `YourDbContext`, `YourServer`, `YourDatabase`, and provide appropriate authentication details.

4. Save the changes to the `Web.config` file.

## Update Database

1. Open the Package Manager Console (PMC) in Visual Studio.

2. Run the following commands to apply migrations and update the database:

   ```bash
   Enable-Migrations
   Update-Database

## Resolve "Could not find a part of the path ... bin\roslyn\csc.exe" Error

If you encounter the error "Could not find a part of the path ... bin\roslyn\csc.exe" while running the project, follow these steps to resolve it:

1. Open Visual Studio.

2. Navigate to **Tools > NuGet Package Manager > Package Manager Console**.

3. In the Package Manager Console, run the following command:

   ```bash
   Update-Package Microsoft.CodeDom.Providers.DotNetCompilerPlatform -r

## Here are some snippet of User interfaces
![image](https://github.com/user-attachments/assets/b350e95e-210b-44c3-afff-9b4dce4a8849)
![image](https://github.com/user-attachments/assets/8c4b0417-ef7a-474d-87d9-290788f2eab6)
![image](https://github.com/user-attachments/assets/ee5c0d4a-c929-4143-83a1-80f15f17c523)
![image](https://github.com/user-attachments/assets/54db88e6-18c8-4924-90e4-bbfd726603de)
![image](https://github.com/user-attachments/assets/ad7661d5-772f-42e4-8f13-d54911caeac7)
![image](https://github.com/user-attachments/assets/ad0b5cd8-fcd8-423a-b30b-fb3ca4e30dc2)
![image](https://github.com/user-attachments/assets/03f3e2fa-d412-4dcf-ba2d-a337770054b9)
![image](https://github.com/user-attachments/assets/3b7b598a-230c-4b78-b434-d0eb3c29e10b)


