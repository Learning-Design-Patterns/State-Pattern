# State Pattern
  * State pattern allows a object differnetly when it state changes at run time.
  * Example 1:
    * Think of UI control which has Draw abstract method.
    * There is a Textbox control which implements the UI control's Draw method.
    * Also there is Checkbox control which implements the UI control's Draw method.
    * So when we create a object refernce with Textbox control the object will behave differnetly than when we create with reference of Checkbox control
    ![Example](https://github.com/Learning-Design-Patterns/Images/blob/develop/State%20Pattern/StatePattern1.PNG)
    
  * Example 2:
    * We have a **Canvas** class which will have **mouseup()** and **mousedown()** methods will behave differnetly based on the currentTool property.
    * The currentTool property is a refernce of an abstract class/ interface which will have an abstract methods **mouseup()** and **mousedown()**.
    * We will have the concerete classes for each tool type like **Selection** and **Bruch** which inherit the base class **Tool**.
    * Each concrete class has its own implementation for the **mouseup()** and **mousedown()** methods.
    * This way when we instantiate the **Canvas** class by passing the concerete class instances, it will acts as deletegate and redirects to the corresponding implementation.
    ![Canvas example](https://github.com/Learning-Design-Patterns/Images/blob/develop/State%20Pattern/StatePattern.PNG)
* In general as GOF(Gang Of Four), 
  * In place of Canvas we will have **Context** which internally have the **request()** method.
  * In place of Tool abstract class/ interface we will have **State** abstract class/ interface which will have the **handle()** method.
  * Also will have the concrete classes for eaxmple concreteStateA and concreteStateB classes which implements the **State** abstract class/ interface 
  ![GOF Image](https://github.com/Learning-Design-Patterns/Images/blob/develop/State%20Pattern/StatePattern_2.PNG)
