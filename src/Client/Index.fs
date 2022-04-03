module Index

open Components
open State
open Routing
open Feliz
open Feliz.Router

let resolveRender (page: Page) =
    match page with
    | Home -> HomePage.render
    | TodoApp -> TodoAppPage.render
    | Test -> TestPage.render
    | NotFound -> NotFoundPage.render

let parseRender urlSegments = urlSegments |> parsePage |> resolveRender

let render (model: Model) (dispatch: Msg -> unit) =
    React.router [
        router.onUrlChanged (UrlChanged >> dispatch)
        router.children [
            (parseRender model.CurrentUrl) model dispatch
        ]
    ]
