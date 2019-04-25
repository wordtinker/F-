// Learn more about F# at http://fsharp.org

open System

// create some list comprehensions
let numericList = [ 0 .. 9 ]
let alpherSeq = seq { 'A' .. 'Z' } // IEnumerable
// create some list comprehensions
let multiplesOfThree = [ 0 .. 3 .. 30 ]
let revNumericSeq = [ 9 .. -1 .. 0 ] 
let squares = seq {for x in 1..10 -> x * x}
// a sequence of even numbers
let evens n =
    seq { for x in 1 .. n do
            if x % 2 = 0 then yield x } 
// sequence of tuples representing points
let squarePoints n =
    seq { for x in 1 .. n do
            for y in 1 .. n do
                yield x, y } 
[<EntryPoint>]
let main argv =
    printfn "%A" numericList
    printfn "%A" alpherSeq
    printfn "%A" multiplesOfThree
    printfn "%A" revNumericSeq
    printfn "%A" squares
    printfn "%A" (evens 10) 
    printfn "%A" (squarePoints 3)
    0 // return an integer exit code
