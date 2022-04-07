module ServerApp.Tests

open Expecto

open Server.Storage
open Shared

let server = testList "Server" [
    testCase "Adding valid Todo" <| fun _ ->
        let storage = Storage()
        let validTodo = Todo.create "TODO"
        let expectedResult = Ok ()

        let result = storage.AddTodo validTodo

        Expect.equal result expectedResult.OkValue "Result should be ok"
        Expect.contains (storage.GetTodos()) validTodo "Storage should contain new todo"
]

let all =
    testList "All"
        [
            Tests.shared
            server
        ]

[<EntryPoint>]
let main _ = runTestsWithCLIArgs [] [||] all