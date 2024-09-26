User :

SIGNUP
http://localhost:5261/Api/User/Signup

SIGN IN
http://localhost:5261/Api/User/Login



Product :

ADD
http://localhost:5261/Api/Product/Add_Product

UPDATE
http://localhost:5261/Api/Product/UpdateProduct

DELETE
http://localhost:5261/Api/Product/DeleteProduct

SHOW PRODUCTS
http://localhost:5261/Api/Product/GetProducts

Project Guidelines :
 1. Routing is a mechanism to convert component into URL known as route.
 2. Then we can apply route-navigation to navigate from one route to another route.
 3. This shows that we don't need single page application(DOM).
 4.Routes is a class in angular to make a route table available in router module package. 


 Agenda :
 1. Design the application in angular to communicate with service, so that we can able to save records in backend.
 2. In last session, we have seen HTTPCLIENT class plays a major role to communicate with service.
 3. HTTPCLIENT is a injectable class to support DI(no need to allocate the memory of HTTPCLIENT).
 4. We need to pass class name in constructor parameter to achieve dependency injection.
 5. Angular runs in browser and services runs on server side, so we need to apply security policy otherwise Front-end like react, Angular cannot communicate with service.
 6. CORS(Cross Origin Resource Sharing) needs to unable in Core WebApi, then Front-end like react, angular can communicate.
 
 Important Questions :
  Q.1 Can you write the syntax to enable the CORS in Core Web  Api?
  Q.2 Please explain the complete steps how Front-end like angular communicate with service.
  Q.3 How to deploy the full stack application on cloud(Azure).

  Finally, we are moving end of full stack.
  1. Agenda
  a. we have to take a data from angular and providing to end point written in core web Api with the help of HttpClient.
  b. Angular runs in browser whereas CoreWebApi runs on Server so we need to define the policy for cross application.
  c. We need to include CORS in program.cs file to define the policy then frontend like angular can communicate with service.

  builder.Services.AddCors(options =>
{
    opt.AddPolicy(name: "CorsPolicy", builder =>
    {
        builder.WithOrigins("https://localhost:4200")  // Allow specific origins

               .AllowAnyHeader()                   // Allow any headers

               .AllowAnyMethod();                  // Allow any HTTP methods (GET, POST, etc.)
    });
});