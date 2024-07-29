open System

let rec productOddValues list =
    match list with
    | [] -> 1
    | head :: tail when head % 2 <> 0 -> head * productOddValues tail 
    | _:: tail -> productOddValues tail

printfn "%i" (productOddValues [1..5])