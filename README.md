# 🍲 RecipeNest – Full Stack Web Application

RecipeNest is a full-stack web application that allows users to create, view, and manage recipes.
It demonstrates the integration of a React frontend, ASP.NET Core backend, and SQLite database.

---

## 🚀 Features

* 👤 User Registration & Login
* 🍲 Add Recipes
* 📋 View All Recipes
* ✏️ Update Recipes
* ❌ Delete Recipes
* 🔄 Real-time UI updates

---

## 🧱 Tech Stack

### Frontend

* React (Vite)
* JavaScript
* HTML & CSS

### Backend

* ASP.NET Core Web API

### Database

* SQLite (Entity Framework Core)

---

## 📂 Project Structure

```
RecipeNest/
├── RecipeNestAPI/        # Backend (ASP.NET Core)
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   └── Program.cs
│
├── recipenest-frontend/  # Frontend (React)
│   ├── src/
│   └── package.json
```

---

## ⚙️ Installation & Setup

### 🔹 1. Clone the Repository

```
git clone https://github.com/moosa-2004/RecipeNest.git
cd RecipeNest
```

---

### 🔹 2. Run Backend

```
cd RecipeNestAPI
dotnet run
```

Backend will run at:

```
http://localhost:5011
```

Swagger API:

```
http://localhost:5011/swagger
```

---

### 🔹 3. Run Frontend

Open a new terminal:

```
cd recipenest-frontend
npm install
npm run dev
```

Frontend will run at:

```
http://localhost:5173
```

---

## 🔗 How It Works

1. User interacts with the React frontend
2. Frontend sends HTTP requests to ASP.NET API
3. Backend processes data and interacts with SQLite database
4. Data is returned and displayed in the UI

---

## 📊 Database Design

### Chef Table

* ChefID (Primary Key)
* FullName
* Email
* PasswordHash
* Biography
* ProfileImage

### Recipe Table

* RecipeID (Primary Key)
* ChefID (Foreign Key)
* Title
* Ingredients
* Instructions
* ImagePath
* DateCreated

---

## 🧪 Example Usage

* Add a recipe via the UI
* View all recipes instantly
* Delete a recipe
* Data updates dynamically

---

## ⚠️ Known Limitations

* Passwords are not hashed (for simplicity)
* No authentication tokens implemented
* Basic UI styling

---

## 🔮 Future Improvements

* Add JWT authentication
* Improve UI/UX design
* Add image upload feature
* Deploy application online

---

## 👨‍💻 Author

Moosa

---

## 📌 Notes

This project was developed as part of a full-stack web development assignment and demonstrates core concepts such as CRUD operations, API integration, and database management.

---
