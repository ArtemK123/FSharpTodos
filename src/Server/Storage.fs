module Server.Storage

open System
open Shared

type Storage() =
    let todos = ResizeArray<Todo>()

    member __.TryGetTodo(todoGuid: Guid): Option<Todo> =
        let getTodo = (fun todo -> todo.Id = todoGuid)
        if todos.Exists(fun todo -> todo.Id = todoGuid) then
           Some(todos.Find(fun todo -> todo.Id = todoGuid))
        else
           None

    member __.GetTodos() = List.ofSeq todos

    member __.AddTodo(todo: Todo) = todos.Add todo

    member __.UpdateTodo(todo: Todo) =
        todos.RemoveAll(fun currentTodo -> currentTodo.Id = todo.Id) |> ignore
        __.AddTodo(todo)