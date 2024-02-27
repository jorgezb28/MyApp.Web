# MyApp.UI

User Story

As a developer, I aim to develop a web application tailored for a gym, 
enabling me to efficiently manage client-related information.

Acceptance Criteria:

1. The application should feature dedicated tabs for "Members" and "Membership Plans," 
displaying essential details for each:

Members:
Name
Phone Number
Join Date
Membership Plan

Membership Plans:
Name
Description
Price

2. The application must support CRUD functionalities, allowing seamless modification of both member and membership plan data.
3. A Web API should be integrated into the application to facilitate CRUD operations.
4. Implementation of a separate Web API is necessary to manage user authorization and login processes effectively.
5. The application is required to include a dedicated unit test project to ensure reliability in its functionality.

Tech Details

1. The application should use Clean Architecture.
2. Models must be implemented to map Database Objects (DTO).
3. The "Database Engine" is a Parser for reading and writing Json files which will representate our database.
4. Repository Pattern must be implemented.
5. UnitTest should be implemented for core logic (Domain, Service) using XUnit, Moq, AutoFixture and FluentAssertion.
6. The endpoints should return DTO (Automapper must be implemented).
7. In APIs endpoint should implement [Authorize] attributes to provide User Authorization.
8. The APIs should be testable from Swagger
9. A Middleware must be implemented to handle unexpected errors in the APIs so it can send proper response to UI.
10. OPTIONAL Keep application the most configurable as possible (Settings, KeyVault, Secrets, etc).
