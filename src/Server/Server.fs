module Server

open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open Saturn
open Shared
open Server.Storage
open Server.Seeders
open Server.UseCases

let storage = Storage()
seedTodos storage

let todosApi =
    { getTodos = getTodos storage
      addTodo = addTodo storage
      completeTodo = completeTodo storage
    }

let webApp =
    Remoting.createApi ()
    |> Remoting.withRouteBuilder Route.builder
    |> Remoting.fromValue todosApi
    |> Remoting.buildHttpHandler

let app =
    application {
        url "http://0.0.0.0:8085"
        use_router webApp
        memory_cache
        use_static "public"
        use_gzip
    }

run app