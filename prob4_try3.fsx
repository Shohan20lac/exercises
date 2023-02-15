open System.Collections.Generic

let reverseString (v: string) =
    v
    |> Seq.rev
    |> Seq.map string
    |> String.concat ""

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

let isPalindrome (v:string): bool = 
    let reversed = 
        v
        |> Seq.rev 
        |> Seq.map string
        |> String.concat ""
    reversed = v

let removeMirroredTuple (tuples: Set<int*int>) (inTuple: int*int ) =
    let mirroredTuple =
        inTuple
        |> fun (integer1,integer2) ->
            (integer2,integer1)
    
    if Set.contains mirroredTuple tuples then
        tuples
        |> Set.remove mirroredTuple
    else
        tuples
        
let removeMirrors ( (tuples: Set<int*int>) ) =
    tuples
    |> Set.map(
        fun tuple ->
            removeMirroredTuple tuples tuple
        )
    
let euler4 ( (digitCount: int) ) =
    
    let minFactor =
        smallestNumberBackwards(digitCount)
        |> reverseString
        |> int
    let maxFactor =
        largestNumber(digitCount)
        |> int
        
    let factorRange =
        [ minFactor..maxFactor ]
    
    let factorTuples =
        factorRange
        |> List.toSeq
        |> Seq.map(
            fun factor -> Seq.allPairs (seq{factor}) factorRange
            )
        |> Seq.collect (fun seq -> seq)
        
    factorTuples
    |> Set
    // |> removeMirrors
    |> fun tuple ->
        removeMirrors factorTuples int tuple
    |> Set.map(
        fun (factor1 , factor2) ->
            factor1 * factor2
        )
    |> Set.filter (isPalindrome)
    |> Set.maxElement

//HEAD-ON APPROACH A: GENERATE THEN FILTER
    
// 1. Take input n

// 2. Generate a sequence factorRange = [ smallestDigit(n)..largestDigit(n) ]

// 3. Generate Cartesian Product between factorRange and itself

// 4. Flatten and eliminate mirrors

// 5. result = map the multiply function over all remaining pairs.

// 5. define isPalindrome

// 6. from result filter to only keep integers that are palindromes


let mirror (x: int * int) =
    (snd(x), fst(x))

let removeMirrors ( (tuples: Set<int*int>) ) =
    tuples
    |> Set.filter(
        fun tuple ->
            Set.contains (tuples mirror(tuple))
        )
let tuples = Set[(1,2);(2,10);(2,1)]
let result = removeMirrors tuples 

// let result = removeMirrors Set[(1,2);(2,1)] |> List
printfn "%A" result

// for element in result do
//         printfn $"{element}"


// 1. test mirrorTuple


// 2. test contains

