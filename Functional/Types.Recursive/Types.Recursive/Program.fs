// Learn more about F# at http://fsharp.org

open System

type XmlAttribute =
    { AttribName: string;
      AttribValue: string; }

type XmlElement =
    { ElementName: string;
      Attributes: XmlAttribute list;
      InnerXml: XmlTree; }

and XmlTree =
    | Element of XmlElement
    | ElementList of XmlTree list
    | Text of string
    | Comment of string
    | Empty

[<EntryPoint>]
let main argv =
    0 // return an integer exit code
