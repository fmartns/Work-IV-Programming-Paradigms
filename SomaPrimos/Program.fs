open System

let contadorDeDivisores n =
    let rec aux divisor contador =
        match divisor with
        | divisor when divisor > n -> contador
        | divisor when n % divisor = 0 -> aux (divisor + 1) (contador + 1)
        | _ -> aux (divisor + 1) contador
    aux 1 0

let ePrimo n =
    match n with
    | num when num <= 1 -> false
    | _ ->
        match contadorDeDivisores n with
        | 2 -> true
        | _ -> false

let lista = [0..10]

let rec somaPrimos lista =
    match lista with
    | [] -> 0
    | primeiroElemento :: restanteLista when ePrimo primeiroElemento -> primeiroElemento + somaPrimos restanteLista
    | _ :: restanteLista -> somaPrimos restanteLista

let soma = somaPrimos lista
printfn "A soma dos números primos na lista é: %d" soma