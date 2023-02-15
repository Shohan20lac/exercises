// Euler Problem 4:

// A palindromic number reads the same both ways.
// The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.

// Find the largest palindrome made from the product of two 3-digit numbers.

let rec smallestNumberBackwards (digitCount: int) =
    if digitCount > 1 then
        (string (0) + smallestNumberBackwards(digitCount-1))
    else
        string(1)

let rec largestNumber (digitCount: int) =
    if digitCount > 1 then
        (string(9) + largestNumber(digitCount-1))
    else
        string(9)
let reverseString (v: string) =
    v
    |> Seq.rev
    |> Seq.map string
    |> String.concat ""
    
let isPalindrome (v:int): bool = 
    let reversed = 
        v
        |> string
        |> Seq.rev 
        |> Seq.map string
        |> String.concat ""
    reversed = (v |> string)

let minFactor =
    smallestNumberBackwards 3
    |> reverseString
    |> int
    
let maxFactor =
    largestNumber 3
    |> int
    
let stopWatch = System.Diagnostics.Stopwatch.StartNew()
let result =
    [minFactor..maxFactor]
    |> Seq.map(
        fun i ->
            let iReplicated = Seq.replicate ((maxFactor-1)) (i)
            Seq.zip iReplicated (Seq.skip (i-1)  [1..(maxFactor)])
        )
    |> Seq.collect ( fun seq-> seq )
    |> Seq.map (
        fun (number1,number2) ->
            number1 * number2
            )
    |> Seq.filter isPalindrome
    |> Seq.max
stopWatch.Stop()

printfn $"Answer: {result}"
printfn $"Run time: {stopWatch.Elapsed.TotalMilliseconds} ms"

// // Output:
// Answer: 906609
// Run time: 253.9017 ms