// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

(*
Problem 1:

If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

Find the sum of all the multiples of 3 or 5 below 1000.
*)
let problem1 = 
    [1..999]
    |> List.filter (fun x -> x % 3 = 0 || x % 5 = 0)
    |> List.sum

[<EntryPoint>]
let main argv = 
    printfn "%A" argv
    printfn "Hello world and project Euler"
    printfn "Problem 1: %d" problem1
    System.Console.ReadKey() |> ignore
    0 // return an integer exit code