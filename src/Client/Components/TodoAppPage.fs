module Components.TodoAppPage

open Feliz
open Feliz.Bulma
open State

let render (_: Model) (_: Msg -> unit) =
    BackgroundContainer.render [
        Bulma.container [
            prop.children [
                Bulma.box [
                    text.hasTextCentered
                    prop.children [
                        Bulma.block "Test"
                    ]
                ]
                RedirectButtons.ToHomePage.render
            ]
        ]
    ]