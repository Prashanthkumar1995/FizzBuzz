# FizzBuzz Web Application

## Introduction

This web application processes an array of values and applies the FizzBuzz rules:

1. If a value is a multiple of 3, it outputs "Fizz".
2. If a value is a multiple of 5, it outputs "Buzz".
3. If a value is a multiple of both 3 and 5, it outputs "FizzBuzz".
4. If a value is invalid, it returns "Invalid Item".
5. If a value is not divisible by 3 or 5, it returns a message indicating "each division that was performed".


## Acheievd in Project
1. Applied Solid principle(Single Responsibility Principle).
2. Implemented  Dependency injection 
3. Implemented factory design pattern.
4. Created Testcases using xUnit.
5. Maintained seperation of code using interfaces for easy to maintain, easy to understand
   ,testability, extensibilty.

## Tesing

- **Swagger:** Use Swagger to test.
- **Postman:** Use Postman to test the API endpoints.

## Steps to Run

1. We need to do the code clone from git repo name : https://github.com/Prashanthkumar1995/FizzBuzz.
2. Create a branch with give unique name. And also clone code from the main branch to created our branch.
3. we can test with Swagger or Postman.
4. With Swagger : After Cloning code and createed the branch. Now Run the application Our Url will be ex:  
   https://localhost:7124/swagger/index.html.
5. Select  Post And click on Try it Out button, Now Provide the values in request body, i am providing 1 
   and click on Execute.
   Hence:  
   **Final reult**     : is if divisible with given number then our result will come.
   **Logresult reult** : is if Not divisible with given number then our result will come.
   Ex: 
   {
   "values": ["1"]
    }
   **Response will be** : 	

      "finalresult": null,
      "logresult": 
      "Divided 1 by 3",
      "Divided 1 by 5".

6. Provide the values in request body, i am providing 3.
   Ex: 
   {
   "values": ["1"]
   }

   **Response will be** : 	

    "finalresult": "Fizz",
    "logresult": []
