module TracksOnTracksOnTracks

let newList: string list = []

let existingList: string list = ["F#"; "Clojure"; "Haskell"]

let addLanguage (language: string) (languages: string list): string list =
    language :: languages

let countLanguages (languages: string list): int = 
    List.length languages

let reverseList(languages: string list): string list = 
    List.rev languages

let excitingList (languages: string list) : bool =
    match languages with
    | "F#" :: _ -> true
    | _ :: "F#" :: [] -> true        // exactly two items, second is "F#"
    | _ :: "F#" :: [_] -> true       // exactly three items, second is "F#"
    | _ -> false


   
   
