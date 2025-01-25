=== day_07_main ===
* [start child]
    -> child

=== child ===
# location: beach
Dialogue here. # child
* [Stare at him]
    ... # siren
    -> child_01
* [Growl at him]
    ... # siren
    -> child_01

= child_01
Dialogue here. # child

* [Stare at him]
    ... # siren
    -> child_02
* [Growl at him]
    ... # siren
    -> child_02
    
= child_02
Dialogue here. # child

* [Stare at him]
    ... # siren
    -> child_03
* [Growl at him]
    ... # siren
    -> child_03

= child_03
Dialogue here. # child

* [Stare at him]
    ... # siren
    -> child_04
* [Growl at him]
    ... # siren
    -> child_04
    
= child_04
Dialogue here. # child

-> child_song

=== child_song ===
// call song minigame here
~ essence_child = true

-> witch_day_seven

=== witch_day_seven ===
# location: beach

I've brought you a trinket.
// add new trinket
~ trinket_day_seven = true
// call new witch song
~ song_surprise = true

Placeholder for witch song words.

->->