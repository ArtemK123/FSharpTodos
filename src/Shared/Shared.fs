namespace Shared

open System

type Todo = { Id: Guid; Description: string; IsCompleted: bool }

type Error =
    | NotFoundTodo
    | InvalidTodo
    | None

module Todo =
    let isValid (description: string) =
        String.IsNullOrWhiteSpace description |> not

    let create (description: string) =
        { Id = Guid.NewGuid()
          Description = description
          IsCompleted = false }

module Route =
    let builder typeName methodName =
        sprintf "/api/%s/%s" typeName methodName


type ITodosApi =
    { getTodos: unit -> Async<Result<Todo list, Error>>
      addTodo: Todo -> Async<Result<Todo, Error>>
      completeTodo: Guid -> Async<Result<Todo, Error>> }
