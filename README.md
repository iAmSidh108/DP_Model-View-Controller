# Model-View-Controller (MVC) Pattern in Unity:

## **What is MVC Pattern?**

The Model-View-Controller (MVC) pattern is a software design architecture that separates an application into three interconnected components: the Model, responsible for managing data and business logic; the View, responsible for displaying user interface elements and presenting information to the user; and the Controller, responsible for handling user input, updating the model, and managing the flow of data between the Model and the View.

![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/c7b12e2c-9b09-4d60-b004-6d15385ed737)

## **Examples of using the MVC pattern in game development:**

1. **Player Character Movement:**
   - **Model:** Represents the player character's position, speed, and other attributes.
   - **View:** Displays the character on the screen.
   - **Controller:** Manages user input (e.g., keyboard or joystick) to update the character's position in the model and reflect changes in the view.

2. **Inventory System:**
   - **Model:** Manages the player's inventory data (items, quantities, etc.).
   - **View:** Displays the inventory GUI.
   - **Controller:** Handles input for adding, removing, or using items, updating the model accordingly, and reflecting changes in the view.

## **Drawbacks of using MVC Pattern:**

1. **Complexity:**
   - MVC can introduce complexity, especially in smaller projects, leading to potential over-engineering.

2. **Learning Curve:**
   - Developers unfamiliar with MVC may face a learning curve, potentially affecting project timelines.

3. **Tight Coupling:**
   - Improper implementation may lead to tight coupling between the components, making it harder to maintain and modify the code.

## **How to implement MVC Pattern:**

1. **Identify Components:**
   - Determine what will serve as the Model, View, and Controller in your system.

2. **Define Interfaces:**
   - Clearly define the interfaces between Model, View, and Controller to ensure proper communication.

3. **Separate Concerns:**
   - Ensure that each component focuses on its specific responsibilities without interfering with the others.

4. **Decouple Components:**
   - Minimize dependencies between components to allow for easier maintenance and modifications.

5. **Use Events and Observers:**
   - Implement event systems or observer patterns to facilitate communication between components without direct dependencies.

6. **Framework Utilization:**
   - Leverage existing frameworks or Unity's built-in systems to help implement MVC patterns efficiently.

7. **Documentation and Best Practices:**
   - Document your architecture and follow best practices to ensure that the MVC pattern is implemented effectively and consistently.

Implementing MVC in Unity requires a thoughtful design approach and a balance between flexibility and simplicity based on the specific requirements of your game development project.

## How I implemented MVC pattern in Unity?
We created 3 diferent scripts for Tank with names TankModel, TankView and TankController respectively. Model and View will not contact eachother.
![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/c473d98a-a4a0-4a5e-9f48-c82ea7ce5ea8)

![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/6b940f91-1aa3-488c-872f-a4260bd6fcdb)
===========================================================================================================================
![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/6c825ba9-0ce9-4b8f-b12e-c8fdece087b1)
===========================================================================================================================
![image](https://github.com/iAmSidh108/DP_SingletonPattern/assets/63715240/c0e51b3c-5c37-49df-aa26-ad0b41ed7d59)
===========================================================================================================================



