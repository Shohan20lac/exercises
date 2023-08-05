// TASK: Find the sum of all multiples of 3 or 5 below 1000



// TODO1: solve using Seq.filter
let solveUsingSeqFilter (upperLimit: int) =
    [1..upperLimit]
    |> Seq.filter 
        (fun multiple -> 
            (multiple % 3 = 0) ||
            (multiple % 5 = 0)
        )
    |> Seq.sum

// TODO2: solve it 
let solveUsingSeqFold () =
    Seq.fold 
        (fun acc item -> 
            if (item % 3 = 0 || item % 5 = 0) then
                acc + item
            else 
                acc
        ) 
        0
        [1..100]


// TODO3: async op
