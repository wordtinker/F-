// Learn more about F# at http://fsharp.org

open System

// definition of the active pattern
let (|Bool|Int|Float|String|) (input:string) =
    // attempt to parse a bool
    let success, res = Boolean.TryParse input
    if success then Bool(res)
    else
        // attempt to parse an int
        let success, res = Int32.TryParse input
        if success then Int(res)
        else
            // attempt to parse a float (Double)
            let success, res = Double.TryParse input
            if success then Float(res)
            else String(input) 

// function to print the results by pattern
// matching over the active pattern
let printInputWithType input =
    match input with
    | Bool b -> printfn "Boolean: %b" b
    | Int i -> printfn "Integer: %i" i
    | Float f -> printfn "Floating point: %f" f
    | String s -> printfn "String: %s" s 

[<EntryPoint>]
let main argv =
    // print the results
    printInputWithType "true"
    printInputWithType "12"
    printInputWithType "-12.1" 
    0 // return an integer exit code
