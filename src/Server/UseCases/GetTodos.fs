[<AutoOpen>]
module Server.UseCases.GetTodos

open Server.Storage

let getTodos (storage: Storage) = storage.GetTodos()