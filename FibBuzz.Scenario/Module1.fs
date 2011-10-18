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

[<Scenario>]
let ``When fibonacci takes 1 then it returns [1; 1].`` () =
    Given 1
    |> When fibonacci
    |> It should equal [1; 1]
    |> Verify

[<Scenario>]
let ``When fibonacci takes 2 then it returns [1; 1; 2].`` () =
    Given 2
    |> When fibonacci
    |> It should equal [1; 1; 2]
    |> Verify

[<Scenario>]
let ``When fizzbuzz takes 1 then it returns "1".`` () =
    Given 1
    |> When fizzbuzz
    |> It should equal "1"
    |> Verify

[<Scenario>]
let ``When fizzbuzz takes 2 then it returns "2".`` () =
    Given 2
    |> When fizzbuzz
    |> It should equal "2"
    |> Verify