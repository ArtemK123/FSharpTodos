[<AutoOpen>]
module Server.UseCases.CompleteTodo

open Shared

let private useCase (storage: Server.Storage.Storage) (todo: Shared.Todo) =
    let completedTodo = { todo with IsCompleted = true }
    storage.UpdateTodo completedTodo
    Ok(completedTodo)

let completeTodo (storage: Server.Storage.Storage) todoGuid =
    getTodo storage todoGuid
    |> Result.bind (useCase storage)
