=== day_09_main ===
* [start drunk]
    -> drunk

=== drunk ===
# location: beach
Dialogue here. # drunk
* [Stare at him]
    ... # siren
    -> drunk_01
* [Growl at him]
    ... # siren
    -> drunk_01

= drunk_01
Dialogue here. # drunk

* [Stare at him]
    ... # siren
    -> drunk_02
* [Growl at him]
    ... # siren
    -> drunk_02
    
= drunk_02
Dialogue here. # drunk

* [Stare at him]
    ... # siren
    -> drunk_03
* [Growl at him]
    ... # siren
    -> drunk_03

= drunk_03
Dialogue here. # drunk

* [Stare at him]
    ... # siren
    -> drunk_04
* [Growl at him]
    ... # siren
    -> drunk_04
    
= drunk_04
Dialogue here. # drunk

-> drunk_song

=== drunk_song ===
// call song minigame here
~ essence_drunk = true

-> witch_day_nine

=== witch_day_nine ===
# location: beach

I've brought you a trinket.
// add new trinket
~ trinket_day_nine = true
// reprise song of hope



->->