let AndGate_BinaryInt (bits:seq<int>) : bool =
    (bits |> Seq.sum) = (bits |> Seq.length) 

let OrGate_BinaryInt (bits:seq<int>) : bool =
    (bits |> Seq.sum) >=1  

[1; 0; 1; 0]
|> AndGate_BinaryInt
|> printfn "%A"

[1; 0; 1; 0]
|> OrGate_BinaryInt
|> printfn "%A"
