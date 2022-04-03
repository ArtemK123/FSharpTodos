module Client.Components.NotFoundPage

open Feliz
open Feliz.Bulma
open Client.State

let render (_: Model) (_: Msg -> unit) =
    BackgroundContainer.render [
        Bulma.block [
            prop.children [
                Bulma.block "Not found"
                Client.RedirectButtons.ToHomePage.render
            ]
        ]
    ]