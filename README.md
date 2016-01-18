# DeltaHacksII

*See our project on Devpost: http://devpost.com/software/leapstax/*

## Inspiration
When thinking about what we can do with technology to evoke positive change, we realized that it needed to start with the youth. Children are the future and the quality of their education is crucial for fostering the next generation of innovative engineers. However, one area that students consistently score poorly on is spatial geometric interpretation. 

With this in mind, we decided to create an application allowing children to work with building blocks in an open environment that challenges their interpretation of 3D space. 

## What it does
LeapStack provides an environment for young children to push the bounds of their imagination as they manipulate various 3-D shapes. Children can build all sorts of structures with the blocks and learn about the properties of 3D objects through hands-on interaction. This application not only allows the children to model three dimensionally but also play with options such as the loss of gravity and observe collisions in space. 

## How we built it
Our application uses a wide range of technologies which consists of Unity/C#, Blender and Leap Motion. The Leap Motion SDK was used to read the hand motions and gestures and Blender was used to create custom 3D objects for the application. Ultimately, we used Unity and C# to create the environment for the application and connect all the pieces together. After learning how the game development engine worked, we began to create the objects and write the script to merge the Leap Motion controller with the objects. 

## Challenges we ran into
Since the entire team had never used any of the technologies required for this program, the entire process of creating the hack was a challenge. At first, we implemented a grid system for the blocks to fall into, but we decided that a more free-ranged application would allow for more open thinking and imagination. It was also especially difficult to get the magnetic grab between the hand and the objects working when triggered by the hand gesture detected on the Leap Motion. In addition, the physics model for the blocks and hand gesture recognition were not working with what we intended the program to do thus, we had to implement those features ourselves. 

## Accomplishments that we're proud of
We are especially proud that we were able to finish this project, despite the team having no experience whatsoever with any of the technologies. In addition, we are very pleased that our program works the way we intended it to and that it could potentially serve a very important purpose of helping to foster an interest in the next generation to learn, design and create things in a fun, interactive way.

## What we learned
We all learned the technologies used in our project, Unity, C#, Blender and Leap Motion, from scratch with no prior experience in these areas. So, a lot of technical skills were learned. Aside from technical skills, we somehow managed to start, make and finish a whole project while learning tons of technologies. So, we definitely tested our capabilities to understand problems quickly and come up with solutions quickly.

## What's next for LeapStack
LeapStack can be scaled and furthered to become a collaborative building environment as well. 
We've also developed a working prototype called LeapFill, which goes a little further with the idea of LeapStack, in that it has 3D objects that can be placed into various containers/holes, allowing children to improve their spatial recognition skills. 
