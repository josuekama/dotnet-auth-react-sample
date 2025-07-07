# Authentication System

A full-stack authentication system built with .NET 9 Web API and React TypeScript frontend.

## Features

- **User Registration & Login**: Secure user authentication with JWT tokens
- **Password Hashing**: BCrypt password hashing for security
- **JWT Authentication**: Token-based authentication with configurable expiration
- **Protected Routes**: Frontend route protection based on authentication status
- **Modern UI**: React with TypeScript and Redux Toolkit for state management
- **Database Integration**: PostgreSQL with Entity Framework Core
- **API Documentation**: Swagger/OpenAPI documentation

## Tech Stack

### Backend (Auth.API)
- **.NET 9** - Web API framework
- **Entity Framework Core** - ORM for database operations
- **PostgreSQL** - Database
- **JWT Bearer Authentication** - Token-based authentication
- **BCrypt.Net** - Password hashing
- **Swagger** - API documentation

### Frontend (Auth.Web)
- **React 19** - Frontend framework
- **TypeScript** - Type safety
- **Redux Toolkit** - State management
- **RTK Query** - API state management
- **React Router** - Client-side routing
- **Vite** - Build tool and dev server

## Project Structure

```
├── Auth.API/                 # .NET Web API Backend
│   ├── Controllers/          # API controllers
│   ├── DTOs/                # Data transfer objects
│   ├── Entities/            # Database entities
│   ├── Services/            # Business logic services
│   ├── Data/                # Database context
│   └── Program.cs           # Application entry point
├── Auth.Web/                # React Frontend
│   ├── src/
│   │   ├── components/      # React components
│   │   ├── pages/           # Page components
│   │   ├── services/        # API services
│   │   └── app/             # Redux store
│   └── package.json
└── README.md
```

## Prerequisites

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Node.js](https://nodejs.org/) (v18 or higher)
- [PostgreSQL](https://www.postgresql.org/) (v12 or higher)

## Getting Started

### Database Setup

1. Install PostgreSQL and create a database
2. Update the connection string in `Auth.API/appsettings.json`:
   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Host=localhost;Port=5432;Database=your_db;Username=your_user;Password=your_password"
     }
   }
   ```

### Backend Setup

1. Navigate to the API directory:
   ```bash
   cd Auth.API
   ```

2. Restore dependencies:
   ```bash
   dotnet restore
   ```

3. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

4. Run the API:
   ```bash
   dotnet run
   ```

The API will be available at `http://localhost:5057`

### Frontend Setup

1. Navigate to the web directory:
   ```bash
   cd Auth.Web
   ```

2. Install dependencies:
   ```bash
   npm install
   ```

3. Create environment file:
   ```bash
   cp .env.example .env
   ```

4. Update the `.env` file with your API URL:
   ```env
   VITE_API_URL=http://localhost:5057
   ```

5. Start the development server:
   ```bash
   npm run dev
   ```

The frontend will be available at `http://localhost:5173`

## API Endpoints

### Authentication
- `POST /api/auth/login` - User login
- `POST /api/auth/register` - User registration

### User Management
- `GET /api/users/me` - Get current user profile (protected)

## Configuration

### JWT Settings
Configure JWT settings in `Auth.API/appsettings.json`:
```json
{
  "Jwt": {
    "Key": "your-secret-key-here",
    "Issuer": "your-issuer",
    "Audience": "your-audience"
  }
}
```

### CORS Configuration
The API is configured to allow requests from `http://localhost:5173`. Update the CORS policy in `Program.cs` if needed.

## Development

### Running Tests
```bash
# Backend tests
cd Auth.API
dotnet test

# Frontend tests
cd Auth.Web
npm test
```

### Building for Production
```bash
# Backend
cd Auth.API
dotnet publish -c Release

# Frontend
cd Auth.Web
npm run build
```

## Security Features

- **Password Hashing**: Uses BCrypt with salt for secure password storage
- **JWT Tokens**: Secure token-based authentication with configurable expiration
- **Input Validation**: Server-side validation for all endpoints
- **CORS Protection**: Configured CORS policy for frontend access
- **HTTPS**: HTTPS redirection enabled in production

## API Documentation

When running in development mode, Swagger documentation is available at:
- `http://localhost:5057/swagger`

## Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add some amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## Support

If you encounter any issues or have questions, please open an issue on the GitHub repository.