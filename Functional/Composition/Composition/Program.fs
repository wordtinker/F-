// Learn more about F# at http://fsharp.org

open System

let add a b = a + b
let times n x = n * x

let add1times2 = add 1 >> times 2
let add5times3 = add 5 >> times 3

[<EntryPoint>]
let main argv =
    add1times2 1 |> printfn "(1 + 1) * 2 = %i"
    add1times2 2 |> printfn "(2 + 1) * 2 = %i"
    add5times3 1 |> printfn "(1 + 5) * 3 = %i"
    0 // return an integer exit code
