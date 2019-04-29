// Learn more about F# at http://fsharp.org

open System

// an interface "IUser"
type IUser =
    // hashes the user's password and checks it against
    // the known hash
    abstract Authenticate: evidence: string -> bool
    // gets the users logon message
    abstract LogonMessage: unit -> string

let logon (user: IUser) (password : string) =
    // authenticate user and print appropriate message
    if user.Authenticate(password) then
        printfn "%s" (user.LogonMessage())
    else
        printfn "Logon failed" 

type User(name, passwordHash) =
    interface IUser with
    // Authenticate implementation
        member x.Authenticate(password) =
            let hashResult = hash (password)
            passwordHash = hashResult
    // LogonMessage implementation
        member x.LogonMessage() =
            Printf.sprintf "Hello, %s" name 

[<EntryPoint>]
let main argv =
    // create a new instance of the user
    // 281887125 is the hash of "mypassword"
    let user = User("Robert", 281887125)
    
    // get the logon message by casting to IUser then calling LogonMessage
    let logonMessage = (user :> IUser).LogonMessage() 
    printfn "%s" logonMessage
    0 // return an integer exit code
