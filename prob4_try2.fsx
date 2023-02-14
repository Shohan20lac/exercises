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

let numbers1 = [100..999]

let result = 
    numbers1
    |> Seq.map(
        fun number ->
            Seq.allPairs (seq{number}) numbers1
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

let reverseString (v: string) =
    v
    |> Seq.rev 
    |> Seq.map string
    |> String.concat ""

// Take n. Generate the smallest n-digit number.



smallestNumber 3
|> reverseString
|> printfn "%s"

largestNumber 3
|> reverseString
|> printfn "%s"
