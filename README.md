# 🏪 Beauty Store Management System

[![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=flat-square&logo=dotnet)](https://dotnet.microsoft.com/)
[![C#](https://img.shields.io/badge/C%23-11.0-239120?style=flat-square&logo=c-sharp)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![WinForms](https://img.shields.io/badge/WinForms-UI-0078D4?style=flat-square&logo=windows)](https://docs.microsoft.com/en-us/dotnet/desktop/winforms/)
[![XML](https://img.shields.io/badge/Storage-XML-FF6600?style=flat-square&logo=xml)](https://www.w3.org/XML/)

Professional point-of-sale management system built with three-tier architecture and role-based user interfaces.

## 🏗️ Three-Tier Architecture

### 📊 Data Access Layer (DAL)
- **DalFacede/** - Interfaces and data objects
- **DalXml/** - XML implementation with serialization
- **DalList/** - In-memory list implementation

**Features:**
- Factory Pattern for dynamic DAL creation
- Repository Pattern for unified data access
- CRUD operations with XML persistence

### 🧠 Business Logic Layer (BL)
- **BlApi/** - Business interfaces
- **BlImplementation/** - Business logic implementation
- **BO/** - Business objects

**Features:**
- Automatic price calculation with sales
- Business validation and inventory management
- Order processing with final price calculation

### 🖥️ User Interface Layer (UI)
- **UI-Login/** - Authentication interface
- **UICashier/** - Cashier interface for order processing
- **UIManager/** - Manager interface for full system management

**Features:**
- Role-based interfaces (Cashier vs Manager)
- WinForms with intuitive user experience
- Real-time updates and error handling

## 🛍️ Product Management

The system handles various beauty and wellness products with comprehensive inventory tracking and sales management.

## 🎯 Core Entities

### 📦 Products
- Unique ID, name, category, price, and inventory quantity
- Active sales and promotions tracking

### 👥 Customers  
- Personal details and contact information
- Preferred customer status and purchase history

### 🎉 Sales
- Sale code, linked product, minimum quantity, and sale price
- Start/end dates with preferred customer restrictions

### 🛒 Orders
- Product list with quantities and automatic price calculation
- Preferred customer status integration

## 🚀 Getting Started

### System Requirements
- .NET 8.0 SDK or later
- Visual Studio 2022 (recommended)
- Windows OS (for WinForms support)

### Running the System

1. **Clone and Build**
   ```bash
   git clone https://github.com/ChayaZak/beauty-store-management-system
   cd DotNet2025_4371_5266
   dotnet build DotNet2025_4371_5266.sln
   ```

2. **Run Applications**
   ```bash
   
   dotnet run --project UI-Login
  
   ```

## 🔧 Project Structure

```
DotNet2025_4371_5266/
├── 📁 BL/                    # Business Logic Layer
├── 📁 DalFacede/            # Data Access Interfaces
├── 📁 DalXml/              # XML Implementation
├── 📁 DalList/             # List Implementation
├── 📁 UI-Login/            # Login Interface
├── 📁 UICashier/           # Cashier Interface
├── 📁 UIManager/           # Manager Interface
├── 📁 Tools/               # Utilities and Logging
└── 📁 xml/                 # Data Files
```

## 📊 Data Management

### XML Storage
- Portable data with easy backup and transfer
- Human-readable format for direct editing
- Lightweight without database server requirements
- Version control friendly

### Logging System
- Comprehensive operation logging with timestamps
- Automatic cleanup of old logs after two months
- Structured format for easy analysis

## 🛠️ Key Features

### Business Logic
- Smart pricing with automatic sales application
- Real-time inventory tracking
- Customer segmentation with preferred customer benefits
- Business rule validation

### User Interface
- Intuitive design with user-friendly navigation
- Role-based access (different interfaces for different users)
- Real-time updates and comprehensive error handling

## 🧪 Testing

- **DalTest** - Unit tests for data access layer
- **BlTest** - Business logic validation

## 🤝 Development Principles

The project demonstrates enterprise-level C# development practices:
- **SOLID Principles** - Clean, maintainable code architecture
- **Design Patterns** - Factory, Repository, and Facade patterns
- **Exception Handling** - Robust error management
- **Documentation** - Comprehensive code comments

## 📝 License

This project was developed as part of academic work, demonstrating professional software development practices in retail management.

---

**Built with ❤️ using .NET 8.0 and modern C# development practices**
