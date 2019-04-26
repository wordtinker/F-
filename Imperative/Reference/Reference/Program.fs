// Learn more about F# at http://fsharp.org

open System

// can be rewritten with mutable since 4.0
let totalArray () =
    // define an array literal
    let array = [| 1; 2; 3 |]
    // define a counter
    let total = ref 0
    // loop over the array
    for x in array do
        // keep a running total
        total := !total + x // NB Watch syntax
    // print the total
    printfn "total: %i" !total 

[<EntryPoint>]
let main argv =
    totalArray()
    0 // return an integer exit code
