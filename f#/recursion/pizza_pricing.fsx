// Introductory Exercise
// Recursion
// Pattern mathcing with types and recursion - not the prettiest solution

module PizzaPricing

// TODO: please define the 'Pizza' discriminated union type
type Pizza = 
    | Margherita
    | Caprese
    | Formaggio
    | ExtraSauce of Pizza
    | ExtraToppings of Pizza

let rec pizzaPrice (pizza: Pizza): int = 
    match pizza with
    | Margherita -> 7
    | Caprese -> 9
    | Formaggio -> 10
    | ExtraSauce(Margherita) -> 1 + pizzaPrice Margherita
    | ExtraSauce(Caprese) -> 1 + pizzaPrice Caprese
    | ExtraSauce(Formaggio) -> 1 + pizzaPrice Formaggio
    | ExtraSauce(ExtraToppings(Margherita)) -> 1 + pizzaPrice (ExtraToppings(Margherita))
    | ExtraSauce(ExtraToppings(Caprese)) -> 1 + pizzaPrice (ExtraToppings(Caprese))
    | ExtraSauce(ExtraToppings(Formaggio)) -> 1 + pizzaPrice (ExtraToppings(Formaggio))
    | ExtraToppings(ExtraSauce(Margherita)) -> 2 + pizzaPrice (ExtraSauce(Formaggio))
    | ExtraToppings(ExtraSauce(Caprese)) -> 2 + pizzaPrice (ExtraSauce(Formaggio))
    | ExtraToppings(ExtraSauce(Formaggio)) -> 2 + pizzaPrice (ExtraSauce(Formaggio))
    | ExtraToppings(Margherita) -> 9
    | ExtraToppings(Caprese) -> 11
    | ExtraToppings(Formaggio) -> 12
    | _ -> failwith "invalid input"

pizzaPrice Caprese 


let orderPrice(pizzas: Pizza list): int = 
    let rec loop (pizzas: Pizza list) acc c =
        match pizzas with 
        | [] -> if c = 1 then acc+3 elif c = 2 then acc+2 else acc
        | Margherita::xs -> loop xs (7+acc) (1+c)
        | Caprese::xs -> loop xs (9+acc) (1+c)
        | Formaggio::xs -> loop xs (10+acc) (1+c)
        | ExtraSauce(Margherita)::xs -> loop xs (8+acc) (1+c)
        | ExtraSauce(Caprese)::xs -> loop xs (10+acc) (1+c)
        | ExtraSauce(Formaggio)::xs -> loop xs (11+acc) (1+c)
        | ExtraSauce(ExtraToppings(Margherita))::xs -> loop xs (10+acc) (1+c)
        | ExtraSauce(ExtraToppings(Caprese))::xs -> loop xs (12+acc) (1+c)
        | ExtraSauce(ExtraToppings(Formaggio))::xs -> loop xs (13+acc) (1+c)
        | ExtraToppings(ExtraSauce(Margherita))::xs -> loop xs (10+acc) (1+c)
        | ExtraToppings(ExtraSauce(Caprese))::xs -> loop xs (12+acc) (1+c)
        | ExtraToppings(ExtraSauce(Formaggio))::xs -> loop xs (13+acc) (1+c)
        | ExtraToppings(Margherita)::xs -> loop xs (9+acc) (1+c)
        | ExtraToppings(Caprese)::xs -> loop xs (11+acc) (1+c)
        | ExtraToppings(Formaggio)::xs -> loop xs (12+acc) (1+c)
        | _ -> failwith "invalid input" 
    loop pizzas 0 0