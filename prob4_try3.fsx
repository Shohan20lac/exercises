let initset = [1..10]

let finalset = initset |> Set |> Set.remove 2

let result =
    [1..10]
    |> Seq.allPairs [1..10]

for element in result do
    printfn $"{element}"

printfn $"{result|> Seq.length}"

// given (1,7), remove (7,1)

let removeEvens ( tuple: int, tuples: Set<int> ) =
    tuple,tuples
    |> fun (tuple1, tuples) -> true
