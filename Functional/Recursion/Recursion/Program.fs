// Learn more about F# at http://fsharp.org

open System

let rec fib x = // NB rec here
    match x with
    | 1 -> 1
    | 2 -> 1
    | x -> fib(x-1) + fib(x-2)

[<EntryPoint>]
let main argv =
    printfn "(fib 2) = %i" (fib 2)
    printfn "(fib 6) = %i" (fib 6)
    printfn "(fib 11) = %i" (fib 11) 
    0 // return an integer exit code
