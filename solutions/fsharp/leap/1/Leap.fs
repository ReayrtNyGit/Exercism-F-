module Leap

let private isDivisibleBy divisor year = year % divisor = 0

let leapYear year =
    (year |> isDivisibleBy 400, year |> isDivisibleBy 100, year |> isDivisibleBy 4)
    |> function
        | (true, _, _) -> true      // Divisible by 400: leap year
        | (_, true, _) -> false     // Divisible by 100 but not 400: not leap year
        | (_, _, true) -> true      // Divisible by 4 but not 100: leap year
        | _ -> false                // Not divisible by 4: not leap year