module TisburyTreasureHunt

let getCoordinate (line: string * string): string =
    snd line

let convertCoordinate (coordinate: string): int * char = 
    let numberPart = coordinate.[0..coordinate.Length - 2] |> int
    let letterPart = coordinate.[coordinate.Length - 1]
    (numberPart, letterPart)

let compareRecords (azarasData: string * string) (ruisData: string * (int * char) * string) : bool = 
    let azaraCoord = azarasData |> getCoordinate |> convertCoordinate
    let (_, ruiCoord, _) = ruisData
    azaraCoord = ruiCoord

let createRecord (azaraRecord: string * string) (ruiRecord: string * (int * char) * string) =
    if compareRecords azaraRecord ruiRecord then
        let location, (num, ch), quadrant = ruiRecord
        let treasure, coordStr = azaraRecord
        (coordStr, location, quadrant, treasure)
    else
        ("", "", "", "")