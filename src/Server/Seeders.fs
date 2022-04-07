module Server.Seeders

open Shared

let seedTodos (storage: Storage.Storage) =
    storage.AddTodo(Todo.create "Create new SAFE project")
    storage.AddTodo(Todo.create "Write your app")
    storage.AddTodo(Todo.create "Ship it !!!")