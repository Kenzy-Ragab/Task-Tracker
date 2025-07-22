using System;
using TaskTracker.Models;
using TaskTracker.Services;
using TaskTracker.Screens;

namespace TaskTracker
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskService taskService = new TaskService();
            MainScreen.Show(taskService);
        }
    }

}



































//Task Tracker app
//-> Create,manage,track the tack 
/*
 * Add Tasks with details like 
 * (titile,decription, due date,priority)
 *
 * update tasks by changing status 
 * (pending, in progress, Completed)
 * 
 * View tasks in different categories such us
 * (active, overdue, completed)
 * 
 * delete tasks thet are no longer needed
 * 
 * exit the app safely with a confirmation prompt to prevent accidental closures.
 *
 * 
 */




/*
 Summary of make any Prof app (any part in class)
* 1. BluePrint(UI) -> [Menu, Parent UI]
* 2. Logic (Client/User) -> [Logic , Options]
* 3. Storging -> [DataLogic] .. writeinFile
* 4. Safty -> [Start {if Fail, if Pass} , Helper theStart,].. in case pass storging pass
*
 */


/*
 BreakDown in details! ::
 * 1. BluePrint(UI):
 * o. Parent -> easy
 * o. Menu:
 * [BluePrintUI {screen, switch}, Helper BluePrint, Options]  
 * 
 *
 */






/*
 *TaskTracker
│
├── Program.cs                      ← الدخول الرئيسي للتطبيق
│
├── Models/
│   └── TaskModel.cs               ← تعريف شكل الـ Task
│
├── Services/
│   └── TaskService.cs            ← كل العمليات: إضافة، تعديل، حذف، فلترة، جلب المهام
│
├── Screens/
│   ├── MainScreen.cs             ← المينيو الرئيسية
│   ├── ViewTasksScreen.cs        ← عرض المهام
│   ├── AddTaskScreen.cs          ← إضافة مهمة
│   ├── UpdateTaskScreen.cs       ← تحديث حالة مهمة
│   ├── DeleteTaskScreen.cs       ← حذف مهمة
│
└── Utilities/
    └── InputHelper.cs            ← قراءة الأرقام وتحقق من النطاقات

 *
 */


/*
 *TaskTracker/
│
├── Models/
│   └── Task.cs
│
├── Services/
│   ├── TaskService.cs
│   └── TaskStorageService.cs     ← ده مسؤول عن الحفظ والتحميل من الفايل
│
├── Screens/
│   ├── MainScreen.cs
│   ├── AddTaskScreen.cs
│   ├── ViewTaskScreen.cs
│   ├── UpdateTaskScreen.cs
│   └── DeleteTaskScreen.cs
│
├── Program.cs
└── Helpers/
    └── InputHelper.cs

 */