﻿
 # 📷 ImageGalleryAppMVC
An ASP.NET Core MVC web application for uploading and displaying images in a gallery using SQL Server and Entity Framework Core.

## 🚀 Features
- Upload images via web form
- Store image metadata in a SQL Server database
- Save image files to wwwroot/images folder
- Display uploaded images in a gallery view

## 🛠️ Technologies Used
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap (optional, for UI styling)

## 📁 Project Structure
ImageGalleryAppMVC/
│
├── Controllers/
│ └── ImagesController.cs
│
├── Models/
│ └── Image.cs
│
├── Views/
│ └── Images/
│ ├── Index.cshtml
│ └── Upload.cshtml
│
├── wwwroot/
│ └── images/
│ └── (Uploaded image files)
│
├── appsettings.json
├── Startup.cs / Program.cs
└── README.md
