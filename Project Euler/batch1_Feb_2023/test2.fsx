

let rec primeFactorsStartingFrom (factor:uint64) (multiple:uint64): seq<int64> =
    seq {

        if factor > (multiple / 2UL ) then
            yield int64 multiple

        elif multiple % factor = 0UL then
            yield int64 factor
            yield! primeFactorsStartingFrom factor (multiple/factor)
        else
            yield! primeFactorsStartingFrom (factor + 1UL) multiple

        // if factor < ( multiple / (2UL) ) then 
        //     yield! ( multiple |> primeFactorsStartingFrom (factor + 1UL) )
    }

let largestPrimeFactor_generateFiltered (n: uint64): int64=
    primeFactorsStartingFrom 2UL  n
    |> Seq.max

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
let result =
    largestPrimeFactor_generateFiltered 600851475143UL

printfn "%i" result
printfn "Run time: %f ms" stopWatch.Elapsed.TotalMilliseconds
stopWatch.Stop()