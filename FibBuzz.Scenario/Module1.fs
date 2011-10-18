module FibBuzz.Scenario

open NaturalSpec
open FibBuzz.Main

[<Scenario>]
let ``When fibonacci takes 0 then it returns [1].`` () =
    Given 0
    |> When fibonacchi
    |> It should equal [1]
    |> Verify
