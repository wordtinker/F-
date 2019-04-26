// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    // define an array literal
    let rhymeArray =
        [| "Went to market";
        "Stayed home";
        "Had roast beef";
        "Had none" |]
    // unpack the array into identifiers
    let firstPiggy = rhymeArray.[0]
    let secondPiggy = rhymeArray.[1]
    let thirdPiggy = rhymeArray.[2]
    let fourthPiggy = rhymeArray.[3]
    // update elements of the array
    rhymeArray.[0] <- "Wee,"
    rhymeArray.[1] <- "wee,"
    rhymeArray.[2] <- "wee,"
    rhymeArray.[3] <- "all the way home"
    
    // Comprehensions
    // an array of characters
    let chars = [| '1' .. '9' |]
    // an array of tuples of number, square
    let squares =
     [| for x in 1 .. 9 -> x, x*x |]
    // print out both arrays
    printfn "%A" chars
    printfn "%A" squares 

    let arr = [|1; 3; 5; 7; 11; 13|]
    let middle = arr.[1..4] // [|3; 5; 7; 11|] 
    let start = arr.[..3] // [|1; 3; 5; 7|]
    let tail = arr.[1..] // [|3; 5; 7; 11; 13|] 

    0 // return an integer exit code
