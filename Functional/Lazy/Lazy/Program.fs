// Learn more about F# at http://fsharp.org

open System

// the lazy list definition
let lazyList =
    Seq.unfold
        (fun x ->
            if x < 13 then
                // if smaller than the limit return
                // the current and next value
                Some(x, x + 1)
            else
            // if great than the limit
            // terminate the sequence
                None)
        10

[<EntryPoint>]
let main argv =
    let lazyValue = lazy ( 2 + 2 )
    let actualValue = lazyValue.Value

    printfn "%i" actualValue
    printfn "%A" lazyList
    Seq.take 2 lazyList |> printfn "%A" 
    0 // return an integer exit code
