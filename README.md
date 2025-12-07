# Practical 10
## Test 1
 - Create an MVC Page such that the string value passed from the URL should be displayed on the web page.
 - For example, if the URL is http://localhost:xxxx/Employee/Mark, then “Mark” should be displayed on the web page where Employee is the controller Name
 - Use Route to create an appropriate route for the same.
<img width="515" height="211" alt="image" src="https://github.com/user-attachments/assets/85a74f4e-c135-421d-8b2a-a4fdd71a9a35" />


## Test 2 
 - Create MVC Page to display a demo of various type of Action Results like ContentResult, FileContentResult, EmptyResult, JavaScriptResult, JsonResult, etc.
<img width="494" height="332" alt="image" src="https://github.com/user-attachments/assets/732121a3-1e2f-4522-970e-e05337394a7a" />

Clicked on ContentResult Action -

<img width="663" height="166" alt="image" src="https://github.com/user-attachments/assets/06d3d4fd-d554-4083-8a90-7051d4b5e18c" />

Clicked on File Content Result Action -

<img width="658" height="158" alt="image" src="https://github.com/user-attachments/assets/aa7e165e-0c5c-44e4-bb09-62e1df361a84" />

Clicked on Empty Result Action -

<img width="657" height="181" alt="image" src="https://github.com/user-attachments/assets/241b53a5-1f03-430a-8218-4caefdb78965" />

Clicked on JSON Result Action -

<img width="616" height="249" alt="image" src="https://github.com/user-attachments/assets/abd81cc4-254a-474a-84c3-a1a8b7b1cfdb" />

Clicked on JavaScript Action -

<img width="1330" height="406" alt="image" src="https://github.com/user-attachments/assets/236064ea-6954-44ca-b604-787ff604d9c8" />


## Test 3 
 - Create an MVC Project for a demo of OutputCache Filter. The output of the Controller action should be cached for 5 minutes, and the action should return the Current date time as a string. So, after implementing the filter, the same date-time will be displayed for an interval of 5 minutes.
Till 5 minutes if we call this same action method than the same response will be returned, and if executed after 5 minutes then new response will be fetched by calling the action method again and store that response in cache for another 5 minutes.
<img width="527" height="191" alt="image" src="https://github.com/user-attachments/assets/5699010d-6b42-41e3-94fb-04c0506a6063" />


## Test 4 
 - Create an MVC Project for a demo of Exception Filter. Create an action that throws Divide by Zero exception and use the exception filter to handle the error properly.
   <img width="626" height="245" alt="image" src="https://github.com/user-attachments/assets/cdf39e60-9d16-4264-b838-f9c246dce48f" />
