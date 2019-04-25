// Learn more about F# at http://fsharp.org

open System

let pair = true, false // not additional definition needed
let b1, b2 = pair

type Name = string
type FullName = string * string // tuple type annotation

let fullNameToString (x : FullName) =
    let first, second = x
    first + " " + second


// define an organization with unique fields
type Organization1 = { boss: string; lackeys: string list } // list<string>
// type representing a couple
type Couple = { him : string ; her : string }

// function to find "David" from a list of couples
let rec findDavid l =
    match l with
    | { him = x ; her = "Posh" } :: tail -> x
    | _ :: tail -> findDavid tail
    | [] -> failwith "Couldn't find David" 

[<EntryPoint>]
let main argv =
    printfn "Full Name: %s" (fullNameToString ("Name", "Surname"))

    let rainbow = // immutable
        { boss = "Jeffrey";
        lackeys = ["Zippy"; "George"; "Bungle"] }
    let rainbow' =
        { rainbow with boss = "NewJeffrey"} // copy syntax
    // access a field from this type
    printfn "rainbow.boss = %s" rainbow.boss
    printfn "rainbow'.boss = %s" rainbow'.boss

    // list of couples
    let couples =
        [ { him = "Brad" ; her = "Angelina" };
        { him = "Becks" ; her = "Posh" };
        { him = "Chris" ; her = "Gwyneth" };
        { him = "Michael" ; her = "Catherine" } ] 

    printfn "%A" (findDavid couples) 
    0 // return an integer exit code
