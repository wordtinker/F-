// Learn more about F# at http://fsharp.org

open System

// a abstract class that represents a user
// its constructor takes one parameter,
// the user's name 
[<AbstractClass>]
type User(name) =
    // the implmentation ofthis method should hashes the
    // user's password and checks it against the known hash
    abstract Authenticate: evidence: string -> bool
    // gets the users logon message
    member x.LogonMessage() =
        Printf.sprintf "Hello, %s" name 

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
