// Which NPC essences has the siren taken?
VAR essence_loremaster = false

// Which songs has the siren learned?
VAR song_shipwrecking = true
VAR song_hope = false
VAR song_disgust = false


// Which trinkets has the siren received?
VAR trinket_day_three = false
VAR trinket_day_four = false

// Loremaster story variables
VAR teeth_done = false
VAR away_done = false


-> loremaster

=== loremaster ===
You smell her first, on the wind. Human smells. Sweat. Smoke. Fat. <i>Rancid</i>. # narration
* [Watch him approach]
    -> loremaster_approach
    
= loremaster_approach
Footsteps, clumsy on rock and sand. Horrible ungainly creature. <i>Closer, closer, come into the water</i>. 
But the song is done. Your voice is gone. She stops when the surf washes over her boots and looks at you. Then shifts her gaze to the village above. #narration
* [Watch her warily]
    -> loremaster_reflects

= loremaster_reflects
"It's all beautiful, isn't it? Our home. Our people." # loremaster
* [Stare at her]
    -> siren_stares
    
= siren_stares
The hunger claws at your own belly. The crabs and silver fishes sustain you, but it's never enough. The hole inside is always there. Seeing her, it grows deeper.

Come into the water. <i>Come into the water. <b>Come into the water.</b></i>

She glances back at you. # narration
* [Continue staring]
->loremaster_beauty

= loremaster_beauty
"Well, perhaps not everything can be beautiful. But the town is flourishing now. Thanks to you. To me."  # loremaster
* [Glare at her]
    -> loremaster_praise
* [Look away]
    -> loremaster_bashful

= loremaster_bashful
    "Now now, don't be bashful." A pause. <> # loremaster 
    -> loremaster_praise
    
= loremaster_praise
"I mean it. Truly, I do. This is our doing. Without you, our people would have starved. Our homes would have collapsed. And without me, well... # loremaster
* [Stare at her]
    "Let's <> # loremaster
* [Show your sharp teeth]
    "And without her too, of course. You're absolutely correct. Ultimately it's all her doing. But let's <> # loremaster

- just say the future looks bright now. The old ways are best way forward." # loremaster
-> loremaster_choice

=== loremaster_choice ===
* {teeth_done == false}[Bare your teeth at her] 
    -> siren_lore_teeth 
* {away_done == false}[Look away] 
    -> siren_lore_away 
* {teeth_done == true && away_done == true}[Sing] 
    -> loremaster_song

= siren_lore_teeth
Her blood would be hot and red, like a porpoise. Sickly, though, like the other ones, from the outside, who come when you call. # narrator
* [Next]
    -> lorekeeper_enthused

= lorekeeper_enthused
~ teeth_done = true
"Yes! Exactly! The outsiders' blood will water our lands and their machines refresh the bones of our town." # loremaster

-> loremaster_choice

= siren_lore_away
A new scent on the night wind. Warm. Clean. Familiar. And then gone. # narrator
* [Look back at the human]
-> loremaster_bones

=loremaster_bones
~ away_done = true
    "You know it's true. You must feel it in your bones now." # loremaster
    -> loremaster_choice

    
=== loremaster_song ===
You feel it welling back up from deep within you. Opening your mouth, the song pours forth. # narrator
* [Sing]
-> loremaster_afraid

= loremaster_afraid
"Wait, what are you-" # loremaster # minigame
// call song minigame here
~ essence_loremaster = true

-> siren_sated_lore

= siren_sated_lore
The colour drains from her face and into your hands, filling you with a deep satisfaction. She turns and runs, stumbling in her haste to escape.

You ignore her, and gaze upon the new orb in your hands. # narrator

* [Admire prize]



-> witch_day_four

=== witch_day_four ===

= witch_approach_day_4
You sense movement on the beach behind you. Glancing over your shoulder, you see the Witch steadily approaching the shoreline. With a sour hiss, you shift your scaled body further down the far side of the rock, warily peering at her through a small gap. # narration

* [Next]
    -> witch_approach_day_4_part2
    
= witch_approach_day_4_part2
She stops at the shoreline, looking in your direction with an unreadable expression on her beautiful face. She pulls a small, shiny object from her pocket, holding it to her heart as she begins to sing a tenuous melody, different from the previous day. # narration

* [Listen]

-> witch_song_day_4

= witch_song_day_4
"I’ll sing until the stars align,
And bring her back, forever mine." #witch

* [Next]
    -> witch_leaves_day_4
    
= witch_leaves_day_4
Upon finishing her brief song, the Witch leans down and gently places the item on a flat rock at the edge of the water. As she stands up, she looks in your direction once more. With a big sigh, she turns away and heads back to the village. # narration

* [Retreive item]
// add necklace trinket
~ trinket_day_four = true
# witch_song
~ song_disgust = true


-> END