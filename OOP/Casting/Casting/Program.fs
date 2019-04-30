// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    let myObject = ("This is a string" :> obj) // Upcasting
    
    if (myObject :? string) then
        printfn "This object is a string"
    else
        printfn "This object is not a string"

    let back = myObject :?> string // downcastring
    printfn "%s" back
    0 // return an integer exit code
