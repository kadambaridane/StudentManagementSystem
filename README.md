# 🎓 Student Management System API

This is a **Student Management System** built using **ASP.NET Core Web API** with **SQL Server**.
It provides secure APIs to manage student records with **JWT Authentication**, **Swagger documentation**, and **clean layered architecture**.

---

## 🚀 Features

* ✅ CRUD Operations (Create, Read, Update, Delete)
* 🔐 JWT Authentication (Secure Endpoints)
* 📘 Swagger UI with Authorize Button
* 🧱 Layered Architecture (Controller, Service, Repository)
* ⚠️ Global Exception Handling Middleware
* 📜 Logging using Serilog
* 🗄️ SQL Server Database Integration

---

## 🛠️ Technologies Used

* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* JWT Authentication
* Swagger (Swashbuckle)
* Serilog

---

## 📂 Project Structure

```text
StudentManagementSystem/
│
├── Controllers/
├── Services/
├── Repositories/
├── Models/
├── Data/
├── Middleware/
├── Helpers/
├── Program.cs
└── appsettings.json
```

---

## ⚙️ Setup Instructions (Step-by-Step)

### 🔹 1. Clone the Repository

```bash
git clone https://github.com/kadambaridane/StudentManagementSystem.git
```

---

### 🔹 2. Open Project

* Open **Visual Studio**
* Click **Open Project/Solution**
* Select the project folder

---

### 🔹 3. Configure Database

Open `appsettings.json` and update connection string:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=StudentsDB;Trusted_Connection=True;TrustServerCertificate=True;"
}
```

---

### 🔹 4. Apply Migration (if needed)

Open Package Manager Console:

```bash
Add-Migration InitialCreate
Update-Database
```

---

### 🔹 5. Run the Project

* Press **F5** or click **Run**
* Swagger UI will open automatically

---

### 🔹 6. Generate JWT Token

Call API:

```
GET /api/student/token
```

Copy the token from response

---

### 🔹 7. Authorize in Swagger

* Click 🔒 **Authorize**
* Enter:

```
Bearer YOUR_TOKEN
```

* Click **Authorize**

---

### 🔹 8. Test APIs

Now you can test:

* GET Students
* POST Student
* PUT Student
* DELETE Student

---

## 🔑 API Endpoints

| Method | Endpoint           | Description        |
| ------ | ------------------ | ------------------ |
| GET    | /api/student       | Get all students   |
| GET    | /api/student/{id}  | Get student by ID  |
| POST   | /api/student       | Add new student    |
| PUT    | /api/student/{id}  | Update student     |
| DELETE | /api/student/{id}  | Delete student     |
| GET    | /api/student/token | Generate JWT Token |

---

## 📌 Example Request

```json
{
  "name": "Rahul Sharma",
  "email": "rahul@gmail.com",
  "age": 21,
  "course": "Computer Science"
}
```

---

## 🗄️ Database Table

**Students**

* Id
* Name
* Email
* Age
* Course
* CreatedDate

---

## 👨‍💻 Author

* Kadambari Dane

---

## ⭐ Notes

* Follows clean architecture and best practices
* Secure API using JWT authentication
  
