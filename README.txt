Instructions
Do not forget the README.txt justification of how you followed the design principles:
* Explain your design and its rationale, and how your components above come together with respect to gameplay and theme
* A point-by-point bullet description of each AI and Mecanim construct and who on your team contributed that construct.




________________




Overview


All of the components below were implemented in order to meet the assignment requirements while also keeping the realistic polar bear environment theme. The lights, sound, and textures were all selected to add to the environmental theme. The physics and mechanium were selected with the player in mind, allowing for the user to interact with a realistic environment. The AI algorithms implemented all play an important role to adding layers of depth to the game.


Lights 


* Two point lights were added to the fish and the end to highlight and make it easier for the player to know what to get and where to end. As a result, the directional light was reduced to make these things more apparent. 
* Spotlight was added to the bear starting position to highlight where the player is and what they are controlling. The light was made blue to reflect the arctic background, keeping a consistent theme throughout the game. 


Sound
* A feedback sound effect plays each time the player collects a fish. This acts as a notification system for the player to recognize that they have collected a game piece.
* A sound effect will play to indicate the start of the game and/or the start of a new round.
* Background sound will play throughout the game. The background sound is the sound of wind blowing to make the game seem more realistic. 


Textures
* A simple yet important texture that was added was the ice cube texture. This is what allowed us to build the actual environment, representing blocks of ice.
* The fish objects all have a fish texture, making them look realistic. This is to match the realism of the main player, which is a polar bear.
* The main player is a polar bear with a polar bear texture attached to it. The white fur and black nose make the polar bear look real, and flows nicely with the rest of the textures, which also all look real.


Physics
* The two fish that are independent of each other. Each fish has their own script and animation. For physics constructs they each have a rigid body and a collider for the physics.
* The polar bear has a rigid body and colliders for physics constructs to make the game seem realistic. 


AI Details


* A* pathfinding implemented by Jared Manusig to give the player a hint on how to complete the level. It helps with the gameplay of the game because a player may get stuck on the level. Thus, incorporating a help function that can be used once can help a player get through the level and progress through the game. In terms of theme, the game is a puzzle game. It is often seen in puzzle games that hints are given. In lieu of this, unBEARable also gives a hint to a player.  - Jared Manusig (help from https://dotnetcoretutorials.com/2020/07/25/a-search-pathfinding-algorithm-in-c/) 
* Fish AI Movement was implemented by Jigar Patel. It's a very basic implementation of a search AI. The player, which is a polar bear, is supposed to eat/collect the fish as it travels through the level. However, the fish is an AI and it will move when the polar bear touches it. The fish can only move to valid locations on the level and I added search logic to check for valid positions the fish can move based on heights of nearby objects. Each fish will only move once to make the game not too challenging.
* Animations FSM was implemented by Darius Alasu. It is a simple algorithm which takes the player’s input and determines which animation(s) to be played while handling the movement of the player. This algorithm is specifically needed for when the player is traversing up and down blocks. When changing heights of the player, the algorithm will determine whether to first play the animation and then teleport, or vice versa. The algorithm will also determine whether a move is valid or not, and play the appropriate animations.




Mechanium 


* Polar bear animation: idling, walking, shaking head (states). The polar bear animation was implemented by Darius Alasu. This is the most important mecanim in the game, as it is the main player. The idling state is the state in which the player is when he is not moving around. On player input, an animation FSM will determine whether the move inputted is valid or not. If it is, the walking animation will be played and the player will be transformed to the proper location. If it is not, then the shaking head animation will be played to indicate that the player cannot move there.
* Bird Flying animation: flying (states). The bird flying animation was implemented by Jared Manusig. Adding to the environment, we have decided to include some other creatures. The bird is a small little companion to the polar bear, constantly circling around him and following him around. The animation is constantly playing while the bird flies in a circle around the player.
* Fish animation: idling, flopping (states). In order to make the game seem more realistic the fish will flop every 5-10 seconds. When the player stands next to the fish it will seem like the fish is jumping in place. Most of the time the fish will be idle. This animation was implemented by Jigar.
UI Design
* We improved the light and the color on the fish to make it more visible (clarity principle)
* Light Improvements were made to make the scene look better and make the color palette look better and more pronounced (Clarity)
* We fixed the fish icons when a fish is collected, put it in the top right (feedback, fitt's laws)
* The Win Text has been improved to display an actual win screen rather than yellow pop-up text (Clarity)
* We enlarged the “Level Win” size (Clarity)
* The pause screen has been implemented, giving the ability to restart (Error Recovery)
* The pause screen has been implemented, giving the ability to return to main menu (Error Recovery)
* Buttons are large and centered to allow for a large target to aim for (Fitts Law)
* The buttons have feedback (color change/audible noise) 
* The Pause, Win, and Main menu follow a similar pattern and design (Consistency/Learnability)
* Disabled Levels are greyed out and don’t have an audible sound attached to them (clarity)
* We fixed the fish icon colors at the top right of the screen (consistent color palette w/ hex #90CAF9)
* We fixed help text color for consistency of the color palette (Light blue w/ hex #90CAF9)
* We enlarged the help text font to be bigger 20 ->26 (Readability, Fitts Law, Clarity)
Sound
In order to meet the requirement of having three background sounds, we added in the following sounds: wind/weather, bird wing flapping, and soft piano music. The wind sound effect was added in to add to the environment of the game, allowing the player to feel more immersed in the actual setting. The bird flapping, once again, is a sound effect included to add to the environment. It is very subtle, because the player shouldn’t be focusing on it, but it is present as background noise. The final audio, a piano song, was added to control the player’s emotion as they play. Because the environment is lonely and in that sense peaceful, the soft piano music can help direct the player’s emotion. It is important to note that all of the sound effects were found online as free audio clips and were edited to fit our game.
We split the game into five main events: menu buttons, camera rotation, player movement, fish movement, and start/end scene. The menu buttons include a hover noise and a click noise to help the user identify the actions that he can make. The camera also has a sound effect for rotation. When a player presses either Q or E, a distinct sound is played to let the player know that the camera was rotated. When the player moves, either an error sound is played (for an invalid move) or a footstep sound is played. For fish movement, a fish flopping sound effect was added to sync with the animation, and a collecting sound effect was added to indicate to the player that the fish was collected. For the final event, a start sound effect is played at the beginning of the level, setting the mood and adding to the environment, and a win sound effect is played once the player makes it to the end of the puzzle.
Some sounds that were brainstormed were adding background noises for the polar bear. We decided against this, because we included polar bear sounds to signify the player interacting with the game, and adding different polar bear noises in the background could potentially confuse the player.