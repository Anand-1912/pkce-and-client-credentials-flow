## App Registrations

### app-resource-api-pkci-cc-001

This App registration represents the `Resource api` which defines the following Scope and App Role.

`Scope:` access_as_admin
`App Role:` RatesConsumer

### app-delegated-client-swagger-pkci-cc-001 

This App registration represents the swagger client which uses `PKCI - Auth Code - User delegation` flow.

`Redirect Uri:` 

Platform type: SPA
 
  - http://localhost:5122/swagger/oauth2-redirect.html
  - https://localhost:7206/swagger/oauth2-redirect.html

API Permissions

  - Add `Delegated Permissions` to the Scope `access_as_Admin`

### app-confidential-client-pkci-cc-001 

This App registration represents the Confidential Client which uses `Client Credentials (App to App Authentication)` flow.

No `Redirect Uri` is required.

API Permissions
 
  - Add `Application Permissions` to the Role `RatesConsumer`