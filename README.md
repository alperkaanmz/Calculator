# Calculator Application

## Overview

The Calculator Application is a simple Windows Form application developed for an internship project. It demonstrates the implementation of a layered architecture and integrates Docker for database management.

## Features

- Perform basic arithmetic operations: addition, subtraction, multiplication, and division.
- Intuitive Windows Form interface for user interaction.
- Comprehensive error handling to prevent invalid inputs.
- Utilizes layered architecture for modular code organization.
- Docker integration for efficient database management.

## Architecture

The application follows a structured layered architecture:

### Presentation Layer

Responsible for the user interface and interaction.

### Business Logic Layer

Implements the core calculator functionalities.

### Data Access Layer

Handles database interactions through Docker.

### Database Layer (Docker)

Manages the application's database in a containerized environment.

## Getting Started

To run the Calculator Application locally:

1. Clone the repository: `git clone https://github.com/alperkaanmz/calculator.git`
2. Navigate to the project directory: `cd calculator`
3. Open the solution file in your preferred C# development environment.
4. Build the solution to install dependencies and compile the application.
5. Run the application and start performing calculations.

For Docker setup:

1. Install Docker on your system.
2. Go to the `database` directory.
3. Build the Docker image: `docker build -t calculator-db .`
4. Run the Docker container: `docker run -d -p 1433:1433 --name calculator-db-container calculator-db`

Remember to configure the database connection string in the application's configuration files.

## Usage

1. Launch the Calculator Application.
2. Input two numbers.
3. Choose an arithmetic operation.
4. Click "Calculate" to view the result.

