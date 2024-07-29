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

printf "Digite um numero: "
let numero = int (Console.ReadLine())

let verificaPrimo = ePrimo numero

let primoEscrito verdadeOuFalso = 
    match verdadeOuFalso with
    | false -> "não é primo"
    | true -> "é primo"

printfn "O número escolhido %s" (primoEscrito verificaPrimo)