// Learn more about F# at http://fsharp.org

open System

// a class with properties
type Properties() =
    let mutable rand = new System.Random()
    // a property definition
    member x.MyProp
        with get () = rand.Next()
        and set y = rand <- new System.Random(y)

// a class with indexers
type Indexers(vals:string[]) =
     // a normal indexer
     member x.Item
        with get y = vals.[y]
        and set y z = vals.[y] <- z
     // an indexer with an unusual name
     member x.MyString
        with get y = vals.[y]
        and set y z = vals.[y] <- z

type Circle() = // Autoproperty
    member val Radius = 0.0 with get, set 

[<EntryPoint>]
let main argv =
    // create a new instance of our class
    let prop = new Properties()
    // run some tests for the class
    prop.MyProp <- 12
    printfn "%d" prop.MyProp
    printfn "%d" prop.MyProp
    printfn "%d" prop.MyProp 

    // create a new instance of the indexer class
    let index = new Indexers [|"One"; "Two"; "Three"; "Four"|]
    // test the get indexers
    printfn "%s" index.[0]
    printfn "%s" (index.Item(1))
    printfn "%s" (index.MyString(2))
    printfn "%s" (index.MyString(3))

    let c = Circle()
    c.Radius <- 99.9
    printf "Radius: %f" c.Radius // 99.9
    0 // return an integer exit code
