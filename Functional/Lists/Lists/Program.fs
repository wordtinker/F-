// Learn more about F# at http://fsharp.org

open System

// lists are immutable
let emptyList = []
let oneItem = "one" :: []
let twoItem = "one" :: "two" :: []
let shortHand = ["apples"; "pears"]
let twoLists = oneItem @ twoItem;
let objList = [box 1; box 2.0; box "three"] // object wrapper

// definition of a concatenation function
let rec concatList l =
    match l with
    | head :: tail -> head @ (concatList tail)
    | [] -> [] 

[<EntryPoint>]
let main argv =
    printfn "%A" emptyList
    printfn "%A" oneItem
    printfn "%A" twoItem
    printfn "%A" shortHand
    printfn "%A" twoLists
    printfn "%A" objList

    // list to be concatenated
    let listOfList = [[2; 3; 5]; [7; 11; 13]; [17; 19; 23; 29]]
    // call the function
    let primes = concatList listOfList
    // print the results
    printfn "%A" primes
    0 // return an integer exit code
