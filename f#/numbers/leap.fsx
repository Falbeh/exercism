// Easy Exercise
// Numbers
// Pattern matching and logic 

module Leap

let leapYear (year: int): bool = 
    match year with 
    | y when y % 400 = 0 -> true
    | y when y % 100 = 0 -> false
    | y when y % 4 = 0 -> true
    | _ -> false

leapYear 1996
leapYear 2000
(* 
on every year that is evenly divisible by 4
  except every year that is evenly divisible by 100
    unless the year is also evenly divisible by 400 *)