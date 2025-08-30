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

## Getting Started

### Prerequisites
Make sure you have the following installed:
* .NET SDK (version 8.0 or later)
* SQL Server
* Docker (optional, for other database services)
* Visual Studio or Visual Studio Code

### Local Setup
1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/Jamil-20240100/FlowCast.git](https://github.com/Jamil-20240100/FlowCast.git)
    cd FlowCast
    ```
2.  **Configure the database:**
    * Update the connection string in `appsettings.json` or `appsettings.Development.json` to point to your SQL Server instance.
    * Apply the Entity Framework migrations:
    ```bash
    dotnet ef database update
    ```
3.  **Run the application:**
    ```bash
    dotnet run --project [your-web-project-name]
    ```
    The application will be accessible at `https://localhost:[port]`.

---

## API Documentation
The project's RESTful API is fully documented using Swagger. Once the application is running, you can access the Swagger UI to view and test all the available endpoints at:
`https://localhost:[port]/swagger`

---

## Contributions
Contributions are highly encouraged! If you want to contribute, please feel free to fork this repository, create a new feature branch (`git checkout -b feature/your-awesome-feature`), and submit a pull request with your changes.

## License
This project is licensed under the MIT License.
