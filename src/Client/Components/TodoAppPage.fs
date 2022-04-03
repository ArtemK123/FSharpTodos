module Components.TodoAppPage

open Feliz
open Feliz.Bulma
open Feliz.Router
open State

let render (_: Model) (_: Msg -> unit) =
    Bulma.hero [
        hero.isFullHeight
        color.isPrimary
        prop.style [
            style.backgroundSize "cover"
            style.backgroundImageUrl "https://unsplash.it/1200/900?random"
            style.backgroundPosition "no-repeat center center fixed"
        ]
        prop.children [
            Bulma.heroBody [
                Bulma.container [
                    prop.children [
                        Bulma.box [
                            text.hasTextCentered
                            prop.children [
                                Bulma.block "Test"
                            ]
                        ]
                        Bulma.button.button [
                            Bulma.color.isPrimary
                            prop.text "Go to Home page"
                            prop.onClick (fun _ -> Router.navigate(""))
                        ]
                    ]
                ]
            ]
        ]
    ]


