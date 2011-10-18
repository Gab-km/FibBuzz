module FibBuzz.Main

let fibonacci n =
    let rec fib n xs =
        if n = 0 then
            xs
        else
            fib (n - 1) (1::xs)
    fib n [1]