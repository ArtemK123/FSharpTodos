module Components.TestPage

open Feliz
open Feliz.Bulma
open Feliz.Router
open State

let render (_: Model) (_: Msg -> unit) =
    Bulma.container [
        container.isWidescreen
        prop.children [
            Bulma.box [
                text.hasTextCentered
                prop.children [
                    Bulma.block "Test"
                    Bulma.button.button [
                        Bulma.color.isPrimary
                        prop.text "Go to main page"
                        prop.onClick (fun _ -> Router.navigate "")
                    ]
                ]
            ]
        ]
    ]