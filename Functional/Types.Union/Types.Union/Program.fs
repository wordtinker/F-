// Learn more about F# at http://fsharp.org

open System

type Volume =
    | Liter of float
    | UsPint of float
    | ImperialPint of float 

let convertVolumeToLiter x =
    match x with
    | Liter x -> x
    | UsPint x -> x * 0.473
    | ImperialPint x -> x * 0.568

type Shape =
    | Square of side:float
    | Rectangle of width:float * height:float
    | Circle of radius:float 

[<EntryPoint>]
let main argv =
    let vol1 = Liter 2.5
    let vol2 = UsPint 2.5
    let vol3 = ImperialPint (2.5)

    // create an instance of a union type without using the field label
    let sq = Square 1.2
    // create an instance of a union type using the field label
    let sq2 = Square(side=1.2)
    // create an instance of a union type using multiple field labels
    // and assigning the field out-of-order
    let rect3 = Rectangle(height=3.4, width=1.2) 
    0 // return an integer exit code
