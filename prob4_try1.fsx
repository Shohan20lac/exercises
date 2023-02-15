// // EULER PROBLEM4 :
// // A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

// // Find the largest palindrome made from the product of two 3-digit numbers

// let rec factorsStartingFrom (x: uint) (y: uint) (n: uint) :seq<uint * uint>=
//     seq {
//         if x < y then
//             if n % x = (uint 0) then
//                 yield x , (n/x)

//             if x < n/(uint 2) then
//                 yield! factorsStartingFrom (x+(uint 1)) y n 
//     }

// let hasAtLeastTwo3DigitFactors (number:int): bool =
//     (uint number)
//     |> factorsStartingFrom (uint 100) (uint 999)
//     |> Seq.length >= 2

// let isPalindrome (v:string) = 
//     let reversed: string = 
//         v
//         |> Seq.rev 
//         |> Seq.map string
//         |> String.concat ""
//     reversed = v

// let rec findPalindromes (foundPalindromes: Set<string>) (inputSet: Set<string>): Set<string> =
//     match inputSet.IsEmpty with
//     | true -> foundPalindromes
//     | false ->
//         let valueToBeChecked = 
//             inputSet
//             |> Set.toSeq
//             |> Seq.head

//         let foundPalindromes =
//             if isPalindrome valueToBeChecked then 
//                 foundPalindromes
//                 |> Set.add valueToBeChecked
//             else
//                 foundPalindromes

//         let inputSetReduced =
//             inputSet 
//             |> Set.remove valueToBeChecked
//             |> Set.remove(
//                 valueToBeChecked.ToString()
//                 |> Seq.rev |> Seq.toArray |> string
//             )
//         findPalindromes foundPalindromes inputSetReduced

// let digitCount number = 
//     (int) (log10 ((float)number)) + 1;

// let largestPalindromeFromTwo3digits =

//     [1000..998001]
//     |> Seq.map string
//     |> Set.ofSeq
//     |> findPalindromes Set.empty
//     |> Set.map uint
//     |> Seq.map ( fun palindrome -> (palindrome, factorsStartingFrom 100u 999u palindrome) ) 
//     // |> Seq.map(
//     //     fun (palindrome, factorPairs) ->
//     //         palindrome,
//     //         factorPairs
//     //         |> Seq.filter (
//     //             fun (factor1,factor2)-> digitCount(factor1) = 3 && digitCount(factor2) = 3
//     //         )
//     // )
//     |> Seq.filter(
//         fun (palindrome, factorPairs) -> not (factorPairs |> Seq.isEmpty)
//     )
//     //maxBy
//     |> Seq.maxBy (
//         fun (palindrome, factorPairs) ->
//             palindrome
//     )

// let stopWatch = System.Diagnostics.Stopwatch.StartNew()
// let result =
//     largestPalindromeFromTwo3digits
// stopWatch.Stop()
// let runtime = stopWatch.Elapsed.TotalMilliseconds 

// printfn "Result: %A" result
// printfn "Run time: %f ms" runtime

// // Output:
// // Result: (485584, seq [(496u, 979u)])
// // Run time: 0.040300 ms

let digitCount number = 
    (int) (log10 ((float)number)) + 1;



let rec factorsStartingFrom (x: uint) (y: uint) (multiple: uint) :seq<uint * uint>=
    seq {

        if x < y then
            printfn "x: %i" x
            if multiple % x = (0u) then
                // printfn "quotient: %i" (multiple / x)
                match digitCount ( multiple/x ) with
                | 3 -> yield x , (multiple / x) 
                | _ -> factorsStartingFrom (x + 1u) y multiple 
            
            if x < (multiple/(2u)) then 
                yield! factorsStartingFrom (x + 1u) y multiple 
            
    }

factorsStartingFrom 100u 999u 995599u
|> Seq.toList
|> printfn "%A" 

