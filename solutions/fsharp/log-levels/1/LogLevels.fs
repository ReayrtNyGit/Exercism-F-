module LogLevels

let message (logLine: string) =
    logLine
    // Split on the first occurrence of ":"
    |> fun s -> s.Split([|':'|], 2)
    // Take the part after the first ":"
    |> fun parts -> 
        if parts.Length > 1 then parts.[1] else ""
    // Trim whitespace (including \r, \n, spaces, etc.)
    |> fun s -> s.Trim()
let logLevel (logLine: string) =
    // Find the text between '[' and ']'
    let startIdx = logLine.IndexOf('[') + 1
    let endIdx = logLine.IndexOf(']')
    if startIdx > 0 && endIdx > startIdx then
        logLine.Substring(startIdx, endIdx - startIdx).ToLower()
    else
    ""




// Reformats the log line
let reformat (logLine: string) =
    let msg = message logLine
    let level = logLevel logLine
    sprintf "%s (%s)" msg level

