// Learn more about F# at http://fsharp.org

open System
open System.Collections.Generic

// a comparer that will compare strings in their reversed order
let comparer =
    { new IComparer<string> // <-- NB { IInterface } inheritance syntax both for interfaces and classes
      // interface ISomething with <-- add as many as needed to class or interface
      with
        member x.Compare(s1, s2) = // <-- interface member
            // function to reverse a string
            let rev (s: String) =
                new String(Array.rev (s.ToCharArray()))
            // reverse 1st string
            let reversed = rev s1
            // compare reversed string to 2nd strings reversed
            reversed.CompareTo(rev s2) } 

[<EntryPoint>]
let main argv =
    // Eurovision winners in a random order
    let winners =
        [| "Sandie Shaw"; "Bucks Fizz"; "Dana International" ;
           "Abba"; "Lordi" |]
    // print the winners
    printfn "%A" winners
    // sort the winners
    Array.Sort(winners, comparer)
    // print the winners again
    printfn "%A" winners
    0 // return an integer exit code
