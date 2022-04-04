// Introductory Exercise
// Floating point numbers 
// Using different floating point number (decimal, single, float) and converting between types

module InterestIsInteresting
let interestRate (balance: decimal): single =
    match balance with 
    | balance when balance < 0m -> 3.213f
    | balance when balance >= 0m && balance < 1000m -> 0.5f
    | balance when balance >= 1000m && balance < 5000m -> 1.621f
    | balance when balance >= 5000m -> 2.475f 
    | _ -> failwith "invalid input"

let interest (balance: decimal): decimal = 
    let rate = interestRate balance
    let rateDec = decimal(rate)
    balance*(rateDec/100m)

let annualBalanceUpdate(balance: decimal): decimal =
   let interest = interest balance
   balance+interest

let amountToDonate(balance: decimal) (taxFreePercentage: float): int =
    let taxFree = decimal(taxFreePercentage)
    let res = (balance*(taxFree/100.0m))*2.0m
    let result = int(res)
    if balance >= 0.0m then result else 0