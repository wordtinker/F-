// Learn more about F# at http://fsharp.org

open System

type 'a BinaryTree =
    | BinaryNode of 'a BinaryTree * 'a BinaryTree
    | BinaryValue of 'a
    
type Tree<'a> =
    | Node of Tree<'a> list
    | Value of 'a 

[<EntryPoint>]
let main argv =
    let tree1 =
        BinaryNode(
            BinaryNode ( BinaryValue 1, BinaryValue 2),
            BinaryNode ( BinaryValue 3, BinaryValue 4) )
    let tree2 =
        Node([ Node( [Value "one"; Value "two"] ) ;
        Node( [Value "three"; Value "four"] ) ] ) 
    0 // return an integer exit code
