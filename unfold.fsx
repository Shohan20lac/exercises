1 
|> Seq.unfold (
    fun state -> 
        if state > 5 then None
        else Some (state, state + 1)
    )
|> printfn "%A"