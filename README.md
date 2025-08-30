# FlowCast: Financial Assets Trend Predictor

## Project Description
**FlowCast** is a financial asset trend predictor application designed to analyze historical data of stocks and cryptocurrencies to forecast future price trends. The system allows users to input data and receive trend predictions based on specific technical analysis modes, facilitating informed decision-making for financial management.

## Key Features
* **Data Input**: Users can input historical asset prices, including their most recent and oldest values.
* **Prediction Modes**: The system offers specific prediction modes, such as the Rate of Change (ROC) calculation over a fixed period (e.g., 5 days).
* **Trend Analysis**: The application analyzes price changes over a specified period to determine the acceleration of price shifts.
* **User Interface**: A clear and intuitive interface for data input and viewing predictions.
* **Scalable Architecture**: Built on a modern, scalable architecture to handle complex financial calculations.

---

## Technologies Used
* **Backend**: C# and **ASP.NET Core** (ASP.NET Core MVC)
* **Databases**: SQL Server, MongoDB
* **ORM**: **Entity Framework (Code First)**
* **Architecture**: **ONION Architecture**, **CQRS** (Command and Query Responsibility Segregation), and **Mediator**
* **Authentication**: JWT (JSON Web Tokens)
* **Validation**: FluentValidation
* **API Documentation**: Swagger
* **Testing**: xUnit for unit and integration testing
* **Front-end**: HTML, CSS, JavaScript, Bootstrap
* **DevOps**: Docker, Git, GitHub Actions

---

## Project Structure
The project follows a modular **ONION Architecture**, ensuring a clean separation of concerns and maintainability. The core layers are:
* **Domain**: Contains the business logic and core entities.
* **Application**: Manages commands and queries, implementing the CQRS pattern to separate read and write operations.
* **Infrastructure**: Handles data persistence with Entity Framework Code First and integrates external services.
* **Presentation (Web)**: The API layer that exposes endpoints for the front-end and other clients, documented with Swagger.

---
