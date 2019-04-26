// Learn more about F# at http://fsharp.org

open System

let words = [| "Red"; "Lorry"; "Yellow"; "Lorry" |]
let ryunosukeAkutagawa =
    [| "Green "; "frog,";
    "Is"; "your"; "body"; "also";
    "freshly"; "painted?" |]
let shusonKato =
    [| "watching."; "been"; "have";
    "children"; "three"; "my"; "realize"; "and";
    "ant"; "an"; "kill"; "I"; |]
let mutable matsuoBasho =
    [ "An"; "old"; "pond!";
    "A"; "frog"; "jumps"; "in-";
    "The"; "sound"; "of"; "water" ]

[<EntryPoint>]
let main argv =
    for word in words do
        printfn "%s" word

    for index = 0 to Array.length ryunosukeAkutagawa - 1 do
        printf "%s " ryunosukeAkutagawa.[index]

    for index = Array.length shusonKato - 1 downto 0 do
        printf "%s " shusonKato.[index]

    for i in 10..-1..0 do
        printfn "%i green bottles" i 

    while (List.length matsuoBasho > 0) do
        printf "%s " (List.head matsuoBasho)
        matsuoBasho <- List.tail matsuoBasho 

    0 // return an integer exit code
