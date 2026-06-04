# Order Status Tracker - Setup Guide

## Project Overview

Order Status Tracker is a full-stack application built using:

### Backend

* ASP.NET Core Web API
* C#
* Repository Pattern
* Service Layer
* Dependency Injection
* In-Memory Data Store

### Frontend

* React
* Axios
* React Router
* Functional Components
* React Hooks

---

# Backend Setup (ASP.NET Core Web API)

## Step 1: Create Solution

Open Visual Studio.

Create a new project:

Create Project → ASP.NET Core Web API

Project Name:

OrderTracker.API

Create Solution:

OrderTracker

---

## Step 2: Add Class Library Projects

Right Click Solution

Add → New Project

Create following Class Libraries:

OrderTracker.Business

OrderTracker.Repository

OrderTracker.Model

---

## Step 3: Add Project References

OrderTracker.API

Reference:

* OrderTracker.Business
* OrderTracker.Model

OrderTracker.Business

Reference:

* OrderTracker.Repository
* OrderTracker.Model

OrderTracker.Repository

Reference:

* OrderTracker.Model

---

## Step 4: Create Backend Folder Structure

### OrderTracker.API

Controllers

Middleware

Program.cs

appsettings.json

### OrderTracker.Business

Interfaces

Services

### OrderTracker.Repository

Interfaces

Implementations

Data

### OrderTracker.Model

Entities

DTO

Enums

Exceptions

---

## Step 5: Run Backend

Build Solution

Run Project

Swagger should open automatically.

Example:

https://localhost:7188/swagger

---

# Frontend Setup (React)

## Step 1: Create React Project

Open Terminal

Run:

npm create vite@latest order-tracker-ui -- --template react

Navigate to project:

cd order-tracker-ui

Install packages:

npm install

---

## Step 2: Install Required Packages

Axios:

npm install axios

React Router:

npm install react-router-dom

Optional UI Library:

npm install @mui/material @emotion/react @emotion/styled

Icons:

npm install @mui/icons-material

---

## Step 3: Frontend Folder Structure

src

api

services

components

pages

routes

assets

App.jsx

main.jsx

---

## Step 4: Create Components

Components:

* OrderTable
* StatusFilter
* ErrorMessage

Pages:

* OrderPage

Services:

* order-service

API:

* axios-instance

Routes:

* app-routes

---

## Step 5: Configure API Base URL

Backend URL:

https://localhost:7188

Configure Axios Base URL to connect React application with ASP.NET Core API.

---

## Step 6: Run React Application

Install dependencies:

npm install

Start application:

npm run dev

Application URL:

http://localhost:5173

---

# Features Implemented

## Order Listing

* View Orders
* Pagination Support
* Status Filtering

## Order Management

* Ship Order
* Deliver Order
* Cancel Order

## Validation Rules

Allowed:

Pending → Shipped

Shipped → Delivered

Pending → Cancelled

Shipped → Cancelled

Rejected:

Pending → Delivered

Delivered → Pending

Cancelled → Pending

Cancelled → Shipped

---

# Error Handling

Backend:

* 400 Bad Request
* 404 Not Found
* Custom Business Exceptions

Frontend:

* API Error Handling
* Validation Messages
* Loading Indicators

---

# Run Complete Application

Step 1

Start ASP.NET Core API

dotnet run

Step 2

Start React Application

npm run dev

Step 3

Open Browser

Frontend:

http://localhost:5173

Backend Swagger:

https://localhost:7188/swagger

---

# Future Enhancements

* SQL Server Integration
* Entity Framework Core
* Authentication & Authorization
* Unit Testing
* Docker Support
* CI/CD Pipeline
* Azure Deployment
* Role-Based Access Control
