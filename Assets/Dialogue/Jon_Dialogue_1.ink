Good Day Traveler, how may I help you?

 * Hi, I'm a traveling bard. #speaker: Bard
 ->continue 
 * Nothing, sorry to bother you. #speaker: Bard
 ->No

===continue===
 - Oh, a bard you say? Well, you're more than welcome here. My name is Jon, I own the place. #speaker: Jon
 - The stage is over there when you're ready to play some music, but feel free to mingle. The night is young, and the people here are very friendly.
+ What's with that sword up there? #speaker: Bard
->Denial
+Tell me about the place.#speaker: Bard
->TheTown 

+ How's the Tavern doing? #speaker: Bard
<<<<<<< Updated upstream
->BlueAle

===BlueAle===
- It's doing quite well at the moment, the only real problem is that I'm low on Blue Ale at the moment and haven't got anymore here. #speaker: Jon
-I've got some out in storge, but I can't leave the bar unattended, and my niece has had too many drinks to get it for me. #speaker: Jon

+ What's with that sword up there? #speaker: Bard
->Denial
+Tell me about the place.#speaker: Bard
->TheTown 
*Im sorry to hear that, talk to you later #speaker: Bard
=======
- It's doing quite well at the moment, the only real problem is that I'm low on Blue Ale at the moment and haven't got anymore here. #speaker: Jon
-I've got some out in storge, but I can't leave the bar unattended, and my niece has had too many drinks to get it for me. #speaker: Jon
>>>>>>> Stashed changes
->END

=== No ===
-No trouble, have a nice evening. #speaker: Jon
->END

===TheTown===
<<<<<<< Updated upstream
There isn't much to say really. The town is rather small, it barely has a name, but there are some intresting characters about. #speaker: enjoying
-I'd love to keep talking but I have customers to serve. Is there anything else? #speaker: Jon
+ How's the Tavern doing? #speaker: Bard
->BlueAle
+ What's with that sword up there? #speaker: Bard
->Denial
* Ok thank you.#speaker: Bard
->END

=== Denial ===
Nothing, it's just an old relic I keep around. If thats all enjoy the rest of your evening, Bard. #speaker: Jon
-Actually... #speaker: Bard
+Could you tell me about the place.#speaker: Bard
->TheTown 
+ How's the Tavern doing? #speaker: Bard
->BlueAle
*You too.#speaker: Bard
=======
There isn't much to say really. The town is rather small, it barely has a name, but there are some intresting characters about. Sorry, I'd love to keep talking but I have customers to serve. #speaker: Jon
->END

=== Denial ===
Nothing, it's just an old relic I keep around. Enjoy the rest of your evening, Bard. #speaker: Jon
>>>>>>> Stashed changes
->END

    
