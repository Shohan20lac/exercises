let rec evenFactorialTail n accSum =
    if n <= 0 then
        printfn "Base Case reached"
        printfn $"accSum: {accSum}"
    else
        printfn $"{n}"
        if n % 2 = 0 then
            evenFactorialTail (n - 1) (accSum + n)
        else
            evenFactorialTail (n - 1) accSum

evenFactorialTail 10 0