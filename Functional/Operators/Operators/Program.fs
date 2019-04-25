// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    let result = (+) 1 1 // turn + opeartor into a function
    let (+*) a b = (a + b) * a * b // define new oparator

    printfn "(1 +* 2) = %i" (1 +* 2)
    0 // return an integer exit code
