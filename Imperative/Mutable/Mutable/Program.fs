// Learn more about F# at http://fsharp.org

open System

// shadowing
let redefineX() =
    let x = "One"
    printfn "Redefining: \r\nx = %s" x
    if true then
        let x = "Two"
        printfn "x = %s" x
    printfn "x = %s" x

// mutation
let mutableX() =
    let mutable x = "One"
    printfn "Mutating: \r\nx = %s" x
    if true then
        x <- "Two"
        printfn "x = %s" x
    printfn "x = %s" x

[<EntryPoint>]
let main argv =
    redefineX()
    mutableX()
    0 // return an integer exit code
