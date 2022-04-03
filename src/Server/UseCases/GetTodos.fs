[<AutoOpen>]
module Server.UseCases.GetTodos

open Server.Storage

let getTodos (storage: Storage) = fun _ -> async { return storage.GetTodos() }