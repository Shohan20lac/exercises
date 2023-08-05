let stopWatch = System.Diagnostics.Stopwatch.StartNew()
let (ans:int) =
    [1..1000]
    |> Seq.filter (
        fun x ->
            x % 2 = 0  
            && 
            x % 5 = 0
    ) 
    |> Seq.sum
stopWatch.Stop()

printfn $"Answer: {ans}"
printfn $"Run time: {stopWatch.Elapsed.TotalMilliseconds}"