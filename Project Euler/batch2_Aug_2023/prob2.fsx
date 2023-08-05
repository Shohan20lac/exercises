let rec factorialTail n  =
    if n <= 0 then
        printfn "Base Case reached"
    else
        printfn $"{n}"
        factorialTail (n - 1) // Tail-recursive call

factorialTail 2