module Shapes

open System.Drawing

type Shape =
    { Reposition: Point -> unit;
      Draw: unit -> unit }

let makeShape initPos draw =
    let currPos = ref initPos
    { Reposition = 
        (fun newPos -> currPos := newPos);
      Draw =
        (fun () -> draw !currPos); }

let draw shape (pos: Point) =
    printfn "%s, with x = %i and y = %i"
      shape pos.X pos.Y

// creates a new circle shape
let circle initPos =
    makeShape initPos (draw "Circle")
// creates a new square shape
let square initPos =
    makeShape initPos (draw "Square") 

// list of shapes in their inital positions
let shapes =
    [ circle (new Point (10,10));
      square (new Point (30,30)) ] 

// draw all the shapes
let drawShapes() =
    shapes |> List.iter (fun s -> s.Draw()) 

[<EntryPoint>]
let main argv =
    drawShapes() // draw the shapes
    // move all the shapes
    shapes |> List.iter (fun s -> s.Reposition (new Point (40,40)))
    drawShapes() // draw the shapes
    0 // return an integer exit code
