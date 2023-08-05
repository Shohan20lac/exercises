// Approach2: Generate sequence of factors, filter to keep primes only

let isPrime (number: int): bool =

    [2..(number/2)]
    |> Seq.filter ( 
        fun x -> 
            number % x = 0 ) 
    |> Seq.isEmpty

let isFactorOf (num: int) (factor: int): bool =
    num % factor = 0

let rec factorsStartingFrom x n =
    seq {

        // Case 1: x is a factor of n
        if n % x = 0 then
            // case 1a: this is the last factor and we don't need to look further
            if x = n/2 then
                yield x
            // case 1b: this is factor, but we also need to look further
            else
                yield x
                yield! ( factorsStartingFrom n (x+1) )
        
        // Case 2: x is NOT a factor of n.
        elif not ( x = n / 2 ) then
            yield! ( factorsStartingFrom n (x+1) )
    }

let largestPrimeFactor (n: int32) =
    factorsStartingFrom 2 n  // |> Seq.filter ( cannotDivide factors )
    |> printfn "%A"
    // |> Seq.filter ( isPrime )
    // |> Seq.max

let stopWatch = System.Diagnostics.Stopwatch.StartNew()

largestPrimeFactor(10098001) 
// |> printfn "%i"

stopWatch.Stop()
printfn "%f ms" stopWatch.Elapsed.TotalMilliseconds