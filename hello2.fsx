let isDivisibleby3or5 inputval =
    inputval % 3 = 0
        || inputval % 5 = 0

let ans = [1..1000] |> Seq.filter isDivisibleby3or5 |> Seq.sum

printfn $"{ans}"