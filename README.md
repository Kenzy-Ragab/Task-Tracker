# 📝 Task Tracker (Console App)

A simple and interactive task tracking application built with **C#**.  
You can easily add, view, update, and delete your daily tasks using a clean and organized console interface.

---

## 💻 Features

- ➕ **Add Tasks** with title, description, due date, priority, and status  
- 📋 **View Tasks** filtered by:  
  - All Tasks  
  - Completed Tasks  
  - Pending Tasks  
  - Overdue Tasks  
- 🔄 **Update Task Status** (Pending, In Progress, Completed)  
- ❌ **Delete Tasks** with confirmation  
- 💾 **Persistent Storage** using a local text file  

---

## 🧱 Project Structure

```
TaskTracker/
├── Models/     # Task model and enums  
├── Screens/    # UI screens for Add, View, Update, Delete, Main  
├── Services/   # Business logic + file storage  
├── Helpers/    # Input validation helpers  
└── Program.cs  # Entry point
```

---

## 🛠️ Technologies Used

- **C#** (.NET Console Application)  
- **File I/O** (System.IO)  
- **Object-Oriented Programming**  
- **Clean Code Architecture** (Models, Services, Screens)  

---

## 🚀 How to Run

1. **Clone the repository**:
   ```bash
   git clone https://github.com/Kenzy-Ragab/Task-Tracker.git
   ```

2. **Open in Visual Studio or VS Code**  
3. **Build and run the project**

---

## 📸 Preview

```
╔══════════════════════════════╗
║        TASK TRACKER          ║
╠══════════════════════════════╣
║ [1] Add New Task             ║
║ [2] View Tasks               ║
║ [3] Update Task              ║
║ [4] Delete Task              ║
║ [5] Exit                     ║
╚══════════════════════════════╝
```

---

## 🧠 What I Learned

- Designing object-oriented applications  
- Working with file-based data persistence  
- Handling user input in console environments  
- Writing clean, reusable, and modular C# code  

---

## 📂 Example Task Format (Saved in File)

```
1|Study|Complete DSA module|2025-07-22|High|Pending  
2|Exercise|Walk 30 minutes|2025-07-19|Medium|Completed
```

---

## 📌 Future Enhancements

- 🔍 Sort tasks by due date or priority  
- 📝 Add search by title  
- 📤 Export tasks to CSV  

---

## 🤍 General Task Outline in DevUnion (Student Activity)  

📎 [Task Outline (Notion)](https://saranabih.notion.site/Task-1-228f54958733801384e0e75fc019d30a) 
📸 [Archived Copy (Google Drive)](https://drive.google.com/drive/u/1/folders/1k_FCZdq7BiEfgG9NudXW5KhrW7mzKT3K)

Made with ❤️ by **Kenzy Ragab**  
Feel free to **fork**, **use**, or **contribute** to the project.
