module AoCBug202006.Program

open AoCBug202006.Data

module Solution =
    let output anything = sprintf $"%A{anything}"
    let collect input =
        let rec doCollect group responses input =
            match input with
            | "" :: rest -> rest |> doCollect [] (group :: responses)
            | hd :: rest -> rest |> doCollect (hd :: group) responses
            | _ -> group :: responses

        input |> doCollect [] []

    let questionsRespondedTo (allResponses: string seq) =
        allResponses
        |> Seq.collect Set.ofSeq
        |> Seq.distinct
        |> Seq.length

    let commonQuestionsRespondedTo (allResponses: string seq) =
        allResponses
        |> Seq.filter (fun x -> x <> "")
        |> Seq.map (fun responsesByOne -> responsesByOne.ToCharArray() |> Set.ofArray)
        |> Seq.reduce Set.intersect
        |> Seq.length

    let parse = List.ofArray >> collect
    let solvePart1 = parse >> Seq.sumBy questionsRespondedTo
    let solvePart2 = parse >> Seq.sumBy commonQuestionsRespondedTo

    let solve (input: string []) =
        (solvePart1 input, solvePart2 input)

[<EntryPoint>]
let main argv =
    printfn "%A" (Solution.solve <| Raw.input.Trim().Split("\n"))
    0 // return an integer exit code