module FibBuzz.Main

let fibonacci n =
    let rec fib n =
        if n > 1 then
            (fib (n - 1)) + (fib (n - 2))
        elif n = 1 || n = 0 then
            1
        else
            0
    let rec fibList n xs =
        if n = 0 then
            ((fib n)::xs)
        else
            fibList (n - 1) ((fib n)::xs)
    fibList n []