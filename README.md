# Subscription Manager

##  Description
Subscription Manager is a full-stack application that allows users to track and manage their subscriptions (such as Netflix, Spotify, etc.).

The app helps users understand their monthly expenses and keep control over active services.

---

## Tech Stack
- Backend: .NET Web API
- Frontend: Angular
- Architecture: REST API

---

## Features
- Create a new subscription
- View all subscriptions
- Track monthly cost
- Manage payment methods
- Active/inactive subscription status

---

## Project Structure
subscription-manager/
│
├── SubscriptionManagerApi   → Backend (.NET)
└── subscription-manager-ui → Frontend (Angular)

---

## How to Run

### Backend
```bash
cd SubscriptionManagerApi
dotnet run
``` 
### Frontend
cd subscription-manager-ui
ng serve

Then open:
http://localhost:4200

## Future Improvements
- Add authentication (JWT)
- Connect to a real database (SQL Server)
- Add edit/delete functionality
- Dashboard with total monthly cost
- Notifications for upcoming payments

## Author
María Paz Ibarra