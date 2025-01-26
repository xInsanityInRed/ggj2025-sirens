=== day_05_main ===
* [start fisherman]
    -> fisherman

=== fisherman ===
# location: beach
Hmph. What a vile creature you are. # fisherman
* [Growl at him]  # siren
    ... # siren
    -> fisherman_01
* [His at him]  # siren
    ... # siren
    -> fisherman_01

= fisherman_01
Dialogue here. # fisherman

* [Stare at him]  # siren
    ... # siren
    -> fisherman_02
* [Growl at him]  # siren
    ... # siren
    -> fisherman_02
    
= fisherman_02
Dialogue here. # fisherman

* [Stare at him]  # siren
    ... # siren
    -> fisherman_03
* [Growl at him]  # siren
    ... # siren
    -> fisherman_03

= fisherman_03
Dialogue here. # fisherman

* [Stare at him]  # siren
    ... # siren
    -> fisherman_04
* [Growl at him]  # siren
    ... # siren
    -> fisherman_04
    
= fisherman_04
Dialogue here. # fisherman

-> fisherman_song

=== fisherman_song ===
// call song minigame here
~ essence_loremaster = true

-> witch_day_five

=== witch_day_five ===
# location: beach

I've brought you a trinket.
// add new trinket
~ trinket_day_five = true
// call new witch song
~ song_anger = true

Placeholder for witch song.

->->
