// Easy (medium) Exercise
// Discriminated unions
// Using types and handling string and lists

module KindergartenGarden

// define the Plant type
type Plant = | Clover | Grass | Radishes | Violets

// transform letter to plant type
let letterToPlant letter = 
    match letter with
    | "C" -> Plant.Clover
    | "G" -> Plant.Grass
    | "R" -> Plant.Radishes
    | "V" -> Plant.Violets
    | _ -> failwith "Unknown plant"

// array with students position
let students = 
    ["Alice"; "Bob"; "Charlie"; "David";
    "Eve"; "Fred"; "Ginny"; "Harriet";
    "Ileana"; "Joseph"; "Kincaid"; "Larry"]

// finds students plants
let plants (diagram: string) student =
    let s = diagram.IndexOf("\n")
    let row1 = diagram.Substring(0,s)
    let row2 = diagram.Substring(s).Trim()

    let i = List.findIndex(fun s -> s = student) students
    let p1 = letterToPlant (row1.Substring(i*2,1))
    let p2 = letterToPlant (row1.Substring(i*2+1,1))
    let p3 = letterToPlant (row2.Substring(i*2,1))
    let p4 = letterToPlant (row2.Substring(i*2+1,1))
    let l = [p1;p2;p3;p4]
    l
    
   
plants "RC\nGG" "Alice"
(* plants "VVCG\nVVRC" "Bob" *)