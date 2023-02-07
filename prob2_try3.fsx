// PE Problem 3: 
// The prime factors of 13195 are 5, 7, 13 and 29.
// What is the largest prime factor of the number 600851475143 ?

open System.Numerics

let isFactorOf (num: int) (factor: int): bool =
    num % factor = 0

let isDivisibleBy  (factor: int) (num: int): bool =
    num % factor = 0

let isPrime (number: int): bool =

    [2..(number/2)]
    |> Seq.filter ( 
        fun x -> 
            number % x = 0 ) 
    |> Seq.isEmpty
        
let cannotDivide (sequence: seq<int>) (factor:int): bool =
    sequence
    |> Seq.filter (isDivisibleBy factor)
    |> Seq.isEmpty

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

let largestPrimeFactor (n: int32) =
    factorsStartingFrom 2 n   // |> Seq.filter ( cannotDivide factors )
    // [2..(n/2)]
    // |> Seq.filter ( isFactorOf n )
    |> Seq.filter ( isPrime )
    |> Seq.max

let stopWatch = System.Diagnostics.Stopwatch.StartNew()
largestPrimeFactor(10000) |> printfn "%i"
stopWatch.Stop()
printfn "%f ms" stopWatch.Elapsed.TotalMilliseconds

// Output:
// System.ArgumentException: The input sequence was empty. (Parameter 'source')
//    at FSI_0001.largestPrimeFactor(Int32 n) in c:\Users\rshoh\cd_workspace\Egg.Hatch\Project-Euler\prob3.fsx:line 36
//    at <StartupCode$FSI_0001>.$FSI_0001.main@() in c:\Users\rshoh\cd_workspace\Egg.Hatch\Project-Euler\prob3.fsx:line 42
//    at System.RuntimeMethodHandle.InvokeMethod(Object target, Void** arguments, Signature sig, Boolean isConstructor)
//    at System.Reflection.MethodInvoker.Invoke(Object obj, IntPtr* args, BindingFlags invokeAttr)
// Stopped due to error
// 1123.949000 ms