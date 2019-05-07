// Learn more about F# at http://fsharp.org

open System.Threading

[<EntryPoint>]
let main argv =
    let thread = new Thread(fun () ->
        printfn "Created thread: %i" Thread.CurrentThread.ManagedThreadId)
    thread.Start()
    printfn "Original thread: %i" Thread.CurrentThread.ManagedThreadId
    thread.Join()
    0 // return an integer exit code
