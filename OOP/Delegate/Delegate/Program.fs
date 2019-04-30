// Learn more about F# at http://fsharp.org

open System

type MyDelegate = delegate of int -> unit

[<EntryPoint>]
let main argv =
    let inst = new MyDelegate (fun i -> printf "%i" i)
    let ints = [1 ; 2 ; 3 ] 
    
    ints
    |> List.iter (fun i -> inst.Invoke(i)) 
    0 // return an integer exit code
