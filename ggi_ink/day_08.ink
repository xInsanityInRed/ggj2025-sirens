=== day_08_main ===
* [start himbo]
    -> himbo

=== himbo ===
# location: beach
Dialogue here. # himbo
* [Stare at him]
    ... # siren
    -> himbo_01
* [Growl at him]
    ... # siren
    -> himbo_01

= himbo_01
Dialogue here. # himbo

* [Stare at him]
    ... # siren
    -> himbo_02
* [Growl at him]
    ... # siren
    -> himbo_02
    
= himbo_02
Dialogue here. # himbo

* [Stare at him]
    ... # siren
    -> himbo_03
* [Growl at him]
    ... # siren
    -> himbo_03

= himbo_03
Dialogue here. # himbo

* [Stare at him]
    ... # siren
    -> himbo_04
* [Growl at him]
    ... # siren
    -> himbo_04
    
= himbo_04
Dialogue here. # himbo

-> child_song

=== himbo_song ===
// call song minigame here
~ essence_himbo = true

-> witch_day_eight

=== witch_day_eight ===
# location: beach

I've brought you a trinket.
// add new trinket
~ trinket_day_eight = true
// call new witch song
~ song_surprise = true

Placeholder for witch song words.

->->