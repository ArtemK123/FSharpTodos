module Index

open Components
open State
open Feliz
open Feliz.Router

let render (model: Model) (dispatch: Msg -> unit) =
    React.router [
        router.onUrlChanged (UrlChanged >> dispatch)
        router.children [
            match model.CurrentUrl with
            | [ ] -> HomePage.render model dispatch
            | [ "todoapp" ] -> TodoAppPage.render model dispatch
            | [ "test" ] -> TestPage.render model dispatch
            | _ -> NotFoundPage.render model dispatch
        ]
    ]
