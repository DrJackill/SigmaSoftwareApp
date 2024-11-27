# File Upload App  
File Upload App is a web application developed using ASP.NET Core, .NET 8, and Angular.  

## Prerequisites  
Ensure you have the following installed:  
- [.NET 8 SDK]
- AngularCLI

## Installation  
1. **Clone the Repository**  
   ```bash  
   git clone <repository-url>  
   cd SigmaSoftwareApp
   ```
2. **Install Dependencies**
   For server:
   ```bash
   dotnet restore
   ```
   For client:
   ```bash
   npm install
   ```
3. **Run the Application**
   Start the API server:
   ```bash
   dotnet run  
   ```
   Start the client:
   ```bash
   npm run start  
   ```
   
## API Documentation
The API is documented with Swagger. After running the application, you can access the Swagger UI at:
```bash
http://localhost:<port>/swagger
```
It provides detailed information about the endpoints, request/response models, and example usage.

## Technologies Used
- **ASP.NET Core**: For building the API.
- **Angular**: For building client side part.
- **Swagger**: For interactive API documentation.
