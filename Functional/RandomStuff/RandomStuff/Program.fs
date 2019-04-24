// Learn more about F# at http://fsharp.org

open System
open System.IO

let printMessages () =
    // define message and print it
    let message = "Important"
    printfn "%s" message;
    // define an inner function that redefines value of message
    let innerFun () =
        let message = "Very Important" //NB shadowing not assignment
        printfn "%s" message
        // call the inner function
    innerFun ()
    // finally print the first message again
    printfn "%s" message

// function that returns a function to
let calculatePrefixFunction prefix =
    // calculate prefix
    let prefix' = Printf.sprintf "[%s]: " prefix
    // define function to perform prefixing
    let prefixFunction appendee =
        Printf.sprintf "%s%s" prefix' appendee
    // return function
    prefixFunction 

// function to read first line from a file
let readFirstLine filename =
    // open file using a "use" binding
    use file = File.OpenText filename
    file.ReadLine()
    // NB Disposed here

[<EntryPoint>]
let main argv =
    let x = 42 // identifier
    let myAdd = fun x y -> x + y // anon function
    let raisePowerTwo x = x ** 2.0 // shortcut syntax
    let result = myAdd x 4
    
    printfn "result = %i" result
    let SafeUpperCase (s : string) =
        let s = if s = null then "" else s
        s.ToUpperInvariant()
    printMessages ()

    // create the prefix function
    let prefixer = calculatePrefixFunction "DEBUG" 

    // use the prefix function
    printfn "%s" (prefixer "My message") 

    0 // return an integer exit code
