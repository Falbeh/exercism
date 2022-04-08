// Medium Exercise
// Numbers / unknown category
// Tail-recursive function finding divisors - putting into list and reversing list in the end 

module PrimeFactors

let factors (number: int64) = 
    let rec loop (number: int64) (divisor: int64) acc = 
        let div = int(divisor)
        match number with
        | 1L -> List.rev acc
        | _ when number % divisor = 0 -> loop (number/divisor) divisor ((div)::acc)
        | _ when number % divisor <> 0 -> loop number (divisor+1L) acc 
        | _ -> failwith "invalid input"
    loop number 2L [] 

factors 973475L