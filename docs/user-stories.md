# User Stories

This document contains technical stories for the 'crewtech-vehix-net-developer' REST api from the perspective of    

## TS001: Retrieve Greeting via GET request
**As a developer**, I want to retrieve a greeting message by providing optional first and last names, 
**I want to** retrieve a greeting message by providing optional first and last names,
**So that** I can test the API with both nammed and anonymous inputs.
### Acceptance Criteria
- **Scenario 1: Anonymous Greeting**
  - **Given** a dveloper has not proviedad any names,
  - **When** The developer requests a greeting via GET,
  - **Then** The developer receives a response with the message "Welcome Anonymous asp.NET Developer"
- **Scenario 2: Personalized Greeting**
  - **Given** a developer has provided a first name "John" and last name "Doe,
  - **When** The developer requests a greeting via GET,
  - **Then** The developer receives a response with the message "Congrats John Doe!  you are now a ASP.NET Developer"
- **Scenario 3: Partial Input**
  - **Given** a developer has provided only a first name "John",
  - **When** The developer requests a greeting via GET,
  - **Then** The developer receives a response with the message "Welcome Anonymous ASP.NET Developer"