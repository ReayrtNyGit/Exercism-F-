module Raindrops

let convert n =
    [(3, "Pling"); (5, "Plang"); (7, "Plong")]
    |> List.filter (fun (divisor, _) -> n % divisor = 0)
    |> List.map snd
    |> String.concat ""
    |> function | "" -> string n | s -> s