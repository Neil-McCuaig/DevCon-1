# Planning:

# **Our vision:**

**Devcon 1:**  
A fun and engaging 2.5D simple idle game that players can enjoy either by itself or as something to do with their eyes and hands while they listen to an audiobook or podcast.

**Devcon 2:**  
An update to our previous simple puzzle game to add more options for players then just a single puzzle.

# **Our goals for this project:**

**Devcon 1:**  
Develop an unique and interesting resource gathering mechanic for an idle game, where instead of just spam-clicking on a button at the start of the game, the player performs a mini-game or completes a puzzle to get resources. The resources that the player could earn are cash, museum fame, and artifact information.

**Devcon 2:**  
Develop new puzzles for our idle game and a way to access them. These will expand the variety available in our game and make it more enjoyable to play.

# **Our Team and Roles:**

**Devcon 1:**  
Neil McCuaig \- Writer, Bug Tester, Asset locator  
Benjamin Leigh-Gladeau \-   
Jacob Grypma \- Model maker

**Devcon 2:**  
Neil McCuaig \- Writer  
Benjamin Leigh-Gladeau \-   
Jacob Grypma \- Model maker

# 

# **Mechanics:**

**Devcon 1:**  
The main mechanic will be a simple puzzle minigame that rewards resources based on how accurately and/or quickly the player was able to complete it.

An upgrade system that allows the players to improve the resource yield of the puzzles, reduce or increase the difficulty of the puzzles, and help with/automatically complete parts of the puzzles.

**Devcon 2:**  
The main mechanic will be a few simple puzzle minigames like our previous Shuriken puzzle.

A menu mechanic that will allow the player to choose which puzzle they are going to play.

# **Controls:** 

**Devcon 1 and 2:**

Mouse to drag and drop puzzle pieces.

# **World:**

**Devcon 1 and 2:**

The game takes place in a mostly grounded Earth-like world in a modern setting, with ancient artifacts and sci-fi tech that does not exist in the real world. The gameplay takes place in just a couple of screens, so the player mostly explores the artifacts and tech through text snippets related to items or upgrades.

# **Characters:**

**Devcon 1 and 2:**

The only character who speaks will be the player’s boss, who will give them basic advice and work orders and a tutorial at the very start of the game. If the game were fully realized, other department heads would also give the player work orders.

# **Story:**

**Devcon 1 and 2:**  
You are a new archivist working at a museum trying to put back together old artifacts that have been recovered from the field.

# **Interface:**

**Devcon 1:**  
The interface will be relatively simplistic, using mostly stylized stone buttons with simple backgrounds. The puzzles will pop up in front of the rest of the interface while active.

**Devcon 2:**  
The interface for the full game would be relatively simplistic, using mostly stylized stone buttons with simple backgrounds. The puzzles will pop up in front of the rest of the interface while active. For this update, we will just be using simple, unstylized buttons due to time constraints.

# **Audio:**

**Devcon 1 and 2:**   
The audio will be fairly simple. Including a looping soundtrack with an egyptian theme, a clicking noise for when buttons are pressed, and two noises for when the puzzles are being clicked on and when the puzzles are completed. Since the game is meant to be an idle game the player can enjoy while listening to other content, the game’s audio will be disableable.

# **Resources:**

**Devcon 1:**

Drag and Drop Script Tutorial:[Drag & Drop 3D | World-Space 3D Objects | C\# | Unity Game Engine](https://www.youtube.com/watch?v=oZie8X_2aAU)

Shuriken: [https://www.thebasemesh.com/asset/3-point-shuriken](https://www.thebasemesh.com/asset/3-point-shuriken)   
Shuriken Texture: [https://ambientcg.com/view?id=Metal053B](https://ambientcg.com/view?id=Metal053B)  
Wooden Table: [https://www.thebasemesh.com/asset/square-table](https://www.thebasemesh.com/asset/square-table)  
Texture for the table: [https://ambientcg.com/view?id=Wood051](https://ambientcg.com/view?id=Wood051)  
Table Cloth Texture: [https://ambientcg.com/view?id=Fabric001](https://ambientcg.com/view?id=Fabric001)

**Devcon 2:**  
Battle Axe: [https://www.thebasemesh.com/asset/battle-axe](https://www.thebasemesh.com/asset/battle-axe)

# **Unused assets:**

**Devcon 1 and 2:**

Arrowhead: [https://www.thebasemesh.com/asset/arrowhead](https://www.thebasemesh.com/asset/arrowhead)  
Background music: [https://pixabay.com/music/ambient-egypt-expedition-phrygdom-119040/](https://pixabay.com/music/ambient-egypt-expedition-phrygdom-119040/) and [https://pixabay.com/music/ambient-egypt-expedition-the-kingdom-119123/](https://pixabay.com/music/ambient-egypt-expedition-the-kingdom-119123/)  
Button Press Sound Effect / Puzzle Clicked sound effect: [https://pixabay.com/sound-effects/button-press-85188/](https://pixabay.com/sound-effects/button-press-85188/)  
Gem: Custom Asset  
Blacksmith Hammer: Custom Asset  
Stone Buttons:   
UI Background:  
Pickaxe: [https://poly.pizza/m/bIaXVvEzNqT](https://poly.pizza/m/bIaXVvEzNqT) alternative: [https://poly.pizza/m/cJp88qPPLc](https://poly.pizza/m/cJp88qPPLc)  
Puzzle complete Sound Effect: [https://pixabay.com/sound-effects/game-level-complete-143022/](https://pixabay.com/sound-effects/game-level-complete-143022/)  
[How To Pick Up an Item - Unity](https://www.youtube.com/watch?v=zEfahR66Pa8) \- Unused method for grabbing the items

# Development Documentation:

We initially discussed adding a polishing version of the puzzle where instead of putting together broken shards the player would polish and preserve an already put together item. We did not adopt this in the end as we were able to get more models broken up into their constituent parts.

When we added our second level, we had an issue where the level buttons were showing up over the table where they were not supposed to be and the rivets for the axe in our second level kept trying to fly off the table and would not slot into the puzzle. The level buttons were fixed by changing their x and y anchor positions. The rivets were fixed by changing their collider from a mesh to a box collider and by moving the triggers that allowed the pieces to slot in.

# **Questions:**

Question 1: How will the player choose between different puzzles?

Some simple buttons that take the player either forward to the next puzzle or back to the previous puzzle.

Question 2: Will selecting a different puzzle load an entirely new scene or just make the selected puzzle appear in the current scene?

Answer 2: Loading a new scene is much easier to program then having only certain items appear, so we opted for loading new scenes.