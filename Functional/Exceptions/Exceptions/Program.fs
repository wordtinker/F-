// Learn more about F# at http://fsharp.org

open System

exception WrongSecond of int

// list of prime numbers
let primes = [ 2; 3; 5; 7; 11; 13; 17; 19; 23; 29; 31; 37; 41; 43; 47; 53; 59 ] 

let testSecond() =
    try
        let currentSecond = System.DateTime.Now.Second in
        if List.exists (fun x -> x = currentSecond) primes then
            failwith "A prime second"
        else
            raise (WrongSecond currentSecond)
    with
    WrongSecond x -> printf "The current was %i, which is not prime" x

// function to write to a file
let writeToFile() =
    // open a file
    let file = System.IO.File.CreateText("test.txt")
    try
        // write to it
        file.WriteLine("Hello F# users")
    finally // can't be used with 'with'
        // close the file, this will happen even if
        // an exception occurs writing to the file
        file.Dispose() 

[<EntryPoint>]
let main argv =
    testSecond()
    0 // return an integer exit code
