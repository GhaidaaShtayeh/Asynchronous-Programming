# Asynchronous-Programming

in this project i tried to apply Asynchronous-Programming

i divide my project into 4 main classes :

* Program : main class -which is call all objects and methods-
* route : which id define the route concept in our Assignment and it's contains an List of Array of type router(another class) and define 4 main methods 

    * Read input : to enter data into the array dynamically 
    * outPut : to print Arrya content
    * Count : in order to  find size of router to be use in another loops 
    * sum : to found the sum of RouterValue

* router : it's just contains an atributte of type int called RouterValue 
* RouterOperation : it's contains two main methods in Router in order to work within it :

    a. Create a new route

    b. Add a router to given route

* RouteSyncAndAsyncMethods : 

    a. Sync method that calculates best route from available routes.


    b. Async method that calculates best route asynchronously by calculating total time
    required for each route in a separate thread.
