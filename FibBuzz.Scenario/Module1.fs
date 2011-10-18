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

[<Scenario>]
let ``When fizzbuzz takes 3 then it returns "Fizz".`` () =
    Given 3
    |> When fizzbuzz
    |> It should equal "Fizz"
    |> Verify

[<Scenario>]
let ``When fizzbuzz takes 5 then it returns "Buzz".`` () =
    Given 5
    |> When fizzbuzz
    |> It should equal "Buzz"
    |> Verify