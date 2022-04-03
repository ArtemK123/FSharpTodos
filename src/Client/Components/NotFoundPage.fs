module Components.NotFoundPage

open Feliz
open Feliz.Bulma
open Feliz.Router
open State

let render (_: Model) (_: Msg -> unit) =
    Bulma.block [
        prop.children [
            Bulma.block "Not found"
            Bulma.button.button [
                Bulma.color.isPrimary
                prop.text "Go to main page"
                prop.onClick (fun _ -> Router.navigate(""))
            ]
        ]
    ]