module Accumulate

let accumulate operation list =
    let rec loop acc remaining =
        match remaining with
        | [] -> acc
        | head :: tail ->
            let result = operation head
            loop (result :: acc) tail
    
    list |> loop [] |> List.rev