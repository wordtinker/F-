#if INTERACTIVE
#else
module HandlersDemo
#endif

open System.Timers

let timedMessages() =
    // define the timer
    let timer = new Timer(Interval = 3000.0, Enabled = true)
    // a counter to hold the current message
    let mutable messageNo = 0
    // the messages to be shown
    let messages =
        [ "bet"; "this"; "gets";
        "really"; "annoying";
        "very"; "quickly" ]
    // add an event to the timer
    timer.Elapsed.Add(fun _ ->
        // print a message
        printfn "%s" messages.[messageNo]
        messageNo <- messageNo + 1
        if messageNo = messages.Length then
            timer.Enabled <- false)

timedMessages()