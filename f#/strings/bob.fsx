// Easy (medium) Exercise
// Strings
// Working on how you can check each character of a string

module Bob
open System

let isUpper sentence = 
    if String.exists Char.IsLetter sentence then 
        let f = String.filter Char.IsLetter sentence 
        String.forall Char.IsUpper f else false
 
let isSilence sentence = 
    if String.exists Char.IsLetter sentence || String.exists Char.IsNumber sentence then false else true

let response (input: string): string =
    let tu = input.ToUpper() 
    match input with
    | input when input.Trim().EndsWith("?") && isUpper input -> "Calm down, I know what I'm doing!"
    | input when input.Trim().EndsWith("?") -> "Sure."
    | input when isSilence input -> "Fine. Be that way!"
    | input when isUpper input -> "Whoa, chill out!"
    | _ -> "Whatever."
    
    
response "How are you?" 
response "HOW ARE YOU" 
response "HOW ARE YOU?"
response "    "
response "1, 2, 3"
