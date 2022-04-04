// Introductory Exercise
// Numbers & if-then-else expressions
// Simple calculations, pattern-matching and converting between types

module CarsAssemble

let successRate (speed: int): float = 
    match speed with 
    | 0 -> 0.0
    | speed when speed > 0 && speed <= 4 -> 1.0
    | speed when speed > 4 && speed <= 8 -> 0.9
    | 9 -> 0.8
    | 10 -> 0.77
    | _ -> failwith "invalid input"

let productionRatePerHour (speed: int): float = 
    let succes = successRate speed
    let speedFloat = float(speed)
    (speedFloat*221.0)*succes

let workingItemsPerMinute (speed: int): int =
    let carsHour = productionRatePerHour speed
    let carsHourInt = int(carsHour)
    let carsMinute = carsHourInt/60
    carsMinute