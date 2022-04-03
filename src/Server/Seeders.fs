module Server.Seeders

open Shared

let seedTodos (storage: Storage.Storage) =
    storage.AddTodo(Todo.create "Create new SAFE project") |> ignore
    storage.AddTodo(Todo.create "Write your app") |> ignore
    storage.AddTodo(Todo.create "Ship it !!!") |> ignore