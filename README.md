# Full-Stack Authentication System with .NET 9 and React

![Project Logo](https://img.shields.io/badge/Version-1.0.0-brightgreen.svg) ![License](https://img.shields.io/badge/License-MIT-blue.svg) ![Build Status](https://img.shields.io/badge/Build-Passing-brightgreen.svg)

## Overview

Welcome to the **dotnet-auth-react-sample** repository. This project demonstrates a complete authentication system using a .NET 9 Web API for the backend and a React TypeScript frontend. It provides a solid foundation for building secure web applications.

## Table of Contents

- [Features](#features)
- [Technologies](#technologies)
- [Installation](#installation)
- [Usage](#usage)
- [API Documentation](#api-documentation)
- [Contributing](#contributing)
- [License](#license)
- [Releases](#releases)

## Features

- User registration and login
- JWT authentication
- Role-based access control
- Secure password storage
- User profile management
- Responsive design with React
- State management using Redux
- API documentation with Swagger

## Technologies

This project utilizes a variety of technologies to create a seamless experience:

- **Backend**: 
  - .NET 9 Web API
  - C#
  - PostgreSQL

- **Frontend**:
  - React
  - TypeScript
  - React Router
  - Redux
  - Redux Toolkit

## Installation

To get started with this project, follow these steps:

1. **Clone the repository**:
   ```bash
   git clone https://github.com/josuekama/dotnet-auth-react-sample.git
   cd dotnet-auth-react-sample
   ```

2. **Set up the backend**:
   - Navigate to the backend folder.
   - Restore the NuGet packages:
     ```bash
     dotnet restore
     ```
   - Set up your PostgreSQL database.
   - Update the connection string in the `appsettings.json` file.
   - Run the database migrations:
     ```bash
     dotnet ef database update
     ```
   - Start the backend server:
     ```bash
     dotnet run
     ```

3. **Set up the frontend**:
   - Navigate to the frontend folder.
   - Install the necessary packages:
     ```bash
     npm install
     ```
   - Start the frontend server:
     ```bash
     npm start
     ```

## Usage

After setting up both the backend and frontend, you can access the application in your browser at `http://localhost:3000`. You can register a new user, log in, and explore the features provided.

### API Endpoints

Here are some key API endpoints available in this project:

- **POST** `/api/auth/register` - Register a new user
- **POST** `/api/auth/login` - Log in a user
- **GET** `/api/user/profile` - Get user profile information
- **PUT** `/api/user/profile` - Update user profile information

You can find more details about these endpoints in the [API Documentation](#api-documentation).

## API Documentation

This project includes Swagger for API documentation. Once the backend is running, you can access the Swagger UI at `http://localhost:5000/swagger`. This interface allows you to explore the available endpoints and test them directly.

## Contributing

We welcome contributions to this project. If you would like to contribute, please follow these steps:

1. Fork the repository.
2. Create a new branch:
   ```bash
   git checkout -b feature/YourFeature
   ```
3. Make your changes and commit them:
   ```bash
   git commit -m "Add your message"
   ```
4. Push to your branch:
   ```bash
   git push origin feature/YourFeature
   ```
5. Create a pull request.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Releases

To download the latest release, visit the [Releases](https://github.com/josuekama/dotnet-auth-react-sample/releases) section. Follow the instructions provided there to execute the files.

![Download Releases](https://img.shields.io/badge/Download%20Latest%20Release-Click%20Here-blue.svg)

For more information about the releases, check the [Releases](https://github.com/josuekama/dotnet-auth-react-sample/releases) section.

## Topics

This project covers various topics, including:

- API
- Authentication
- Backend Development
- Boilerplate Code
- C#
- .NET
- .NET Core
- PostgreSQL
- Frontend Development
- React
- React Router
- Redux
- Redux Toolkit
- SQL
- Swagger
- Web Development

## Screenshots

Here are some screenshots of the application:

### Login Page

![Login Page](https://via.placeholder.com/800x400?text=Login+Page)

### Registration Page

![Registration Page](https://via.placeholder.com/800x400?text=Registration+Page)

### User Profile

![User Profile](https://via.placeholder.com/800x400?text=User+Profile)

## Contact

For any inquiries or feedback, please reach out via the issues section of this repository. 

## Acknowledgments

Thanks to all contributors and libraries that made this project possible. Your efforts are greatly appreciated.

## Support

If you encounter any issues, please check the [Releases](https://github.com/josuekama/dotnet-auth-react-sample/releases) section for updates or fixes.