module FibBuzz.Scenario

open NUnit.Framework
open NaturalSpec
open FibBuzz.Main

module Fibonacci =
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

module FizzBuzz =
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

    [<Scenario>]
    let ``When fizzbuzz takes 6 then it returns "Fizz".`` () =
        Given 6
        |> When fizzbuzz
        |> It should equal "Fizz"
        |> Verify

    [<Scenario>]
    let ``When fizzbuzz takes 10 then it returns "Buzz".`` () =
        Given 10
        |> When fizzbuzz
        |> It should equal "Buzz"
        |> Verify

    [<Scenario>]
    let ``When fizzbuzz takes 15 then it returns "FizzBuzz".`` () =
        Given 15
        |> When fizzbuzz
        |> It should equal "FizzBuzz"
        |> Verify

module FibBuzz =
    [<Scenario>]
    let ``When fibbuzz takes 0 then it returns ["1"].`` () =
        Given 0
        |> When fibbuzz
        |> It should equal ["1"]
        |> Verify

    [<Scenario>]
    let ``When fibbuzz takes 1 then it returns ["1"; "1"].`` () =
        Given 1
        |> When fibbuzz
        |> It should equal ["1"; "1"]
        |> Verify

    [<Scenario>]
    let ``When fibbuzz takes 2 then it returns ["1"; "1"; "2"].`` () =
        Given 2
        |> When fibbuzz
        |> It should equal ["1"; "1"; "2"]
        |> Verify

    [<Scenario>]
    let ``When fibbuzz takes 3 then it returns ["1"; "1"; "2"; "Fizz"].`` () =
        Given 3
        |> When fibbuzz
        |> It should equal ["1"; "1"; "2"; "Fizz"]
        |> Verify
