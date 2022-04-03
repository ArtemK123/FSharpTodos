[<AutoOpen>]
module Server.UseCases.AddTodo

let addTodo (storage: Server.Storage.Storage) =
    fun todo ->
        async {
            match storage.AddTodo todo with
            | Ok () -> return todo
            | Error e -> return failwith e
        };