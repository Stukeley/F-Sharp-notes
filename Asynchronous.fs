module Asynchronous

open System.IO
open System.Threading.Tasks

// SIMPLE ASYNC FUNCTION

// let! runs an async<'a> object on its own thread, then it immediately releases the current thread back to the threadpool. When let! returns, execution of the workflow will continue on the new thread, which may or may not be the same thread that the workflow started out on.

let printTextAsync (text:string) = 
    async {
        Async.Sleep(1000) |> ignore // Ignore compiler's remarks about the value not being saved to a variable
        printfn "%s" text

        // let: the type will be Async<string>
        // let!: the type will be string

        let asyncTextFromFile = File.ReadAllTextAsync("somefile.txt") |> Async.AwaitTask    // await
        let! textFromFile = File.ReadAllTextAsync("somefile.txt") |> Async.AwaitTask  // await

        printfn "%s" textFromFile
    }

let callFunctionSynchronously = 
    printTextAsync "Hello World Sync" |> Async.RunSynchronously


// TASKS

let performOperation : Task = 
    async {
        Async.Sleep(5000) |> ignore
        printfn "5"
    } |> Async.StartAsTask :> Task

let runTask = 
    let result = Task.Run(fun () -> performOperation) |> Async.AwaitTask
    printfn "done"

let asyncAdd (x:int, y:int) = 
    async {
        Async.Sleep(2000) |> ignore
        return x + y
    };;