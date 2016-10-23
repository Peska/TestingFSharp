// Next: http://www.tryfsharp.org/Learn/advanced-programming#operator-definition

let add x y = x + y
let sub x y = x - y

let inc = add 1
let anotherInc x = add 1 x

let searchEven = Seq.filter (fun v -> v % 2 = 0)

let swapargs f x y = f y x
let dec = swapargs sub 1

[<EntryPoint>]
let main argv = 
    printfn ""
    printfn "%d is the same as %d" (inc 2) (anotherInc 2)
    printfn "%d even numbers in [1, 100]" ([1..100] |> searchEven |> Seq.length)
    printfn "Before 10 is %d" (dec 10)
    0