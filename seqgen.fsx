let bigNumber = 21

let rec factorStartingFrom x n =
    seq {

        // Case 1: x is a factor of n
        if n % x = 0 then
            // case 1a: this is the last factor and we don't need to look further
            if x = n/2 then
                yield x
            // case 1b: this is factor, but we also need to look further
            else
                yield x
                yield! ( factorStartingFrom n (x+1) )
        
        // Case 2: x is NOT a factor of n.
        elif not ( x = n / 2 ) then
            yield! ( factorStartingFrom n (x+1) )
    }

bigNumber
|> factorStartingFrom 2
|> printfn "%A"