/* THE GOOGLE ROBOT INTERVIEW QUESTION!!

Scientists have opened a portal to another dimension.
In that dimension, the plane of existence is just an infinite line.

Scientists want to send two robots through to do something. Idk what.

But when they are sent through this portal, they don't enter that plane of existence
in the same place. In fact, they land in entirely different places. 

Because this is a weird place, the robots actually land on top of the parachutes they 
used to float down (??? I know) 

For some reason, these scientists forgot to put any significant amount of money towards
the software development side of this experiment.

So here's the deal. Two robots, land on top of their parachutes, and have exactly the same code on them.

The code can comprise of a combination of our basic tool kit (setting variables, for loops, while
loops, if/else if/else checks, etc.), and a handful of predefined methods, which are as follows:

moveLeft(){} -> Moves the robot to the left one unit of distance in one unit of time.
moveRight(){} -> Moves the robot to the right one unit of distance in one unit of time.
wait(){} -> The robot stays in place for one unit of time.
parachuteCheck(){} -> Returns a boolean for whether or not the robot is currently on top of a parachute. Takes 
                    one unit of time.
robotCheck(){} -> Returns a boolean for whether or not the robot has found another robot. Takes one unit 
                    of time.


A piece of clarification!!

When I say the same code is on both robots, what I mean is that the program runs on both robots.
So if the program is just
moveLeft();

Both robots will move left.

SO!!! The goal is to write a program that GUARANTEES (this assumes the robots have an infinite power source)
that they will find each other.
*/