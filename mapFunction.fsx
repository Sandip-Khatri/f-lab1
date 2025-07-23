
let rawNames = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]

// Using List.map with a named function for clarity
let trimString (s: string) = s.Trim()
let cleanedNames = List.map trimString rawNames

printfn "Names after trimming whitespace: %A" cleanedNames
