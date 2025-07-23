
let numbers = [1 .. 700]

// Filter numbers divisible by 5 and 7
let divisibleBy5And7 = List.filter (fun x -> x % 5 = 0 && x % 7 = 0) numbers

// Sum the filtered numbers using List.fold
let totalSum = List.fold (fun acc x -> acc + x) 0 divisibleBy5And7

printfn "Sum of numbers divisible by both 5 and 7 between 1 and 700 is %d" totalSum
