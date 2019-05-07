// Learn more about F# at http://fsharp.org

open System
open System.Linq
open System.Reflection 

// define easier access to LINQ methods
let select f s = Enumerable.Select(s, new Func<_,_>(f))
let where f s = Enumerable.Where(s, new Func<_,_>(f))
let groupBy f s = Enumerable.GroupBy(s, new Func<_,_>(f))
let orderBy f s = Enumerable.OrderBy(s, new Func<_,_>(f))
let count s = Enumerable.Count(s) 

[<EntryPoint>]
let main argv =
    let namesByFunction =
        (typeof<string>).GetMethods()
        |> Seq.filter(fun m -> not m.IsStatic)
        |> Seq.groupBy(fun m -> m.Name)
        |> Seq.map(fun (k, v) -> k, v |> Seq.length)
        |> Seq.sortBy(fun (_, v) -> v)

    namesByFunction
    |> Seq.iter(fun (name, count) -> printfn "%s - %i" name count)
    
    let namesByFunctionLINQ =
        (typeof<string>).GetMethods()
        |> where (fun m -> not m.IsStatic)
        |> groupBy (fun m -> m.Name)
        |> select (fun m -> m.Key, count m)
        |> orderBy (fun (_, m) -> m) 

    namesByFunctionLINQ
    |> Seq.iter (fun (name, count) -> printfn "%s - %i" name count) 
    0 // return an integer exit code
