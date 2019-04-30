// Learn more about F# at http://fsharp.org

open System

type IpAddress = struct
     val first : byte
     val second : byte
     val third : byte
     val fourth : byte
     new(first, second, third, fourth) =
         { first = first;
         second = second;
         third = third;
         fourth = fourth }
     override x.ToString() =
         Printf.sprintf "%O.%O.%O.%O" x.first x.second x.third x.fourth
     member x.GetBytes() = x.first, x.second, x.third, x.fourth
end

type Scale =
| C = 1
| D = 2
| E = 3 

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
