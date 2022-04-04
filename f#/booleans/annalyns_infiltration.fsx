// Introductory Exercise
// Booleans practice 
// Usage of different boolean operators and if-then-else

module AnnalynsInfiltration

let canFastAttack (knightIsAwake: bool): bool = if knightIsAwake then false else true

let canSpy (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    if knightIsAwake || archerIsAwake || prisonerIsAwake then true else false

let canSignalPrisoner (archerIsAwake: bool) (prisonerIsAwake: bool): bool =
    if prisonerIsAwake && not archerIsAwake then true else false

let canFreePrisoner (knightIsAwake: bool) (archerIsAwake: bool) (prisonerIsAwake: bool) (petDogIsPresent: bool): bool =
    if not knightIsAwake && not archerIsAwake && petDogIsPresent then true
    elif not knightIsAwake && not archerIsAwake && prisonerIsAwake then true
    elif knightIsAwake && not archerIsAwake && not prisonerIsAwake && petDogIsPresent then true
    elif knightIsAwake && not archerIsAwake && prisonerIsAwake && petDogIsPresent then true
    else false