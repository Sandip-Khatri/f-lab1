
let productOfList numbers =
    // Helper function that uses an accumulator to hold the product so far
    let rec multiply acc lst =
        match lst with
        | [] -> acc  // Base case: return accumulated product when list is empty
        | head :: tail -> multiply (acc * head) tail  // Multiply head with accumulator and recurse
    multiply 1 numbers


let sampleList = [1; 2; 3; 4; 5]
printfn "Product of the list %A is %d" sampleList (productOfList sampleList)
