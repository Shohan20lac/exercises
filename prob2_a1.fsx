// Approach1: Generate Sequence, Filter factors, Filter primes

let isPrime (number: int): bool =

    [2..(number/2)]
    |> Seq.filter ( 
        fun x -> 
            number % x = 0 ) 
    |> Seq.isEmpty

let isFactorOf (num: int) (factor: int): bool =
    num % factor = 0

let largestPrimeFactor (n: int32) =
    [2..n/2]
    |> Seq.filter ( isFactorOf n )    // |> Seq.filter ( cannotDivide factors )
    |> Seq.filter ( isPrime )
    |> Seq.max

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
largestPrimeFactor(1000) |> printfn "%i"
stopWatch.Stop()
printfn "%f ms" stopWatch.Elapsed.TotalMilliseconds