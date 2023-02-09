let isFactorOf (num: int) (factor: int): bool =
    num % factor = 0

let isDivisibleBy  (factor: int) (num: int): bool =
    num % factor = 0

let isPrime (number: int): bool =
    let sqrtnumber: int32 = number |> float |> sqrt |> int32
    [2..number/2]
    |> Seq.filter ( 
        fun x -> 
            number % x = 0 )
    |> Seq.isEmpty

let rec factorsStartingFrom x n =
    seq {
        
        if n % x = 0 then
            printf "%i is a factor. " x
            
            if isPrime(x) then
                printfn "\nPrime too! Including..."
                yield x
            else
                printfn "Not a prime number tho. Ignoring..."

        if x < n/2 then 
            yield! ( factorsStartingFrom (x+1) n )
        else
            printfn "STOP"
    }

let largestPrimeFactor_generateThenFilter (n: int32) =
    [2..(n/2)]
    |> Seq.filter ( isFactorOf n )
    |> Seq.filter ( isPrime )
    |> Seq.max

let largestPrimeFactor_generateFiltered (n: int32) =
    n
    |> factorsStartingFrom 2
    |> Seq.filter ( isPrime )
    |> printfn "%A"
    // |> Seq.max

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
printfn "generate filtered:"
largestPrimeFactor_generateFiltered(1000) |> printfn "%A" 
stopWatch.Stop()
printfn "%f ms" stopWatch.Elapsed.TotalMilliseconds

// let stopWatch2 = System.Diagnostics.Stopwatch.StartNew()
// stopWatch2.Stop()
// printfn "generate then filter:"
// largestPrimeFactor_generateThenFilter(100001) |> printfn "%i"
// printfn "%f ms" stopWatch2.Elapsed.TotalMilliseconds

