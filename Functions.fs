module Functions

// Function signature
let addOne x = x + 1

// Alternative function signature
let addTwo = fun x -> x + 2

// A function that only takes string arguments
let concatString str1 str2 : string  = 
    str1 + str2 // No 'return' statement

let printFunctionValue = 
    printfn "addOne with the argument 3: %i" (addOne 3) // %i is the same as %d and prints an integer

let printConcatString = 
    printfn "concatString with arguments ab and cd: %s" (concatString "ab" "cd")    // %s prints a string

let cylinderVolume radius length : float = 
    let pi = 3.14159
    length * pi * radius * radius

// Recursive function - rec keyword
let rec fib n : int = 
    if n < 2 then
        1
    else
        fib n-1 + fib n-2

let printFibonacci =
    for i = 0 to 10 do
        printf "Fibonacci %i : %i " i (fib i)

// Lambda functions
let lambdaExample = 
    let result = (fun x y -> x * y) 5 10    // anonymous function called with arguments 5 and 10
    printfn "%i" result // prints 50