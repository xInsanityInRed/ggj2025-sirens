-> loremaster

=== loremaster ===
You smell him first, on the wind. Human smells. Sweat. Smoke. Fat. <i>Rancid</i>. # narration
* [Watch him approach]
    -> loremaster_approach
    
= loremaster_approach
Footsteps, clumsy on rock and sand. Horrible ungainly creature. <i>Closer, closer, come into the water</i>. 
But the song is done. Your voice is gone. And he stops when the surf washes over his boots. Looks at you. then away. #narration
* [Stare at him]
    -> loremaster_reflects

= loremaster_reflects
"It's all beautiful, isn't it? Our home. Our people." # loremaster
* [Watch him]
    -> siren_stares
    
= siren_stares
The hunger claws at your own belly. The crabs and silver fishes sustain you, but it's never enough. The hole inside is always there. Seeing him makes it deepen.

Come into the water. <i>Come into the water. <b>Come into the water.</b># narration
* [Continue staring]
->loremaster_beauty

= loremaster_beauty
"Well, perhaps not everything can be beautiful. But the town is flourishing now. Thanks to you. To me."  # loremaster
* [Stare at him]
    -> loremaster_praise
* [Look away]
    -> loremaster_bashful

= loremaster_bashful
    "Now now, don't be bashful." A pause. <> # loremaster 
    -> loremaster_praise
    
= loremaster_praise
"I mean it. Truly, I do. This is our doing. Without you, our people would have starved. Our homes would have collapsed. And without me, well... # loremaster
* [Stare at him]  # siren
    "Let's <> # loremaster
* [Show your sharp teeth]  # siren
    "And without her too, of course. You're absolutely correct. Ultimately it's all her doing. But let's <> # loremaster

- just say the future looks bright now. The old ways are best way forward." # loremaster
-> loremaster_choice

=== loremaster_choice ===
* [Bare your teeth at him] {teeth_done == false}
    -> siren_lore_teeth 
* [Look away] {away_done == false}
    -> siren_lore_away 
* [Sing] {teeth_done == true && away_done == true}
    -> loremaster_song

= siren_lore_teeth
His blood would be hot and red, like a porpoise. Sickly, though, like the other ones who come when you call. # narrator
* [<i>Come into the water</i>]
    -> lorekeeper_enthused

= lorekeeper_enthused
"Yes! Exactly! The outsiders' blood will water our lands and their machines refresh the bones of our town." # loremaster
~ teeth_done = true
-> loremaster_choice

= siren_lore_away
A new scent on the night wind. Warm. Clean. Familiar. And then gone. # narrator
-> loremaster_bones

=loremaster_bones
    "You know it's true. You must feel it in your bones now." # loremaster
~ away_done = true
    -> loremaster_choice

    
=== loremaster_song ===
You feel it welling back up from deep within you. Opening your mouth, the song pours forth. # narrator
* [Sing]
-> loremaster_afraid

= loremaster_afraid
"Wait, what are you-" # loremaster
// call song minigame here
~ essence_loremaster = true

-> siren_sated_lore

= siren_sated_lore
The colour drains from his face and into your hands, filling you with a deep satisfaction. He turns and runs, stumbling in his haste to escape.

You ignore him, and take your new prize home to admire. # narrator

* [Go home.]



-> witch_day_four

=== witch_day_four ===

I've brought you a trinket. #witch
// add new trinket
~ trinket_day_four = true
// call new witch song
~ song_disgust = true

Placeholder for witch song. #witch

-> END