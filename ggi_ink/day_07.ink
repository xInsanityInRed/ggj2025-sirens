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

-> DONE