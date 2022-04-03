[<AutoOpen>]
module Server.UseCases.AddTodo

open Shared

let addTodo (storage: Server.Storage.Storage) todo =
    if Todo.isValid todo.Description then
        storage.AddTodo todo
        Ok(todo)
    else
        Error Shared.Error.InvalidTodo