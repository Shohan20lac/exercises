let isPrime (number: int): bool =
    let sqrtnumber: int32 = number |> float |> sqrt |> int32
    [2..number/2]
    |> Seq.filter ( 
        fun x -> 
            number % x = 0 )
    |> Seq.isEmpty

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
printfn "result: "
stopWatch.Stop()
printfn "Runtime: %f ms" stopWatch.Elapsed.TotalMilliseconds

// let stopWatch2 = System.Diagnostics.Stopwatch.StartNew()
// stopWatch2.Stop()
// printfn "generate then filter:"
// largestPrimeFactor_generateThenFilter(100001) |> printfn "%i"
// printfn "%f ms" stopWatch2.Elapsed.TotalMilliseconds