# C-TDD-and-Moq

This project is a **Test-Driven Development (TDD)** exercise built in **C#** using the **Moq** framework and **NUnit** for unit testing. It models a trainee group evaluation system, separating concerns across interfaces and implementations while emphasizing unit test coverage and mocking.

---

## 🧰 Technologies Used

- **Language**: C#
- **Framework**: .NET
- **Testing**: NUnit
- **Mocking**: Moq
- **Design**: Interface-driven architecture
- **IDE**: Visual Studio

---

## ✨ Features

- TDD-compliant structure: tests are written first to drive implementation
- Interface-based design for loose coupling and testability
- Business logic to evaluate trainee performance and group calculations
- Full unit test coverage for key components using NUnit and Moq

---

## 📁 Solution Structure

```
TddAssessmentRenePerida.sln         # Visual Studio solution file

├── SourceCodeTests                 # Additional test project
│   ├── GradeCalculatorTests.cs
│   └── SourceCodeTests.csproj

├── TddAssessmentRenePerida         # Core project with business logic
│   ├── DatabaseReader.cs
│   ├── GradeCalculator.cs
│   ├── GroupController.cs
│   ├── IDatabaseReader.cs
│   ├── IDatabaseWriter.cs
│   ├── IGradeCalculator.cs
│   ├── IGroupController.cs
│   ├── ITrainee.cs
│   ├── Program.cs
│   ├── SourceCode.csproj
│   └── Trainee.cs

├── UnitTests                       # NUnit/Moq Unit Testing Project
│   ├── GradeCalculatorTest.cs
│   ├── GroupControllerTest.cs
│   └── UnitTests.csproj

├── .gitignore
├── .gitattributes
└── README.md
```

---

## 🚀 How to Run

1. Open the solution in Visual Studio (`TddAssessmentRenePerida.sln`)
2. Set the appropriate project as the startup project (`TddAssessmentRenePerida`)
3. Run the application (`Program.cs`) or run the test suite

---

## 🧪 How to Test

You can run tests using:
- Visual Studio Test Explorer
- Or via CLI:  
  ```bash
  dotnet test UnitTests/UnitTests.csproj

