module FibBuzz.Scenario

open NUnit.Framework
open NaturalSpec
open FibBuzz.Main

[<Scenario>]
let ``When fibonacci takes 0 then it returns [1].`` () =
    Given 0
    |> When fibonacci
    |> It should equal [1]
    |> Verify
