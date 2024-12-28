# Unity Game AI Systems Implementation

Welcome to this repository, where I have implemented a series of powerful AI techniques for video games using Unity. This repository showcases the application of key AI concepts such as State Machines, Behavior Trees, and Genetic Algorithms, all integrated into practical Unity projects. The goal of these implementations is to simulate intelligent NPC behaviors and create immersive game worlds where AI characters can interact, learn, and evolve without direct player control.

## Overview

In this repository, you'll find various Unity projects that demonstrate different AI techniques. These projects focus on providing practical AI solutions for games, such as a simple replica of the game "Catch" and a more complex colony simulation similar to games like _Rimworld_ or _Oxygen Not Included_. The repository is designed to help you understand and implement various AI concepts that are commonly used in both indie and AAA game productions.

### Key AI Techniques Covered:

1. **State Machines**  
   State machines are a fundamental concept in game AI. In this project, I demonstrate how to implement basic AI behaviors using state machines. This includes creating simple decision-making structures where the NPCs transition between different states based on the game conditions.

2. **State Pattern for Extensible State Machines**  
   As the project evolves, I refactor the basic state machine system to make it more extensible using the State Pattern. This allows for cleaner, more maintainable code that can be easily extended with new states without introducing complexity.

3. **Behavior Trees**  
   One of the more advanced AI techniques demonstrated in this repository is the use of Behavior Trees (BTs) to control NPC behavior. Behavior Trees are used to build more sophisticated AI systems, where NPCs can make decisions based on complex conditions and context. I have incorporated the **Behavior Designer** plugin to enhance the behavior tree system, which is widely used in game development for crafting responsive and dynamic AI.

4. **Genetic Algorithms**  
   In this section, I explore the use of genetic algorithms to simulate an ecology and create AI that evolves over time. Genetic algorithms allow NPCs to adapt based on their success in survival tasks, offering an innovative approach to game mechanics and AI progression.

## Project Breakdown

### 1. **Catch Game AI**

- This is a simple AI project where I developed a digital version of the classic "catch" game.
- The AI controls the movement of one of the players in the game, using a state machine to determine its actions.
- This serves as an introduction to basic AI concepts like state transitions and decision making.

### 2. **Colony Simulation AI**

- Inspired by survival games like _Rimworld_ and _Oxygen Not Included_, this project involves creating AI for a colony of NPCs that must survive by managing their needs such as food, rest, and health.
- NPCs in this simulation are controlled by a complex system of behavior trees, which allow them to perform actions based on various factors in their environment.
- The state of the colony is simulated with AI that decides tasks such as resource gathering, building, and other survival activities.

## Key Concepts Implemented

- **AI State Machines**: Simple decision-making logic for NPCs to manage their state transitions based on game events.
- **State Pattern**: A design pattern used to improve the extensibility and maintainability of state machines.
- **Behavior Trees**: A more complex and flexible AI system that helps NPCs make decisions based on game state and environmental variables.
- **Behavior Designer**: A plugin used to enhance behavior tree implementation and make it easier to design and visualize AI behaviors.
- **Genetic Algorithms**: Used to simulate an evolving ecosystem where NPCs adapt and evolve based on survival factors.
