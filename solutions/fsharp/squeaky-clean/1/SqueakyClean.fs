module SqueakyClean

open System

let transform (ch: char) : string =
    if Char.IsWhiteSpace ch then ""
    elif System.Char.IsUpper(ch) then $"-{System.Char.ToLower(ch)}"
    elif ch = '-' then "_"
    elif ch >= '0' && ch <= '9' then ""
    elif ch >= 'α' && ch <= 'ω' then "?"
    elif ch >= 'A' && ch <= 'Z' then "-" + Char.ToLower(ch).ToString()
    else ch.ToString()

let clean (str: string) : string =
    String.collect transform str