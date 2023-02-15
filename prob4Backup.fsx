// PROBLEM4 :
// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

// Find the largest palindrome made from the product of two 3-digit numbers


let digitCount number = 
    (int) (log10 ((float)number)) + 1;

let rec factorsStartingFrom (x: uint) (y: uint) (multiple: uint) :seq<uint * uint>=
    seq {

        if x < y then
            // printfn "x: %i" x
            if multiple % x = (0u) then
                yield x , (multiple / x)

            if x < (multiple/(2u)) then 
                yield! factorsStartingFrom (x + 1u) y multiple
    }


let rec factorsStartingFrom2 (x: uint) (y: uint) (multiple: uint) :seq<uint * uint>=
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


let isPalindrome (v:string) = 
    let reversed: string = 
        v
        |> Seq.rev 
        |> Seq.map string
        |> String.concat ""
    reversed = v

let rec findPalindromes (foundPalindromes: Set<string>) (inputSet: Set<string>): Set<string> =
    match inputSet.IsEmpty with
    | true -> foundPalindromes
    | false ->
        let valueToBeChecked = 
            inputSet
            |> Set.toSeq
            |> Seq.head

        let foundPalindromes =
            if isPalindrome valueToBeChecked then 
                foundPalindromes
                |> Set.add valueToBeChecked
            else
                foundPalindromes

        let inputSetReduced =
            inputSet 
            |> Set.remove valueToBeChecked
            |> Set.remove(
                valueToBeChecked.ToString()
                |> Seq.rev |> Seq.toArray |> string
            )
        findPalindromes foundPalindromes inputSetReduced



let largestPalindromeFromTwo3digits =

    let palindromes = 
        []
        |> Seq.map string
        |> Set.ofSeq
        |> findPalindromes Set.empty



    let palindromesWithThreeDigitFactorPairs = 
        palindromes
        |> Set.map uint
        |> Seq.map ( fun palindrome -> (palindrome, factorsStartingFrom2 100u 999u palindrome) )

    for element in palindromesWithThreeDigitFactorPairs do
        printfn $"{element}"

   
        // |> Seq.map (
        //     fun (palindrome , factorPairs) ->

        //         palindrome, (
        //             factorPairs
        //             |> Seq.filter(
        //                 fun (factor1 , factor2)-> (digitCount(factor1) = 3) && (digitCount(factor2) = 3)
        //                 )
                        
        //         )
        //     )
        // |> Seq.map fst
        // |> Seq.max


    
    // |> 
    // |> Seq.filter(
    //     fun (palindrome, factorPairs) -> not (factorPairs |> Seq.isEmpty)
    // )


let stopWatch = System.Diagnostics.Stopwatch.StartNew()
let result =
    largestPalindromeFromTwo3digits
stopWatch.Stop()
let runtime = stopWatch.Elapsed.TotalMilliseconds 

printfn "Result: %A" result
printfn "Run time: %f ms" runtime

// Output:
// Result: (485584, seq [(496u, 979u)])
// Run time: 0.040300 ms

