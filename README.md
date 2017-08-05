# **Unity Controls**

Holding the right mouse click 

**W** Will make the scene move forward 

**A** Will make the scene move left handside

**D** Will make the scene move to right handsome

**S** Will make the scene move to backward



Using Rotational tool we can change the angle of the scene. 

In which we can change the scene tab to game tab for watching the changes in realtime. 

**User interface controls that you should know**

Hierarchy 

Game View

Scene View

Inspector

Project structure

**Install**

While installing the unity it is necessary mind the version and the latest will always have conflict with the prior version editors. 

# **Example 1 Go Home**

This game allows us to work with vectors and we will try finding the home. 

Through this example we will learn basics of C# and Vector Maths. 

#### **Rough plan for this game**

1. Creating a rough plan
2. Define the user's problem. 
3. Brainstorming the concept, rules and requirements 
4. We will also document the future ideas.




## **Problem**

- I'm bored.
- I want to challenge myself.
- I want to beat my friends.



# Concept

- [ ] You are lost and trying to find your way home. 
- [ ] All you know is your distance from home. 



# Rules

- [ ] You can move up, down, left and right. 
- [ ] Movement is a fixed distance. 
- [ ] After each turn, your distance from home is displayed. 
- [ ] You win when you get home. 
- [ ] Your score is how many turns it took. 

# Writing the requirements.

- What assets will you need?
- What sound effects?
- ArtWork? 
- What features will you leave out?

# Requirements 

- Introduction and story text.
- Potentially some ASCII artwork. 
- No sounds. 

# Future IDEAS (The NO List)

- Graphical interface. 
- Sound effects. 



# Let's get started. - Scripts in unity.

**Scripts in unity**

In the layout menu from the right handside choose the default layout settings for getting started on the basic programs. 

Scripts are actors which gives stage directions for the models. 

1. walk into the bathroom
2. Turn on the shower
3. stand under the shower
4. take the soap

**To Create a Script file**

1. Use the project pane
2.  Create a c# script
3. Give it a sensible name

**Writing to the console through C#**

Anatomy of the c# scripting langauage. 

We tell the program to do the action in the start through

```c#
void start(){



}

```

We need actor to run our script. 

Scripts are called components. 

Actor is nothing but a game object.

we can have multiple components which means multiple scripts

Using the print method we can print the strings in console. 

```c#
print("Welcome to Go Home");
```

**Declaring and assigning variables**

Pseudo code.

- Set start location 
- calculate distance from home 
- print distance from home
- read players move
- update location from home. 
- Repeat. 

types with different shapes 

integer is sqaure 

string is circle 

float is hexagon

**Using booleans and their operators**

1. conditional execution with if statement
2. Reacting to different conditions 

**Getting inputs **

```c#
if (Input.GetKeyDown (KeyCode.LeftArrow)) { 

}
```

**vectors for positions and movements**

* Understad what a vector is. 
* Adding/Subtracting vectors. 
* Using vectors to calculate the path home. 

Vector : Positional vectors

