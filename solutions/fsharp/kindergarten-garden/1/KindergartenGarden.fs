

module KindergartenGarden

type Plant = 
    | Grass
    | Clover
    | Radishes
    | Violets

let charToPlant = function
    | 'G' -> Grass
    | 'C' -> Clover
    | 'R' -> Radishes
    | 'V' -> Violets
    | _ -> failwith "Unknown plant character"

let students = ["Alice"; "Bob"; "Charlie"; "David"; "Eve"; "Fred"; "Ginny"; "Harriet"; "Ileana"; "Joseph"; "Kincaid"; "Larry"]

let plants (diagram: string) (student: string) =
    let rows: string[] = diagram.Split('\n')
    let firstRow: string = rows.[0]
    let secondRow: string = rows.[1]
    
    let studentIndex = students |> List.findIndex ((=) student)
    let startPos = studentIndex * 2
    
    let plant1 = charToPlant firstRow.[startPos]
    let plant2 = charToPlant firstRow.[startPos + 1]
    let plant3 = charToPlant secondRow.[startPos]
    let plant4 = charToPlant secondRow.[startPos + 1]
    
    [plant1; plant2; plant3; plant4]