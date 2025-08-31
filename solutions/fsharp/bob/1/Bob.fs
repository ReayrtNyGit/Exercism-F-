module Bob

open System

let response (input: string) =
    let trimmed = input.Trim()
    let isSilent = String.IsNullOrWhiteSpace(input)
    let isQuestion = trimmed.EndsWith("?")
    let isYelling = 
        trimmed |> String.exists Char.IsLetter 
        && trimmed |> String.forall (fun c -> Char.IsUpper(c) || not (Char.IsLetter(c)))
    
    match isSilent, isYelling, isQuestion with
    | true, _, _ -> "Fine. Be that way!"
    | _, true, true -> "Calm down, I know what I'm doing!"
    | _, true, false -> "Whoa, chill out!"
    | _, false, true -> "Sure."
    | _ -> "Whatever."