// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.

open System
open System.ComponentModel
open System.Windows.Forms

let fibs =
    (1I,1I) |> Seq.unfold
        (fun (n0, n1) ->
            Some(n0, (n1, n0 + n1)))
let fib n = Seq.item n fibs

let form =
    let form = new Form()
    let input = new TextBox()
    let button = new Button(Left = input.Right + 10, Text = "Go")
    // label to display the result
    let output = new Label(Top = input.Bottom + 10, Width = form.Width,
                           Height = form.Height - input.Bottom + 10,
                           Anchor = (AnchorStyles.Top
                                     ||| AnchorStyles.Left
                                     ||| AnchorStyles.Right
                                     ||| AnchorStyles.Bottom))
    // create and run a new background worker
    let runWorker() =
        let background = new BackgroundWorker()
        // parse the input to an int
        let input = Int32.Parse(input.Text)
        // add the "work" event handler
        background.DoWork.Add(fun ea ->
            ea.Result <- fib input)
        // add the work completed event handler
        background.RunWorkerCompleted.Add(fun ea ->
            output.Text <- Printf.sprintf "%A" ea.Result)
        // start the worker off
        background.RunWorkerAsync()
    // hook up creating and running the worker to the button
    button.Click.Add(fun _ -> runWorker())
    // add the controls
    let dc c = c :> Control
    form.Controls.AddRange([|dc input; dc button; dc output |])
    form

[<EntryPoint>]
let main argv =
    Application.Run()
    0 // return an integer exit code
