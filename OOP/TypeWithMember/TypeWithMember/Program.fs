// Learn more about F# at http://fsharp.org

open System

// A point type
type Point =
    { Top: int;
      Left: int }
    with
    // the swap member creates a new point
    // with the left/top coords reveresed
    member x.Swap() =
      { Top = x.Left;
        Left = x.Top }

// a type representing the amount of a specific drink
type DrinkAmount =
    | Coffee of int
    | Tea of int
    | Water of int
    with
    // get a string representation of the value
    override x.ToString() =
        match x with
        | Coffee x -> Printf.sprintf "Coffee: %i" x
        | Tea x -> Printf.sprintf "Tea: %i" x
        | Water x -> Printf.sprintf "Water: %i" x 

[<EntryPoint>]
let main argv =
    let myPoint = { Top = 3; Left = 7 }
    // print the inital point
    printfn "%A" myPoint
    // create a new point with the coords swapped
    let nextPoint = myPoint.Swap()
    // print the new point
    printfn "%A" nextPoint

    let t = Tea 2 
    // print out the string
    printfn "%s" (t.ToString()) 
    0 // return an integer exit code
