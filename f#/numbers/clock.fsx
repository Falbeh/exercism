// Easy Exercise
// Numbers
// using sprintf and modulo - not the prettiest solution

module Clock

let create hours minutes =
    // finding hour and minutes checking if input is negative 
    let hour = 
        match hours with 
        | h when h < 0 && minutes < 0 -> 24+((((minutes-59)/60)+hours)%24)
        | h when h < 0 && minutes >= 0 -> if ((((minutes)/60)+hours)%24) = 0 then ((((minutes)/60)+hours)%24) else 24+((((minutes)/60)+hours)%24)
        | h when h >= 0 && minutes >= 0 -> (hours + (minutes / 60))%24
        | _ -> if ((((minutes-59)/60)+hours)%24) < 0 then ((((minutes-59)/60)+hours)%24)+24 else ((((minutes-59)/60)+hours)%24)
    let minute = 
        match minutes with 
        | m when m < 0 -> if (minutes % 60) = 0 then (minutes % 60) else (minutes % 60)+60
        | _ ->  minutes % 60
    // Creating clock using the internal string buffer sprintf 
    sprintf "%02i:%02i" hour minute

create 2 -60

// -1+()

// Adding minutes using by calling create method
let add minutes (clock: string) = 
    let minute = int(clock.Substring(3,2))
    let hour = int(clock.Substring(0,2))
    let updateMin = minute+minutes
    create hour updateMin

// Subtracting minutes by calling create method
let subtract minutes (clock: string) = 
    let minute = int(clock.Substring(3,2))
    let hour = int(clock.Substring(0,2))
    let updateMin = minute-minutes
    create hour updateMin

// Displaying clock
let display clock = clock
