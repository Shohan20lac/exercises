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

// Generate a list containing the first 3 fibonacci numbers
[1..4] |> Seq.map fib |> printfn "%A"