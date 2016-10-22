module TestingFSharpModule

let square x = x * x
let isOdd x = x % 2 <> 0

[<EntryPoint>]
let main argv = 
    printfn "%d squared is: %d" 12 (square 12)
    printfn "%d isOdd? Answer: %b" 12 (isOdd 12)
    printfn "%d squared isOdd? Answer: %b" 12 (12 |> square |> isOdd)
    0 // return an integer exit code
