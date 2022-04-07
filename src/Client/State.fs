module Client.State

open Fable.Core
open Shared
open Elmish
open Fable.Remoting.Client
open Feliz.Router

type Model = { Todos: Todo list; Input: string; CurrentUrl: string list }

type Msg =
    | GotTodos of Todo list
    | SetInput of string
    | AddTodo
    | AddedTodo of Result<Todo, Error>
    | UrlChanged of string list
    | LogError of Error

let todosApi =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.buildProxy<ITodosApi>

let init () : Model * Cmd<Msg> =
    let model = { Todos = []; Input = ""; CurrentUrl = Router.currentUrl() }

    let cmd =
        Cmd.OfAsync.perform todosApi.getTodos () GotTodos

    model, cmd

let [<Global>] console: JS.Console = jsNative
let update (msg: Msg) (model: Model) : Model * Cmd<Msg> =
    match msg with
    | GotTodos todos -> { model with Todos = todos }, Cmd.none
    | SetInput value -> { model with Input = value }, Cmd.none
    | AddTodo ->
        let todo = Todo.create model.Input

        let cmd =
            Cmd.OfAsync.perform todosApi.addTodo todo AddedTodo

        { model with Input = "" }, cmd
    | AddedTodo todoResult ->
        match todoResult with
        | Ok todo -> { model with Todos = model.Todos @ [ todo ] }, Cmd.none
        | Error error -> model, Cmd.ofMsg (LogError error)
    | UrlChanged segments -> { model with CurrentUrl = segments }, Cmd.none
    | LogError error ->
        console.log($"Received error: {error}")
        model, Cmd.none
