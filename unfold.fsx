let bigNumber= 10

let rec factors (n:int): seq<int>= 
    seq{
        yield 10
    }

printfn "%A" (factors 10) 

// 1 
// |> Seq.unfold (
//     fun state -> 
//         if state > 5 then None
//         else Some (state, state + 1)
//     )
// |> printfn "%A"