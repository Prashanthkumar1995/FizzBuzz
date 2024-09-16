# FizzBuzz Web Application

## Introduction

This web application processes an array of values and applies the FizzBuzz rules:

1. If a value is a multiple of 3, it outputs "Fizz".
2. If a value is a multiple of 5, it outputs "Buzz".
3. If a value is a multiple of both 3 and 5, it outputs "FizzBuzz".
4. If a value is invalid, it returns "Invalid Item".
5. If a value is not divisible by 3 or 5, it returns a message indicating "each division that was performed".

## Tesing

- **Swagger:** Use Swagger to test.
- **Postman:** Use Postman to test the API endpoints.

## Steps to Run

1. git clone https://github.com/Prashanthkumar1995/FizzBuzz/tree/main.
2. Create a branch with give unique name. And colone code from the main branch to created branch.
3. we can test with Swagger or Postman.
4. With Swagger : After Cloning and createed the branch Run the application Our Url will be ex:  https://localhost:7124/swagger/index.html.
5. Provide the values in request body, i am providing 1 and click on Execute.
Ex: 
{
  "values": ["1"]
}
   **Response will be** : 	

 "finalresult": null,
    "logresult": 
      "Divided 1 by 3",
      "Divided 1 by 5"
6. Provide the values in request body, i am providing 3.
Ex: 
{
  "values": ["1"]
}

**Response will be** : 	

"finalresult": "Fizz",
    "logresult": []
