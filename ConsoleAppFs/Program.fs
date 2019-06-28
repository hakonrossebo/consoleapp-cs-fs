// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    let listOfIntegers = [ 1; 2; 3; 4; 10; 20 ]

    let timesTwo number = number * 2
    
    let multiArgumentFunction existingNumber1 existingNumber2 number = existingNumber1 + existingNumber2 +  number * 2

    let accumulateNumbers accumulated current = accumulated + current
        

    let newList = listOfIntegers 
                    |> List.map (fun x -> x * 2)

    let newList2 = listOfIntegers 
                    |> List.map timesTwo
    
    let newList3 = 
        let prefilledMutiArgumentFunction = multiArgumentFunction 10 20
        listOfIntegers 
        |> List.map prefilledMutiArgumentFunction

    let newListOfOddsSummarizedWithAccumulateLambda =
        listOfIntegers
        |> List.filter (fun x -> x % 2 = 0)
        |> List.fold (fun acc current -> acc + current) 0
    
    let newListOfOddsSummarizedWithAccumulateFunction =
        listOfIntegers
        |> List.filter (fun x -> x % 2 = 0)
        |> List.fold accumulateNumbers 0

    
    newList2
    |> List.iter (printfn "Numbers are: %d")

    printfn "Sum is: %d" newListOfOddsSummarizedWithAccumulateLambda

    0 // return an integer exit code
