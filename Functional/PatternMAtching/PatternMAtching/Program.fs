// Learn more about F# at http://fsharp.org

open System

// definition of Lucas numbers using pattern matching
let rec luc x =
    match x with
    | x when x <= 0 -> failwith "value must be greater than 0" // NB when and fail 
    | 1 -> 1 // there could be several | pattern | pattern on the same match
    | 2 -> 3
    | x -> luc (x - 1) + luc (x - 2)

let myOr b1 b2 =
    match b1, b2 with
    | true, _ -> true
    | _, true -> true
    | _ -> false

// concatenate a list of strings into single string
let rec concatStringList =
    function head :: tail -> head + concatStringList tail // NB function head :: tail 
           | [] -> ""

[<EntryPoint>]
let main argv =
    printfn "(luc 2) = %i" (luc 2)
    printfn "(luc 6) = %i" (luc 6)
    printfn "(luc 11) = %i" (luc 11)
    printfn "(luc 12) = %i" (luc 12)
    
    // test data
    let jabber = ["'Twas "; "brillig, "; "and "; "the "; "slithy "; "toves "; "..."]
    // call the function
    let completJabber = concatStringList jabber
    // print the result
    printfn "%s" completJabber 
    0 // return an integer exit code
