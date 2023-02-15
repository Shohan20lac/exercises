let rec smallestNumber (digitcount: int) =
    if digitcount > 1 then
        (string (0) + smallestNumber(digitcount-1))
    else
        string(1)

let rec largestNumber (digitcount: int) =
    if digitcount > 1 then
        (string(9) + largestNumber(digitcount-1))
    else
        string(9)

let isPalindrome (v:string) = 
    let reversed = 
        v
        |> Seq.rev 
        |> Seq.map string
        |> String.concat ""
    reversed = v

let reverseString (v: string) =
    v
    |> Seq.rev 
    |> Seq.map string
    |> String.concat ""

let result = 
    let minfactor = smallestNumber 3 |> reverseString |> int
    let maxfactor = largestNumber 3 |> int
    
    let factorRange = [minfactor..maxfactor]
    
    factorRange
    |> Seq.map(
        fun number ->
            Seq.allPairs (seq{number}) factorRange
        )
    |> Seq.collect (fun seq -> seq)
    |> Seq.map (
        fun (factor1 , factor2) -> factor1 * factor2
    )
    |> Seq.filter (
        fun multiple ->
            multiple
            |> string
            |> isPalindrome
    )
    |> Seq.max
    |> printfn "%i"