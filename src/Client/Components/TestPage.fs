module Client.Components.TestPage

open Feliz
open Feliz.Bulma
open Client.State

let render (_: Model) (_: Msg -> unit) =
    BackgroundContainer.render [
        Bulma.container [
            container.isWidescreen
            prop.children [
                Bulma.box [
                    text.hasTextCentered
                    prop.children [
                        Bulma.block "Test"
                        Client.RedirectButtons.ToHomePage.render
                    ]
                ]
            ]
        ]
    ]