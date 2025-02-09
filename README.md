# Developer Evaluation Project

## Greetings
Hi dear evaluator!<br />
Thank you for taking the time to evaluate this test!

## Premises
Due to lack of time, I wasn't able to develop all the required rules.<br />
However, I tried to make at least one CRUD operation, and I chose the Product CRUD.<br />
I have also fixed some bugs I found in user and auth scenarios, as well as implemented the Authorization that was missing in the provided template solution.<br />
I hope this is enough to show my skills as a senior developer, and to show that I understood and was able to follow the proposed architecture.<br />

## How to run the webapi
```
1. Clone this git repository. Code is in main branch.
2. Open up the solution in Visual Studio 2022
3. Choose `docker-compose` as your startup project, and run it with CTRL+F5
4. Now, choose `Ambev.DeveloperEvaluation.WebApi` as your startup project and hit CTRL+F5 again
```
*Ps: you can run it via command line using `docker compose` if you wish*

You don't need to worry about the database creation and data seeding, I have it cover ;-)
I implemented automatic migration (including seeding data) either to create users and products.
So, once you have finished the steps above, you should expect to have a new database and fully populated Users and Products tables.

*Ps: all users are set with the same password, which is* **!2e456T8**

## Testing the webapi
Once you have the webapi up and running, you can inspect the swagger (/swagger/index.html) to interact with the endpoints.

If you prefer, you can find at the root folder a Postman Collection file you can import in Postman to test the api.

Either way, you should:
```
1. Call any user or product endpoints without authentication to see error 401 - Unauthorized
2. Call the /api/Auth endpoint to get a valid token. There is a script already attached to this action that creates a Postman Collection Variable with the returned token, so you don't have to manually set the bearer token for each endpoint yourself :-)
3. Now you can expect to have successful calls to whatever endpoint you like.
```