Overview

All of the components below were implemented in order to meet the assignment requirements while also keeping the realistic polar bear environment theme. The lights, sound, and textures were all selected to add to the environmental theme. The physics and mechanium were selected with the player in mind, allowing for the user to interact with a realistic environment. The AI algorithms implemented all play an important role to adding layers of depth to the game.

Lights 

Two point lights were added to the fish and the end to highlight and make it easier for the player to know what to get and where to end. As a result, the directional light was reduced to make these things more apparent. 
Spotlight was added to the bear starting position to highlight where the player is and what they are controlling. The light was made blue to reflect the arctic background, keeping a consistent theme throughout the game. 

Sound
A feedback sound effect plays each time the player collects a fish. This acts as a notification system for the player to recognize that they have collected a game piece.
A sound effect will play to indicate the start of the game and/or the start of a new round.
Background sound will play throughout the game. The background sound is the sound of wind blowing to make the game seem more realistic. 

Textures
A simple yet important texture that was added was the ice cube texture. This is what allowed us to build the actual environment, representing blocks of ice.
The fish objects all have a fish texture, making them look realistic. This is to match the realism of the main player, which is a polar bear.
The main player is a polar bear with a polar bear texture attached to it. The white fur and black nose make the polar bear look real, and flows nicely with the rest of the textures, which also all look real.

Physics
The two fish that are independent of each other. Each fish has their own script and animation. For physics constructs they each have a rigid body and a collider for the physics.
The polar bear has a rigid body and colliders for physics constructs to make the game seem realistic. 

AI Details

A* pathfinding implemented by Jared Manusig to give the player a hint on how to complete the level. It helps with the gameplay of the game because a player may get stuck on the level. Thus, incorporating a help function that can be used once can help a player get through the level and progress through the game. In terms of theme, the game is a puzzle game. It is often seen in puzzle games that hints are given. In lieu of this, unBEARable also gives a hint to a player.  - Jared Manusig (help from https://dotnetcoretutorials.com/2020/07/25/a-search-pathfinding-algorithm-in-c/) 
Fish AI Movement was implemented by Jigar Patel. It's a very basic implementation of a search AI. The player, which is a polar bear, is supposed to eat/collect the fish as it travels through the level. However, the fish is an AI and it will move when the polar bear touches it. The fish can only move to valid locations on the level and I added search logic to check for valid positions the fish can move based on heights of nearby objects. Each fish will only move once to make the game not too challenging.
Animations FSM was implemented by Darius Alasu. It is a simple algorithm which takes the player’s input and determines which animation(s) to be played while handling the movement of the player. This algorithm is specifically needed for when the player is traversing up and down blocks. When changing heights of the player, the algorithm will determine whether to first play the animation and then teleport, or vice versa. The algorithm will also determine whether a move is valid or not, and play the appropriate animations.


Mechanium 

Polar bear animation: idling, walking, shaking head (states). The polar bear animation was implemented by Darius Alasu. This is the most important mecanim in the game, as it is the main player. The idling state is the state in which the player is when he is not moving around. On player input, an animation FSM will determine whether the move inputted is valid or not. If it is, the walking animation will be played and the player will be transformed to the proper location. If it is not, then the shaking head animation will be played to indicate that the player cannot move there.
Bird Flying animation: flying (states). The bird flying animation was implemented by Jared Manusig. Adding to the environment, we have decided to include some other creatures. The bird is a small little companion to the polar bear, constantly circling around him and following him around. The animation is constantly playing while the bird flies in a circle around the player.
Fish animation: idling, flopping (states). In order to make the game seem more realistic the fish will flop every 5-10 seconds. When the player stands next to the fish it will seem like the fish is jumping in place. Most of the time the fish will be idle. This animation was implemented by Jigar.
