// Introductory Exercise
// Discriminated Unions
// Making types (discriminated unions) and using them in pattern-matching

module ValentinesDay

// TODO: please define the 'Approval' discriminated union type
type Approval = 
    | Yes
    | No
    | Maybe

// TODO: please define the 'Cuisine' discriminated union type
type Cuisine = 
    | Korean
    | Turkish

// TODO: please define the 'Genre' discriminated union type
type Genre = 
    | Crime
    | Horror
    | Romance
    | Thriller

// TODO: please define the 'Activity' discriminated union type
type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int

let rateActivity (activity: Activity): Approval =
    match activity with
    | Movie(Romance) -> Yes
    | Restaurant(Korean) -> Yes
    | Restaurant(Turkish) -> Maybe
    | Walk(int) when int < 3 -> Yes
    | Walk(int) when int < 5 && int >= 3 -> Maybe
    | _ -> No
