module TwoFer

let twoFer nameOption =
    match nameOption with
    | Some name when not (System.String.IsNullOrWhiteSpace(name)) -> 
        sprintf "One for %s, one for me." name
    | _ -> "One for you, one for me."