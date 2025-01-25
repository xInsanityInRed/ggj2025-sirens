=== day_06_main ===
* [start villageelder]
    -> villageelder

=== villageelder ===
# location: beach
Dialogue here. # villageelder
* [Stare at him]
    ... # siren
    -> villageelder_01
* [Growl at him]
    ... # siren
    -> villageelder_01

= villageelder_01
Dialogue here. # villageelder

* [Stare at him]
    ... # siren
    -> villageelder_02
* [Growl at him]
    ... # siren
    -> villageelder_02
    
= villageelder_02
Dialogue here. # villageelder

* [Stare at him]
    ... # siren
    -> villageelder_03
* [Growl at him]
    ... # siren
    -> villageelder_03

= villageelder_03
Dialogue here. # villageelder

* [Stare at him]
    ... # siren
    -> villageelder_04
* [Growl at him]
    ... # siren
    -> villageelder_04
    
= villageelder_04
Dialogue here. # villageelder

-> elder_song

=== elder_song ===
// call song minigame here
~ essence_elder = true

-> witch_day_six

=== witch_day_six ===
# location: beach

I've brought you a trinket.
// add new trinket
~ trinket_day_six = true
// call new witch song
~ song_boredom = true

Placeholder for witch song.

->->