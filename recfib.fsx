let rec fib (n:int) : int =
    match n with
    | 1 -> 1
    | 2 -> 2
    | _ -> fib(n-1) + fib(n-2)


fib 32
|> printfn "%A"