﻿[<AutoOpen>]
module Server.UseCases.CompleteTodo

let completeTodo (storage: Server.Storage.Storage) todoGuid =
    match storage.TryGetTodo todoGuid with
    | Some todo -> Ok(todo)
    | None -> Error(Shared.Error.NotFoundTodo)
