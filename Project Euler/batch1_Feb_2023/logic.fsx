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

let isFactorOf_Number (num: int) (factor: int): bool =
    num % factor = 0

let n = 1000

let factors =
    [ 2..(n-1) ]
    |> Seq.filter ( isFactorOf_Number n )
    
let checkDivisibility (factor:int) (intseq: seq<int>)
    let results =
    intseq
    |> Seq.filter ()

factors
for factor in factors do
    Seq.map ( checkDivisibility factor )