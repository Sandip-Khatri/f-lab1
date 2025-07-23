// Tail Recursion 2: Calculate product of all odd numbers from a given odd number down to 1
let productOfOdds n =
    // Recursive helper function with accumulator
    let rec loop acc current =
        if current < 1 then
            acc  // Base case: return accumulated product
        else
            loop (acc * current) (current - 2)  // Multiply current odd number and decrement by 2
    loop 1 n

// Test the function with an odd number
let oddNum = 11
printfn "Product of odd numbers from %d down to 1 is %d" oddNum (productOfOdds oddNum)
