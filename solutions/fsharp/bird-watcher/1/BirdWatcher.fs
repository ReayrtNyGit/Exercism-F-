module BirdWatcher

let lastWeek: int[] =
   [| 0; 2; 5; 3; 7; 8; 4 |]

let yesterday(counts: int[]): int =
  counts.[counts.Length - 2]  

let total(counts: int[]): int =
    Array.sum counts
  

let dayWithoutBirds(counts: int[]): bool =
    Array.exists (fun x -> x = 0) counts
  

let incrementTodaysCount(counts: int[]): int[] =
    let copy = Array.copy counts
    copy.[copy.Length - 1] <- copy.[copy.Length - 1] + 1
    copy




let unusualWeek(counts: int[]): bool =
    let allEvenZero =
        counts
        |> Array.mapi (fun i x -> if (i + 1) % 2 = 0 then x = 0 else true)
        |> Array.forall id

    let allEvenTen =
        counts
        |> Array.mapi (fun i x -> if (i + 1) % 2 = 0 then x = 10 else true)
        |> Array.forall id

    let allOddFive =
        counts
        |> Array.mapi (fun i x -> if (i + 1) % 2 = 1 then x = 5 else true)
        |> Array.forall id

    allEvenZero || allEvenTen || allOddFive

