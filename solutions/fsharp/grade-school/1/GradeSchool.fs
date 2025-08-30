module GradeSchool

type School = Map<int, Set<string>>

let empty = Map.empty

let add student gradeNum (school: School) =
    let studentExists = 
        school 
        |> Map.exists (fun _ students -> students |> Set.contains student)
    
    if studentExists then
        school
    else
        let currentStudents = 
            school 
            |> Map.tryFind gradeNum 
            |> Option.defaultValue Set.empty
        
        school 
        |> Map.add gradeNum (currentStudents |> Set.add student)

let grade gradeNum (school: School) =
    school 
    |> Map.tryFind gradeNum 
    |> Option.defaultValue Set.empty
    |> Set.toList
    |> List.sort

let roster (school: School) =
    school
    |> Map.toList
    |> List.sortBy fst
    |> List.collect (fun (_, students) -> 
        students 
        |> Set.toList 
        |> List.sort)