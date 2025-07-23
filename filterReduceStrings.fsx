// Using Filter and Fold with Strings: Concatenate names containing the letter 'I' (case-insensitive)
let nameList = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]

// Filter names containing 'i' or 'I'
let containsI (name: string) = name.ToLower().Contains("i")
let filteredNamesWithI = List.filter containsI nameList

// Concatenate filtered names using fold
let concatenatedNames = List.fold (fun acc name -> acc + name) "" filteredNamesWithI

printfn "Concatenated names containing the letter 'I': %s" concatenatedNames
