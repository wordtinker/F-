// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let add x y = x + y
    let addFour = add 4 // partially applied function

    let result = add 6 7 |> addFour |> add 5 // pipe-forward |> : add 5 (addFour (add 6 7))

    printfn "Hello World from F#!"
    0 // return an integer exit code
