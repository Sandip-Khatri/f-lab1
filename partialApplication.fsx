
let power exponent value = 
    // This function takes an exponent and a value, and returns value raised to that exponent
    System.Math.Pow(value, float exponent)

// Creating specialized functions by partially applying the exponent
let square = power 2
let cube = power 3

// Testing the square and cube functions with some values
printfn "Square of 4 is %f" (square 4.0)
printfn "Square of 5 is %f" (square 5.0)
printfn "Cube of 2 is %f" (cube 2.0)
printfn "Cube of 3 is %f" (cube 3.0)
