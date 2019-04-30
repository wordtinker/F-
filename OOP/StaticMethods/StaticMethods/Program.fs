// Learn more about F# at http://fsharp.org

open System

type StacitMemberCls() = 
    //A static filed should be defined first
    static let mutable staticFiled = ""  
      
    static member StaticProp
        with get() = staticFiled
        and set(v) = staticFiled <- v

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
