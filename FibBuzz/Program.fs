module FibBuzz.Main

let fibonacci n =
    let rec fib n =
        if n > 1 then
            (fib (n - 1)) + (fib (n - 2))
        elif n = 1 || n = 0 then
            1
        else
            0
    List.map fib [0..n]

let fizzbuzz n =
    if n % 3 = 0 then
        "Fizz"
    elif n = 5 then
        "Buzz"
    else
        n.ToString ()