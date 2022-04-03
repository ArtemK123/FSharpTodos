module Components.TodoAppPage

open Feliz
open Feliz.Bulma
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
                        RedirectButtons.ToHomePage.render
                    ]
                ]
            ]
        ]
    ]


