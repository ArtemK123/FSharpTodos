module Server.Storage

open System
open Shared

type Storage() =
    let todos = ResizeArray<Todo>()

    member __.TryGetTodo(todoGuid: Guid): Option<Todo> =
        let getTodo = fun todo -> todo.Id = todoGuid
        if todos.Exists(getTodo) then
           Some(todos.Find(getTodo))
        else
           None

    member __.GetTodos() = List.ofSeq todos

    member __.AddTodo(todo: Todo) = todos.Add todo