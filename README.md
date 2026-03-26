# 🍕 Blazing Pizza - Blazor Learning Application

A comprehensive Blazor Server application demonstrating modern web development techniques with C# and .NET. This project showcases a complete pizza ordering system with advanced routing, layouts, data management, and interactive components.

## 🌟 Features

### 🗺️ **Complete Navigation & Routing System**
- **Route Parameters**: Order tracking with `/myorders/{orderId:int}` constraints
- **Optional Parameters**: Favorite pizza routes with `{favorite?}` syntax
- **Route Constraints**: Type safety with int, bool, datetime, decimal, double, guid constraints
- **Catch-all Parameters**: Flexible URL handling with `{*favorites}` patterns
- **NavLink Components**: Professional navigation with active state management

### 🏗️ **Modern Layout Architecture**
- **MainLayout Component**: Centralized navigation and branding
- **Layout Inheritance**: `@inherits LayoutComponentBase` with `@Body` directive
- **Consistent Theming**: Unified design across all pages
- **Responsive Design**: Mobile-friendly interface

### 💰 **Localized Currency System**
- **US Dollar Formatting**: Complete USD currency implementation
- **Cultural Awareness**: `en-US` culture settings throughout
- **Consistent Pricing**: Standardized currency display across all components

### 🍕 **Pizza Ordering System**
- **Interactive Menu**: Dynamic pizza selection with real-time pricing
- **Order Management**: Complete checkout and order tracking workflow
- **State Management**: Scoped services for cart and order state
- **Order History**: View and track previous orders

### 🗄️ **Data Management**
- **Entity Framework Core**: SQLite database integration
- **RESTful APIs**: MVC controllers for data access
- **Async Operations**: Proper async/await patterns
- **Seed Data**: Pre-populated pizza specials

### ⚡ **Interactive Components**
- **Modal Dialogs**: Pizza configuration with size selection
- **Real-time Updates**: Dynamic pricing and cart management
- **Form Validation**: Data binding and validation patterns
- **Component Communication**: Parent-child parameter passing

## 🚀 **Getting Started**

### Prerequisites
- .NET 10.0 or later
- Visual Studio Code or Visual Studio 2022
- Git

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/warmace101/blazorPizza.git
   cd blazorPizza
   ```

2. **Restore packages**
   ```bash
   dotnet restore
   ```

3. **Build the application**
   ```bash
   dotnet build
   ```

4. **Run the application**
   ```bash
   dotnet run
   ```

5. **Access the application**
   - HTTPS: `https://localhost:7189`
   - HTTP: `http://localhost:5050`

## 📁 **Project Structure**

```
MvcMovie/
├── Components/
│   ├── Layout/                    # Layout components
│   │   ├── MainLayout.razor      # Main application layout
│   │   └── NavMenu.razor         # Navigation sidebar
│   ├── Pages/                     # Page components
│   │   ├── Home.razor            # Pizza menu
│   │   ├── Checkout.razor        # Order checkout
│   │   ├── MyOrders.razor        # Order history
│   │   ├── OrderDetail.razor     # Individual order tracking
│   │   └── DatabaseDemo.razor    # EF Core demonstration
│   └── Shared/                    # Reusable components
│       └── ConfigurePizzaDialog.razor
├── Controllers/                   # API Controllers
│   └── OrdersController.cs       # Order management API
├── Data/                         # Entity Framework models
│   ├── PizzaStoreContext.cs     # Database context
│   └── Models/                   # Data models
└── Services/                     # Application services
    └── OrderState.cs             # Order state management
```

## 🛠️ **Technologies Used**

- **Framework**: .NET 10.0 with Blazor Server
- **Database**: Entity Framework Core with SQLite
- **UI Framework**: Bootstrap 5
- **State Management**: Scoped services
- **API**: ASP.NET Core MVC Controllers
- **Styling**: CSS3 with responsive design

## 🎯 **Learning Objectives Demonstrated**

This project covers comprehensive Blazor development concepts:

1. **Component Architecture**: Reusable components and layout systems
2. **Routing & Navigation**: Advanced routing with parameters and constraints
3. **Data Binding**: Two-way binding and event handling
4. **State Management**: Application-wide state with scoped services
5. **API Integration**: RESTful APIs with Entity Framework
6. **Form Handling**: Data validation and submission patterns
7. **Responsive Design**: Mobile-first UI development
8. **Localization**: Currency and cultural formatting

## 👤 **Author**

**Johnathan Babb** - United States

Created as part of comprehensive Blazor learning curriculum, demonstrating modern web development practices with C# and .NET.

## 📝 **License**

This project is for educational purposes and learning demonstration.

## 🔗 **Live Demo**

Visit the application at your local development environment:
- Primary: `https://localhost:7189`
- Secondary: `http://localhost:5050`

---

*Built with ❤️ using Blazor Server and .NET 10.0*