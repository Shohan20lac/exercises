// Problem 5
// 2520 is the smallest number that can be
// divided by each of the numbers from 1 to 10
// without any remainder.
//
// What is the smallest positive number that is
// evenly divisible by all of the numbers from 1 to 20?

// Fully brute force:

// let rec tryNumbersUpto (starting: int) (ending: int) = 
//     
//     seq{
//         
//         if starting < ending then
//             
//             yield tryNumbersUpto ( (starting+1) (ending) )
//         
//         else
//             // base case: boundary reached. starting = ending
//             true
//         
//     }
    
    
let rec increasingSequence (starting:int) (ending:int) =
    seq{
        
        // Main yield
        yield starting
        
        // Recursive yield
        if starting < ending then
            
            yield! increasingSequence (starting+1) ending
    }
    |> Seq.toList
    
let result = increasingSequence 100 500

for element in result do
    printfn $"{element}"

    // recursive case: keep trying the next number
// = Set [1..20]

// printfn $"{myset}"

