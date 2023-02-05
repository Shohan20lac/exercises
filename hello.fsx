let addtoself x  =
    x+x

let mutliplytoself x =
    x*x

let integer = 10
integer |>  addtoself |> mutliplytoself |> printfn "%i"