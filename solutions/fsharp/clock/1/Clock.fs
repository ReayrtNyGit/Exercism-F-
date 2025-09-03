module Clock

type Clock = { Hours: int; Minutes: int }

let private normalizeTime totalMinutes =
    let normalizedMinutes = ((totalMinutes % 1440) + 1440) % 1440
    { Hours = normalizedMinutes / 60; Minutes = normalizedMinutes % 60 }

let create hours minutes =
    hours * 60 + minutes |> normalizeTime

let add minutes clock =
    clock.Hours * 60 + clock.Minutes + minutes |> normalizeTime

let subtract minutes clock =
    clock.Hours * 60 + clock.Minutes - minutes |> normalizeTime

let display clock =
    sprintf "%02d:%02d" clock.Hours clock.Minutes