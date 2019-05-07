// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System

let mailbox =
    MailboxProcessor.Start(fun mb ->
        let rec loop x =
            async { let! msg = mb.Receive()
                    let x = x + msg
                    printfn "Running total: %i - new value %i" x msg
                    return! loop x }
        loop 0) 

[<EntryPoint>]
let main argv =
    mailbox.Post(1)
    mailbox.Post(2)
    mailbox.Post(3)
    Console.ReadLine() |> ignore
    0 // return an integer exit code
