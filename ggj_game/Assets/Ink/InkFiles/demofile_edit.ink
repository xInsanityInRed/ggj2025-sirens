VAR essence_loremaster = false
VAR song_hope = true
VAR song_disgust = false
VAR trinket_one = false

-> loremaster

=== loremaster ===
# location: beach
It's all beautiful, isn't it? Our home. Our people. # loremaster
* [Stare at him] #siren
    ... #siren
    -> loremaster_01

= loremaster_01
Well, perhaps not everything can be beautiful. But the town is flourishing now. Thanks to you. To me.  # loremaster

* [Stare at him]... #siren
    ... #siren
    -> loremaster_02
* [Look away]
    ... #siren
    Now now, don't be bashful. # loremaster 
    -> loremaster_02
    
= loremaster_02
I mean it. Truly, I do. This is our doing. Without you, our people would have starved. Our homes would have collapsed. And without me, well... # loremaster

* [Stare at him]  # siren
    ... #siren
    -> loremaster_04
* [Bare your teeth at him]  # siren
    ... #siren
    -> loremaster_03

= loremaster_03
And without her too, of course. You're absolutely correct. Ultimately it's all her doing.  # loremaster
-> loremaster_04

= loremaster_04
Let's just say the future looks bright now. The old ways are best way forward. # loremaster
* [Bare your teeth at him]  # siren
    ... #siren
      Yes! Exactly! The outsiders' blood will water our lands and their machines refresh our town.# loremaster
      -> loremaster_04
* [Look away]  #siren
    ... #siren
    -> loremaster_04
    You know it's true. You must feel it in your bones now.   #loremaster
* [Sing] #siren
    -> loremaster_song
    
=== loremaster_song ===
Wait, what are you-
// call song minigame here

// now holds the bubble for the loremaster
~ essence_loremaster = true

-> witch_day_four

=== witch_day_four ===
I've brought you a trinket.
~ trinket_one = true
// call new witch song
~ song_disgust = true

Placeholder for witch song lyrics.

-> END