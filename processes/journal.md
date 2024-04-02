# Weekly journal 

## January 25, 2024
* Make a Thing! 
This week was the first time I experimented with tiny game engines. I am pleased we did not dive straight into coding (though this class focuses on C## in unity), I was not the type of artist to be perfect at coding but I enjoy it. I experimented with bitsy and I am glad I chose this mini engine as it is quite easy to work with and very beginner friendly. I also found that bitsy brought some nostalgia considering it is pixel based. I made a bitsy game called, “Mewmew’s Gift giving” which was a cat being granted permission to explore its owner’s garden and collect an array of funky items. Though it was not a win or lose game and more of an exploration game, I had fun experimenting with this sort of exploration game. I was happy with the outcome however there were a few things to keep in mind which was to properly set the garden’s walls as objects that prevent the cat from going through. I would have like to explore more into making complex games with additional designs; I learned I am able to work with my own pixel designs that have more detail and color variation, and also incorporate my own unique code to the bitsy html file. Overall, bitsy is an overall great tool for beginners and an excellent starting point to a bigger and more complex game. 


## February 6, 2024
* Pawng!
This week was a stretch for me considering I just gotten into C## coding with Unity. I find using C## and Unity is a bit challenging but I have hopes I will get better. Anyways, this week’s exercise was to complete or add onto the last in-class exercise, SleepyTimes, which basically was an introduction exercise to Unity and basic CC## coding. I was able to implement the Pawng template to my own scene in Unity with the sleepy time objects however I feel like I forgotten some parts to add onto my code which I will try to add and fix later before class. I like to think of myself as organized and having everything in one place, a document if you may. It would be nice to have the instructions to these mini exercises in an official document or PDF that could be posted on the website or moodle instead of discord where things may get lost or misread. Aside from that, I enjoyed doing this mini activity with the basics, and I plan to add more stuff to it like adding the score board in a text that changes each time a player gets a score. 
Feedback from peers:
-	Decrease the bed’s box collider so the ball will collide closer to the bed.
-	Friction with the ball – prevent it from getting stuck. 
-	Make the ball become faster overtime. 
-	Add a cool scoreboard. 


## February 8, 2024
* Breakout!
What you need to make it:
•	Field of bricks
•	Array of game objects 
•	A paddle
•	A ball that goes neither left or right (random direction) 
•	Walls L/R, U – bounce, F – Respawn
•	Scoreboard (Use canvas UI text in unity)
•	Awake is ran before start
I find making a list like this is useful when starting a game. It gives me a clear idea what I need to do and doing it bit-by-bit is key!


## February 10, 2024
* Breakout!... Breakdown
Breakout exercise was a bit challenging considering its physics but I do have a broad understanding that breakout is basically pawng but with different behaviors and positions. The new component is its brick behaviors which I will most likely go back and study it. Last class I could not really be engaged due to my coughing and sniffling (I was battling a cold at the time) and was left behind with additional stages of the breakout exercise. Though the pro is welcome to help, I felt as though my consistent hand raises and coughs were disrupting the class so I left early. Besides that, I went to the computation lab for help and had a better understanding of how things worked and why I kept running into errors. However, I feel as though some errors are not explainable and sometimes are due to spontaneous algorithms. I just hope this upcoming class won’t be as harsh as the last… 
Notes to keep in mind:
-	Have not figured out the scoreboard display though it is triggered in the debug/log so maybe separate each “point” component (eg: the heart.png) instead of one single image?


## February 15, 2024
* Breakout: peer feedback
·	Change paddle horizontal limit (must not go past wall) 
·	Add an acceleration to the ball (has something to do with material?)
·	Fix the brick’s space/distance with each other. 
·	Add a scoreboard (will learn from prof tonight)

* SHMUP Notes: 

0) Game Manager
- Score
- lives
- weapons
- time
- Start & Game Over

1) Player L/R & UP/DOWN
input key - Projectiles (INST)
    - GO > BULLET (MOV/SCRIPT)

2) Enemies
Projectiles movement shooting out

3) Enemy Manager
- Spawn

4) Things getting spawned
- health
- friends/allies
- bonus weapons
- obstacles

## February 16-22
Shmup Creative Process 
Step 1:
- Made basic sprite object (player) move up, down, left, and right with keys

Step 2:
- Made basic sprite object (enemy) move on x axis

step 3: 
- Made a gun and bullet for player 
- Added a script to both enemy and player to be interactive with one another

step 4: 
- Made bullet shoot consistently shoot on x axis and die after 3 secs
- Made bullet to shoot at enemy => enemy disappears (collision & rigid components added)

step 5:
- Made health meter for fish health (rectangle image fill amount decrease script)
- Made scoreboard for how many enemies are collided with bullet (shoot)

step 6:
- Made enemy + player collision decrease fill amount of health meter
- Made additional scenes (Lose, menu, win)
- Made enemy movement on x axis in sin wave (math things!)

step 7:
- Testing movements and interactivity
- Editing and revising movement & mechanics
- Replaced sprites with prettier designs (used pixel art)


Key Elements:
- Fishy (player)
- Bubble (bullet object to shoot garbage enemies)
- Garbage (enemy objects to decline fishy health)
- Scoreboard (how many garbage objects collected)
- Health Meter (Fishy's health decreases 20% if touches garbage object) 
  
* Side-view perspective
* Fishy avoids flying garbage
* Fishy shoots garbage
* Garbage declines fishy health meter
* Fixed shooters shmup type


## Design Journal
The Game I choose to discuss about is Sons of the Forest which is a game I finished, and I am quite proud of my completion. Sons of the Forest is an extension (or second part of the original The Forest). It is a single or multiplayers game that consists of a mission that the player/s must survive in a cannibal and mutant monster infested forest. In dept the players who are military officers are hired by PuffCorp is dispatched to an island called "Site 2" to search for Edward Puffton (PuffCorp's founder and CEO), his wife Barbara, and his 20-year-old daughter Virginia, who have been missing for several months. In the beginning of the game the military officers (players) are in military helicopters flying over the forest and somehow end up crashing. Luckily, the player/s survive alongside their companion, Kelvin, a non-player character who is another military officer that lost his hearing and is unable to talk. 

In the journey to survival, the player/s and Kelvin must collect resources such as first aid kits, food, and any other material that needs to be collected to survive. I really enjoy this component because the collection of materials is not straight forward as it leads to challenges and critical thinking for the player to gather materials to build bigger shelters, require parts to make better weapons, and resources to make a good meal to survive. Aside from the scavenger and puzzle component, I really like the horror side of it since I am a fan of horror (not necessarily jump scare horror) but more of gore horror. I feel like the game producers did a really good job into modelling the cannibals and the monster mutants because they were not something you would see in any other horror game or film which was a nice surprise to it. In general, the story mission had a lot of plot twists which lead to some conspiracy theories and open discussions in the Sons of the Forest gaming community questioning the story’s meaning and plot. A couple of the topics was that Kelvin was a mutant (or at least becoming one) and that the daughter of the CEO, Virginia, became a mutant (which was another non-player character that can be befriended later in the game. What was interesting about Virginia is that there is no clear story behind the reasoning of her becoming a mutant or how she became one which led to an extension of theories. 

The Sons of the Forest is an excellent game if you are looking for survival games, but I find there was not many explanations to how and why the forest is infested, including some gaps that seemed to be missing in some plots (though it stirred some hot topics in the gaming community). I also found that the main mission to the game was quite short lived compared to longer games such as Elden Ring. I also found that the player/s’ could not run fast enough from advanced cannibals and mutants which was frustrating. Another issue was when taking hours to build a shelter or fort, it would quickly be destroyed by cannibals and mutants which was frustrating because why else would I be building a fort and shelter? It was also annoying when building a fence made of arrows or traps did not affect any of the cannibals and mutants; it was useless.

In the future, I plan to make survival games based on my Indigenous culture however, I would replace the mutants and cannibals with some fictional creatures from legends. I would expand the forest and make it as big as Elden Ring (which is quote large). In terms of techniques, I would borrow the methods of collecting materials to combine and build stuff like shelters and weapons; it requires some critical thinking and puzzle-making. 

## February 22, 2024
Shmup Mix Peer Feedback
- change the background for aesthethic purposes
- Add levels
- Fishy movement is cool when it collides with a garbage piece
- Game feels too easy (make levels to make it harder - maybe add a boss enemy/garbage?)
- Menu and instructions is a nice touch for new players!
- Add some sound!
- Maybe add a large net to ensure difficulty??
- Focus on the fishy's bullet (maybe add more variety of what he is shooting?)
- Fishy boundary is too soon
- Make the game longer (add more points required for winning)

## Design Journal - Final Game Design Ideas:
1) Girl in the red Coat
- Side-view
- 2D pixel game
- Similar to 'super mario' + shmup
The Mechanics: 
      - collecting sun rays = rare item that must be collected throughout levels 
      - collecting medicine plants = healing to fill health bar
      - collecting tools & weapons (arrows, rocks, sticks, rope) -> if collected, weapon is made then player can use to hunt animals (caribou, rabbit, ptarmigan) for "bonus" powerups to prepare for big boss (this should be thoroughly designed)
      - Getting hit by small enemies (must think & design about) = health bar decreases 
      - If enough items collected = gets to the "sun" (a diety that has knowledge + power) assigns the player to fight the boss
      - Fighting boss (darkness/evil) - this should be thoroughly designed = Winning game
  The Visuals:
  - Menu scene, Winning scene, losing scene, five levels???
Menu Scene: Title, about (for educational stuff to learn about game), Resume??
Winning Scene: Winning text, retry, small animation? 
Losing scene: Losing text, retry, go back to position of player's last scene/level 

Possible Design Goal Values:
- Experience
- Theme
- Point of View
- Challenge
- Decision Making
- Skill, Strategy, chance & uncertainty
- Context
- Emotion

Design Goal chosen (Stating a challenge): 
1. How to make a a video game to explore cultural values without the use of violence/shooting? 
2. How to not make shmup violent?
3. How to make a game that explores storytelling + culture?

HYBRID MIX!
shmup + super mario style -> current idea ^^^
nurse 
super hero 
librarian 
nature
healer
collector/gatherer
adventure 
shmup adventure 

Draft Notes from 'speed dating (gaming)' with peers (a mashup of ideas session): 
Skateboard - collecting knowledge of skateboard tricks (collecting different npc's = different outcomes that either increase/decrease your chances of winning) <REMIX!> Indigenous Super Hero - collecting elements of knowledge of cultural stuff (depending how much you/what you collect = different outcomes that either increase/decrease your chances of winning) 

Prototype Idea #1
Deck of cards (blank cards) - collecting game
* Cards are split based on the elements of the game (medicine/plants, (rocks, sticks, rope to make weapon = hunting traditional food), language, clothes, and sun-rays.
* Find a way to play the game with cards' prototype

Prototype Idea #2
Visual Cards - puzzle game 
Character state: strength low (10%), no knowledge = no strength, if no strength = can't fight monster
Key Factors: collect items that make more items that lead to strengthing + power to defeat the boss

What the character stats looks like:
Mind 
Body 
Spirit
Knowledge 

* Main elements to build on:
1) Labrador plant + water = Medicinal tea for the body - health up (2%-5%) 
2) Cedar + water = medicinal tea for the mind - health up (2%-5%)
3) Sage + sacred fire = medicinal smudge for spirit - health up (2%-5%)
4) Sacred Fire (rare item) = 10-20 collected - knowledge up (2%-5%) + cut scene of meeting with the sun deity

The challenge:
* Balance between how much yopu have and what you can make. If there is an imbalance, the chances of beating the monster is none to very little.

Prototype Idea #3
Visual Cards - Adventure + SHMUP
* Similar to Prototype Idea #2 but with more action + more stuff 

Main Elements that changed
1) Collecting things but without having to make something out of it but to collect it for health/power-ups (eg: Super Mario with coins)
2) Being able to hunt and eat wild animals for powerups (could be gory to some people due to cultural differences & triggers)
3) A narrative/shmup/adventure game 

## Conceptualizing
Description: The concept consisted of a paper prototype to ensure that the methods/process of gameplay was efficient and fun for my peers to experiment. In this stage, it was also meant to capture the game's motives and emotional feel of the game's aesthetics of cultural knowledge. The game consisted a variety of cards which were carried out through elements that players must collect which were: 
- Rocks + sticks = making an arrow
- Arrow + caribou = making a Naskapi (Indigenous) hunter's clothing
- Water + cedar = medicinal tea (healing element)
- Water + labrador = medicinal tea (healing element)
- Fire + sage = medicinal smudge (healing element) 
- Green disease = enemy (non-healing element) 

The Goal: The player must collect from the pile of cards (hopwever must not collect an item more than once). If they get 'hit' by a green disease 3x, they lose however they have chances to get rid of the green disease if they run into medicinal plants (cedar, sage, labrador) with their assigned alements like either fire or water. Throughout gameplay, their end-goal is to collect the Naskapi hunter's coat through collecting the other elements (rocks, sticks, then caribou). 

Feedback from peers & What I learned: 
- A great game to teach culture!
- There should be more options to do with the fire elements
- Find more options/elements to make it more challenging
- Add levels
- Add some scenes? -> this would be nice but I am focusing more on interactivity (should scenes be part of the experience?) 
- Maybe make this into a card game? -> The reason I chose this to be a card/paper prototype was to have the player FEEL the critical thinking behind the material/element collecting component of the game (My main goal is to make this into a Super Mario 2D side scroller/collecting game!)

The Next Steps:
1. Make the objects collectible in Unity by the protogonist (Wapino)
2. Begin some interactivity & think about how to implement health and damage points with the elements collected/hit
3. Think how to make it challenging & adding levels
4. Main Focus: Start implementing the visuals (some pixel art & minimal interactivity in Unity)

![prototype1](https://github.com/DestinyChescappio/CART-315/assets/90113915/c3639d4e-75dc-4b86-a459-9ad9df6cb548)

## Prototype: Stage 01
Description: This stage would be focused on the look/feel aspect of the prototype stage as I focused on the appearance of the game and how it would look like in Unity. At this stage, I had the protogonist semi-functional with some movements. The Girl in the Red Coat is a game that is about collecting knowledge and avoiding colonialism. 

Goal: The  player plays the protogonist (Wapino) and must run away from the floating green disease (colonialism) and is on a mission to find herself and especially find her ways of cultural traditions in medicine, hunting, and traditional clothing. Based from the Naskapi Nation's cultural values, the game's goals is to encounter stages in this mission which are critical thinking collection processes (for example: if wapino gets hit by the disease, she must collect medicinal plants and its coordinating elements such as fire or water in order to heal), she then encounters other elements such as stones, sticks, to help build traditional tools and eventually has to hunt a caribou in order to get to the "final boss" that leads her to the Naskapi coat made out of caribou hide. 

The Questions I have to consider?
- Is this cultural significant and reflect on the character's story? Yes. Wapino has been an ongoing project I developed a few years ago with character design, concept design, environmental design, etc.
- Did this successfully turn into a 2D pixel interactive video game as intended compared to the conceptualization? Yes. However I adjusted some functions and methods of the game such as changing the character's abilities and functionality. There is much more needed to do.
- Did the storyline and method of gameplay change? No. My initial goal is to establish a cultural plot of collecting knowledge while maintaining critical thinking involved with the player.

What I learned:
- There is a lot of implementation of behavior scripts. Can I show only a part of interacting with one of the elements instead of all? I have many plants, I have fire/water objects, caribou, arrows, rocks, sticks, etc. Which is A LOT!
- This 2D side scroller game can be more than one type of game. It could be a mix of shmup, super mario, and puzzle game!
- There should be more options of usage with some elements (maybe some shooting behaviors for the player?)

Next Steps:
1. Begin more complex implementation like camera movement, enemy behaviors, collisions, etc.
2. Consider if the collisions with ALL elements are neccessary OR showing one example with a object is ok?
3. Add a health bar! 
4. Add some cut scenes? is this neccessary for a prototype?
5. How much work is too much for a prototype? Think about this.

<img width="1440" alt="Screenshot 2024-03-28 at 2 56 50 PM" src="https://github.com/DestinyChescappio/CART-315/assets/90113915/6d2eb100-019f-43b1-a277-cbe617f9b795">

## Prototype: Stage 02
Description: This stage would be focused on implementation prototype as I focused on the functionality of the game and not fully completing it. I find this stage takes time with moving forward to the final stages of completion. Wapino (player) can move, jump, and die by falling past a certain point. Camera follows Wapino's movements. Health bar is built but not functional yet! The enemy is the other major component that is functional in terms of behavior. Enemy is able to float and follow wapino. There is also collision but no visual interaction besides it showing in the console. Wapino can collide with plants (how to not make wapino not "move" these?) Concept and theme remain the same. Technological and functional stuff is heavy duty in this one! 

Goal: The goals remain the same as the last two entries. Nothing changed :) EXCEPT... the enemy bevahvior. Though I aimed for a moving enemy continuosly moving across the x axis, I had the enemy follow the player. This is important to know because I added more concept to the enemy instead of the old idea of a "shmup" enemy moving without a sense of direction. This would be a good base of understanding that the game is mix combination of shmup/super-mario/puzzle/adventure game! 

The Questions I have to consider?
- I considered the initial conceptualization of combining various game themes/methods into one for my final game idea. Pretty cool :)
- How to make Wapino not "move" the plants/elements?
- I'm thinking about having the enemy shoot bullets? is it too much since it's already following player?

Next Steps: 
1. Connect health bar to wapino + enemy collisions
2. Connect health bar to wapino + plants/elements (example: if wapino collides with lab tea + water = health goes up)
3. Make fire + sage = health up but ALSO make fire collectable and its amount collected showed on a score? Hmmm...
4. Make speed of enemy faster after each level (make 3 levels just to show "samples" since this is a prototype...)
5. Add a timer to game so Wapino must collect this many fire objects + eventually kill enemy (enemy must have a health bar as well??) 

<img width="1440" alt="Screenshot 2024-03-29 at 6 12 41 PM" src="https://github.com/DestinyChescappio/CART-315/assets/90113915/8216d1db-24ef-420e-a288-dbb1ee5d4b9a">

