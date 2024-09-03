**Why PKCE Flow is Used:**

PKCE (Proof Key for Code Exchange) is used primarily in OAuth 2.0 to enhance the security of the authorization code grant flow, especially for public clients (like mobile or single-page apps) that cannot securely store client secrets. PKCE helps prevent certain attacks, such as the authorization code interception attack, by adding an additional layer of security.

**The PKCE Flow:**

1. **Client Initialization:**
   - The client (e.g., a mobile app) generates a random string known as the `code_verifier`.
   - The client then creates a `code_challenge` by applying a hashing function (usually SHA-256) to the `code_verifier` and base64 URL-encoding the result. Alternatively, the `code_verifier` itself can be used as the `code_challenge` in a simpler mode called "plain."

2. **Authorization Request:**
   - The client redirects the user to the authorization server (e.g., Google, GitHub) with the following parameters:
     - `response_type=code`: Indicates that the client is requesting an authorization code.
     - `client_id`: The client’s ID.
     - `redirect_uri`: The URI to which the authorization server will send the user after authorization.
     - `code_challenge`: The generated `code_challenge`.
     - `code_challenge_method`: The method used to create the challenge, typically `S256` for SHA-256.

3. **User Authorization:**
   - The user logs in and grants permission to the client. The authorization server validates the request and, if successful, generates an authorization code and redirects the user to the specified `redirect_uri`.

4. **Token Request:**
   - The client sends a POST request to the authorization server's token endpoint with the following:
     - `grant_type=authorization_code`: Indicates that the client is exchanging the authorization code for a token.
     - `code`: The authorization code received.
     - `redirect_uri`: Must match the original `redirect_uri` from the authorization request.
     - `client_id`: The client’s ID.
     - `code_verifier`: The original random string generated in the first step.

5. **Token Response:**
   - The authorization server validates the `code_verifier` by applying the same hashing function and comparing the result with the original `code_challenge` sent during the authorization request. If they match, the server issues an access token (and optionally a refresh token) to the client.

**Benefits of PKCE:**

- **Mitigation of Authorization Code Interception:** Even if an attacker intercepts the authorization code, they cannot exchange it for an access token without the correct `code_verifier`.
- **No Client Secret Required:** Public clients don’t need to store or send a client secret, which is especially useful for apps that cannot securely store secrets.
- **Enhanced Security for Public Clients:** It provides a secure way for public clients to perform the authorization code flow without being vulnerable to attacks that would be mitigated by the use of a client secret in confidential clients.


Packages Used
----

1. Microsoft.AspNetCore.Authentication.JwtBearer;
2. Microsoft.Identity.Web;

