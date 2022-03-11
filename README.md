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


1. You need to build classes that represent the router and route. - DONE - (Route and Router Classes)


2. You need to build a class that reads input from user to : -DONE- (RouterOperation class)

   a. Create a new route
   
   b. Add a router to given route

3. Create a class that contains two methods -DONE- (RouteSyncAndAsyncMethods class)
4. 
    a. Sync method that calculates best route from available routes.
    
    b. Async method that calculates best route asynchronously by calculating total time
   required for each route in a separate thread.
   
4. The number of routes for each route is dynamic depending on user input -DONE- (By using ArrayList and Add method)

6. The max number of allowed parallel threads is 4, for instance if we have 3 routes only, then you need to run 3 threads only but if you have more than for 4 like 6, first you run 4 threads and once a thread is released you need to run one more and so on. - DONE - (By using BestRoute method in RouteSyncAndAsyncMethods class and use                 .WithDegreeOfParallelism(4) )
