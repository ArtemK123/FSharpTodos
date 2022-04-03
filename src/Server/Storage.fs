module Server.Storage

open System
open Shared

type Storage() =
    let todos = ResizeArray<Todo>()

    member __.GetTodo(todoGuid: Guid): Option<Todo> =
        let getTodo = fun todo -> todo.Id = todoGuid
        if todos.Exists(getTodo) then
           Some(todos.Find(fun todo -> todo.Id = todoGuid))
        else
           None

    member __.GetTodos() = List.ofSeq todos

    member __.AddTodo(todo: Todo) =
        if Todo.isValid todo.Description then
            todos.Add todo
            Ok()
        else
            Error "Invalid todo"