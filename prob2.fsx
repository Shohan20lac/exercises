let isEven x=
    x%2=0

//Project Euler Problem #2:
//By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms
//(Starting with 1 and 2).

// Find sum of first ten numbers in the fibonacci sequence


// 1. Custom Pattern Matching
let rec simplePatternMatch x =
   match x with
    | 10 -> printfn "inputval is 10."
    | _ -> 
        printfn "inputval is not 10. Decreasing..."
        simplePatternMatch (x-10)

simplePatternMatch 100