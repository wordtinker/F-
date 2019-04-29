// Learn more about F# at http://fsharp.org

open System

// a very crude hasher - don't
// use this method in real code!
let hash (s : string) = s.GetHashCode() 

// a class that represents a user
// its constructor takes two parameters, the user's
// name and a hash of their password
type User(name, passwordHash) =
    // additional ctors can be added by using 'new' keyword
    // hashes the users password and checks it against
    // the known hash
    member x.Authenticate(password) =
        let hashResult = hash password
        passwordHash = hashResult
    // gets the users logon message
    member x.LogonMessage() =
        sprintf "Hello, %s" name

type AClass(?someState:int) = // optional parameter
    let state = // can be shared between methods
        match someState with // wrapped into an Option
        | Some x -> string x
        | None -> "<no input>"
    member x.PrintState (prefix, ?postfix) =
        match postfix with
        | Some x -> printfn "%s %s %s" prefix state x
        | None -> printfn "%s %s" prefix state

[<EntryPoint>]
let main argv =
    // Create a user using the primary constructor
    let user1 = User("kiteason", 1234) // new User("kiteason", 1234) also allowed
    // Access a method of the User instance
    printfn "*** %s" (user1.LogonMessage())

    let aClass = new AClass()
    let aClass' = new AClass(109)
    aClass.PrintState("There was ")
    aClass'.PrintState("Input was:", ", which is nice.")

    0 // return an integer exit code
