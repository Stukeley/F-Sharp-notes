module DataStructures

open System

// Arrays (mutable)
// ARRAY TYPE MUST BE CONSISTENT

// 1. Initialization through [| ... |] with semicolons
let array1 = [|1; 2; 3; 4; 5; 6; |]

// 2. Initialization through [| ... |] without semicolons
let array2 = 
    [|
        1
        2
        3
        4
        5
        6
    |]

// 3. Initialization through sequence expression
let array3 = [| for i in 1..6 -> i |]

// All 3 of the above arrays are the same

// Display array's contents
let printArray = 
    for i in 0 .. array1.Length - 1 do
        printf "%i" array1.[i]  // Arrays are accessed by .[index] operator
    printfn " "

// Creating an empty array
let emptyArray = array.Empty

// Generic Collcetions (mutable)
// Work just like Generic Colections in C#

open System.Collections.Generic

let intList = new List<int>()

let populateIntList = 
    intList.Add(1)
    intList.Add(2)
    intList.Add(3)
    intList.Add(4)

let dict = new Dictionary<int,string>()

let populateDictionary = 
    dict.Add(0,"A")
    dict.Add(1,"B")
    dict.Add(2,"C")

// Enums
type Days = 
    | Mon = 1
    | Tue = 2
    | Wed = 3
    | Thu = 4
    | Fri = 5
    | Sat = 6
    | Sun = 7

let printDayOfWeek = 
    printfn "%A" Days.Sun