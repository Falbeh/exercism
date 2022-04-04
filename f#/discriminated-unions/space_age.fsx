// Easy Exercise
// Discriminated unions 
// Using type (discriminated unions), pattern-matching, and rounding to two decimals on floats

// Define the Planet type
type Planet = 
    | Earth
    | Mercury
    | Venus
    | Mars
    | Jupiter
    | Saturn
    | Uranus
    | Neptune

// Calculate age on different planets based on Earth seconds
let age (planet: Planet) (seconds: int64): float =
    let earthYearInSeconds = 31557600.0
    let sec = float(seconds) 
    let earthAge = sec/earthYearInSeconds 
    match planet with
    | Earth -> System.Math.Round((earthAge),2)
    | Mercury -> System.Math.Round((earthAge/0.2408467),2)
    | Venus -> System.Math.Round((earthAge/0.61519726),2)
    | Mars -> System.Math.Round((earthAge/1.8808158),2)
    | Jupiter -> System.Math.Round((earthAge/11.862615),2)
    | Saturn -> System.Math.Round((earthAge/29.447498),2)
    | Uranus -> System.Math.Round((earthAge/84.016846),2)
    | Neptune -> System.Math.Round((earthAge/164.79132),2)

age Earth 1000000000L // 31.69
age Mercury 2134835688L // 280.88
age Venus 189839836L // 9.78
age Mars 2129871239L // 35.88
age Jupiter 901876382L // 2.41
age Saturn 2000000000L // 2.15
age Uranus 1210123456L // 0.46
age Neptune 1821023456L // 0.35


