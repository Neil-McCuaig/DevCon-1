# Planning:

# **Our vision:**

A fun and engaging 2.5D simple idle game that players can enjoy either by itself or as something to do with their eyes and hands while they listen to an audiobook or podcast.

# **Our goals for this project:**

Develop an unique and interesting resource gathering mechanic for an idle game, where instead of just spam-clicking on a button at the start of the game, the player performs a mini-game or completes a puzzle? Blacksmithing an item? Operating heavy machinery?  
to get resources. The resources that the player could earn are cash, museum fame, and artifact information.

# **Our Team and Roles:**

Neil McCuaig \- Writer, Bug Tester  
Benjamin Leigh-Gladeau \-   
Jacob Grypma \- Model maker

# **Mechanics:**

The main mechanic will be a simple puzzle minigame that rewards resources based on how accurately and/or quickly the player was able to complete it.

An upgrade system that allows the players to improve the resource yield of the puzzles, reduce or increase the difficulty of the puzzles, and help with/automatically complete parts of the puzzles.

# **Controls:** 

Mouse to drag and drop puzzle pieces.

# **World:**

The game takes place in a mostly grounded Earth-like world in a modern setting, with ancient artifacts and sci-fi tech that does not exist in the real world. The gameplay takes place in just a couple of screens, so the player mostly explores the artifacts and tech through text snippets related to items or upgrades.

# **Characters:**

The only character who speaks will be the player’s boss, who will give them basic advice and work orders and a tutorial at the very start of the game. If the game were fully realized, other department heads would also give the player work orders.

# **Story:**

You are a new archivist working at a museum trying to put back together old artifacts that have been recovered from the field.

# **Interface:**

The interface will be relatively simplistic, using mostly stylized stone buttons with simple backgrounds. The puzzles will pop up in front of the rest of the interface while active.

# **Audio:**

The audio will be fairly simple. Including a looping soundtrack with an egyptian theme, a clicking noise for when buttons are pressed, and two noises for when the puzzles are being clicked on and when the puzzles are completed. Since the game is meant to be an idle game the player can enjoy while listening to other content, the game’s audio will be disableable.

# **Resources:**

Drag and Drop Script Tutorial:[Drag & Drop 3D | World-Space 3D Objects | C\# | Unity Game Engine](https://www.youtube.com/watch?v=oZie8X_2aAU)

Shuriken: [https://www.thebasemesh.com/asset/3-point-shuriken](https://www.thebasemesh.com/asset/3-point-shuriken)   
Shuriken Texture: [https://ambientcg.com/view?id=Metal053B](https://ambientcg.com/view?id=Metal053B)  
Wooden Table: [https://www.thebasemesh.com/asset/square-table](https://www.thebasemesh.com/asset/square-table)  
Texture for the table: [https://ambientcg.com/view?id=Wood051](https://ambientcg.com/view?id=Wood051)  
Table Cloth Texture: [https://ambientcg.com/view?id=Fabric001](https://ambientcg.com/view?id=Fabric001)

# **Unused assets:**

Arrowhead: [https://www.thebasemesh.com/asset/arrowhead](https://www.thebasemesh.com/asset/arrowhead)  
Battle Axe: [https://www.thebasemesh.com/asset/battle-axe](https://www.thebasemesh.com/asset/battle-axe)  
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

Some of the visions we considered for the minigames the player would be operating were archeology, blacksmithing, and operating heavy machinery like mining drills. We eventually decided on archeology.

We decided that we would strip off much of the “Idle Game” part of the project in favor of just having the game open straight into our puzzle, in order to simplify the scope of the project to fit into a week.

We thought that a top-down view of a table with a tablecloth on it with the broken artifact would make for a good backdrop instead of our initial free floating pieces idea.

We had an issue with the merge from one of our members to the main, removing everything in the scene, and we had to take an older working version, strip out the main, and replace it with the functional version. Even after that fact, the merges have conflicts and seem to drop things at random.

We handled the puzzle logic by setting up several box colliders in the scene that were set to be triggers. Each collider would check for a puzzle piece with the correct tag and when the correct piece entered it the script would disable the draggable piece and enable an identical static piece on the table, once all pieces were placed the static pieces would be disabled and the completed object would be enabled in their place.

At one point we had a version of the code where a raycast would disable one of the puzzle pieces and enable a piece in the player’s hand, making it look like it had been grabbed, and a version that would work with the puzzle piece being picked up and dragged by the mouse. We opted for the raycast initially, but could not get it to work with the collision for placing the puzzle pieces down properly, so we opted for the picking up and dragging instead.

At one point the raycast was not hitting the blades at the back of the desk. It turned out the hitboxes for the different pads where the items were to be placed were too tall, and were blocking the raycast. For the earlier raycast version of the puzzle, they were made shorter to prevent this. In the end, the raycast model was replaced, so the hitboxes were reverted.

There were several assets that we initially planned to use that were not included in the final as we scaled back the project. We left them in this GDD anyway, as they were part of our thought process.

# **Questions:**

Question 1: How will the player know what shape the pieces need to be put back together in?

Answer 1: The Shuriken is broken up into fairly understandable pieces. Four blades and one core. There are five pads on the table where these can be placed.

Question 2: How will we get the pieces to fall into place when the player puts them in the right spot? 

Answer 2: Have a second hidden collection of pieces. When the ones that the player picked up are dropped on the right spot, the grabable piece is deleted, and the invisible one is revealed.

Question 3: How will we fix issues with Github pushes not having assets included in them.

Answer 3: Send a copy of the .ZIP to a team member without the problem, and have them replace their copy of the main repository on their computer with the updated game version, and then push that into the main on github.

Question 4: How will the broken pieces actually be grabbed by the player? 

Answer: Players will click on the pieces to grab them and drag them with the mouse to the correct location.