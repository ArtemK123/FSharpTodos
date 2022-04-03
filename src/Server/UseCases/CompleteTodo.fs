[<AutoOpen>]
module Server.UseCases.CompleteTodo

let completeTodo (storage: Server.Storage.Storage) =
    fun todoGuid ->
        async {
            match storage.GetTodo todoGuid with
            | Some todo -> return todo
            | None -> return failwith "Todo is not found"
        }