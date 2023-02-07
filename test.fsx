let isFactorOf (num: int) (factor: int): bool =
    num % factor = 0

let isDivisibleBy  (factor: int) (num: int): bool =
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

let isPrime (number: int): bool =
    let sqrtnumber: int32 = number |> float |> sqrt |> int32
    [2..sqrtnumber]
    |> Seq.filter ( 
        fun x -> 
            number % x = 0 )
    |> Seq.isEmpty

let largestPrimeFactor_generateThenFilter (n: int32) =
    [2..(n/2)]
    |> Seq.filter ( isFactorOf n )
    |> Seq.filter ( isPrime )
    |> Seq.max

let largestPrimeFactor_generateFiltered (n: int32) =
    n
    |> factorsStartingFrom 2
    |> Seq.filter ( isPrime )
    |> Seq.max

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
stopWatch.Stop()
printfn "generate filtered:"
largestPrimeFactor_generateFiltered(100001) |> printfn "%i"
printfn "%f ms" stopWatch.Elapsed.TotalMilliseconds

let stopWatch2 = System.Diagnostics.Stopwatch.StartNew()
stopWatch2.Stop()
printfn "generate then filter:"
largestPrimeFactor_generateThenFilter(100001) |> printfn "%i"
printfn "%f ms" stopWatch2.Elapsed.TotalMilliseconds

