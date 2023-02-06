//Project Euler Problem #2: 
// find the sum of the even-valued fibonacci numbers (Starting with 1 and 2) 

// 1. Custom Pattern Matching
let rec simplePatternMatch x =
   match x with
    | 10 -> printfn "inputval is 10."
    | _ -> 
        printfn "inputval is not 10. Decreasing..."
        simplePatternMatch (x-10)

let isEven x=
    if x%2=0 then x
    else 0

let rec factorial x =
    match x with
    | 1 -> 1
    | _ ->
        x * factorial (x-1)

let rec fib n=
    match n with
    |2 -> 2
    |1 -> 1
    |_ -> fib(n-1) + fib(n-2)

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
[1..31] |> Seq.map fib |> Seq.map isEven |> Seq.sum |> printfn "%A"
stopWatch.Stop()
printfn "%f ms" stopWatch.Elapsed.TotalMilliseconds



