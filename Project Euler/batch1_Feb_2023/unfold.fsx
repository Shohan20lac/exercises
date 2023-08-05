let bigNumber= 10

let rec factors (n:int): seq<int>= 
    seq{
        yield 10
    }

printfn "%A" (factors 10) 

1 
|> Seq.unfold (
    fun state -> 
        if state > 5 then None
        else Some (state, state + 1)
    )
|> printfn "%A"


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

100 
|> factorsStartingFrom 2
|> printfn "%A"
