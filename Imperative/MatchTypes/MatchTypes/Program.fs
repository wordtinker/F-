// Learn more about F# at http://fsharp.org

open System

// list of objects
let anotherList = [ box "one"; box 2; box 3.0 ] 

// pattern match and print value
let recognizeAndPrintType (item : obj) =
    match item with
    | :? System.Int32 as x -> printfn "An integer: %i" x
    | :? System.Double as x -> printfn "A double: %f" x
    | :? System.String as x -> printfn "A string: %s" x
    | x -> printfn "An object: %A" x 

[<EntryPoint>]
let main argv =
    anotherList |> List.iter recognizeAndPrintType
    0 // return an integer exit code
