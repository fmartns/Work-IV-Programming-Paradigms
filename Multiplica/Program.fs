let rec exponentiation n1 n2 =
    match (n1, n2) with
    | (n1, n2) when n1 = n2 -> n1 * n2
    | (n1, n2) -> 
        let rec power n1 n2 =
            match n2 with
            | 0 -> 1
            | 1 -> n1
            | _ -> n1 * power n1 (n2 - 1)
        power n1 n2

printfn "%i" (exponentiation 2 2)
printfn "%i" (exponentiation 2 3)