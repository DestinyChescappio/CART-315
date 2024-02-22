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
