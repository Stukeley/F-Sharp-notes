module Classes

// Classes

// A sample class
type public SampleClass =
    class
        val SomeInt:int
        val SomeString:string
    end

// A sample class with constructor parameters

type public Point (xCoord:float, yCoord:float) = 
    class
        member x.X = xCoord // x. behaves just like this. in C# - except it can be named differently, not just x
        member x.Y = yCoord

        // Functions
        member x.Sum() = x.X + x.Y  // Returns X+Y
    end

// Creating an object
let SomePoint = new Point(1.0, 2.0)

// Accessing the object's fields
let printSomePoint = 
    printfn "Point: %f %f" SomePoint.X SomePoint.Y