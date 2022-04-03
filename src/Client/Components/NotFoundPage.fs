module Components.NotFoundPage

open Feliz
open Feliz.Bulma
open State

let render (_: Model) (_: Msg -> unit) =
    BackgroundContainer.render [
        Bulma.block [
            prop.children [
                Bulma.block "Not found"
                RedirectButtons.ToHomePage.render
            ]
        ]
    ]