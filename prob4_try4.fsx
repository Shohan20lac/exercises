//HEAD-ON APPROACH B: GENERATE FILTERED

// step1: define a function that does this:

// given length,
// for i in range[1..length]
    // generate [ (i,i) (i,i+1) ... (i,length) ]

let rec factorsStartingFrom (x: uint) (y: uint) (n: uint) :seq<uint * uint>=
    seq {
        if x < y then
            if n % x = (uint 0) then
                yield x , (n/x)

            if x < n/(uint 2) then
                yield! factorsStartingFrom (x+(uint 1)) y n 
    }
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
printfn $"{minFactor}"
let maxFactor =
    largestNumber 3
    |> int
printfn $"{maxFactor}"
let length = Seq.length [minFactor..maxFactor]
printfn $"length: {length}"

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
let result =
    [minFactor..maxFactor]
    |> Seq.map(
        fun i ->
            let iReplicated = Seq.replicate ((maxFactor-1)) (i)
            // printfn "replicated: %A" iReplicated
            Seq.zip iReplicated (Seq.skip (i-1)  [1..(maxFactor)])
        )
    |> Seq.collect ( fun seq-> seq )
    |> Seq.map (
        fun (number1,number2) ->
            number1 * number2
            )
    // |> Seq.contains 906609
    |> Seq.filter isPalindrome
    |> Seq.max

stopWatch.Stop()

printfn $"{result}"
printfn $"Run time: {stopWatch.Elapsed.TotalMilliseconds} ms"