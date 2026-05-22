# Employee-ManagementSystem

Project Description

EmployeeManagementSystem is a desktop application developed using Visual Basic (Windows Forms). The system is integrated with Microsoft SQL Server (SSMS) and allows managing employee records including adding, updating, deleting, and listing data.

Technologies Used
Visual Basic (.NET Windows Forms)
Microsoft SQL Server (SSMS)
ADO.NET (SqlConnection, SqlCommand, SqlDataReader)
DataGridView for data display
Parameterized SQL queries
Features
Employee Management
Stores employee information such as ID, name, surname, city, job, salary, and marital status (Single / Married).
Data is saved directly into a SQL Server database.
All records are displayed in a DataGridView.
CRUD Operations
Save: Adds a new employee record to the database.
Show List: Displays all records from the database in a DataGridView.
Delete: Removes the selected record from the database.
Update: Updates existing employee information.
Clear: Clears all input fields on the form.
Data Interaction
Double-clicking a row in the DataGridView automatically fills the form fields with the selected record’s data.
This allows easy editing and updating of records.
Reporting and Statistics
Average salary calculation
Total number of married employees
Employee distribution by city
Average salary by job title

A separate statistics form is used to display these reports.

Charts
Employee distribution by city
Average salary by job title
Login System
A separate login form is implemented.
Username and password are stored in a dedicated SQL Server table.
Authentication is handled using if-else logic with database validation.
