module ValentinesDay

// TODO: please define the 'Approval' discriminated union type

type Approval =
    | Yes 
    | No
    | Maybe

// TODO: please define the 'Cuisine' discriminated union type

type Cuisine =
    | Korean
    | Turkish

// TODO: please define the 'Genre' discriminated union type

type Genre =
    | Crime
    | Horror
    | Romance
    | Thriller

// TODO: please define the 'Activity' discriminated union type

type Activity =
    | BoardGame
    | Chill
    | Movie of Genre
    | Restaurant of Cuisine
    | Walk of int


// let rateActivity (activity: Activity): Approval = failwith "Please implement the 'rateActivity' function"

let rateActivity activity =
    match activity with
    | BoardGame -> No
    | Chill -> No
    | Movie genre ->
        match genre with
        | Romance -> Yes
        | _ -> No
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> Yes
        | Turkish -> Maybe
    | Walk km when km < 3 -> Yes
    | Walk km when km < 5 -> Maybe
    | Walk _ -> No