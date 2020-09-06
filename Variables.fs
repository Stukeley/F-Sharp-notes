module Variables

// Global scope variable declaration
let a = 10
let b = a + 1

// val vs let
// let has to be initialized
// val can be used in classes or structures without being initialized

// Variables by default are IMMUTABLE
// That means their value cannot be changed after assignment

// let a = 15   // Error
let c = a = 15  // Bool value: a equals 15? (false)

// Explicit type
let f:float = 6.9
let d:double = 21.37

// Mutable variables
let mutable mut = 20

// A function that will change the mutable variable's value and display it
let printMutableInt = 
    printfn "%i" mut
    mut <- 30   // Assignment operator for mutable variables
    printfn "%i" mut

// OPERATORS
let operatorsReference = 
    let x = 2
    let y = 8
    printfn "%i" (x + y)  // Addition
    printfn "%i" (x - y)  // Subtraction
    printfn "%i" (x * y)  // Multiplication
    printfn "%i" (y / x)  // Division
    printfn "%i" (x % y)  // Remainder

    let z:float = 3.0
    printfn "%f" (z ** z) // Exponentiation (floating point types only)

    printfn "%b" (x = y)    // Equals operator (NOT ASSIGNMENT) - false
    printfn "%b" (a > b)    // true
    printfn "%b" (a <> b)   // true

    let isEqual:bool = a = b
    printfn "%b" (not isEqual)  // not - reverses the logical state

// printf / printfn formats
// %i, %d - int
// %f - float
// %s - string
// %c - char
// %b - bool
// %A - any value, formatted with default layout settings
// %% - prints a %

// UNITS OF MEASURES
[<Measure>] type kg
[<Measure>] type m
[<Measure>] type s

let gravityOnEarth = 9.81<m/s^2>    // an acceleration
let myHeight = 1.84<m>              // a distance

//let sum = gravityOnEarth + myHeight   // Error - measures don't match!