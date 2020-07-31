# ProcessSim
Simulation of a process control scenario.

The goal is to eventually create a game based on process control. Uses simple on/off control at the moment.

When started, the setpoint defaults to 50%. The tank level ranges from 0 to 100%, and drops by about 10 points per second. Hysteresis creates a gap between the level where the pump is turned on and it is turned off. With hysteresis set to 0, the pump switches on and off rapidly. In a physical system this is very hard on the pump and the contactor that drives it, hysteresis prevents this. The effect is sometimes termed hunting, because the system is constantly hunting for a stable position but can never find one.
