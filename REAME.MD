# HandsOn - Project Setup

This project uses **.NET 9** for the back-end and **Angular with Nx** for the front-end. Below are the detailed instructions to set up and run the development environment.

---

## 📌 Requirements

Before starting, install the following dependencies on your system:

### 🚀 Front-End

- [Node.js 20+](https://nodejs.org/en/download) (**Tested with: v22.14.0**)
- [Nx CLI](https://nx.dev/) (Install globally):
  ```sh
  npm add --global nx@latest
  ```

### 🛠️ Back-End

- [.NET 9](https://dotnet.microsoft.com/en-us/download)
- [Entity Framework Core](https://learn.microsoft.com/en-us/ef/core/get-started/overview/install) - Install globally after .NET:
  ```sh
  dotnet tool install --global dotnet-ef
  ```
- [MySQL](https://dev.mysql.com/downloads/installer/)
- A SQL database management tool, such as:
  - [DBeaver](https://dbeaver.io/)
  - [HeidiSQL](https://www.heidisql.com/)
  - [MySQL Workbench](https://www.mysql.com/products/workbench/)

### 🛠️ Auxiliary Tools

- [Git](https://git-scm.com/downloads)
- [Visual Studio Code (VSCode)](https://code.visualstudio.com/download)
  - Recommended extensions:
    - [.NET Extension Pack](https://marketplace.visualstudio.com/items?itemName=ms-dotnettools.vscode-dotnet-pack)
    - [Nx Console](https://marketplace.visualstudio.com/items?itemName=nrwl.angular-console)
    - [Prettier - Code Formatter](https://marketplace.visualstudio.com/items?itemName=esbenp.prettier-vscode)
    - [ESLint](https://marketplace.visualstudio.com/items?itemName=dbaeumer.vscode-eslint)

---

# ⚙️ How to Run the Project

After installing all the requirements, follow the instructions to run the back-end and front-end.

## 🏠 Back-End

### 1 - Configure Environment Variables

- Navigate to the back-end root folder:
  ```sh
  cd HandsOn-Back
  ```
- Open the configuration file:
  ```
  HandsOn-Back/src/API/appsettings.json
  ```
- Edit the database connection details to match your MySQL credentials:
  ```json
  "ConnectionStrings": {
    "DefaultConnection": "server=YOUR_SERVER;port=YOUR_SERVER_PORT;database=YOUR_DATABASE;user=YOUR_USER;password=YOUR_PASSWORD"
  }
  ```
- **Tip:** You can create a `appsettings.Development.json` file to avoid modifying the original file.

### 2 - Restore Dependencies

Run the following command to download the required packages:

```sh
  dotnet restore
```

### 3 - Create the Database and Apply Migrations

- If the database does not exist, create it in MySQL.
- Apply Entity Framework migrations:
  ```sh
  dotnet ef database update --verbose --project "src/Infrastructure" --startup-project "src/API" --context UsersDbContext
  ```
- To create new migrations, use:
  ```sh
   dotnet ef migrations add "migration_name" --verbose --project "src/Infrastructure" --startup-project "src/API" --context UsersDbContext -o Persistence/Migrations
  ```

### 4 - Run the API

- **Via Terminal:**
  ```sh
  dotnet run --project "./src/API/API.csproj"
  ```
- **Or using VS Code:**
  - Open the project in VS Code.
  - Ensure the **startup project** is set to:
    ```
    ./src/API/API.csproj
    ```
  - Use the **debugger** to start the application.

👉 The API will be available at: `http://localhost:5143`

### 📏 Accessing Swagger

After starting the API, you can access the Swagger documentation in your browser at:

🔗 **http://localhost:5143**

Swagger allows you to test endpoints and view API documentation interactively.

---

## 🎨 Front-End

### 1 - Configure Environment Variables

- Navigate to the front-end root folder:
  ```sh
  cd HandsOn
  ```
- Locate the environment file:
  ```
  HandsOn/src/app/environments/environment.prod.ts
  ```
- Copy and rename it to `environment.ts`:
  ```sh
  cp HandsOn/src/app/environments/environment.prod.ts HandsOn/src/app/environments/environment.ts
  ```
- Edit the `environment.ts` file and update the API URL to point to the back-end:

  ```ts
  export const environment = {
    production: false,

    clientId: "",
    redirectUri: "",

    jwtToken: "jwt_token",
    allowedDomains: ["http://localhost:5143"],

    authApiUrl: "http://localhost:5143/api/users",
    usersApiUrl: "http://localhost:5143/api/users",
  };
  ```

### 2 - Install Dependencies

Run the following command in the front-end root directory to install the required packages:

```sh
npm install
```

### 3 - Run the Front-End

Start the Angular server:

```sh
npm run start
```

👉 The front-end will be available at: `http://localhost:4200/`.
