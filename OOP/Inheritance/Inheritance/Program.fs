// Learn more about F# at http://fsharp.org

open System

// a base class
type Base() =
    // some internal state for the class
    let mutable state = 0
    // an ordinary member method
    member x.JiggleState y = state <- y
    // an abstract method
    abstract WiggleState: int -> unit
    // a default implementation for the abstract method
    default x.WiggleState y = state <- y + state
    member x.GetState() = state
// a sub class
type Sub() =
    inherit Base()
    // call base.Method for method of parent class 
    // override the abstract method
    default x.WiggleState y = x.JiggleState (x.GetState() &&& y) 

// a small test for our classes
let testBehavior (c : #Base) = // #Base - Base or any of its derivative types
    c.JiggleState 1
    printfn "%i" (c.GetState())
    c.WiggleState 3
    printfn "%i" (c.GetState()) 

[<EntryPoint>]
let main argv =
    // create instances of both methods
    let myBase = new Base()
    let mySub = new Sub()

    printfn "base class: "
    testBehavior myBase
    printfn "sub class: "
    testBehavior mySub 
    0 // return an integer exit code
