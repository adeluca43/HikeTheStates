HiketheStates is a full-stack web application designed to help hikers log their trail adventures, track personal progress, and discover trails based on preferences like difficulty level, dog-friendliness, and amenities.

Problem
Hikers often lack a centralized, easy-to-use platform to:
Log hikes and track their outdoor activity history
Discover trails tailored to their preferences (e.g., kid-friendly, restrooms, paved)
View insights about trail difficulty and popularity
Share trail experiences with others

Solution
This app provides:
A user-friendly interface for logging hikes
Difficulty and feature-based filtering
A system for liking hikes and tracking achievements
Star rewards every 5 hikes


Tech Stack
Frontend
React
React Router DOM
Reactstrap
Bootstrap
Vite

Backend
ASP.NET Core Web API
Entity Framework Core
PostgreSQL

Installation & Setup
Clone the repository

bash
Copy
Edit
git clone https://github.com/your-username/hiking-app.git
cd hiking-app
Install frontend dependencies

bash
Copy
Edit
cd client
npm install
Run frontend

bash
Copy
Edit
npm run dev
Run backend

Navigate to your server/ folder

Run:

bash
Copy
Edit
dotnet restore
dotnet ef database update
dotnet run
Features
Register, login, and create hikes

Log title, description, location, distance, and trail features

Filter hikes by difficulty and accessibility features

Track personal hike history and average difficulty

Earn a star for every 5 hikes logged

Like hikes submitted by others

