// Learn more about F# at http://fsharp.org

open System

[<Measure>]type liter 
[<Measure>]type pint

let ratio = 1.0<liter> / 1.76056338<pint>
// a function to convert pints to liters
let convertPintToLiter pints = 
    pints * ratio

[<EntryPoint>]
let main argv =
    let vol1 = 2.5<liter>
    let vol2 = 2.5<pint>

    // perform the conversion and add the values
    let newVol = vol1 + (convertPintToLiter vol2) 
    printfn "The volume is %f" vol1 
    0 // return an integer exit code
